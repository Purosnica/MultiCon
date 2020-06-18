Public Class Frm_Servicios
    Public Tipo As Integer
    Public Codigo As String
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()

    End Sub

    Private Sub Frm_Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = 1 Then

            btnGuardar.Text = "Editar"
        End If


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Tipo = 1 Then
            If txtdescri.EditValue = Nothing Then
                MsgBox("Llene todo los Campos Requeridos", MsgBoxStyle.Critical)
            Else
                conect1.EjecutaSQL("Update Tbl_Servicios set Descripcion = '" & txtdescri.EditValue & "' where cod_servicio ='" & Codigo & "'")
                MsgBox("Editado exitosamente", MsgBoxStyle.Information)
                Me.Close()
            End If
        Else


            If txtdescri.EditValue = Nothing Then
                MsgBox("Llene todo los Campos Requeridos", MsgBoxStyle.Critical)
            Else
                Contador = conect1.ConsulSql("Select isnull(max(Cod_Servicio),0) + 1  from Tbl_Servicios")
                Contador = conect1.FXSTRZERO(Contador, 3)
                conect1.EjecutaSQL("Insert into Tbl_Servicios (Cod_Servicio,Descripcion,Fecha_Crea,Uscrea)values('" & Contador & "','" & txtdescri.EditValue & "',getdate(),'" & IdUsu & "')")
                MsgBox("Registro Adicionado exitosamente", MsgBoxStyle.Information)
                Me.Close()

            End If
        End If
    End Sub
End Class