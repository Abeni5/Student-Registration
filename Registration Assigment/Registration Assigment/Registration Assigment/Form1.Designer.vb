﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbdep = New System.Windows.Forms.ComboBox()
        Me.cmdid = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.weekend = New System.Windows.Forms.RadioButton()
        Me.extension = New System.Windows.Forms.RadioButton()
        Me.regular = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.cmdregistred = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Department:"
        '
        'cmbdep
        '
        Me.cmbdep.FormattingEnabled = True
        Me.cmbdep.Items.AddRange(New Object() {"Accounting", "Business Administration", "Computer Science", "Management", "Marketing"})
        Me.cmbdep.Location = New System.Drawing.Point(194, 45)
        Me.cmbdep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbdep.Name = "cmbdep"
        Me.cmbdep.Size = New System.Drawing.Size(180, 28)
        Me.cmbdep.TabIndex = 1
        '
        'cmdid
        '
        Me.cmdid.Location = New System.Drawing.Point(580, 42)
        Me.cmdid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdid.Name = "cmdid"
        Me.cmdid.Size = New System.Drawing.Size(180, 35)
        Me.cmdid.TabIndex = 2
        Me.cmdid.Text = " GenerateID"
        Me.cmdid.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID:"
        '
        'weekend
        '
        Me.weekend.AutoSize = True
        Me.weekend.Location = New System.Drawing.Point(50, 260)
        Me.weekend.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.weekend.Name = "weekend"
        Me.weekend.Size = New System.Drawing.Size(102, 24)
        Me.weekend.TabIndex = 4
        Me.weekend.TabStop = True
        Me.weekend.Text = "Weekend"
        Me.weekend.UseVisualStyleBackColor = True
        '
        'extension
        '
        Me.extension.AutoSize = True
        Me.extension.Location = New System.Drawing.Point(50, 225)
        Me.extension.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.extension.Name = "extension"
        Me.extension.Size = New System.Drawing.Size(104, 24)
        Me.extension.TabIndex = 5
        Me.extension.TabStop = True
        Me.extension.Text = "Extension"
        Me.extension.UseVisualStyleBackColor = True
        '
        'regular
        '
        Me.regular.AutoSize = True
        Me.regular.Location = New System.Drawing.Point(50, 189)
        Me.regular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.regular.Name = "regular"
        Me.regular.Size = New System.Drawing.Size(94, 24)
        Me.regular.TabIndex = 6
        Me.regular.TabStop = True
        Me.regular.Text = "Regular "
        Me.regular.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 138)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(314, 177)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "               Division"
        '
        'cmdclose
        '
        Me.cmdclose.Location = New System.Drawing.Point(502, 348)
        Me.cmdclose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(112, 35)
        Me.cmdclose.TabIndex = 9
        Me.cmdclose.Text = "Exit"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdregistred
        '
        Me.cmdregistred.Location = New System.Drawing.Point(135, 348)
        Me.cmdregistred.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdregistred.Name = "cmdregistred"
        Me.cmdregistred.Size = New System.Drawing.Size(112, 35)
        Me.cmdregistred.TabIndex = 10
        Me.cmdregistred.Text = "Register "
        Me.cmdregistred.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(135, 348)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 35)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Register "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 402)
        Me.Controls.Add(Me.cmdregistred)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.regular)
        Me.Controls.Add(Me.extension)
        Me.Controls.Add(Me.weekend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdid)
        Me.Controls.Add(Me.cmbdep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbdep As System.Windows.Forms.ComboBox
    Friend WithEvents cmdid As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents weekend As System.Windows.Forms.RadioButton
    Friend WithEvents extension As System.Windows.Forms.RadioButton
    Friend WithEvents regular As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdregistred As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
