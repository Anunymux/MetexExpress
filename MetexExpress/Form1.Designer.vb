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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnZufall = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblMessintervall = New System.Windows.Forms.Label()
        Me.lblMessdauer = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtMessDauer = New System.Windows.Forms.TextBox()
        Me.txtMessIntervall = New System.Windows.Forms.TextBox()
        Me.toggleAnAus = New System.Windows.Forms.CheckBox()
        Me.rbSMessInvervall = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbHMessIntervall = New System.Windows.Forms.RadioButton()
        Me.rbMMessIntervall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbHMessdauer = New System.Windows.Forms.RadioButton()
        Me.rbMMessdauer = New System.Windows.Forms.RadioButton()
        Me.rbSMessDauer = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 1200
        Me.SerialPort1.DataBits = 7
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.ReadTimeout = 1000
        Me.SerialPort1.StopBits = System.IO.Ports.StopBits.Two
        Me.SerialPort1.WriteTimeout = 1000
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(184, 22)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(98, 16)
        Me.lblAnswer.TabIndex = 1
        Me.lblAnswer.Text = "Text von Metex"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Messintervall"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Messdauer"
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(504, 194)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(121, 23)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export nach CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnZufall
        '
        Me.btnZufall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZufall.Location = New System.Drawing.Point(649, 193)
        Me.btnZufall.Name = "btnZufall"
        Me.btnZufall.Size = New System.Drawing.Size(75, 23)
        Me.btnZufall.TabIndex = 8
        Me.btnZufall.Text = "Zufall"
        Me.btnZufall.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(504, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(220, 176)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "Werte"
        Me.ColumnHeader.Width = 193
        '
        'lblMessintervall
        '
        Me.lblMessintervall.AutoSize = True
        Me.lblMessintervall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessintervall.ForeColor = System.Drawing.Color.Red
        Me.lblMessintervall.Location = New System.Drawing.Point(10, 68)
        Me.lblMessintervall.Name = "lblMessintervall"
        Me.lblMessintervall.Size = New System.Drawing.Size(0, 16)
        Me.lblMessintervall.TabIndex = 10
        '
        'lblMessdauer
        '
        Me.lblMessdauer.AutoSize = True
        Me.lblMessdauer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessdauer.ForeColor = System.Drawing.Color.Red
        Me.lblMessdauer.Location = New System.Drawing.Point(134, 68)
        Me.lblMessdauer.Name = "lblMessdauer"
        Me.lblMessdauer.Size = New System.Drawing.Size(0, 16)
        Me.lblMessdauer.TabIndex = 11
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 196)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtMessDauer
        '
        Me.txtMessDauer.AcceptsTab = True
        Me.txtMessDauer.AutoCompleteCustomSource.AddRange(New String() {"test", "hallo", "aaaaaa", "mist"})
        Me.txtMessDauer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMessDauer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMessDauer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMessDauer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessDauer.Location = New System.Drawing.Point(140, 74)
        Me.txtMessDauer.MaxLength = 2
        Me.txtMessDauer.Name = "txtMessDauer"
        Me.txtMessDauer.Size = New System.Drawing.Size(37, 22)
        Me.txtMessDauer.TabIndex = 16
        Me.txtMessDauer.Text = "1"
        '
        'txtMessIntervall
        '
        Me.txtMessIntervall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessIntervall.Location = New System.Drawing.Point(12, 74)
        Me.txtMessIntervall.MaxLength = 2
        Me.txtMessIntervall.Name = "txtMessIntervall"
        Me.txtMessIntervall.Size = New System.Drawing.Size(37, 22)
        Me.txtMessIntervall.TabIndex = 17
        Me.txtMessIntervall.Text = "1"
        '
        'toggleAnAus
        '
        Me.toggleAnAus.Appearance = System.Windows.Forms.Appearance.Button
        Me.toggleAnAus.AutoSize = True
        Me.toggleAnAus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toggleAnAus.Location = New System.Drawing.Point(12, 12)
        Me.toggleAnAus.Name = "toggleAnAus"
        Me.toggleAnAus.Size = New System.Drawing.Size(80, 26)
        Me.toggleAnAus.TabIndex = 18
        Me.toggleAnAus.Text = "Verbinden"
        Me.toggleAnAus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toggleAnAus.UseVisualStyleBackColor = True
        '
        'rbSMessInvervall
        '
        Me.rbSMessInvervall.AutoSize = True
        Me.rbSMessInvervall.Checked = True
        Me.rbSMessInvervall.Location = New System.Drawing.Point(6, 19)
        Me.rbSMessInvervall.Name = "rbSMessInvervall"
        Me.rbSMessInvervall.Size = New System.Drawing.Size(87, 20)
        Me.rbSMessInvervall.TabIndex = 20
        Me.rbSMessInvervall.TabStop = True
        Me.rbSMessInvervall.Text = "Sekunden"
        Me.rbSMessInvervall.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbHMessIntervall)
        Me.GroupBox1.Controls.Add(Me.rbMMessIntervall)
        Me.GroupBox1.Controls.Add(Me.rbSMessInvervall)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(101, 92)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "in"
        '
        'rbHMessIntervall
        '
        Me.rbHMessIntervall.AutoSize = True
        Me.rbHMessIntervall.Location = New System.Drawing.Point(6, 65)
        Me.rbHMessIntervall.Name = "rbHMessIntervall"
        Me.rbHMessIntervall.Size = New System.Drawing.Size(75, 20)
        Me.rbHMessIntervall.TabIndex = 22
        Me.rbHMessIntervall.Text = "Stunden"
        Me.rbHMessIntervall.UseVisualStyleBackColor = True
        '
        'rbMMessIntervall
        '
        Me.rbMMessIntervall.AutoSize = True
        Me.rbMMessIntervall.Location = New System.Drawing.Point(6, 42)
        Me.rbMMessIntervall.Name = "rbMMessIntervall"
        Me.rbMMessIntervall.Size = New System.Drawing.Size(72, 20)
        Me.rbMMessIntervall.TabIndex = 21
        Me.rbMMessIntervall.Text = "Minuten"
        Me.rbMMessIntervall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbHMessdauer)
        Me.GroupBox2.Controls.Add(Me.rbMMessdauer)
        Me.GroupBox2.Controls.Add(Me.rbSMessDauer)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(137, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 92)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "in"
        '
        'rbHMessdauer
        '
        Me.rbHMessdauer.AutoSize = True
        Me.rbHMessdauer.Location = New System.Drawing.Point(6, 65)
        Me.rbHMessdauer.Name = "rbHMessdauer"
        Me.rbHMessdauer.Size = New System.Drawing.Size(75, 20)
        Me.rbHMessdauer.TabIndex = 22
        Me.rbHMessdauer.TabStop = True
        Me.rbHMessdauer.Text = "Stunden"
        Me.rbHMessdauer.UseVisualStyleBackColor = True
        '
        'rbMMessdauer
        '
        Me.rbMMessdauer.AutoSize = True
        Me.rbMMessdauer.Location = New System.Drawing.Point(6, 42)
        Me.rbMMessdauer.Name = "rbMMessdauer"
        Me.rbMMessdauer.Size = New System.Drawing.Size(72, 20)
        Me.rbMMessdauer.TabIndex = 21
        Me.rbMMessdauer.TabStop = True
        Me.rbMMessdauer.Text = "Minuten"
        Me.rbMMessdauer.UseVisualStyleBackColor = True
        '
        'rbSMessDauer
        '
        Me.rbSMessDauer.AutoSize = True
        Me.rbSMessDauer.Checked = True
        Me.rbSMessDauer.Location = New System.Drawing.Point(6, 19)
        Me.rbSMessDauer.Name = "rbSMessDauer"
        Me.rbSMessDauer.Size = New System.Drawing.Size(87, 20)
        Me.rbSMessDauer.TabIndex = 20
        Me.rbSMessDauer.TabStop = True
        Me.rbSMessDauer.Text = "Sekunden"
        Me.rbSMessDauer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 221)
        Me.Controls.Add(Me.txtMessDauer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtMessIntervall)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.toggleAnAus)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblMessdauer)
        Me.Controls.Add(Me.lblMessintervall)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnZufall)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAnswer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metex auswerten"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnZufall As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents lblMessintervall As System.Windows.Forms.Label
    Friend WithEvents lblMessdauer As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtMessDauer As TextBox
    Friend WithEvents txtMessIntervall As TextBox
    Friend WithEvents toggleAnAus As CheckBox
    Friend WithEvents rbSMessInvervall As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbHMessIntervall As RadioButton
    Friend WithEvents rbMMessIntervall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbHMessdauer As RadioButton
    Friend WithEvents rbMMessdauer As RadioButton
    Friend WithEvents rbSMessDauer As RadioButton
End Class
