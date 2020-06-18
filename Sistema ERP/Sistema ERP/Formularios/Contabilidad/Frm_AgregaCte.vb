Public Class Frm_AgregaCte
    Public Tipo As Integer
    Public Codigo As Integer
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Tipo = 1 Then

            conect1.EjecutaSQL("Insert into Tbl_CTComprobantes (Descripcion,Siglas,Fecha_Creacion,Us_Crea)values('" & txtdescri.EditValue.ToString.ToUpper.Trim & "','" & txtabrevia.EditValue.ToString.ToUpper.Trim & "',getdate(), " + IdUsu + " )")
            MsgBox("Tipo de Comprobante Registrado", MsgBoxStyle.Information)
            Me.Close()
        Else
            conect1.EjecutaSQL("Update Tbl_CTComprobantes set Descripcion ='" & txtdescri.EditValue.ToString.ToUpper.Trim & "',Siglas ='" & txtabrevia.EditValue.ToString.ToUpper.Trim & "' where Cod_Comprobante ='" & Codigo & "'")
            MsgBox("Tipo de Comprobante Registrado", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub Frm_AgregaCte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class