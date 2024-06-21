<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roshan Bhagchandani, Slidely Task 2 - Create Submission"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Phone Num"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Github Link For Task 2"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(199, 103)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(479, 31)
        Me.txtName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(199, 163)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(479, 31)
        Me.txtEmail.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(240, 220)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(438, 31)
        Me.txtPhone.TabIndex = 2
        '
        'txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(318, 283)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(360, 31)
        Me.txtGithubLink.TabIndex = 2
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.Color.Khaki
        Me.btnStartStop.Location = New System.Drawing.Point(199, 345)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(260, 34)
        Me.btnStartStop.TabIndex = 3
        Me.btnStartStop.Text = "Toggle StopWatch (CTRL + T)"
        Me.btnStartStop.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(295, 412)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(191, 34)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit (CTRL+S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(487, 348)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.Size = New System.Drawing.Size(191, 31)
        Me.txtStopwatch.TabIndex = 5
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtStopwatch As TextBox
End Class
