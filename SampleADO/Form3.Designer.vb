<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpd
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDateIn = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(309, 72)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 23)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "UPDATEサンプル"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(127, 23)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(100, 19)
        Me.txtKey.TabIndex = 27
        Me.txtKey.Text = "ID"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(53, 23)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(49, 12)
        Me.lblMsg.TabIndex = 25
        Me.lblMsg.Text = "検索キー"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(127, 128)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 19)
        Me.txtEmail.TabIndex = 31
        Me.txtEmail.Text = "メアド"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 92)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 28
        Me.txtName.Text = "名前"
        '
        'txtDateIn
        '
        Me.txtDateIn.Location = New System.Drawing.Point(127, 208)
        Me.txtDateIn.Name = "txtDateIn"
        Me.txtDateIn.Size = New System.Drawing.Size(100, 19)
        Me.txtDateIn.TabIndex = 33
        Me.txtDateIn.Text = "2016/04/01"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(127, 165)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(100, 19)
        Me.txtCompany.TabIndex = 32
        Me.txtCompany.Text = "会社名"
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(309, 19)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(128, 23)
        Me.btnGetData.TabIndex = 34
        Me.btnGetData.Text = "データ呼び出し"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(309, 128)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(128, 23)
        Me.btnDel.TabIndex = 35
        Me.btnDel.Text = "DELETEサンプル"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'FormUpd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 256)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.txtDateIn)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "FormUpd"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtKey As TextBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDateIn As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents btnGetData As Button
    Friend WithEvents btnDel As Button
End Class
