Imports System.Data.OleDb
Imports DevExpress.DataAccess.Excel

Public Class Frm_AgreTC
    Private Sub Frm_AgreTC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Instanciamos nuestro cuadro de dialogo
        Dim openFileDialog1 As New OpenFileDialog
        'Directorio Predeterminado
        openFileDialog1.InitialDirectory = "C:\"
        'Filtramos solo archivos con extension *.xls
        openFileDialog1.Filter = "Excel Files |*.xlsx"

        'Si se presiona abrir entonces...
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Asignamos la ruta donde se almacena el fichero excel que se va a importar
            TextBox1.Text = openFileDialog1.FileName

            'Instanciamos nuestra cadena de conexion especial para excel,indicando la ruta del fichero
            Dim cadconex As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Me.TextBox1.Text.Trim & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=2"""
            Dim cn As New OleDb.OleDbConnection(cadconex)
            Dim cmd As New OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable

            cmd.Connection = cn
            'Consultamos la hoja llamada Clientes de nuestro archivo *.xls
            cmd.CommandText = "select * from [hola$]"
            cmd.CommandType = CommandType.Text

            da.SelectCommand = cmd
            'Llenamos el datatable
            da.Fill(dt)
            'Llenamos el Datagridview
            DataGridView1.DataSource = dt
            'Ajustamos las columnas del DataGridView
            DataGridView1.AutoSizeColumnsMode = 16
        End If
    End Sub
End Class