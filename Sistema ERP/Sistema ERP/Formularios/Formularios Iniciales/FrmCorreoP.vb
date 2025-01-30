Public Class FrmCorreoP
    Dim conect As New Conexion
    Private _Tbl_Remitente, _dtRem As DataTable
    Private _ftHelper As New FunctionHelper
    Private Sub FrmCorreoP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If Validates() = True Then

            Dim _SQl As String = ""
            _SQl = _ftHelper.CadenaInsert("Tbl_Remitente", 1)
            _SQl += "CorreoRemitente,Pass,Host,Port,FechaCreacion,Estado,UsuarioCrea) values ('" & txtCorreo.EditValue & "','" & txtpass.Text & "' ,'" & txtHost.EditValue & "','" & CInt(txtport.EditValue) & "' ,getdate(),1,'" & IdUsu & "')"

            If (conect1.EjecutaSQL(_SQl) = True) Then
                MsgBox("Registro Guardado Exitosamente ", MsgBoxStyle.Information)
                LoadData()
            Else
                MsgBox("Hubo un error al guardar ", MsgBoxStyle.Critical)
            End If
        Else

            MsgBox("Favor Complete los Campos", MsgBoxStyle.Critical)
            Exit Sub

        End If

    End Sub

    Private Sub gvcorreo_DoubleClick(sender As Object, e As EventArgs) Handles gvcorreo.DoubleClick
        Me._dtRem = conect1.Return_Datetable("Tbl_Remitente", "IdRemitente", gvcorreo.GetFocusedRow(0))

        For Each rows In _dtRem.Rows
            txtCorreo.EditValue = rows(1) : txtpass.Text = rows(2)
            txtHost.EditValue = rows(3) : txtport.EditValue = rows(4) : ckestado.EditValue = rows(5)

        Next
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If Validates() = True Then

            Dim _SQl As String = ""
            _SQl = _ftHelper.CadenaInsert("Tbl_Remitente", 4)
            _SQl += "CorreoRemitente = '" & txtCorreo.EditValue & "' ,Pass='" & txtpass.Text & "',Host='" & txtHost.EditValue & "',Port='" & CInt(txtport.EditValue) & "',FechaModificacion=getdate(),Estado where IdRemitente =" + CInt(gvcorreo.GetFocusedRow(0)) + " "

            If (conect1.EjecutaSQL(_SQl) = True) Then
                MsgBox("Registro Guardado Exitosamente ", MsgBoxStyle.Information)
                LoadData()
            Else
                MsgBox("Hubo un error al guardar ", MsgBoxStyle.Critical)
            End If

        Else
            MsgBox("Favor Complete los Campos", MsgBoxStyle.Critical)
            Exit Sub

        End If

    End Sub

    Private Function Validates() As Boolean
        Dim _Result As Boolean = True

        If txtCorreo.EditValue = "" Or txtpass.Text = "" Or
            txtHost.EditValue = "" Then
            _Result = False
        End If
        Return _Result
    End Function

    Private Sub LoadData()

        conect.CargaGrid(GrdCorreo, "Select IdRemitente,CorreoRemitente ,Host,Port,Pass from [dbo].[Tbl_Remitente] where Estado =1", "_Tbl_Remitente", "")
        gvcorreo.Columns(4).Visible = False
        gvcorreo.BestFitColumns()
    End Sub
End Class