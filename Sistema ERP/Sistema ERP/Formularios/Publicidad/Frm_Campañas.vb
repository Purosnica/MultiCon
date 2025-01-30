Public Class Frm_Campañas
    Public Tipo As Integer
    Public Codigo As String
    Dim dtSegmento As DataTable
    Private _ftHelper As New FunctionHelper

    Private Sub Frm_Campañas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect1.CargaCombo(cmbSegmento, "Segmento", "IdSegmento", "Select IdSegmento,[Tipo Persona] + ' ' + Ocupacion as Segmento from V_Segmento", dtSegmento)
        cmbSegmento.ItemIndex = 0
        FechaInit.EditValue = DateTime.Now
        FechaFin.EditValue = DateTime.Now
        creargrid()
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

    Private Sub creargrid()
        _DtAllCampana.Columns.Clear()
        _DtAllCampana.Columns.Add("IdSegmento")
        _DtAllCampana.Columns.Add("Segmento")

    End Sub
    Private Sub AgregaGrid()
        Dim row As DataRow
        row = _DtAllCampana.NewRow()
        row("IdSegmento") = cmbSegmento.EditValue
        row("Segmento") = cmbSegmento.Text

        _DtAllCampana.Rows.Add(row)
        _DtAllCampana.AcceptChanges()
        grdCampana.DataSource = _DtAllCampana
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        AgregaGrid()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        If gvcampana.RowCount = 0 Then
            MsgBox("No hay datos seleccionado", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            For Each x In gvcampana.GetSelectedRows
                _DtAllCampana.Rows.Item(x).Delete()
            Next
            grdCampana.DataSource = _DtAllCampana
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If gvcampana.RowCount = 0 Then

            MsgBox("No hay datos seleccionado", MsgBoxStyle.Exclamation)
            Exit Sub

        Else
            Dim _Counter As Integer = 0
            Dim _SQl As String = ""

            _SQl = _ftHelper.CadenaInsert("Tbl_Campana", 1)
            _SQl += "Descripcion,FechaInicio,FechaFin,Estado,FechaCreacion,UsuarioCrea) values ('" & txtdescri.EditValue & "','" & Format(CDate(FechaInit.EditValue), "yyyy-MM-dd") & "','" & Format(CDate(FechaFin.EditValue), "yyyy-MM-dd") & "',1,getdate(),'" & IdUsu & "')"

            If (conect1.EjecutaSQL(_SQl) = True) Then

                _Counter = gvcampana.DataRowCount
                For i As Integer = 0 To gvcampana.DataRowCount - 1
                    _SQl = _ftHelper.CadenaInsert("p_InsertDetalleCampana", 3) & " " & CInt(gvcampana.GetRowCellValue(i, "IdSegmento")) & ""

                    If conect1.EjecutaSQL(_SQl) = True Then

                        If (_Counter = i) Then

                            MsgBox("Registro Guadado Exitosamente", MsgBoxStyle.Information)

                        End If

                    Else

                        MsgBox("Hubo un error al Guardar los datos", MsgBoxStyle.Critical)
                        Exit For

                    End If
                Next

            Else
                MsgBox("Hubo un error al Guardar los datos", MsgBoxStyle.Critical)
                Exit Sub

            End If


        End If

    End Sub
End Class