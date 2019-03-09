Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sports As String() = System.IO.Ports.SerialPort.GetPortNames


        If sports Is Nothing Then
            MsgBox("Não foram encontradas portas seriais nesse computador")
        End If

        For i = 0 To UBound(sports)
            ComboBox1.Items.Add(sports(i))
            ComboBox1.SelectedIndex = 0
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            SerialPort1.PortName = ComboBox1.SelectedItem
            SerialPort1.BaudRate = 9600
            SerialPort1.DataBits = 8
            SerialPort1.Parity = IO.Ports.Parity.None
            SerialPort1.StopBits = IO.Ports.StopBits.One

            SerialPort1.Open()
            Label1.Text = "Conectado"

        Catch ex As Exception
            Label1.Text = "Erro ao conectar"
        End Try
    End Sub

    Delegate Sub meumetodo(ByVal [text] As String)
    Dim subrotinaSTR As New meumetodo(AddressOf tratamentoSTR)

    Private Sub SerialPort1_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim string1 As String = SerialPort1.ReadExisting()
        Invoke(subrotinaSTR, string1)
    End Sub

    Sub tratamentoSTR(ByVal meustring As String)
        TextBox1.Text &= meustring

        If meustring = "a" Then
            SendKeys.Send("{F1}")
        ElseIf meustring = "b" Then
            SendKeys.Send("{F2}")
        End If
    End Sub

End Class
