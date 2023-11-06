Public Class Frm_Profesiones
    Public Tipo As Integer
    Public Codigo As String
    Dim dtOcupacion As DataTable

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()

    End Sub

    Private Sub Frm_Profesiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect1.CargaCombo(cmbOcupacion, "Descripcion", "IdOcupacion", "Select IdOcupacion,Descripcion from [dbo].[Tbl_Ocupacion] where Estado =1", dtOcupacion)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Tipo = 1 Then
            If txtauto.EditValue = Nothing Then
                MsgBox("Debe Llenar los Campos Requeridos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If conect1.EjecutaSQL("Update Tbl_Profesion set Descripcion ='" & txtdescri.EditValue.ToString.ToUpper.Trim & "', IdOcupacion = '" & cmbOcupacion.EditValue & "'  where IdProfesion = '" & Codigo & "'") = True Then
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
                If conect1.EjecutaSQL("Insert into Tbl_Profesion (IdOcupacion,Descripcion,Estado)values('" & cmbOcupacion.EditValue & "','" & txtdescri.EditValue.ToString.ToUpper.Trim & "',1)") = True Then
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