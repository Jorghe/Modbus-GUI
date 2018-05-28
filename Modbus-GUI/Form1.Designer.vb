<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.goSettings = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlGral = New System.Windows.Forms.Panel()
        Me.txtBoxGral = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlIndicador1 = New System.Windows.Forms.Panel()
        Me.lblIndicador1 = New System.Windows.Forms.Label()
        Me.pnlIndicador2 = New System.Windows.Forms.Panel()
        Me.lblIndicador2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.txtDebug = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pnlIndicador3 = New System.Windows.Forms.Panel()
        Me.lblIndicador3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox3 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlIndicador1.SuspendLayout()
        Me.pnlIndicador2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnlIndicador3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(104, 18)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(74, 17)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Máquina 1"
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(121, 45)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(44, 22)
        Me.txtbox1.TabIndex = 1
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(112, 43)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(59, 22)
        Me.txtbox2.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(432, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(139, 41)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start reading"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.goSettings)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 590)
        Me.Panel1.TabIndex = 7
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 114)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 17)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help"
        '
        'goSettings
        '
        Me.goSettings.AutoSize = True
        Me.goSettings.LinkColor = System.Drawing.Color.Black
        Me.goSettings.Location = New System.Drawing.Point(13, 82)
        Me.goSettings.Name = "goSettings"
        Me.goSettings.Size = New System.Drawing.Size(59, 17)
        Me.goSettings.TabIndex = 1
        Me.goSettings.TabStop = True
        Me.goSettings.Text = "Settings"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 61)
        Me.Panel3.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(111, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Panel de control"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.pnlGral)
        Me.Panel2.Controls.Add(Me.txtBoxGral)
        Me.Panel2.Controls.Add(Me.btnStart)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(704, 61)
        Me.Panel2.TabIndex = 8
        '
        'pnlGral
        '
        Me.pnlGral.Location = New System.Drawing.Point(100, 13)
        Me.pnlGral.Name = "pnlGral"
        Me.pnlGral.Size = New System.Drawing.Size(88, 30)
        Me.pnlGral.TabIndex = 13
        '
        'txtBoxGral
        '
        Me.txtBoxGral.Location = New System.Drawing.Point(204, 21)
        Me.txtBoxGral.Name = "txtBoxGral"
        Me.txtBoxGral.Size = New System.Drawing.Size(179, 22)
        Me.txtBoxGral.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Máquina 2"
        '
        'pnlIndicador1
        '
        Me.pnlIndicador1.Controls.Add(Me.lblIndicador1)
        Me.pnlIndicador1.Location = New System.Drawing.Point(13, 21)
        Me.pnlIndicador1.Name = "pnlIndicador1"
        Me.pnlIndicador1.Size = New System.Drawing.Size(72, 66)
        Me.pnlIndicador1.TabIndex = 9
        '
        'lblIndicador1
        '
        Me.lblIndicador1.AutoSize = True
        Me.lblIndicador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicador1.Location = New System.Drawing.Point(21, 15)
        Me.lblIndicador1.Name = "lblIndicador1"
        Me.lblIndicador1.Size = New System.Drawing.Size(24, 25)
        Me.lblIndicador1.TabIndex = 0
        Me.lblIndicador1.Text = "0"
        Me.lblIndicador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlIndicador2
        '
        Me.pnlIndicador2.Controls.Add(Me.lblIndicador2)
        Me.pnlIndicador2.Location = New System.Drawing.Point(11, 21)
        Me.pnlIndicador2.Name = "pnlIndicador2"
        Me.pnlIndicador2.Size = New System.Drawing.Size(72, 66)
        Me.pnlIndicador2.TabIndex = 10
        '
        'lblIndicador2
        '
        Me.lblIndicador2.AutoSize = True
        Me.lblIndicador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicador2.Location = New System.Drawing.Point(15, 15)
        Me.lblIndicador2.Name = "lblIndicador2"
        Me.lblIndicador2.Size = New System.Drawing.Size(27, 29)
        Me.lblIndicador2.TabIndex = 1
        Me.lblIndicador2.Text = "0"
        Me.lblIndicador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Tag = ""
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        Me.Timer2.Tag = ""
        '
        'txtDebug
        '
        Me.txtDebug.Location = New System.Drawing.Point(551, 217)
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.Size = New System.Drawing.Size(100, 22)
        Me.txtDebug.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlIndicador2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbox2)
        Me.GroupBox1.Location = New System.Drawing.Point(468, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pnlIndicador1)
        Me.GroupBox2.Controls.Add(Me.lbl1)
        Me.GroupBox2.Controls.Add(Me.txtbox1)
        Me.GroupBox2.Location = New System.Drawing.Point(223, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Machine 1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pnlIndicador3)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtbox3)
        Me.GroupBox4.Location = New System.Drawing.Point(236, 230)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Machine 3"
        '
        'pnlIndicador3
        '
        Me.pnlIndicador3.Controls.Add(Me.lblIndicador3)
        Me.pnlIndicador3.Location = New System.Drawing.Point(13, 21)
        Me.pnlIndicador3.Name = "pnlIndicador3"
        Me.pnlIndicador3.Size = New System.Drawing.Size(72, 66)
        Me.pnlIndicador3.TabIndex = 9
        '
        'lblIndicador3
        '
        Me.lblIndicador3.AutoSize = True
        Me.lblIndicador3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicador3.Location = New System.Drawing.Point(10, 23)
        Me.lblIndicador3.Name = "lblIndicador3"
        Me.lblIndicador3.Size = New System.Drawing.Size(24, 25)
        Me.lblIndicador3.TabIndex = 0
        Me.lblIndicador3.Text = "0"
        Me.lblIndicador3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Máquina 3"
        '
        'txtbox3
        '
        Me.txtbox3.Location = New System.Drawing.Point(121, 45)
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.Size = New System.Drawing.Size(44, 22)
        Me.txtbox3.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(904, 590)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDebug)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlIndicador1.ResumeLayout(False)
        Me.pnlIndicador1.PerformLayout()
        Me.pnlIndicador2.ResumeLayout(False)
        Me.pnlIndicador2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnlIndicador3.ResumeLayout(False)
        Me.pnlIndicador3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlIndicador1 As Panel
    Friend WithEvents pnlIndicador2 As Panel
    Friend WithEvents lblIndicador1 As Label
    Friend WithEvents lblIndicador2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtBoxGral As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents pnlGral As Panel
    Friend WithEvents goSettings As LinkLabel
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtDebug As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pnlIndicador3 As Panel
    Friend WithEvents lblIndicador3 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbox3 As TextBox
End Class
