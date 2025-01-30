Public Class FrmCat_Articulos
    Public busca, cod_etiqueta As String


    Private Sub FrmCat_Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim x As New FrmArticulo
        x.ShowDialog()
    End Sub
End Class