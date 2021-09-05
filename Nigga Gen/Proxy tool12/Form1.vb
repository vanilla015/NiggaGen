


Public Class Form1
    Private Sub FormImagenFondoUno_Load(
            ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles MyBase.Load

        Call EstablecerImagenFondoParaFormLoad()
    End Sub
    Private Sub EstablecerImagenFondoParaFormLoad()
        Try
            Me.BackgroundImage =
        Image.FromFile(".\img\Imagen1.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch

        Finally
        End Try
    End Sub
    Private Sub FormImagenFondoUno_Resize(
        ByVal sender As Object, ByVal e As System.EventArgs) _
         Handles Me.Resize
        Me.Refresh()
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        ProgressBar1.Maximum = NumericUpDown1.Value
        Do Until Label1.Text = NumericUpDown1.Value
            Dim caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
            Dim num As Integer = 16
            Dim RND As New Random
            Dim code As String = ""
            Do Until code.Length = num
                code += caracteres.ToCharArray(RND.Next(0, caracteres.Length), 1)
            Loop
            ProgressBar1.Increment(1)
            Label1.Text += 1
            TextBox1.Text =
        TextBox1.Text & vbNewLine & "https://discord.gift/" & code
        Loop
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        NumericUpDown1.Maximum = Decimal.MaxValue
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBox1.Text = ""
        Label1.Text = 0
        ProgressBar1.Value = 0
    End Sub
End Class