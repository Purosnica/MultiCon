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
End Class