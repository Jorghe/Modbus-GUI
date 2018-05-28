Public Class Form1
    ' Declare port, address and instantiate EasyModbus
    Dim modbusPort As Integer = 502

    Dim ipAddress As String '= "192.168.1.76"
    Dim machineCounter As Integer
    Dim redLimit As Integer
    Dim yellowLimit As Integer
    Dim greenLimit As Integer

    Private connectionAvailable As Boolean = False
    Private settingsAvailable As Boolean = False

    Public defaultSettings As New Dictionary(Of String, String)
    Public settingsArray = New String() {"ipAddress", "machineCounter", "redLimit", "yellowLimit", "greenLimit"}

    'Public Sub New(ByVal machC As String, ByVal redLimit As String, ByVal yellowLimit As String, ByVal greenLimit As String)

    'Me.machineCounter = CInt(machC)
    'Me.redLimit = CInt(redLimit)
    'Me.yellowLimit = CInt(yellowLimit)
    'Me.greenLimit = CInt(greenLimit)


    'End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim modbusClient As New EasyModbus.ModbusClient(ipAddress, modbusPort)
        modbusClient.Connect()
        Dim HoldingRegistersArray As Integer() = modbusClient.ReadHoldingRegisters(0, 3)
        txtbox1.Text = HoldingRegistersArray(0).ToString
        txtbox2.Text = HoldingRegistersArray(1).ToString
        txtbox3.Text = HoldingRegistersArray(2).ToString

        modbusClient.Disconnect()
        Console.WriteLine("Register Array", HoldingRegistersArray)


        'txtbox1.Text = randomValue(100)
        'txtbox2.Text = randomValue(100)
        'txtbox3.Text = randomValue(100)
        ' Valor 100 es equivalente a rgba(1, 0, 255, 0)
        ' Valor 75 es equivalente a rgba(1, 255, 170, 0)
        ' Valor 50 es equivalente a rgba(1, 255, 0, 0)

        Dim number As Integer
        Dim redLimit As Integer = CInt(defaultSettings("redLimit"))
        Dim yellowLimit As Integer = CInt(defaultSettings("yellowLimit"))
        Dim greenLimit As Integer = CInt(defaultSettings("greenLimit"))

        Dim result As Boolean = Int32.TryParse(txtbox1.Text, number)
        If result Then
            lblIndicador1.Text = number
            Console.WriteLine("Converted '{0}' to {1}.", txtbox1.Text, number)
            If number > greenLimit Then
                pnlIndicador1.BackColor = Color.Green
            ElseIf number > yellowLimit Then
                pnlIndicador1.BackColor = Color.Yellow
                'End If
            ElseIf number > redLimit Then
                pnlIndicador1.BackColor = Color.Red
            Else Console.WriteLine("Number below red limit")

            End If
        Else
            Console.WriteLine("Attempted conversion of '{0}' failed.",
                          If(txtbox1.Text Is Nothing, "<null>", txtbox1.Text))
        End If

        Dim number2 As Integer

        Dim result2 As Boolean = Int32.TryParse(txtbox2.Text, number2)
        If result Then
            lblIndicador2.Text = number2
            Console.WriteLine("Converted '{0}' to {1}.", txtbox1.Text, number2)
            If number2 > 85 Then
                pnlIndicador2.BackColor = Color.Green
            ElseIf number2 > 70 Then
                pnlIndicador2.BackColor = Color.Yellow
                'End If
            Else pnlIndicador2.BackColor = Color.Red

            End If
        Else
            Console.WriteLine("Attempted conversion of '{0}' failed.",
                              If(txtbox2.Text Is Nothing, "<null>", txtbox1.Text))
        End If

        Dim number3 As Integer

        Dim result3 As Boolean = Int32.TryParse(txtbox3.Text, number3)
        If result Then
            lblIndicador3.Text = number3

            Console.WriteLine("Converted '{0}' to {1}.", txtbox1.Text, number3)
            If number3 > 85 Then
                pnlIndicador3.BackColor = Color.Green
            ElseIf number3 > 70 Then
                pnlIndicador3.BackColor = Color.Yellow
                'End If
            Else pnlIndicador3.BackColor = Color.Red

            End If
        Else
            Console.WriteLine("Attempted conversion of '{0}' failed.",
                              If(txtbox2.Text Is Nothing, "<null>", txtbox1.Text))
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim modbusClient As New EasyModbus.ModbusClient(ipAddress, modbusPort)
        'If (modbusClient.Available(32)) Then
        'End If



        modbusClient.Connect()

            'Dim HoldingRegistersArray As Integer() = modbusClient.ReadHoldingRegisters(0, 3)

            Dim CoilStatus As Boolean() = modbusClient.ReadCoils(0, 1)
        If (CoilStatus(0) = False) Then
            txtBoxGral.Text = "No conectado"
            Timer1.Stop()
            pnlGral.BackColor = Color.Red

            'Start conection attempt
        ElseIf (CoilStatus(0) = True) Then
            txtBoxGral.Text = "Conectado"
            pnlGral.BackColor = Color.Green

            'Switch Holding Timer ON
            Timer1.Start()
        End If
        modbusClient.Disconnect()

    End Sub

    Private Sub goSettings_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles goSettings.LinkClicked
        'Dim Evento As Object
        'Evento = MsgBox("Text", MsgBoxStyle.ApplicationModal, "Do nothing")
        Me.Visible = False
        Settings.Show()

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        applySettings()
        If (settingsAvailable) Then
            testConnection()

        End If
        If (connectionAvailable) Then
            Timer2.Start()

        End If


        'txtDebug.Text = Settings.settingsDict("machineCounter")

    End Sub
    Private Sub testConnection()
        Dim modbusClient As New EasyModbus.ModbusClient(ipAddress, modbusPort)
        Try
            modbusClient.Connect()
            connectionAvailable = True
            modbusClient.Disconnect()


        Catch ex As Exception
            showError("Connection not available")
            connectionAvailable = False

        End Try
    End Sub
    Private Sub showError(message As String)
        Dim Evento As Object
        Evento = MsgBox(message, MsgBoxStyle.Critical, "Error")
    End Sub
    Private Sub applySettings()

        If (Settings.settingsDict.Count > 0) Then
            settingsAvailable = True

            Try
                machineCounter = Settings.settingsDict("machineCounter")
            Catch ex As Exception
                machineCounter = defaultSettings("machineCounter")
                'txtDebug.Text = "Default value"
            End Try
            Try
                ipAddress = Settings.settingsDict("ipAddress")
                'txtDebug.Text = Settings.settingsDict("machineCounter")
            Catch ex As Exception
                Console.WriteLine("settings {0}", ipAddress)
                ipAddress = defaultSettings("ipAddress")

                txtDebug.Text = "Default value"
            End Try

            'Timer2.Start()

        Else
            settingsAvailable = False
            ' Not specified settings
            showError("Settings are recquired")

            'ipAddress = defaultSettings("ipAddress")
            'machineCounter = defaultSettings("machineCounter")

        End If

    End Sub


End Class
