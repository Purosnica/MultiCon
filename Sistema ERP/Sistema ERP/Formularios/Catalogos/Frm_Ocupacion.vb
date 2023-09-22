Public Class Frm_Ocupacion
    Public Tipo As Integer
    Public Codigo As String
    Private Sub Frm_Ocupacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = 1 Then
            txtdescri.EditValue = conect1.ConsulSql("Select Descripcion from Tbl_Ocupacion where IdOcupacion = '" & Codigo & "'")
        End If
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Tipo = 1 Then
            If txtauto.EditValue = Nothing Then
                MsgBox("Debe Llenar los Campos Requeridos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If conect1.EjecutaSQL("Update Tbl_Ocupacion Descripcion ='" & txtdescri.EditValue.ToString.ToUpper.Trim & "' where IdOcupacion = '" & Codigo & "'") = True Then
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
                If conect1.EjecutaSQL("Insert into Tbl_Ocupacion (Descripcion,Estado)values('" & txtdescri.EditValue.ToString.ToUpper.Trim & "',1)") = True Then
                    MsgBox("Registro Adicionado Exitosamente", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Hubo un error al Editar el registro", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If
    End Sub
End Class