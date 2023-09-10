Public Class FrmCat_Clientes
    Public Llamadatos As String
    Private Sub FrmCat_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim x As New Frm_Cliente
        x.ShowDialog()
    End Sub
End Class