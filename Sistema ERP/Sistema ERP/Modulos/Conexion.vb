Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Public Class Conexion
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Private oDataAdater1 As New SqlDataAdapter
    Private oDataSet1 As New DataSet
    Private oDataTable1 As New DataTable
    Sub New()
        Try
            cn = New SqlConnection("Data Source= SOPORTE;Initial Catalog=SYSERP;Integrated Security=True")
            cn.Open()
            '' MsgBox("CONECTADO")
        Catch ex As Exception
            MsgBox("Error al conectarse debido a: " + ex.ToString)
        End Try
    End Sub

    Public Function Recolecta_Datos(ByVal tabla As String, ByVal consulta As String, ByVal parametro As String)
        Dim sql As String
        sql = "Select * from " + tabla + " where  " + consulta + "= '" & parametro & "' "
        Me.oDataAdater1 = New SqlDataAdapter(sql, cn)
        Me.oDataTable1 = New DataTable()
        Me.oDataAdater1.Fill(Me.oDataTable1)
        If Me.oDataTable1.Rows.Count = 0 Then
            Return MsgBox("No se Encontro ningun elemento")
        End If
        For Each rows In oDataTable1.Rows
            Column1 = rows(0).ToString
            Column2 = rows(1).ToString : Column3 = rows(2).ToString : Column4 = rows(3).ToString : Column5 = rows(4).ToString
            Column6 = rows(5).ToString : Column7 = rows(6).ToString : Column8 = rows(7).ToString : Column10 = rows(10).ToString
        Next
        Return 0

    End Function

    Public Function Recolecta_Datos2(ByVal tabla As String, ByVal consulta As String, ByVal parametro As String)
        Dim sql As String
        sql = "Select * from " + tabla + " where  " + consulta + "= '" & parametro & "' "
        Me.oDataAdater1 = New SqlDataAdapter(sql, cn)
        Me.oDataTable1 = New DataTable()
        Me.oDataAdater1.Fill(Me.oDataTable1)
        If Me.oDataTable1.Rows.Count = 0 Then
            '  Return MsgBox("No se Encontro ningun elemento")
        End If
        For Each rows In oDataTable1.Rows
            Column1 = rows(0).ToString
            Column2 = rows(1).ToString : Column3 = rows(2).ToString : Column4 = rows(3).ToString
        Next
        Return 0

    End Function
    'Devuelve un valor de una consulta'
    Public Function ConsulSql(SqlValor As String) As Object
        Try
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            cmd = New SqlCommand(SqlValor, cn)
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    ConsulSql = reader.Item(0)
                End While
            Else
                ConsulSql = Nothing
            End If
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try
    End Function
    Public Sub CargaCombo(ByRef CtrlCombo As DevExpress.XtraEditors.LookUpEdit, CampoLista As String, CampoValor As String, TblSql As String, DtCbo As DataTable)
        Try
            Dim da As New SqlDataAdapter(TblSql, cn)
            DtCbo = New DataTable
            DtCbo.Dispose()
            CtrlCombo.Properties.DataSource = Nothing
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DisplayMember = CampoLista
            CtrlCombo.Properties.ValueMember = CampoValor
            da.Fill(DtCbo)
            CtrlCombo.Properties.DataSource = DtCbo
            CtrlCombo.ItemIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try
    End Sub
    'Insertar o ejecutar cualquier consulta sql'
    Public Sub EjecutaSQL(SQLSTR As String)
        Try
            Dim cmd As SqlCommand
            cmd = New SqlCommand(SQLSTR, cn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try
    End Sub
    Public Sub CargaGrid(ByRef CtrlGrid As Object, TblSql As String, strDataMenber As String, strFiltro As String)
        Try
            da.Dispose()
            dsGral.Dispose()
            da = New SqlDataAdapter(TblSql, cn)
            dsGral = New DataSet
            da.Fill(dsGral, strDataMenber)
            dtGral = New DataTable
            dtGral = dsGral.Tables(0)
            CtrlGrid.DataSource = dtGral
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try
    End Sub
    Public Function FXSTRZERO(ByVal TNNUMERO As Integer, ByVal TNSIZE As Integer) As String
        Dim XCEROS As String, I As Integer
        XCEROS = ""
        For I = 1 To TNSIZE
            XCEROS = XCEROS + "0"
        Next
        FXSTRZERO = Format$(TNNUMERO, XCEROS)
    End Function
    Public Function GuardarImagenes(tabla As String, IdTablaN As String, IdTablaV As Object, ByRef Galeria As DevExpress.XtraBars.Ribbon.GalleryControl)
        Dim sourceFile As String = ""
        Dim destinationFile As String = ""
        If Galeria.Gallery.Groups(0).Items.Count = 0 Then Exit Function
        EjecutaSQL("delete from " + tabla + " where " + IdTablaN + "=" + IdTablaV.ToString)

        For i = 0 To Galeria.Gallery.Groups(0).Items.Count - 1

            Dim img As Image = Galeria.Gallery.Groups(0).Items(i).Image
            Dim sql As String = "insert into " + tabla + " values(" + IdTablaV.ToString + ",@imgData)"
            Dim command1 As SqlCommand = New SqlCommand(sql, conndb)
            Dim sqlpara As New SqlParameter("imgData", SqlDbType.Image)
            Dim mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, ImageFormat.Jpeg)
            sqlpara.SqlValue = mStream.GetBuffer
            command1.Parameters.Add(sqlpara)
            command1.ExecuteNonQuery()
        Next
    End Function
End Class
