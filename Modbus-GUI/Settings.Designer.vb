<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ipAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDebug = New System.Windows.Forms.TextBox()
        Me.addMachineC = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.advancedSettings = New System.Windows.Forms.CheckBox()
        Me.remMachineC = New System.Windows.Forms.Button()
        Me.machineCounter = New System.Windows.Forms.TextBox()
        Me.greenLimit = New System.Windows.Forms.TextBox()
        Me.yellowLimit = New System.Windows.Forms.TextBox()
        Me.redLimit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ipAddress)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtDebug)
        Me.Panel1.Controls.Add(Me.addMachineC)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.advancedSettings)
        Me.Panel1.Controls.Add(Me.remMachineC)
        Me.Panel1.Controls.Add(Me.machineCounter)
        Me.Panel1.Controls.Add(Me.greenLimit)
        Me.Panel1.Controls.Add(Me.yellowLimit)
        Me.Panel1.Controls.Add(Me.redLimit)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(52, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 326)
        Me.Panel1.TabIndex = 0
        '
        'ipAddress
        '
        Me.ipAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ipAddress.Location = New System.Drawing.Point(211, 14)
        Me.ipAddress.MaxLength = 20
        Me.ipAddress.Name = "ipAddress"
        Me.ipAddress.Size = New System.Drawing.Size(148, 22)
        Me.ipAddress.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "IP Address"
        '
        'txtDebug
        '
        Me.txtDebug.Location = New System.Drawing.Point(211, 229)
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.Size = New System.Drawing.Size(100, 22)
        Me.txtDebug.TabIndex = 12
        '
        'addMachineC
        '
        Me.addMachineC.Location = New System.Drawing.Point(300, 48)
        Me.addMachineC.Name = "addMachineC"
        Me.addMachineC.Size = New System.Drawing.Size(20, 23)
        Me.addMachineC.TabIndex = 2
        Me.addMachineC.Text = "+"
        Me.addMachineC.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Ports"
        '
        'advancedSettings
        '
        Me.advancedSettings.AutoSize = True
        Me.advancedSettings.Location = New System.Drawing.Point(7, 208)
        Me.advancedSettings.Name = "advancedSettings"
        Me.advancedSettings.Size = New System.Drawing.Size(148, 21)
        Me.advancedSettings.TabIndex = 10
        Me.advancedSettings.Text = "Advanced Settings"
        Me.advancedSettings.UseVisualStyleBackColor = True
        '
        'remMachineC
        '
        Me.remMachineC.Location = New System.Drawing.Point(229, 48)
        Me.remMachineC.Name = "remMachineC"
        Me.remMachineC.Size = New System.Drawing.Size(20, 23)
        Me.remMachineC.TabIndex = 3
        Me.remMachineC.Text = "-"
        Me.remMachineC.UseVisualStyleBackColor = True
        '
        'machineCounter
        '
        Me.machineCounter.Location = New System.Drawing.Point(255, 49)
        Me.machineCounter.Name = "machineCounter"
        Me.machineCounter.Size = New System.Drawing.Size(39, 22)
        Me.machineCounter.TabIndex = 8
        Me.machineCounter.Text = "0"
        '
        'greenLimit
        '
        Me.greenLimit.Location = New System.Drawing.Point(255, 173)
        Me.greenLimit.Name = "greenLimit"
        Me.greenLimit.Size = New System.Drawing.Size(39, 22)
        Me.greenLimit.TabIndex = 7
        '
        'yellowLimit
        '
        Me.yellowLimit.Location = New System.Drawing.Point(255, 138)
        Me.yellowLimit.Name = "yellowLimit"
        Me.yellowLimit.Size = New System.Drawing.Size(39, 22)
        Me.yellowLimit.TabIndex = 6
        '
        'redLimit
        '
        Me.redLimit.Location = New System.Drawing.Point(255, 104)
        Me.redLimit.Name = "redLimit"
        Me.redLimit.Size = New System.Drawing.Size(39, 22)
        Me.redLimit.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Green"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Yellow"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Red"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Change limits"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number of machines"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Settings"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(52, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(352, 387)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(195, 387)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 5
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 450)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents advancedSettings As CheckBox
    Friend WithEvents remMachineC As Button
    Friend WithEvents machineCounter As TextBox
    Friend WithEvents greenLimit As TextBox
    Friend WithEvents yellowLimit As TextBox
    Friend WithEvents redLimit As TextBox
    Friend WithEvents addMachineC As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnDefault As Button
    Friend WithEvents txtDebug As TextBox
    Friend WithEvents ipAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
