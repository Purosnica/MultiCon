Public Class FrmUbicacion
    Public Tipo, Codigo As String
    Public Edita As Integer
    Dim conect As New Conexion
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim contador As String
        If Edita = 1 Then
            Select Case Tipo
                Case "Area"
                    conect.EjecutaSQL("Update Tbl_Areas set Descripcion = '" & TextEdit2.EditValue & "' where Cod_Area ='" & Codigo & "' ")
                    MsgBox("Editado Exitosamente", MsgBoxStyle.Information)
                    Me.Close()

                Case "Ubicacion"
                    conect.EjecutaSQL("Update Tbl_Ubicacion set Descripcion = '" & TextEdit2.EditValue & "' where Cod_Ubicacion ='" & Codigo & "' ")
                    MsgBox("Editado Exitosamente", MsgBoxStyle.Information)
                    Me.Close()
            End Select
        Else

            Select Case Tipo
                Case "Area"
                    contador = conect.ConsulSql("Select isnull(max(Cod_Area),0)+1 from Tbl_Areas ")
                    contador = conect.FXSTRZERO(contador, 2)
                    conect.EjecutaSQL("Insert into Tbl_Areas (Cod_Area,Descripcion,DFecha)values('" & contador & "','" & TextEdit2.EditValue & "',getdate()) ")
                    MsgBox("Registrado Exitosamente", MsgBoxStyle.Information)
                    Me.Close()

                Case "Ubicacion"
                    contador = conect.ConsulSql("Select isnull(max(Cod_Ubicacion),0)+1 from Tbl_Ubicacion ")
                    contador = conect.FXSTRZERO(contador, 2)
                    conect.EjecutaSQL("Insert into Tbl_Ubicacion (Cod_Ubicacion,Descripcion,DFecha)values('" & contador & "','" & TextEdit2.EditValue & "',getdate()) ")
                    MsgBox("Registrado Exitosamente", MsgBoxStyle.Information)
                    Me.Close()

            End Select
        End If
    End Sub
End Class