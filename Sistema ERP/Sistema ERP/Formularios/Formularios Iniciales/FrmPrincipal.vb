Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation

Partial Public Class FrmPrincipal
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim X As New FrmUsuarios
        X.ShowDialog()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim x As New FrmCat_Articulos
        x.ShowDialog()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem7.ItemClick

        Dim x As New FrmCat_Ubicacion
        x.ShowDialog()
    End Sub

    Private Sub btnarea_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnarea.ItemClick
        Dim x As New FrmCat_Areasvb
        x.ShowDialog()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim x As New FrmCat_Empleado
        x.ShowDialog()

    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Dim x As New FrmReasignar
        x.ShowDialog()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnproveedor.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Proveedor"
        x.ShowDialog()

    End Sub

    Private Sub btnunidadmedida_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnunidadmedida.ItemClick

        Dim x As New FrmCat_General
        x.Llamadatos = "Medida"
        x.ShowDialog()

    End Sub

    Private Sub btnproductos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnproductos.ItemClick

        Dim x As New FrmCat_General
        x.Llamadatos = "Producto"
        x.ShowDialog()

    End Sub

    Private Sub BtnServicios_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnServicios.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Servicio"
        x.ShowDialog()
    End Sub

    Private Sub btnNuevaSol_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNuevaSol.ItemClick
        Dim x As New FrmAdq_ElaboraSol
        x.ShowDialog()
    End Sub

    Private Sub btnSolicitantes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSolicitantes.ItemClick
        Dim x As New Frm_Solicitante
        x.ShowDialog()
    End Sub

    Private Sub btndepartamentos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btndepartamentos.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Departamento"
        x.ShowDialog()
    End Sub

    Private Sub btntasa_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btntasa.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Tasa"
        x.Text = "Tasa de Cambio"
        x.ShowDialog()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSalir_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSalir.ItemClick
        End

    End Sub

    Private Sub cmdTasa_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTasa.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Tasa"
        x.Text = "Tasa de Cambio"
        x.ShowDialog()
    End Sub

    Private Sub cmdCta_Comprobante_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCta_Comprobante.ItemClick
        Dim x As New FrmGeneralCont
        x.Llamadatos = "CatCTE"
        x.ShowDialog()

    End Sub

    Private Sub btnCliente_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCliente.ItemClick

    End Sub
End Class
