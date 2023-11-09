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

    Public Sub CargaListBox(ByRef CtrlListBox As DevExpress.XtraEditors.ListBoxControl, CampoLista As String, CampoValor As String, TblSql As String, DtCbo As DataTable)

        Try
            Dim da As New SqlDataAdapter(TblSql, conndb)
            DtCbo = New DataTable
            DtCbo.Dispose()

            CtrlListBox.DataSource = Nothing

            CtrlListBox.DisplayMember = CampoLista
            CtrlListBox.ValueMember = CampoValor
            da.Fill(DtCbo)
            CtrlListBox.DataSource = DtCbo


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



End Module
