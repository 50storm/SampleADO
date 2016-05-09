Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FormUpd

    Private strKey As String

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim UpdSql As String = " UPDATE emails SET email=@email, name=@name, company=@company, date_in=@date_in "
        UpdSql &= " WHERE id=@id"

        Dim trans As SqlTransaction
        Using connection As New SqlConnection(My.Settings.Item("connectionString").ToString())
            connection.Open()
            trans = connection.BeginTransaction()

            Try
                Dim command As New SqlCommand()
                command.Connection = connection
                command.Transaction = trans

                command.Parameters.Add("@id", SqlDbType.Int).Value = strKey


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

                command.CommandText = UpdSql
                command.ExecuteNonQuery()
                trans.Commit()

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("[UPDATE失敗！ロールバックします]" & ex.Message)

            End Try
        End Using
    End Sub



    Private Function getKey(txtKey As String) As String
        Dim strKey As String = String.Empty


        Using connection As New SqlConnection(My.Settings.Item("connectionString").ToString())

            connection.Open()
            Dim command As New SqlCommand()
            command.Connection = connection

            Dim selSql As String = "Select * FROM emails Where id = @id"
            command.Parameters.Add("@id", SqlDbType.Int).Value = txtKey
            command.CommandText = selSql

            Try
                'Sqlcommandクラスで発行したSQLの結果はDataReaderで取得
                Dim Reader As SqlDataReader = command.ExecuteReader


                Reader.Read()
                If (Reader.HasRows) Then
                    If String.IsNullOrEmpty(Reader("id").ToString()) Then
                    Else
                        strKey = Reader("id").ToString()

                    End If
                    If String.IsNullOrEmpty(Reader("name").ToString()) Then
                        txtName.Text = String.Empty
                    Else
                        txtName.Text = Reader("name").ToString()

                    End If
                    If String.IsNullOrEmpty(Reader("email").ToString()) Then
                        txtEmail.Text = String.Empty
                    Else
                        txtEmail.Text = Reader("email").ToString()
                    End If
                    If String.IsNullOrEmpty(Reader("company").ToString()) Then
                        txtCompany.Text = String.Empty
                    Else
                        txtCompany.Text = Reader("company").ToString()
                    End If

                    If String.IsNullOrEmpty(Reader("date_in").ToString()) Then
                        txtDateIn.Text = String.Empty
                    Else
                        txtDateIn.Text = Reader("date_in").ToString()
                    End If

                Else

                    MessageBox.Show("テーブルにデータはありませんでした。")
                End If

            Catch ex As Exception
                MessageBox.Show("DB接続エラー")
            End Try

        End Using
        Return strKey

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        strKey = getKey(Me.txtKey.Text.Trim)

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim delSql As String = " DELETE FROM emails WHERE id=@id"

        Dim trans As SqlTransaction
        Using connection As New SqlConnection(My.Settings.Item("connectionString").ToString())
            connection.Open()
            trans = connection.BeginTransaction()

            Try
                Dim command As New SqlCommand()
                command.Connection = connection
                command.Transaction = trans

                command.Parameters.Add("@id", SqlDbType.Int).Value = strKey

                command.CommandText = delSql
                command.ExecuteNonQuery()
                trans.Commit()
                MessageBox.Show("データーベースから削除しました！")
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("[DELETE失敗！ロールバックします]" & ex.Message)

            End Try
        End Using
    End Sub
End Class