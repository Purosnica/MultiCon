Public Class Frm_Producto
    Public Tipo As Integer
    Public codigo As String
    Dim dtunidad As DataTable
    Private Sub Frm_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect1.CargaCombo(cmbunidad, "Descripcion", "Cod_Medida", "Select Cod_Medida,Descripcion from Tbl_Medidas", dtunidad)
        cmbunidad.ItemIndex = 0
        If Tipo = 1 Then
            conect1.Recolecta_Datos2("Tbl_Producto", "Cod_Producto", codigo)
            txtdescri.EditValue = Column2
            txtdescriL.EditValue = Column3
            cmbunidad.EditValue = Column4
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Tipo = 1 Then
            If txtdescri.EditValue = Nothing Or txtdescriL.EditValue = Nothing Then
                MsgBox("Llene la Campos ", MsgBoxStyle.Critical)
                Exit Sub
            Else
                conect1.EjecutaSQL("Update Tbl_Producto set ,Descripcion= '" & txtdescri.EditValue.ToString.ToUpper.Trim & "',Descripcion_L='" & txtdescriL.EditValue.ToString.ToUpper.Trim & "',Cod_UM='" & cmbunidad.EditValue & "' where Cod_Producto ='" & codigo & "' ")
                MsgBox("Producto Editado Exitosamente", MsgBoxStyle.Information)
                Me.Close()
            End If
        Else

            If txtdescri.EditValue = Nothing Or txtdescriL.EditValue = Nothing Then
                MsgBox("Llene la Campos ", MsgBoxStyle.Critical)
                Exit Sub
            Else

                Contador = conect1.ConsulSql("Select isnull(max(Cod_Producto),0)+1 from Tbl_Producto")
                Contador = conect1.FXSTRZERO(Contador, 6)
                conect1.EjecutaSQL("Insert into Tbl_Producto (Cod_Producto,Descripcion,Descripcion_L,Cod_UM,Uscrea,Fecha_crea)values('" & Contador & "','" & txtdescri.EditValue.ToString.ToUpper.Trim & "','" & txtdescriL.EditValue.ToString.ToUpper.Trim & "','" & cmbunidad.EditValue & "','" & IdUsu & "',GETDATE()) ")
                MsgBox("Producto Adicionado Exitosamente", MsgBoxStyle.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
End Class