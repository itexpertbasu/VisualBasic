<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.radAdult = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalFee = New System.Windows.Forms.TextBox()
        Me.lblMonthlyFee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSenior)
        Me.GroupBox1.Controls.Add(Me.radStudent)
        Me.GroupBox1.Controls.Add(Me.radChild)
        Me.GroupBox1.Controls.Add(Me.radAdult)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of Membership"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(26, 104)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(89, 17)
        Me.radSenior.TabIndex = 3
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "S&enior Citizen"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(26, 81)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(62, 17)
        Me.radStudent.TabIndex = 2
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "&Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Location = New System.Drawing.Point(26, 58)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(108, 17)
        Me.radChild.TabIndex = 1
        Me.radChild.TabStop = True
        Me.radChild.Text = "Child (12 && under)"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Location = New System.Drawing.Point(26, 35)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(95, 17)
        Me.radAdult.TabIndex = 0
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard Adult"
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTrainer)
        Me.GroupBox2.Controls.Add(Me.chkKarate)
        Me.GroupBox2.Controls.Add(Me.chkYoga)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 155)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkTrainer
        '
        Me.chkTrainer.AutoSize = True
        Me.chkTrainer.Location = New System.Drawing.Point(57, 96)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(103, 17)
        Me.chkTrainer.TabIndex = 2
        Me.chkTrainer.Text = "Personal Trainer"
        Me.chkTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(57, 63)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(57, 17)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(54, 36)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(51, 17)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMonths)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 115)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Membership Length"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(24, 55)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(142, 20)
        Me.txtMonths.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Number of Months"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalFee)
        Me.GroupBox4.Controls.Add(Me.lblMonthlyFee)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(362, 193)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(261, 113)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Membership Fees"
        '
        'lblTotalFee
        '
        Me.lblTotalFee.Location = New System.Drawing.Point(125, 67)
        Me.lblTotalFee.Name = "lblTotalFee"
        Me.lblTotalFee.Size = New System.Drawing.Size(96, 20)
        Me.lblTotalFee.TabIndex = 3
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.Location = New System.Drawing.Point(121, 30)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(101, 20)
        Me.lblMonthlyFee.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monthly Fee"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(72, 346)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 21)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(278, 346)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 20)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(489, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 26)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(0, 371)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(740, 22)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 393)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Membership Fee Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotalFee As TextBox
    Friend WithEvents lblMonthlyFee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStatus As StatusStrip
End Class
