Public Class FrmGeneralCont
    Public Llamadatos As String
    Dim conect As New Conexion
    Private Sub FrmGeneralCont_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case Llamadatos

            Case "CatCTE"
                conect.CargaGrid(GrdGeneral, "Select * from Tbl_CTComprobantes ", "Tbl_CTComprobantes", "")
                GvGeneral.BestFitColumns()

        End Select

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Select Case Llamadatos

            Case "CatCTE"
                Dim x As New Frm_AgregaCte
                x.Tipo = 1
                x.ShowDialog()

        End Select
    End Sub

    Private Sub btnedita_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnedita.ItemClick
        Select Case Llamadatos

            Case "CatCTE"
                Dim x As New Frm_AgregaCte
                x.Codigo = GvGeneral.GetFocusedRow(0)
                x.ShowDialog()

        End Select
    End Sub
End Class