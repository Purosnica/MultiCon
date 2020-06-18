Imports System.Data.SqlClient

Public Class FrmReasignar
    Dim conect As New Conexion
    Public cod_etiqueta, LCQUERY As String
    Dim dtem As DataTable
    Private oConexion As New SqlConnection
    Private oDataAdater1 As New SqlDataAdapter
    Private oDataSet1 As New DataSet
    Private oDataTable1 As New DataTable
    Private Sub FrmReasignar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.Text = "Empleado" Then
            conect.CargaCombo(gridEmpleados, "Nombres", "CodEmpleado", "select CodEmpleado,Nombres +' '+Apellidos as Nombres from SICCGEN..CatEmpleados ", dtem)
        ElseIf ComboBox1.Text = "Departamento" Then
            conect.CargaCombo(gridEmpleados, "CDESCRI", "CCODDEP", " select CCODDEP,CDESCRI from BDINV..INVTDEP where CESTADO = 'A'  ", dtem)

        ElseIf ComboBox1.Text = "Ubicacion_Fisica" Then
            conect.CargaCombo(gridEmpleados, "Nombre_Ubicacion_F", "Id_Ubicacion_F", " select Id_Ubicacion_F,Nombre_UbicacionF from Cat_Ubicacion_F ", dtem)
        Else
            gridEmpleados.Enabled = False
        End If
    End Sub
    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.Text = "Empleado" Then
            conect.CargaCombo(gridEmpleados, "Nombres", "CodEmpleado", "select CodEmpleado,Nombres +' '+Apellidos as Nombres from SICCGEN..CatEmpleados ", dtem)
            gridEmpleados.Enabled = True
        ElseIf ComboBox1.Text = "Departamento" Then
            conect.CargaCombo(gridEmpleados, "CDESCRI", "CCODDEP", " select CCODDEP,CDESCRI from BDINV..INVTDEP where CESTADO = 'A'  ", dtem)
            gridEmpleados.Enabled = True
        ElseIf ComboBox1.Text = "Ubicacion_Fisica" Then
            conect.CargaCombo(gridEmpleados, "Nombre_Ubicacion_F", "Id_Ubicacion_F", " select Id_Ubicacion_F,Nombre_UbicacionF from Cat_Ubicacion_F ", dtem)
            gridEmpleados.Enabled = True
        End If
    End Sub

    Private Sub btnbusca_Click(sender As Object, e As EventArgs) Handles btnbusca.Click


        Dim x As New FrmCat_Articulos
        x.btnnuevo.Enabled = False
        x.btneditar.Enabled = False
        x.busca = "Busca"
        x.ShowDialog()
        Agregar_Activo(x.cod_etiqueta)


    End Sub

    Private Sub Agregar_Activo(ByRef cod_etiqueta As String)
        Me.LCQUERY = "select Descripcion,Marca,Serie,Modelo,Cod_Activo from Tbl_Articulo WHERE Cod_Activo = '" & cod_etiqueta & "' "
        Me.oDataAdater1 = New SqlDataAdapter(Me.LCQUERY, conect.cn)
        Me.oDataTable1 = New DataTable()
        Me.oDataAdater1.Fill(Me.oDataTable1)
        If Me.oDataTable1.Rows.Count = 0 Then
            MsgBox("No se Encontro ese Activo", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        For Each row1 As DataRow In oDataTable1.Rows
            Dim existeElDato As Boolean = False
            For Each itm As DataGridViewRow In DataGridView1.Rows
                If itm.Cells(4).Value = row1(4) Then
                    existeElDato = True
                End If
            Next
            If DataGridView1.Rows.Count > 0 AndAlso existeElDato = True Then
                MsgBox("Ya existe este Codigo", MsgBoxStyle.Critical)
                Exit Sub
            End If
            DataGridView1.Rows.Add(row1(0), row1(1), row1(2), row1(3), row1(4))
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Next
    End Sub
End Class