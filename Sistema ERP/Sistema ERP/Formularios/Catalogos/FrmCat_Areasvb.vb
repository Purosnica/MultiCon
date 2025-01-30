Public Class FrmCat_Areasvb
    Dim conect As New Conexion
    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick



        Dim x As New FrmUbicacion
        x.Tipo = "Area"
        x.Text = "Nueva Area"
        x.ShowDialog()
    End Sub

    Private Sub FrmCat_Areasvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect.CargaGrid(gridarea, "Select Cod_Area,Descripcion from Tbl_Areas order by Cod_Area", "Tbl_Areas", "")
    End Sub

    Private Sub btnEdita_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdita.ItemClick


        Dim x As New FrmUbicacion
        x.Tipo = "Area"
        x.Text = "Editar Area"
        x.btnGuardar.Text = "Editar"
        x.Codigo = gvarea.GetFocusedRow(0).ToString
        x.ShowDialog()

    End Sub
End Class