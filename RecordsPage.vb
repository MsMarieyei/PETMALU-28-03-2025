Imports MySql.Data.MySqlClient

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
                      From pets_info pi 
                      LEFT JOIN petsurgeries ps ON pi.PetID = ps.PetID 
                      Left Join petdewormings pd ON pi.PetID = pd.PetID 
                      Left JOIN dewormings d ON pd.DewormingID = d.DewormingID
                      Left Join petvaccinations pv ON pi.PetID = pv.PetID 
                      Left JOIN vaccines v ON pv.VaccineID = v.VaccineID 
                      INNER Join clients c ON pi.ClientID = c.ClientID 
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

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim dashboardPage As New DashboardPage()
        dashboardPage.Show()
        Me.Hide()
    End Sub
End Class
