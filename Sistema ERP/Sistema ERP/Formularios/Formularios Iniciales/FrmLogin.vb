Imports System.Data.SqlClient

Public Class FrmLogin

    Dim conect1 As New Conexion
    Public salida As String


    Private Function Descriptar(ByVal x As String)

        For i = 1 To Len(x)
            salida = salida & "0" & Asc(Mid(UCase(x), i, 1))
        Next i
        Return salida

    End Function

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtusuario.Text = Nothing And txtpass.Text = Nothing Then
            MsgBox("Ingrese su usuario y contrase;a", MsgBoxResult.Retry)
        Else

            Dim command As New SqlCommand("select * from Tbl_Usuario where Usuario = @username and Pass = @password", conect1.cn)
            Descriptar(txtpass.Text)

            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusuario.Text
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = salida
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MsgBox("Escriba bien su usuario y contraseña", MsgBoxStyle.Critical)
                txtusuario.Text = Nothing
                txtpass.Text = Nothing
                txtusuario.Focus()

            Else
                Me.Hide()
                IdUsu = txtusuario.Text
                FrmPrincipal.Show()
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        End
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelItem1_Click(sender As Object, e As EventArgs) Handles LabelItem1.Click

    End Sub
End Class