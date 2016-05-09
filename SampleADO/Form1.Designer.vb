<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnDbConnect = New System.Windows.Forms.Button()
        Me.exeBtn = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtNameKey = New System.Windows.Forms.TextBox()
        Me.txtEmailKey = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gView = New System.Windows.Forms.DataGridView()
        Me.btnSelGview = New System.Windows.Forms.Button()
        Me.btnInsForm = New System.Windows.Forms.Button()
        Me.btnUpdateSample = New System.Windows.Forms.Button()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDbConnect
        '
        Me.BtnDbConnect.Location = New System.Drawing.Point(375, 12)
        Me.BtnDbConnect.Name = "BtnDbConnect"
        Me.BtnDbConnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnDbConnect.TabIndex = 0
        Me.BtnDbConnect.Text = "DB接続のみ"
        Me.BtnDbConnect.UseVisualStyleBackColor = True
        '
        'exeBtn
        '
        Me.exeBtn.Location = New System.Drawing.Point(375, 54)
        Me.exeBtn.Name = "exeBtn"
        Me.exeBtn.Size = New System.Drawing.Size(75, 23)
        Me.exeBtn.TabIndex = 4
        Me.exeBtn.Text = "SELECT"
        Me.exeBtn.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(175, 146)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 5
        Me.txtName.Text = "名前"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "名前"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(175, 182)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 19)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.Text = "メアド"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(44, 54)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(77, 12)
        Me.lblMsg.TabIndex = 9
        Me.lblMsg.Text = "検索キー(And)"
        '
        'txtNameKey
        '
        Me.txtNameKey.Location = New System.Drawing.Point(142, 76)
        Me.txtNameKey.Name = "txtNameKey"
        Me.txtNameKey.Size = New System.Drawing.Size(100, 19)
        Me.txtNameKey.TabIndex = 10
        Me.txtNameKey.Text = "名前"
        '
        'txtEmailKey
        '
        Me.txtEmailKey.Location = New System.Drawing.Point(142, 51)
        Me.txtEmailKey.Name = "txtEmailKey"
        Me.txtEmailKey.Size = New System.Drawing.Size(100, 19)
        Me.txtEmailKey.TabIndex = 13
        Me.txtEmailKey.Text = "メアド"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "検索結果"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "動的なSQLサンプル"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(175, 221)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(100, 19)
        Me.txtCompany.TabIndex = 18
        Me.txtCompany.Text = "会社名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Company"
        '
        'gView
        '
        Me.gView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gView.Location = New System.Drawing.Point(92, 221)
        Me.gView.Name = "gView"
        Me.gView.RowTemplate.Height = 21
        Me.gView.Size = New System.Drawing.Size(425, 150)
        Me.gView.TabIndex = 20
        '
        'btnSelGview
        '
        Me.btnSelGview.Location = New System.Drawing.Point(374, 109)
        Me.btnSelGview.Name = "btnSelGview"
        Me.btnSelGview.Size = New System.Drawing.Size(142, 23)
        Me.btnSelGview.TabIndex = 21
        Me.btnSelGview.Text = "SELECT(GridView)"
        Me.btnSelGview.UseVisualStyleBackColor = True
        '
        'btnInsForm
        '
        Me.btnInsForm.Location = New System.Drawing.Point(374, 146)
        Me.btnInsForm.Name = "btnInsForm"
        Me.btnInsForm.Size = New System.Drawing.Size(75, 23)
        Me.btnInsForm.TabIndex = 22
        Me.btnInsForm.Text = "INSERT"
        Me.btnInsForm.UseVisualStyleBackColor = True
        '
        'btnUpdateSample
        '
        Me.btnUpdateSample.Location = New System.Drawing.Point(374, 177)
        Me.btnUpdateSample.Name = "btnUpdateSample"
        Me.btnUpdateSample.Size = New System.Drawing.Size(150, 23)
        Me.btnUpdateSample.TabIndex = 23
        Me.btnUpdateSample.Text = "UPDATE/DELETE"
        Me.btnUpdateSample.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 385)
        Me.Controls.Add(Me.btnUpdateSample)
        Me.Controls.Add(Me.btnInsForm)
        Me.Controls.Add(Me.btnSelGview)
        Me.Controls.Add(Me.gView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmailKey)
        Me.Controls.Add(Me.txtNameKey)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.exeBtn)
        Me.Controls.Add(Me.BtnDbConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents BtnDbConnect As Button
    Friend WithEvents exeBtn As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents txtNameKey As TextBox
    Friend WithEvents txtEmailKey As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gView As DataGridView
    Friend WithEvents btnSelGview As Button
    Friend WithEvents btnInsForm As Button
    Friend WithEvents btnUpdateSample As Button
End Class
