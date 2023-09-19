Public Class FrmPais
    Private _funct As New FunctionHelper()
    Public Tipo As Integer
    Public Codigo As String
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtCod.EditValue = "" Or txtdescri.EditValue = "" Then
            MsgBox("Favor Completar los Campos", MsgBoxStyle.Exclamation)
        Else

            If Tipo = 1 Then

                If conect1.EjecutaSQL("Update Tbl_Medidas set Descripcion = '" & txtdescri.EditValue.ToString.ToUpper.Trim & "' ,CodPais= '" & txtCod.EditValue.ToString.ToUpper.Trim & "' where CodPais ='" & Codigo & "'") = True Then

                    MsgBox("Registro Editado Existosamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error al Editar el Registro", MsgBoxStyle.Critical)

                End If

            Else
                    Dim _SQl As String
                _SQl = _funct.CadenaInsert("Tbl_Pais", 1) & " CodPais,Descripcion,Estado ) values (" + txtCod.EditValue + "," + txtdescri.EditValue + ",1) "
                If conect1.EjecutaSQL(_SQl) = True Then
                    MsgBox("Registro Guardado Existosamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error al Guardar el Registro", MsgBoxStyle.Critical)

                End If

            End If

        End If
    End Sub

    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class