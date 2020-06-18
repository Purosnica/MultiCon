Public Class Frm_Solicitante
    Dim dt As New DataTable
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtcod.EditValue = Nothing Or txtdescri.EditValue = Nothing Or txtcargo.EditValue = Nothing Then

            MsgBox("Favor Completar los Campos", MsgBoxStyle.Critical)
        Else

            conect1.EjecutaSQL("insert into Tbl_Solicitante (Cod_empleado, Nombres, Cod_Departamento, Cargo)values('" & txtcod.EditValue & "','" & txtdescri.EditValue & "','" & cmbdepartamento.EditValue & "','" & txtcargo.EditValue & "')")
            MsgBox("Solicitante Adicionado Exitosamente", MsgBoxStyle.Information)
            Me.Close()

        End If
    End Sub

    Private Sub Frm_Solicitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect1.CargaCombo(cmbdepartamento, "Descripcion", "Cod_Departamento", "Select Cod_Departamento,Descripcion from Tbl_Departamento", dt)
        cmbdepartamento.ItemIndex = 0
    End Sub
End Class