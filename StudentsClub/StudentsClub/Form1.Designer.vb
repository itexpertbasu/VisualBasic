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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMemberNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Items.AddRange(New Object() {"Adams, Ben", "Baker, Sally", "Canseco, Juan", "Davis, Sharon", "Etienne, Jean", "Gonzalez, Jose", "Johnson, Eric", "Koenig, Johann", "Matsunaga, Akiko", "Nakamura, Ken", "Ramairez, Maria", ""})
        Me.lstNames.Location = New System.Drawing.Point(43, 228)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(180, 238)
        Me.lstNames.TabIndex = 0
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.Location = New System.Drawing.Point(480, 228)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(180, 238)
        Me.lstMembers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "General Student List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Club Membership List"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(297, 278)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 102)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add selected student"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(717, 278)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 102)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Remove selected member"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(732, 96)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'lblMemberNum
        '
        Me.lblMemberNum.Location = New System.Drawing.Point(717, 423)
        Me.lblMemberNum.Name = "lblMemberNum"
        Me.lblMemberNum.Size = New System.Drawing.Size(132, 28)
        Me.lblMemberNum.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 585)
        Me.Controls.Add(Me.lblMemberNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.lstNames)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents lstMembers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMemberNum As System.Windows.Forms.Label

End Class
