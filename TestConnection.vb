Imports MySql.Data.MySqlClient

Public Class TestConnection
        Dim connectionString As String = "Server=127.0.0.1;Port=3306;Database=petmalu_record_system;User ID=root;Password=;"

        Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    MessageBox.Show("✅ Connected Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As MySqlException
                MessageBox.Show("❌ Connection Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
