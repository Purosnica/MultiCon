Public Class Frm_Departamento
    Public Tipo As Integer
    Public Codigo As String

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Tipo = 1 Then
            If txtauto.EditValue = Nothing Then
                MsgBox("Debe Llenar los Campos Requeridos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                conect1.EjecutaSQL("Update Tbl_Departamento Descripcion ='" & txtdescri.EditValue.ToString.ToUpper.Trim & "' where Cod_Departamento = '" & Codigo & "'")
                MsgBox("Registro Editado Exitosamente", MsgBoxStyle.Information)
                Me.Close()
            End If

        Else

            If txtauto.EditValue = Nothing Then
                MsgBox("Debe Llenar los Campos Requeridos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Contador = conect1.ConsulSql("Select isnull(max(Cod_Departamento),0)+1 from Tbl_Departamento")
                conect1.EjecutaSQL("Insert into Tbl_Departamento (Cod_Departamento,Descripcion,Fecha_Crea)values('" & Contador & "','" & txtdescri.EditValue.ToString.ToUpper.Trim & "',getdate())")
                MsgBox("Registro Adicionado Exitosamente", MsgBoxStyle.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Frm_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = 1 Then
            txtdescri.EditValue = conect1.ConsulSql("Select Descripcion from Tbl_Departamento where cod_departamento = '" & Codigo & "'")
        End If
    End Sub
End Class