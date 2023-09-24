Public Class Frm_Segmento
    Public Tipo As Integer
    Public Codigo As String
    Dim dtTipoPersona, dtOcupacion As DataTable
    Private Sub Frm_Segmento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect1.CargaCombo(cmbtipopersona, "Descripcion", "IdTipoPersona", "Select IdTipoPersona,Descripcion from dbo.Tbl_TipoPersona where Estado=1", dtTipoPersona)
        conect1.CargaCombo(cmbOcupacion, "Descripcion", "IdOcupacion", "Select IdOcupacion,Descripcion from dbo.Tbl_Ocupacion where Estado=1", dtOcupacion)

        cmbOcupacion.ItemIndex = 0
        cmbtipopersona.ItemIndex = 0

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Tipo = 1 Then
            If txtauto.EditValue = Nothing Then
                MsgBox("Debe Llenar los Campos Requeridos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If conect1.EjecutaSQL("Update Tbl_Segmento SET IdTipoPersona = " & cmbtipopersona.EditValue & ",IdOcupacion=" & cmbOcupacion.EditValue & " ,Descripcion ='" & txtdescri.EditValue.ToString.ToUpper.Trim & "' where IdSegmento = '" & Codigo & "'") = True Then
                    MsgBox("Registro Editado Exitosamente", MsgBoxStyle.Information)
                    Me.Close()
                Else

                    MsgBox("Hubo un error al Editar el registro", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Else

            If txtauto.EditValue = Nothing Then
                MsgBox("Debe Llenar los Campos Requeridos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If conect1.EjecutaSQL("Insert into Tbl_Segmento (IdTipoPersona,IdOcupacion,Descripcion,Estado)values(" & cmbtipopersona.EditValue & "," & cmbOcupacion.EditValue & ",'" & txtdescri.EditValue.ToString.ToUpper.Trim & "',1)") = True Then
                    MsgBox("Registro Adicionado Exitosamente", MsgBoxStyle.Information)

                    Me.Close()
                Else
                    MsgBox("Hubo un error al Editar el registro", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
End Class