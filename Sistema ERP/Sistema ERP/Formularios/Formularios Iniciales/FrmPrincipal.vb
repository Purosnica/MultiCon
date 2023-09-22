Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation

Partial Public Class FrmPrincipal
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim X As New FrmUsuarios
        X.MdiParent = Me
        X.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim x As New FrmCat_Articulos
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem7.ItemClick

        Dim x As New FrmCat_Ubicacion
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btnarea_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnarea.ItemClick
        Dim x As New FrmCat_Areasvb
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim x As New FrmCat_Empleado
        x.MdiParent = Me
        x.Show()

    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Dim x As New FrmReasignar
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnproveedor.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Proveedor"
        x.MdiParent = Me
        x.Show()

    End Sub

    Private Sub btnunidadmedida_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnunidadmedida.ItemClick

        Dim x As New FrmCat_General
        x.Llamadatos = "Medida"
        x.MdiParent = Me
        x.Show()


    End Sub

    Private Sub btnproductos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnproductos.ItemClick

        Dim x As New FrmCat_General
        x.Llamadatos = "Producto"
        x.MdiParent = Me
        x.Show()


    End Sub

    Private Sub BtnServicios_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnServicios.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Servicio"
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btnNuevaSol_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNuevaSol.ItemClick
        Dim x As New FrmAdq_ElaboraSol
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btnSolicitantes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSolicitantes.ItemClick
        Dim x As New Frm_Solicitante
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btndepartamentos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btndepartamentos.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Departamento"
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btntasa_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btntasa.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Tasa"
        x.Text = "Tasa de Cambio"
        x.MdiParent = Me
        x.Show()
    End Sub


    Private Sub cmdTasa_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTasa.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Tasa"
        x.Text = "Tasa de Cambio"
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub cmdCta_Comprobante_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdCta_Comprobante.ItemClick
        Dim x As New FrmGeneralCont
        x.Llamadatos = "CatCTE"
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btnCliente_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCliente.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Cliente"
        x.Text = "Catalago de Cliente"
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btnCorreoMasivos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCorreoMasivos.ItemClick
        Dim x As New FrmCorreo_Masivo
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btnPais_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPais.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Pais"
        x.Text = "Catalago de Paises"
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub btnIdentificacion_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnIdentificacion.ItemClick
        Dim x As New FrmCat_General
        x.Llamadatos = "Identificaciones"
        x.Text = "Catalago Tipo Identificaciones"
        x.MdiParent = Me
        x.Show()
    End Sub
End Class
