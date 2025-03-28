Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class ForgotPage
    Dim connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Private Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click
        Dim email As String = txtemail.Text

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter your email address.")
        Else
            Dim query As String = "SELECT * FROM Users WHERE Email = @Email"

            Try
                Using conn As New MySqlConnection(connectionString)
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Email", email)

                        conn.Open()
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then

                            reader.Close()


                            Dim tempPassword As String = GenerateTemporaryPassword()
                            Dim updateQuery As String = "UPDATE Users SET Password = @Password WHERE Email = @Email"

                            Using updateCmd As New MySqlCommand(updateQuery, conn)
                                updateCmd.Parameters.AddWithValue("@Password", tempPassword)
                                updateCmd.Parameters.AddWithValue("@Email", email)
                                updateCmd.ExecuteNonQuery()
                            End Using


                            SendResetEmail(email, tempPassword)

                            MessageBox.Show("A temporary password has been sent to your email.")
                        Else

                            MessageBox.Show("Email address not found.")
                        End If

                        conn.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
    End Sub


    Private Function GenerateTemporaryPassword() As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim random As New Random()
        Return New String(Enumerable.Repeat(chars, 8).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function


    Private Sub SendResetEmail(email As String, tempPassword As String)
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .Credentials = New Net.NetworkCredential("jmercado090803@gmail.com", "mqfx bibl glsh oasw"),
                .EnableSsl = True
            }

            Dim mail As New MailMessage() With {
                .From = New MailAddress("jmercado090803@gmail.com"),
                .Subject = "Password Reset",
                .Body = $"Your temporary password is: {tempPassword}. Please log in and change your password immediately."
            }
            mail.To.Add(email)

            smtpClient.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Failed to send email: " & ex.Message)
        End Try
    End Sub

    Private Sub ForgotPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

