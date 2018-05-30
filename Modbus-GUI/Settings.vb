Public Class Settings
    Public settingsDict As New Dictionary(Of String, String)

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click

        machineCounter.Text = "3"
        redLimit.Text = "85"
        yellowLimit.Text = "90"
        greenLimit.Text = "95"
        ipAddress.Text = "192.168.1.76"

        'Dim Evento As Object
        'Evento = MsgBox("Text", MsgBoxStyle.ApplicationModal, "Do nothing")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Visible = False
        Form1.Show()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Dim Evento As Object
        'Evento = MsgBox("Text", MsgBoxStyle.ApplicationModal, "Parameters will be applied")

        ' Add some elements to the dictionary. There are no 
        ' duplicate keys, but some of the values are duplicates.
        For Each d As KeyValuePair(Of String, String) In settingsDict
            Try
                txtDebug.Text = d.Key
                'd in settings(d)
            Catch ex As Exception
                txtDebug.Text = "Not found"
            End Try
            Console.WriteLine(txtDebug.Text)
        Next

        Try
            settingsDict.Add("ipAddress", ipAddress.Text)
        Catch
            settingsDict("ipAddress") = ipAddress.Text
            Console.WriteLine("An element with Key = already exists.")
        End Try
        If (CInt(machineCounter.Text) > 0) Then
            Try

                settingsDict.Add("machineCounter", machineCounter.Text)
            Catch
                settingsDict("machineCounter") = machineCounter.Text
                Console.WriteLine("An element with Key = already exists.")
            End Try
        Else
            ' machineCounter must be > 0
        End If

        Try
            settingsDict.Add("redLimit", redLimit.Text)

        Catch ex As Exception
            settingsDict("redLimit") = redLimit.Text

        End Try

        Try
            settingsDict.Add("yellowLimit", yellowLimit.Text)
        Catch ex As Exception
            settingsDict("yellowLimit") = yellowLimit.Text

        End Try
        Try
            settingsDict.Add("greenLimit", greenLimit.Text)
        Catch ex As Exception
            settingsDict("greenLimit") = greenLimit.Text

        End Try


        txtDebug.Text = settingsDict("machineCounter")

        Me.Visible = False
        Form1.Show()

    End Sub

    Private Sub addMachineC_Click(sender As Object, e As EventArgs) Handles addMachineC.Click
        Dim i As Integer
        i = CInt(machineCounter.Text) + 1
        machineCounter.Text = i.ToString

    End Sub

    Private Sub remMachineC_Click(sender As Object, e As EventArgs) Handles remMachineC.Click
        Dim i As Integer
        i = CInt(machineCounter.Text) - 1
        machineCounter.Text = i.ToString
    End Sub
End Class