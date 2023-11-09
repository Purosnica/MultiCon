

Public Class FrmCorreo_Masivo

    Private _ftHelper As New FunctionHelper()
    Private _dtCorreo As DataTable
    Private Sub btnasignarImg_Click(sender As Object, e As EventArgs) Handles btnasignarImg.Click

        'XtraOpenFileDialog1.Filter = "txt files  (.html)|*.html"
        If XtraOpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = XtraOpenFileDialog1.FileName
            txtformato.EditValue = filePath

        End If

    End Sub

    Private Sub btnLimpiarImg_Click(sender As Object, e As EventArgs) Handles btnLimpiarImg.Click
        txtformato.EditValue = ""

    End Sub

    Private Sub btnCargaCliente_Click(sender As Object, e As EventArgs) Handles btnCargaCliente.Click


        _ftHelper.EnviarCorreosMasivos("purosnica@gmail.com", "jvmxwvgdwfemdpnd", "stmp.gmail.com", 587, _dtCorreo, txtformato.EditValue, TextBox1.Text.ToString().Trim)
    End Sub
End Class