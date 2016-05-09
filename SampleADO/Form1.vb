Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private connectionString As String


    Private Sub BtnDbConnect_Click(sender As Object, e As EventArgs) Handles BtnDbConnect.Click
        'SQLServerへ接続する文字列(IDとパスワード)
        'SQLServer認証の場合
        ' Security Info=False;User ID=*****;Password=*****;Initial Catalog=AdventureWorks;Server=MySqlServer"
        'connectionString  = "Persist Security Info=False;User ID=sa;Password=awsadmin;Initial Catalog=pdi;Server=AWS-IG-PC\SQLEXPRESS"


        'App.configに記述する場合(設定ファイルに外出しする場合)
        connectionString = My.Settings.Item("connectionString").ToString()



        'ADO.NETで
        'SQLServerへの接続をするには、SqlConnectionクラスを使うことになっています。
        'Using句を使って、コネクション開放を自動的に行うか、もしくは、
        'Dimで宣言した場合は、Try~catchで囲み、例外発生時に、コネクションを強制的に開放できるようにしてください。
        '

        'Dim connection As New SqlConnection(connectionString)

        'Try
        '    connection.Open()
        '    MessageBox.Show("DBと接続しました。")

        '    'SQLを発行する処理を書く


        '    connection.Close()
        '    MessageBox.Show("DBと切断しました。")

        'Catch ex As Exception
        '    MessageBox.Show("例外が発生しました。" & ex.Message)
        '    '例外発生時の処理を書く

        'Finally
        '    MessageBox.Show("DBコネクションを開放します")
        '    'コネクションを開放させる
        '    connection.Close()

        'End Try

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("DBと接続しました。")

                'SQLを発行する処理を書く

                '書いても書かなくてもDBコネクションの開放は保証される
                'connection.Close()
                MessageBox.Show("DBと切断しました。")
            Catch ex As Exception
                MessageBox.Show("例外が発生しました。" & ex.Message)
                '例外発生時の処理を書く

            End Try
        End Using


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exeBtn.Click

        If Me.txtEmailKey.Text.Equals(String.Empty) Then
            MessageBox.Show("メアドは必須です～")
            '検索しない
            Exit Sub
        End If


        Using connection As New SqlConnection(My.Settings.Item("connectionString").ToString())

            connection.Open()
            Dim command As New SqlCommand()
            command.Connection = connection

            Dim selSql As String = "Select * FROM emails Where email = @email"

            If Me.txtNameKey.Text.Trim <> String.Empty Then
                selSql &= " And name = @name "
            End If

            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmailKey.Text.Trim

            If Me.txtNameKey.Text.Trim <> String.Empty Then
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNameKey.Text.Trim

            End If

            command.CommandText = selSql

            'Sqlcommandクラスで発行したSQLの結果はDataReaderで取得
            Dim Reader As SqlDataReader = command.ExecuteReader


            Reader.Read()
            If (Reader.HasRows) Then
                If String.IsNullOrEmpty(Reader("name").ToString()) Then
                Else
                    txtName.Text = Reader("name").ToString()

                End If
                If String.IsNullOrEmpty(Reader("email").ToString()) Then
                Else
                    txtEmail.Text = Reader("email").ToString()
                End If
                If String.IsNullOrEmpty(Reader("company").ToString()) Then
                Else
                    txtCompany.Text = Reader("company").ToString()
                End If
            Else

                MessageBox.Show("テーブルにデータはありませんでした。")
            End If
        End Using

        'MessageBox.Show("DBと切断しました。")


    End Sub

    Private Sub chkBoxNameKey_CheckedChanged(sender As Object, e As EventArgs)
        If txtNameKey.Enabled Then
            txtNameKey.Enabled = False
        Else
            txtNameKey.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Initialize()
    End Sub

    Private Sub Initialize()

        txtNameKey.Text = "五十嵐"
        txtEmailKey.Text = "igarashi@hnps.co.jp"

        txtNameKey.Enabled = True
        txtEmailKey.Enabled = True

        txtName.Text = String.Empty
        txtEmail.Text = String.Empty

    End Sub

    Private Sub chkBoxEmailKey_CheckedChanged(sender As Object, e As EventArgs)
        If txtEmailKey.Enabled Then
            txtEmailKey.Enabled = False
        Else
            txtEmailKey.Enabled = True
        End If
    End Sub



    Private Function getSqlNameKey(connection As SqlConnection) As SqlCommand
        Dim command As New SqlCommand()
        command.Connection = connection
        command.CommandText = "SELECT * FROM emails Where name = @name"
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNameKey.Text.Trim

        Return command

    End Function


    Private Function getSqlEmailKey(connection As SqlConnection) As SqlCommand
        Dim command As New SqlCommand()
        command.CommandText = "SELECT * FROM emails Where email = @email"
        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmailKey.Text.Trim

        Return command
    End Function


    Private Function getSqlNameAndEmail(connection As SqlConnection) As SqlCommand
        Dim command As New SqlCommand()
        command.CommandText = "SELECT * FROM emails Where email = @email and @name"
        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmailKey.Text.Trim
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNameKey.Text.Trim


        Return command
    End Function

    Private Sub RBtnSelect_CheckedChanged(sender As Object, e As EventArgs)
        lblMsg.Text = "検索キー(And)"
        exeBtn.Text = "SELECT"

    End Sub

    Private Sub RBtnIns_CheckedChanged(sender As Object, e As EventArgs)
        lblMsg.Text = "登録"
        exeBtn.Text = "INSERT"


    End Sub

    Private Sub btnSelGview_Click(sender As Object, e As EventArgs) Handles btnSelGview.Click
        If Me.txtEmailKey.Text.Equals(String.Empty) Then
            MessageBox.Show("メアドは必須です～")
            '検索しない
            Exit Sub
        End If


        Using connection As New SqlConnection(My.Settings.Item("connectionString").ToString())

            connection.Open()
            Dim command As New SqlCommand()
            command.Connection = connection

            Dim selSql As String = "Select * FROM emails Where email = @email"

            If Me.txtNameKey.Text.Trim <> String.Empty Then
                selSql &= " And name = @name "
            End If

            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmailKey.Text.Trim

            If Me.txtNameKey.Text.Trim <> String.Empty Then
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNameKey.Text.Trim

            End If
            command.CommandText = selSql

            Dim adapter As New SqlDataAdapter
            adapter.SelectCommand = command

            Dim ds As New DataSet

            adapter.Fill(ds, "emails")
            Me.gView.AutoGenerateColumns = True

            Me.gView.DataSource = ds.Tables("emails")

            Me.gView.Refresh()

            Me.gView.Visible = True


        End Using

        'MessageBox.Show("DBと切断しました。")

    End Sub

    Private Sub btnInsForm_Click(sender As Object, e As EventArgs) Handles btnInsForm.Click
        Dim FormIns As New Form2
        FormIns.Show()

    End Sub

    Private Sub btnUpdateSample_Click(sender As Object, e As EventArgs) Handles btnUpdateSample.Click
        Dim FormUpd As New FormUpd
        FormUpd.Show()

    End Sub
End Class
