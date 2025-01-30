Public Class FrmIdentificaciones
    Private _funct As New FunctionHelper()
    Public Tipo As Integer
    Public Codigo As String
    Private oDataTable1 As DataTable
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtdescri.EditValue = "" Then
            MsgBox("Favor Completar los Campos", MsgBoxStyle.Exclamation)
        Else

            If Tipo = 1 Then

                If conect1.EjecutaSQL("Update Tbl_TipoIdentificacion set Descripcion = '" & txtdescri.EditValue.ToString.ToUpper.Trim & "'  where IdTipoIdentificacion ='" & Codigo & "'") = True Then

                    MsgBox("Registro Editado Existosamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error al Editar el Registro", MsgBoxStyle.Critical)

                End If

            Else
                Dim _SQl As String
                _SQl = _funct.CadenaInsert("Tbl_TipoIdentificacion", 1) & "Descripcion,Estado ) values ('" + txtdescri.EditValue + "',1) "
                If conect1.EjecutaSQL(_SQl) = True Then
                    MsgBox("Registro Guardado Existosamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error al Guardar el Registro", MsgBoxStyle.Critical)

                End If


            End If
        End If
    End Sub

    Private Sub FrmIdentificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = 1 Then
            Me.oDataTable1 = conect1.Return_Datetable("Tbl_TipoIdentificacion", "IdTipoIdentificacion", Codigo)

            For Each rows In oDataTable1.Rows
                txtauto.EditValue = rows(0)
                txtdescri.EditValue = rows(1)

            Next


        End If
    End Sub
End Class