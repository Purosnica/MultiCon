Public Class Frm_Proveedor
    Public Tipo As Integer
    Public LCCODPVE As String
    Private LCNOMBRE, LCRAZON, LCDIRECC, LCCIUDAD, LCTELEFO As String, ITIPPVE As Integer
    Private Sub Frm_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = 1 Then
            conect.Recolecta_Datos("Tbl_Proveedor", "CCODPVE", LCCODPVE)
            TBRAZON.Text = Column2 : TBNOMBRE.Text = Column3 : TBDIRECC.Text = Column4 : TBCIUDAD.Text = Column5
            TBTELEFO.Text = Column6 : TBCONTAC.Text = Column7 : TBCARGO.Text = Column8 : TBNUMRUC.Text = Column10
            TBNUMRUC.Enabled = False
        End If
    End Sub
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
    Private LCCONTAC, LCCARGO, LCREFERE, LCMAIL, LCESTADO, LCNUMRUC, LCCUENTA As String
    Private LIEXENTO_IR, LIEXENTO_ALMA As Integer
    Dim conect As New Conexion
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Tipo = 1 Then
            validacion()
            conect.EjecutaSQL("Update Tbl_Proveedor CRAZON =  '" & Me.LCRAZON & "',CNOMBRE = '" & Me.LCNOMBRE & "', CDIRECC = '" & Me.LCDIRECC & "', CCIUDAD ='" & Me.LCCIUDAD & "' , CTELEFO ='" & Me.LCTELEFO & "', CCONTAC ='" & Me.LCCONTAC & "' WHERE  CCODPVE = '" & LCCODPVE & "'  ")
            MsgBox("Registro Editado Exitosamemte ", MsgBoxStyle.Information)

            Me.Close()
        Else
            Dim LINUMERO As Integer
            validacion()
            LINUMERO = conect.ConsulSql("SELECT isnull(MAX(CCODPVE),0)+1  FROM Tbl_Proveedor")
            LCCODPVE = conect.FXSTRZERO(LINUMERO, 5)
            conect.EjecutaSQL("INSERT INTO Tbl_Proveedor ( CCODPVE, CRAZON,CNOMBRE, CDIRECC, CCIUDAD, CTELEFO, CCONTAC,CCARGO, CREFERE, CMAIL,CESTADO,CNUMRUC,ITIPPVE,IEXEN_IR,IEXEN_ALMA)values('" & Me.LCCODPVE & "', '" & Me.LCRAZON & "', '" & Me.LCNOMBRE & "', '" & Me.LCDIRECC & "', '" & Me.LCCIUDAD & "','" & Me.LCTELEFO & "',  '" & Me.LCCONTAC & "', '" & Me.LCCARGO & "','" & Me.LCREFERE & "','" & Me.LCMAIL & "', '" & Me.LCESTADO & "', '" & Me.LCNUMRUC & "','" & Me.ITIPPVE & "','" & Me.LIEXENTO_IR & "', '" & Me.LIEXENTO_ALMA & "') ")
            MsgBox("Registro ha sido Adicionado", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
    Private Sub validacion()

        Me.LCNOMBRE = Me.TBNOMBRE.Text
        If Len(Trim(Me.LCNOMBRE)) = 0 Then
            MsgBox("Debe Digitar Nombres.....", 64, "ATENCION")
            Me.TBNOMBRE.Focus()
            Exit Sub
        End If

        Me.LCRAZON = Me.TBRAZON.Text
        If Len(Trim(Me.LCRAZON)) = 0 Then
            MsgBox("Debe Digitar Razon Social.....", 64, "ATENCION")
            Me.TBRAZON.Focus()
            Exit Sub
        End If

        Me.LCDIRECC = Me.TBDIRECC.Text
        If Len(Trim(Me.LCDIRECC)) = 0 Then
            MsgBox("Debe Digitar Direccion.....", 64, "ATENCION")
            Me.TBDIRECC.Focus()
            Exit Sub
        End If

        Me.LCCIUDAD = Me.TBCIUDAD.Text
        Me.LCTELEFO = Me.TBTELEFO.Text
        Me.LCCONTAC = Me.TBCONTAC.Text
        Me.LCCARGO = Me.TBCARGO.Text
        Me.LCREFERE = Me.TBREFERE.Text
        Me.LCMAIL = Me.TBMAIL.Text

        If Me.RBPVENAC.Checked = True Then
            Me.ITIPPVE = 1
        End If
        If Me.RBPVEINT.Checked = True Then
            Me.ITIPPVE = 2
        End If

        Me.LCNUMRUC = Me.TBNUMRUC.Text
        If Len(Trim(Me.LCNUMRUC)) = 0 Then
            MsgBox("Debe Digitar Numero RUC.....", 64, "ATENCION")
            Me.TBNUMRUC.Focus()
            Exit Sub
        End If
        LCESTADO = "A"

        If Me.RBSI_IR.Checked = True Then
            Me.LIEXENTO_IR = 1
        Else
            Me.LIEXENTO_IR = 0
        End If
        If Me.RBSI_ALMA.Checked = True Then
            Me.LIEXENTO_ALMA = 1
        Else
            Me.LIEXENTO_ALMA = 0
        End If

    End Sub
End Class