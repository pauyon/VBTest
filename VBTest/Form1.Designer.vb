<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAddValue1 = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.txtAddValue2 = New System.Windows.Forms.TextBox()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtSumAnswer = New System.Windows.Forms.TextBox()
        Me.txtDivideAnswer = New System.Windows.Forms.TextBox()
        Me.lblDivideEqual = New System.Windows.Forms.Label()
        Me.txtDivideValue2 = New System.Windows.Forms.TextBox()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.txtDivideValue1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(53, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 20)
        Me.txtName.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(15, 61)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(96, 61)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(75, 23)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = "&Message"
        Me.txtMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(177, 61)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAddValue1
        '
        Me.txtAddValue1.Location = New System.Drawing.Point(15, 107)
        Me.txtAddValue1.Name = "txtAddValue1"
        Me.txtAddValue1.Size = New System.Drawing.Size(55, 20)
        Me.txtAddValue1.TabIndex = 5
        '
        'btnAddValues
        '
        Me.btnAddValues.Location = New System.Drawing.Point(76, 105)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(23, 23)
        Me.btnAddValues.TabIndex = 6
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'txtAddValue2
        '
        Me.txtAddValue2.Location = New System.Drawing.Point(105, 107)
        Me.txtAddValue2.Name = "txtAddValue2"
        Me.txtAddValue2.Size = New System.Drawing.Size(55, 20)
        Me.txtAddValue2.TabIndex = 7
        '
        'lblAddEqual
        '
        Me.lblAddEqual.AutoSize = True
        Me.lblAddEqual.Location = New System.Drawing.Point(166, 110)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(13, 13)
        Me.lblAddEqual.TabIndex = 8
        Me.lblAddEqual.Text = "="
        '
        'txtSumAnswer
        '
        Me.txtSumAnswer.Location = New System.Drawing.Point(185, 107)
        Me.txtSumAnswer.Name = "txtSumAnswer"
        Me.txtSumAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtSumAnswer.TabIndex = 9
        '
        'txtDivideAnswer
        '
        Me.txtDivideAnswer.Location = New System.Drawing.Point(185, 145)
        Me.txtDivideAnswer.Name = "txtDivideAnswer"
        Me.txtDivideAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideAnswer.TabIndex = 14
        '
        'lblDivideEqual
        '
        Me.lblDivideEqual.AutoSize = True
        Me.lblDivideEqual.Location = New System.Drawing.Point(166, 148)
        Me.lblDivideEqual.Name = "lblDivideEqual"
        Me.lblDivideEqual.Size = New System.Drawing.Size(13, 13)
        Me.lblDivideEqual.TabIndex = 13
        Me.lblDivideEqual.Text = "="
        '
        'txtDivideValue2
        '
        Me.txtDivideValue2.Location = New System.Drawing.Point(105, 145)
        Me.txtDivideValue2.Name = "txtDivideValue2"
        Me.txtDivideValue2.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideValue2.TabIndex = 12
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(76, 143)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(23, 23)
        Me.btnDivide.TabIndex = 11
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'txtDivideValue1
        '
        Me.txtDivideValue1.Location = New System.Drawing.Point(15, 145)
        Me.txtDivideValue1.Name = "txtDivideValue1"
        Me.txtDivideValue1.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideValue1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtDivideAnswer)
        Me.Controls.Add(Me.lblDivideEqual)
        Me.Controls.Add(Me.txtDivideValue2)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.txtDivideValue1)
        Me.Controls.Add(Me.txtSumAnswer)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.txtAddValue2)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.txtAddValue1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents txtMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAddValue1 As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents txtAddValue2 As TextBox
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtSumAnswer As TextBox
    Friend WithEvents txtDivideAnswer As TextBox
    Friend WithEvents lblDivideEqual As Label
    Friend WithEvents txtDivideValue2 As TextBox
    Friend WithEvents btnDivide As Button
    Friend WithEvents txtDivideValue1 As TextBox
End Class
