Public Class FrmCat_Ubicacion
    Dim conect As New Conexion
    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim x As New FrmUbicacion
        x.Tipo = "Ubicacion"
        x.ShowDialog()
    End Sub

    Private Sub FrmCat_Ubicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect.CargaGrid(gridUbicacion, "Select Cod_Ubicacion,Descripcion from Tbl_Ubicacion order by Cod_ubicacion", "Tbl_Ubicacion", "")
    End Sub

    Private Sub btneditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btneditar.ItemClick
        Dim x As New FrmUbicacion
        x.Tipo = "Ubicacion"
        x.btnGuardar.Text = "Editar"
        x.Text = "Editar Ubicacion"
        x.Codigo = gvUbicacion.GetFocusedRow(0).ToString
        x.ShowDialog()
    End Sub
End Class