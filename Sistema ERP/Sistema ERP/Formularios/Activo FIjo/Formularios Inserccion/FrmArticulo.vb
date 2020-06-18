Public Class FrmArticulo
    Dim conect As New Conexion
    Dim dt As DataTable
    Private Sub FrmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect.CargaCombo(cmbubicacion, "Descripcion", "Cod_Ubicacion", "select Cod_Ubicacion,Descripcion from Tbl_Ubicacion", dt)
        conect.CargaCombo(cmbarea, "Descripcion", "Cod_Area", "select Cod_Area,Descripcion from Tbl_Areas", dt)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtcodart.EditValue = Nothing Or txtdescri.EditValue = Nothing Or txtmarca.EditValue = Nothing Or txtmodelo.EditValue = Nothing Or txtserie.EditValue = Nothing Then
            MsgBox("Debe de Complementar los campos", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Dim contador As String = 0
            contador = conect.ConsulSql("Select isnull(max(id_articulo),0)+1 from Tbl_Articulos")
            conect.EjecutaSQL("Insert Into Tbl_Articulos(Id_Articulo, Cod_Activo, Descripcion, Marca, Modelo, Serie, Dimensiones, Asignado, Cod_Area, Cod_Ubicacion_F, Estado, Fecha)values('" & contador & "','" & txtcodart.EditValue.ToString.Trim & "','" & txtdescri.EditValue.ToString.Trim & "','" & txtmarca.EditValue.ToString.Trim & "','" & txtmodelo.EditValue.ToString.Trim & "','" & txtserie.EditValue.ToString.Trim & "','" & txtdimensiones.EditValue.ToString.Trim & "' ,'" & cmbempleado.EditValue & "','" & cmbarea.EditValue & "','" & cmbubicacion.EditValue & "',getdate() )")
            MsgBox("Registrado Exitosamente", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class