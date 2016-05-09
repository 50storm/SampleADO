<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.txtDateIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(43, 76)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 19)
        Me.txtEmail.TabIndex = 10
        Me.txtEmail.Text = "メアド"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(43, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 9
        Me.txtName.Text = "名前"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(43, 117)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(100, 19)
        Me.txtCompany.TabIndex = 11
        Me.txtCompany.Text = "会社名"
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(177, 53)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(75, 23)
        Me.btnIns.TabIndex = 12
        Me.btnIns.Text = "登録"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'txtDateIn
        '
        Me.txtDateIn.Location = New System.Drawing.Point(43, 160)
        Me.txtDateIn.Name = "txtDateIn"
        Me.txtDateIn.Size = New System.Drawing.Size(100, 19)
        Me.txtDateIn.TabIndex = 13
        Me.txtDateIn.Text = "2016/04/01"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtDateIn)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents btnIns As Button
    Friend WithEvents txtDateIn As TextBox
End Class
