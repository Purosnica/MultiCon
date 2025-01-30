Public Class Frm_CreaSolAdq
    Private Sub Frm_CreaSolAdq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        creargrid()
        conect1.CargaCombo(cmbsolicitante, "Nombres", "cod_empleado", "select cod_empleado , Nombres from Tbl_Solicitante order by Nombres", dt)
        conect1.CargaCombo(cmbdeptodes, "Descripcion", "cod_Departamento", "select cod_Departamento , Descripcion from Tbl_Departamento order by cod_departamento", dt)
    End Sub
    Private Sub AgregaGrid()
        Dim row As DataRow
        row = Producto.NewRow()
        row("N°") = gvsolicitud.RowCount + 1
        row("Codigo") = txtcodigo.EditValue
        row("Descripcion") = txtdescicod.EditValue.ToString.Trim
        row("Medida") = txtmedida.EditValue.ToString.Trim
        row("Cantidad") = txtcantidad.EditValue
        Producto.Rows.Add(row)
        Producto.AcceptChanges()
        grdsolicitud.DataSource = Producto
    End Sub
    Private Sub creargrid()
        Producto.Columns.Clear()
        Producto.Columns.Add("N°")
        Producto.Columns.Add("Codigo")
        Producto.Columns.Add("Descripcion")
        Producto.Columns.Add("Medida")
        Producto.Columns.Add("Cantidad")
    End Sub
    Private Sub txtcantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles txtcantidad.MouseClick
        If txtcantidad.SelectionLength = 0 Then
            txtcantidad.SelectAll()
        Else
            txtcantidad.Focus()
        End If
    End Sub
    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If (Char.IsNumber(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(46) _
                                     Or e.KeyChar = Microsoft.VisualBasic.ChrW(127) _
                                     Or e.KeyChar = Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = False
        Else
            e.Handled = True
            AgregaGrid() : txtcantidad.EditValue = CStr("0")
            txtcodigo.EditValue = CStr("") : txtdescicod.EditValue = CStr("") : txtmedida.EditValue = CStr("")
        End If
    End Sub
    Private Sub cmbsolicitante_EditValueChanged(sender As Object, e As EventArgs) Handles cmbsolicitante.EditValueChanged
        conect1.Recolecta_Datos2("Tbl_Solicitante", "cod_empleado", cmbsolicitante.EditValue)
        txtcargo.EditValue = Column4
        txtdepto.EditValue = conect1.ConsulSql("Select Descripcion from Tbl_Departamento where Cod_Departamento = '" & Column3 & "'")
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim x As New FrmCat_General
        x.Llamadatos = "Producto"
        x.ShowDialog()
        txtcodigo.EditValue = codProduto : txtdescicod.EditValue = NombreProducto : txtmedida.EditValue = UM
    End Sub
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class