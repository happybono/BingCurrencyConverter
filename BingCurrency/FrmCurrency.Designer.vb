<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCurrency
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxA = New System.Windows.Forms.ComboBox()
        Me.cbxB = New System.Windows.Forms.ComboBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblCurrentRate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 222)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To"
        '
        'cbxA
        '
        Me.cbxA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbxA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxA.FormattingEnabled = True
        Me.cbxA.Location = New System.Drawing.Point(226, 107)
        Me.cbxA.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cbxA.Name = "cbxA"
        Me.cbxA.Size = New System.Drawing.Size(331, 40)
        Me.cbxA.TabIndex = 0
        '
        'cbxB
        '
        Me.cbxB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbxB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxB.FormattingEnabled = True
        Me.cbxB.Location = New System.Drawing.Point(226, 216)
        Me.cbxB.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cbxB.Name = "cbxB"
        Me.cbxB.Size = New System.Drawing.Size(331, 40)
        Me.cbxB.TabIndex = 1
        '
        'btnRun
        '
        Me.btnRun.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(819, 332)
        Me.btnRun.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(163, 42)
        Me.btnRun.TabIndex = 3
        Me.btnRun.Text = "Convert"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(735, 110)
        Me.txtA.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(290, 32)
        Me.txtA.TabIndex = 2
        Me.txtA.Text = "1"
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(735, 220)
        Me.txtB.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(290, 32)
        Me.txtB.TabIndex = 4
        '
        'btnSwitch
        '
        Me.btnSwitch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwitch.Location = New System.Drawing.Point(321, 162)
        Me.btnSwitch.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(163, 42)
        Me.btnSwitch.TabIndex = 5
        Me.btnSwitch.Text = "Switch"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(597, 113)
        Me.lblA.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(28, 32)
        Me.lblA.TabIndex = 6
        Me.lblA.Text = "$"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(597, 219)
        Me.lblB.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(28, 32)
        Me.lblB.TabIndex = 7
        Me.lblB.Text = "$"
        '
        'lblCurrentRate
        '
        Me.lblCurrentRate.AutoSize = True
        Me.lblCurrentRate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentRate.Location = New System.Drawing.Point(728, 254)
        Me.lblCurrentRate.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCurrentRate.Name = "lblCurrentRate"
        Me.lblCurrentRate.Size = New System.Drawing.Size(0, 32)
        Me.lblCurrentRate.TabIndex = 8
        '
        'FrmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 425)
        Me.Controls.Add(Me.lblCurrentRate)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.cbxB)
        Me.Controls.Add(Me.cbxA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "FrmCurrency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Converter Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxA As ComboBox
    Friend WithEvents cbxB As ComboBox
    Friend WithEvents btnRun As Button
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnSwitch As Button
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblCurrentRate As Label
End Class
