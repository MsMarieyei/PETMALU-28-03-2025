Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Printing

Public Class RecordsPage
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Private selectedClientID As Integer

    ' Constructor to accept the ClientID
    Public Sub New(clientID As Integer)
        InitializeComponent() ' Load form elements
        Me.selectedClientID = clientID
    End Sub

    Private Sub Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("Server=localhost;Database=petmalu_record_system;User ID=root;Password=;")

        Dim dataSet As New DataTable()
        Dim bindingSrc As New BindingSource()
        Dim dataAdapter As New MySqlDataAdapter()

        Try
            connection.Open()

            ' Corrected Query: Filter by ClientID instead of FullName
            Dim query As String = "SELECT pi.PetID, pi.Name, pi.Sex, pi.Birthday, pi.Type, pi.Breed, pi.Color, pi.Photo, ps.SurgeryType, d.DewormingName, v.VaccineName 
                       FROM pets_info pi 
                       LEFT JOIN petsurgeries ps ON pi.PetID = ps.PetID 
                       LEFT JOIN petdewormings pd ON pi.PetID = pd.PetID 
                       LEFT JOIN dewormings d ON pd.DewormingID = d.DewormingID
                       LEFT JOIN petvaccinations pv ON pi.PetID = pv.PetID 
                       LEFT JOIN vaccines v ON pv.VaccineID = v.VaccineID 
                       INNER JOIN clients c ON pi.ClientID = c.ClientID 
                       WHERE c.ClientID = @ClientID;"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@ClientID", selectedClientID)

            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@ClientID", selectedClientID) ' Correct parameter

            dataAdapter.SelectCommand = command
            dataAdapter.Fill(dataSet)
            bindingSrc.DataSource = dataSet
            DataGridView1.DataSource = bindingSrc

        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Update Record
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim petID As Integer = selectedRow.Cells("PetID").Value
            Dim updateForm As New UpdateRecordPage(petID)
            updateForm.ShowDialog()
            Records_Load(sender, e) ' Reload the records
        Else
            MessageBox.Show("Please select a record to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Delete Record
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim petID As Integer = selectedRow.Cells("PetID").Value

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.Yes Then
                Try
                    connection.Open()
                    Dim query As String = "DELETE FROM pets_info WHERE PetID = @PetID"
                    Dim cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Records_Load(sender, e) ' Reload the records
                Catch ex As MySqlException
                    MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Print Records
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim dashboardPage As New DashboardPage()
        dashboardPage.Show()
        Me.Hide()
    End Sub
End Class
