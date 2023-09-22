Imports System.Drawing.Drawing2D

Public Class FrmCorreo_Masivo

    Private _ftHelper As New FunctionHelper()
    Private Sub btnasignarImg_Click(sender As Object, e As EventArgs) Handles btnasignarImg.Click

        XtraOpenFileDialog1.Filter = "txt files (*.png)|*.png"
        If XtraOpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = XtraOpenFileDialog1.FileName
            Me.PictureEdit1.Image = _ftHelper.CambiarTamanoImagen(Image.FromFile(filePath), 200, 200)

        End If

    End Sub

    Private Sub btnLimpiarImg_Click(sender As Object, e As EventArgs) Handles btnLimpiarImg.Click
        Me.PictureEdit1.Image.Dispose()

    End Sub

    Private Sub btnCargaCliente_Click(sender As Object, e As EventArgs) Handles btnCargaCliente.Click

    End Sub
End Class