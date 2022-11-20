<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.Login_Attempts_Label = New System.Windows.Forms.Label()
        Me.Login_Attempts_Changing = New System.Windows.Forms.Label()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Username_Textbox = New System.Windows.Forms.TextBox()
        Me.Password_Textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Login:"
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_Label.Location = New System.Drawing.Point(52, 132)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(105, 24)
        Me.Username_Label.TabIndex = 1
        Me.Username_Label.Text = "Username"
        '
        'Password_Label
        '
        Me.Password_Label.AutoSize = True
        Me.Password_Label.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_Label.Location = New System.Drawing.Point(52, 215)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(103, 24)
        Me.Password_Label.TabIndex = 2
        Me.Password_Label.Text = "Password"
        '
        'Login_Attempts_Label
        '
        Me.Login_Attempts_Label.AutoSize = True
        Me.Login_Attempts_Label.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Attempts_Label.Location = New System.Drawing.Point(52, 287)
        Me.Login_Attempts_Label.Name = "Login_Attempts_Label"
        Me.Login_Attempts_Label.Size = New System.Drawing.Size(153, 24)
        Me.Login_Attempts_Label.TabIndex = 5
        Me.Login_Attempts_Label.Text = "Login Attempts"
        '
        'Login_Attempts_Changing
        '
        Me.Login_Attempts_Changing.AutoSize = True
        Me.Login_Attempts_Changing.BackColor = System.Drawing.Color.White
        Me.Login_Attempts_Changing.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Attempts_Changing.Location = New System.Drawing.Point(245, 287)
        Me.Login_Attempts_Changing.Name = "Login_Attempts_Changing"
        Me.Login_Attempts_Changing.Size = New System.Drawing.Size(21, 24)
        Me.Login_Attempts_Changing.TabIndex = 6
        Me.Login_Attempts_Changing.Text = "0"
        '
        'Login_Button
        '
        Me.Login_Button.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.Location = New System.Drawing.Point(173, 349)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(115, 50)
        Me.Login_Button.TabIndex = 7
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'Username_Textbox
        '
        Me.Username_Textbox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Username_Textbox.Location = New System.Drawing.Point(187, 126)
        Me.Username_Textbox.Name = "Username_Textbox"
        Me.Username_Textbox.Size = New System.Drawing.Size(221, 30)
        Me.Username_Textbox.TabIndex = 8
        '
        'Password_Textbox
        '
        Me.Password_Textbox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Password_Textbox.Location = New System.Drawing.Point(187, 209)
        Me.Password_Textbox.Name = "Password_Textbox"
        Me.Password_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_Textbox.Size = New System.Drawing.Size(221, 30)
        Me.Password_Textbox.TabIndex = 9
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(463, 442)
        Me.Controls.Add(Me.Password_Textbox)
        Me.Controls.Add(Me.Username_Textbox)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.Login_Attempts_Changing)
        Me.Controls.Add(Me.Login_Attempts_Label)
        Me.Controls.Add(Me.Password_Label)
        Me.Controls.Add(Me.Username_Label)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login_Form"
        Me.Text = "Staff Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Username_Label As Label
    Friend WithEvents Password_Label As Label
    Friend WithEvents Login_Attempts_Label As Label
    Friend WithEvents Login_Attempts_Changing As Label
    Friend WithEvents Login_Button As Button
    Friend WithEvents Username_Textbox As TextBox
    Friend WithEvents Password_Textbox As TextBox
End Class
