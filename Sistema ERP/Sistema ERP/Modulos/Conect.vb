Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlBulkCopy
Imports System.Data.SqlClient.SqlDataReader
Imports System.Data.Sql
Imports System.Data.OleDb.OleDbConnection
Imports System.Net.Mail

Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Imports DevExpress
Imports DevExpress.CodeParser
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports System.Drawing.Imaging

Module Conect


    Public OBJACCESO As String = ""


    Dim cmdbd As SqlCommand()
    'Public conndb As SqlConnection
    Public conndb As SqlConnection

    Public SQLSTR, VALOR As String
    Public dtDepto As New DataTable
    Public dtMun As New DataTable
    Public dtBarCom As New DataTable
    Public dtGral As New DataTable
    Public dsGral As New DataSet
    Public daGral As New SqlDataAdapter
    Public dvGral As New DataView
    Public args As New XtraInputBoxArgs()
    Public GTXTINPUT As String
    Private oDataAdater1 As New SqlDataAdapter
    Private oDataSet1 As New DataSet
    Private oDataTable1 As New DataTable
    Private oComando As New SqlCommand
    Private Comando As New SqlCommand

    Public da As New SqlDataAdapter





    Public Sub cargagridView(ByVal dgv As DataGridView, ByVal SQL As String)
        Try
            oDataAdater1 = New SqlDataAdapter(SQL, conndb)
            oDataTable1 = New DataTable
            oDataAdater1.Fill(oDataTable1)
            dgv.DataSource = oDataTable1
            dgv.Columns(2).DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
        Catch ex As Exception
            MessageBox.Show("Error al llenar la grilla: " + ex.ToString)
        End Try
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
        dgv.Columns(0).Width = 200
        dgv.Columns(2).Width = 120

    End Sub
    Public Sub CargaListBox(ByRef CtrlListBox As DevExpress.XtraEditors.ListBoxControl, CampoLista As String, CampoValor As String, TblSql As String, DtCbo As DataTable)
        ' Windows.Forms.ComboBox
        Try
            Dim da As New SqlDataAdapter(TblSql, conndb)
            DtCbo = New DataTable
            DtCbo.Dispose()

            CtrlListBox.DataSource = Nothing
            'CtrlListBox.Columns.Clear()
            CtrlListBox.DisplayMember = CampoLista
            CtrlListBox.ValueMember = CampoValor
            da.Fill(DtCbo)
            CtrlListBox.DataSource = DtCbo
            'CtrlListBox.ItemIndex = -1

        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try
    End Sub
    Public Function ToDataSet(ByVal strQuery As String,
                   Optional ByVal strTable As String = "") As DataSet
        Try
            'Dim objConnection As New SqlConnection(m_StrConnectionString)
            'Cria o objecto
            Dim objCommand = New SqlCommand(strQuery, conndb)
            Dim objDataSet As New DataSet
            'Cria o sql DataAdapter
            Dim objSqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(objCommand)

            'Verifica se foi defenido a tabela
            If strTable = "" Then _
                 objSqlDataAdapter.Fill(objDataSet) _
            Else objSqlDataAdapter.Fill(objDataSet, strTable)


            objCommand = Nothing

            Return objDataSet

        Catch ex As Exception

            MsgBox("ToDataSet " + ex.Message, vbCritical)
            Return Nothing
        End Try
    End Function

    Public Function DameInput(Titulo As String, MsgInput As String, StrMod As String) As String
        ' set required Input Box options 

        args.Caption = Titulo '"Justificacion de Rechazo"
        args.Prompt = MsgInput '"Si la Solicitud es rechazada Justifique:"
        args.DefaultButtonIndex = 0
        Dim editor As New MemoEdit ' TextEdit
        editor.EditValue = StrMod.Trim

        args.DefaultResponse = StrMod.Trim
        args.Editor = editor
        ' a default DateEdit value 

        ' display an Input Box with the custom editor 
        Dim result As Object
        result = XtraInputBox.Show(args)
        If result = Nothing Then
            result = ""

        End If
        ' set a dialog icon 
        If (result = "") Then
            MsgBox("No se especifico ninguna entrada de texto!", vbCritical)
            DameInput = ""
        Else
            DameInput = result
        End If
    End Function

    Public Function GuardarDocPDFProcedmiento(tabla As String, IdTablaN As String, IdTablaV As Object, PDFIMAGE As Image)

        Dim sourceFile As String = ""
        Dim destinationFile As String = ""
        Dim img As Image = PDFIMAGE
        Dim sql As String = "insert into " + tabla + " values(" + IdTablaV.ToString + ",@imgData)"
        Dim command1 As SqlCommand = New SqlCommand(sql, conndb)
        Dim sqlpara As New SqlParameter("imgData", SqlDbType.Image)

        Dim mStream As MemoryStream = New MemoryStream()
        img.Save(mStream, ImageFormat.Jpeg)
        sqlpara.SqlValue = mStream.GetBuffer

        command1.Parameters.Add(sqlpara)

        command1.ExecuteNonQuery()

    End Function
    Public Function CargarImagenes(tabla As String, IdTablaN As String, IdTablaV As Object, ByRef Galeria As DevExpress.XtraBars.Ribbon.GalleryControl)
        Try
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            SQLSTR = "select imagen from " + tabla + " where " + IdTablaN + "=" + IdTablaV.ToString + ""
            cmd = New SqlCommand(SQLSTR, conndb)
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()

                    Dim bitPic() As Byte = CType(reader.Item(0), Byte())
                    Dim mStream As MemoryStream = New MemoryStream(bitPic)
                    Dim img As Image = Image.FromStream(mStream)
                    Galeria.Gallery.Groups(0).Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(img, "averia", ""))

                End While
            End If
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try

    End Function
    Public Sub GuardaDT(DtGuarda As DataTable, tabla As String)
        Try
            Using bulkCopy As SqlBulkCopy =
           New SqlBulkCopy(conndb)
                bulkCopy.DestinationTableName = tabla '"dbo.BulkCopyDemoMatchingColumns"

                Try
                    ' Write from the source to the destination.
                    bulkCopy.WriteToServer(DtGuarda)

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
