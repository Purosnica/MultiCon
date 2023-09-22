Imports DATOS

Public Class Frm_Cliente
    Public Llamadatos As String
    Public Tipo As Integer
    Public codigo As String
    Private _ftHelper As FunctionHelper = New FunctionHelper
    Private _Entities As New SYSERPEntities()

    Dim dtTipoPersona, dtPais, dtTipoIdentificacion As DataTable

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Client As New Tbl_Clientes

        If Validate() = False Then

            MsgBox("Favor complete los campos", MsgBoxStyle.Information)
        Else

            If conect1.EjecutaSQL("INSERT INTO [dbo].[Tbl_Clientes]([Nombre],[Apellidos],[FechaNacimiento],[IdTipoIdentificacion] ,[Cedula],[IdTipoPersona],[IdPais],[Correo],[Telefono_Casa],[Telefono_Celular],[Estado],[FechaRegistro])VALUES ('" & txtNombres.EditValue & "','" & txtApellidos.EditValue & "','" & Format(CDate(FechaCumple.EditValue), "yyyy-MM-dd HH:mm:ss") & "'," & CmbTipoidentificacion.EditValue & ",'" & txtIdentificacion.EditValue & "'," & cmbtipopersona.EditValue & "," & cmbPais.EditValue & ",'" & txtCorreo.EditValue & "'," & txtTelefono.EditValue & "," & txtCelular.EditValue & ",1,getdate())") = True Then

                MsgBox("Registro Guardo Exitosamente", MsgBoxStyle.Information)
                Me.Close()

            Else
                MsgBox("Hubo un Error al Registrar ", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub Frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub cmbtipopersona_EditValueChanged(sender As Object, e As EventArgs) Handles cmbtipopersona.EditValueChanged
        If cmbtipopersona.ItemIndex <> 0 Then
            Label2.Visible = False
            txtApellidos.Visible = False
        Else
            Label2.Visible = True
            txtApellidos.Visible = True
        End If


    End Sub

    Private Sub txtCorreo_Leave(sender As Object, e As EventArgs) Handles txtCorreo.Leave
        Dim temp As String
        temp = txtCorreo.EditValue

        If _ftHelper.emailaddresscheck(temp) = False Then
            MessageBox.Show("Ingrese un correo valido", "Correo Incorrecto")

        End If
    End Sub

    Private Sub LoadData()

        conect1.CargaCombo(CmbTipoidentificacion, "Descripcion", "IdTipoIdentificacion", "Select IdTipoIdentificacion,Descripcion from dbo.Tbl_TipoIdentificacion where Estado=1", dtTipoIdentificacion)
        conect1.CargaCombo(cmbtipopersona, "Descripcion", "IdTipoPersona", "Select IdTipoPersona,Descripcion from dbo.Tbl_TipoPersona where Estado=1", dtTipoPersona)
        conect1.CargaCombo(cmbPais, "Descripcion", "IdPais", " Select IdPais,Descripcion from dbo.Tbl_Pais where Estado=1", dtPais)
        cmbPais.ItemIndex = 0
        CmbTipoidentificacion.ItemIndex = 0
        cmbtipopersona.ItemIndex = 0
        FechaCumple.EditValue = Date.Now

    End Sub

    Private Overloads Function Validate() As Boolean
        Dim _ReturnValidate As Boolean = True

        If txtNombres.EditValue = "" Or txtIdentificacion.EditValue = "" Or txtCorreo.EditValue = "" Then
            _ReturnValidate = False
        End If

        Return _ReturnValidate

    End Function

End Class