Public Class Frm_UM
    Public Tipo As Integer
    Public Codigo As String
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Tipo = 1 Then
            If txtdescri.EditValue = Nothing Or txtabrevia.EditValue = Nothing Then
                MsgBox("Debe de LLenar los Campos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                conect1.EjecutaSQL("Update Tbl_Medidas set Descripcion = '" & txtdescri.EditValue.ToString.ToUpper.Trim & "' ,Abreviatura= '" & txtabrevia.EditValue.ToString.ToUpper.Trim & "' where Cod_Medida ='" & Codigo & "'")
                MsgBox("Unidad de Medida Editada", MsgBoxStyle.Information)
            End If

        Else
            If txtdescri.EditValue = Nothing Or txtabrevia.EditValue = Nothing Then
                MsgBox("Debe de LLenar los Campos", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Dim Contador As String = conect1.ConsulSql("Select max(Cod_Medida)+1 from Tbl_Medida")
                Contador = conect1.FXSTRZERO(Contador, 3)
                conect1.EjecutaSQL("Insert into Tbl_Medidas (Cod_Medida,Descripcion,Abreviatura,Estado)values('" & Contador & "','" & txtdescri.EditValue.ToString.ToUpper.Trim & "','" & txtabrevia.EditValue.ToString.ToUpper.Trim & "','A')")
                MsgBox("Unidad de Medida Registrada", MsgBoxStyle.Information)

            End If
        End If
    End Sub
    Private Sub Frm_UM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = 1 Then
            btnGuardar.Text = "Editar"
            conect1.Recolecta_Datos2("Tbl_Medidas", "Cod_Medida", Codigo)
            txtabrevia.EditValue = Column2
            txtdescri.EditValue = Column3
        End If
    End Sub
End Class