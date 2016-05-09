Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form2
    Private connectionString As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        Dim InsSql As String = "INSERT INTO emails ( email , name , company, date_in ) "
        InsSql &= "VALUES ( @email , @name , @company, @date_in ) "

        Dim trans As SqlTransaction
        Using connection As New SqlConnection(My.Settings.Item("connectionString").ToString())
            connection.Open()
            trans = connection.BeginTransaction()

            Try
                Dim command As New SqlCommand()
                command.Connection = connection
                command.Transaction = trans

                If Me.txtEmail.Text.Trim <> String.Empty Then
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text.Trim
                Else
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = String.Empty
                End If

                If Me.txtCompany.Text.Trim <> String.Empty Then
                    command.Parameters.Add("@company", SqlDbType.NVarChar).Value = txtCompany.Text.Trim
                Else
                    command.Parameters.Add("@company", SqlDbType.NVarChar).Value = String.Empty
                End If

                If Me.txtName.Text.Trim <> String.Empty Then
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text.Trim
                Else
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = String.Empty

                End If
                If Me.txtDateIn.Text.Trim <> String.Empty Then

                    If Utility.IsDateFormat(Me.txtDateIn.Text.Trim) Then
                        command.Parameters.Add("@date_in", SqlDbType.DateTime).Value = txtDateIn.Text
                    Else
                        MessageBox.Show("日付は9999/99/99形式です。")
                        Exit Sub
                    End If

                Else
                    command.Parameters.Add("@date_in", SqlDbType.DateTime).Value = System.Data.SqlTypes.SqlString.Null


                End If

                command.CommandText = InsSql
                command.ExecuteNonQuery()
                trans.Commit()

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("[登録失敗]ロールバックしました。" & ex.Message)

            End Try
        End Using

    End Sub
End Class