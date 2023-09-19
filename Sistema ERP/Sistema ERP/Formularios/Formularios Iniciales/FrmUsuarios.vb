Public Class FrmUsuarios

    Dim conect As New Conexion
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim cadena As String = UCase(TextEdit2.EditValue)
        Dim pass As String

        If TextEdit1.EditValue = Nothing Or TextEdit2.EditValue = Nothing Then
            MsgBox("Debe de Asignar un Usuario o Contraseña", MsgBoxStyle.Critical)
            Exit Sub
            TextEdit1.Focus()

        Else
            pass = ""
            For i = 1 To Len(TextEdit2.EditValue)
                pass = pass & "0" & Asc(Mid(cadena, i, 1))
            Next i

            conect.EjecutaSQL("Insert into Tbl_Usuario(Usuario,Pass,Correo)values('" & TextEdit1.EditValue & "','" & pass & "','" & TextEdit3.EditValue & "')")
            MsgBox("Nuevo Usuario Adicionado", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class