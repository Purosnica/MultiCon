Public Class FrmCat_General
    Public Llamadatos As String
    Dim conect As New Conexion
    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Select Case Llamadatos
            Case "Proveedor"
                Dim x As New Frm_Proveedor
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_proveedor ", "Tbl_Proveedor", "")
                gvproveedor.BestFitColumns()
            Case "Medida"
                Dim x As New Frm_UM
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Medidas ", "Tbl_Medidas", "")
                gvproveedor.BestFitColumns()
            Case "Producto"
                Dim x As New Frm_Producto
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from V_Producto ", "V_Producto", "")
                gvproveedor.BestFitColumns()
            Case "Servicio"
                Dim x As New Frm_Servicios
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Servicios ", "Tbl_Servicios", "")
                gvproveedor.BestFitColumns()
            Case "Departamento"
                Dim x As New Frm_Departamento
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Departamento ", "Tbl_Departamento", "")
                gvproveedor.BestFitColumns()
            Case "Tasa"
                Dim x As New Frm_AgreTC
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Tasacambio ", "Tbl_Tasacambio", "")
                gvproveedor.BestFitColumns()
                btnEdita.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Case "Pais"
                Dim x As New FrmPais
                x.ShowDialog()
            Case "Cliente"
                Dim x As New Frm_Cliente
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select CodPais,Descripcion from Tbl_Pais where Estado=1", "Tbl_Pais", "")
                gvproveedor.BestFitColumns()
                conect.CargaGrid(gridproveedor, "Select * from V_Clientes order by IdCliente desc", "V_Clientes", "")
                gvproveedor.BestFitColumns()
            Case "Identificaciones"
                Dim x As New FrmIdentificaciones
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select IdTipoIdentificacion Codigo,Descripcion from Tbl_TipoIdentificacion where Estado=1", "Tbl_TipoIdentificacion", "")
                gvproveedor.BestFitColumns()
            Case "Ocupacion"
                Dim x As New Frm_Ocupacion
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select IdOcupacion,Descripcion from Tbl_Ocupacion where Estado=1", "Tbl_Ocupacion", "")
                gvproveedor.BestFitColumns()
            Case "Segmento"
                Dim x As New Frm_Segmento
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from V_Segmento", "V_Segmento", "")
                gvproveedor.BestFitColumns()
            Case "campana"
                Dim x As New Frm_Campañas
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select IdOcupacion,Descripcion from Tbl_Ocupacion where Estado=1", "Tbl_Ocupacion", "")
                gvproveedor.BestFitColumns()

            Case "Profesiones"
                Dim x As New Frm_Profesiones
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select IdProfesion,Descripcion from V_Profesiones", "V_Profesiones", "")
                gvproveedor.BestFitColumns()
        End Select
    End Sub

    Private Sub FrmCat_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Llamadatos
            Case "Proveedor"
                conect.CargaGrid(gridproveedor, "Select * from Tbl_proveedor ", "Tbl_Proveedor", "")
                gvproveedor.BestFitColumns()
            Case "Medida"
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Medidas ", "Tbl_Medidas", "")
                gvproveedor.BestFitColumns()
            Case "Producto"
                conect.CargaGrid(gridproveedor, "Select * from V_Producto ", "V_Producto", "")
                gvproveedor.BestFitColumns()
            Case "Servicio"
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Servicios ", "Tbl_Servicios", "")
                gvproveedor.BestFitColumns()
            Case "Departamento"
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Departamento ", "Tbl_Departamento", "")
                gvproveedor.BestFitColumns()
            Case "Tasa"
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Tasacambio ", "Tbl_Tasacambio", "")
                gvproveedor.BestFitColumns()
                btnEdita.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Case "Pais"
                conect.CargaGrid(gridproveedor, "Select CodPais,Descripcion from Tbl_Pais where Estado=1", "Tbl_Pais", "")
                gvproveedor.BestFitColumns()
            Case "Cliente"
                conect.CargaGrid(gridproveedor, "Select * from V_Clientes order by IdCliente desc", "V_Clientes", "")
                gvproveedor.BestFitColumns()
            Case "Identificaciones"
                conect.CargaGrid(gridproveedor, "Select IdTipoIdentificacion Codigo,Descripcion from Tbl_TipoIdentificacion where Estado=1", "Tbl_TipoIdentificacion", "")
                gvproveedor.BestFitColumns()
            Case "Ocupacion"
                conect.CargaGrid(gridproveedor, "Select IdOcupacion,Descripcion from Tbl_Ocupacion where Estado=1", "Tbl_Ocupacion", "")
                gvproveedor.BestFitColumns()

            Case "Segmento"
                conect.CargaGrid(gridproveedor, "Select * from V_Segmento", "V_Segmento", "")
                gvproveedor.BestFitColumns()
            Case "campana"
                conect.CargaGrid(gridproveedor, "Select IdOcupacion,Descripcion from Tbl_Ocupacion where Estado=1", "Tbl_Ocupacion", "")
                gvproveedor.BestFitColumns()
            Case "Profesiones"
                conect.CargaGrid(gridproveedor, "Select IdProfesion,Descripcion from V_Profesiones", "V_Profesiones", "")
                gvproveedor.BestFitColumns()

        End Select
    End Sub
    Private Sub btnEdita_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdita.ItemClick

        If gvproveedor.RowCount = 0 Then
            MsgBox("Debe existir al menos un Registro", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Select Case Llamadatos
            Case "Proveedor"
                Dim x As New Frm_Proveedor
                x.Tipo = 1
                    x.LCCODPVE = gvproveedor.GetFocusedRow(0)
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_proveedor ", "Tbl_Proveedor", "")
                gvproveedor.BestFitColumns()
            Case "Medida"
                Dim x As New Frm_UM
                x.Tipo = 1
                x.Codigo = gvproveedor.GetFocusedRow(0)
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Medidas ", "Tbl_Medidas", "")
                gvproveedor.BestFitColumns()
            Case "Producto"
                Dim x As New Frm_Producto
                x.Tipo = 1
                x.codigo = gvproveedor.GetFocusedRow(0)
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from V_Producto ", "V_Producto", "")
                gvproveedor.BestFitColumns()
            Case "Servicio"
                Dim x As New Frm_Servicios
                x.Tipo = 1
                x.btnGuardar.Text = "Editar Servicio"
                x.codigo = gvproveedor.GetFocusedRow(0)
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Servicios ", "Tbl_Servicios", "")
                gvproveedor.BestFitColumns()
            Case "Departamento"
                Dim x As New FrmPais
                x.Tipo = 1
                x.Codigo = gvproveedor.GetFocusedRow(0)
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Departamento ", "Tbl_Departamento", "")
                gvproveedor.BestFitColumns()
            Case "Pais"
                Dim x As New FrmPais
                x.Tipo = 1
                x.Codigo = gvproveedor.GetFocusedRow(0)
                x.btnGuardar.Text = "Editar"
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select CodPais,Descripcion from Tbl_Pais where Estado=1", "Tbl_Pais", "")
                gvproveedor.BestFitColumns()
            Case "Cliente"
                Dim x As New Frm_Cliente
                x.Tipo = 1
                x.codigo = gvproveedor.GetFocusedRow(0)
                x.btnGuardar.Text = "Editar"
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from V_Clientes", "V_Clientes", "")
                gvproveedor.BestFitColumns()
            Case "Ocupacion"
                Dim x As New Frm_Ocupacion
                x.Tipo = 1
                x.codigo = gvproveedor.GetFocusedRow(0)
                x.btnGuardar.Text = "Editar"
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Ocupacion where estado=1", "Tbl_Ocupacion", "")
                gvproveedor.BestFitColumns()

            Case "Segmento"
                Dim x As New Frm_Segmento
                x.Tipo = 1
                x.Codigo = gvproveedor.GetFocusedRow(0)
                x.btnGuardar.Text = "Editar"
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Ocupacion where estado=1", "Tbl_Ocupacion", "")
                gvproveedor.BestFitColumns()

            Case "campana"
                Dim x As New Frm_Campañas
                x.Tipo = 1
                x.Codigo = gvproveedor.GetFocusedRow(0)
                x.btnGuardar.Text = "Editar"
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select * from Tbl_Ocupacion where estado=1", "Tbl_Ocupacion", "")
                gvproveedor.BestFitColumns()

            Case "Profesiones"
                Dim x As New Frm_Profesiones
                x.Tipo = 1
                x.Codigo = gvproveedor.GetFocusedRow(0)
                x.btnGuardar.Text = "Editar"
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select IdProfesion,Descripcion from V_Profesiones", "V_Profesiones", "")
                gvproveedor.BestFitColumns()

            Case "Identificaciones"
                Dim x As New FrmIdentificaciones
                x.Tipo = 1
                x.Codigo = gvproveedor.GetFocusedRow(0)
                x.btnGuardar.Text = "Editar"
                x.ShowDialog()
                conect.CargaGrid(gridproveedor, "Select IdTipoIdentificacion Codigo,Descripcion from Tbl_TipoIdentificacion where Estado=1", "Tbl_TipoIdentificacion", "")
                gvproveedor.BestFitColumns()
        End Select
    End Sub

    Private Sub gvproveedor_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvproveedor.RowClick

        If Llamadatos = "Producto" Then
            codProduto = gvproveedor.GetFocusedRow(0).ToString.Trim
            NombreProducto = gvproveedor.GetFocusedRow(2).ToString.Trim
            UM = gvproveedor.GetFocusedRow(3).ToString.Trim
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class