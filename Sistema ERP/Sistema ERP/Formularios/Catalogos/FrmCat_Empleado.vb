Public Class FrmCat_Empleado
    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim x As New FrmEmpleado
        x.ShowDialog()
    End Sub
End Class