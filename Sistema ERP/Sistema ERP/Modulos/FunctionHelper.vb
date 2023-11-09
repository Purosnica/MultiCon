Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime

Public Class FunctionHelper
    Public Function CambiarTamanoImagen(pImagen As Image, pAncho As Integer, pAlto As Integer) As Image
        Dim vBitmap As Bitmap = New Bitmap(pAncho, pAlto)
        Using vGraphics = Graphics.FromImage(TryCast(vBitmap, Image))
            vGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            vGraphics.DrawImage(pImagen, 0, 0, pAncho, pAlto)
        End Using
        Return TryCast(vBitmap, Image)
    End Function

    Public Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function


    Public Function CadenaInsert(ByRef _Table As String, ByRef _Type As String) As String
        Dim _Result As String
        Dim _SqlStr As String = ""

        Select Case _Type
            Case 1 : _SqlStr = "Insert into " + _Table + " ( "

            Case 2 : _SqlStr = "Delete from " + _Table + ""

            Case 3 : _SqlStr = " Execute " + _Table + ""
            Case Else
                _SqlStr = " Update " + _Table + " set "

        End Select
        _Result = _SqlStr.ToString
        Return _Result

    End Function

    Public Sub GuardaDT(DtGuarda As DataTable, tabla As String)
        Try
            Using bulkCopy As SqlBulkCopy =
           New SqlBulkCopy(conndb)
                bulkCopy.DestinationTableName = tabla

                Try

                    bulkCopy.WriteToServer(DtGuarda)

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


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



    Public Sub EnviarCorreosMasivos(ByRef _Correo As String, ByRef pass As String, ByVal _Host As String, ByVal _Port As Integer, ByVal _LsCorreo As DataTable, ByVal _url As String, ByVal cuerpoHTML As String)

        Dim remitente As String = _Correo
        Dim contraseña As String = pass

        Try
            Dim smtpCliente As New SmtpClient(_Host)
            Dim correo As New MailMessage()
            correo.From = New MailAddress(remitente)
            correo.Subject = "Feliz Cumpleaños"
            correo.Body = "¡Feliz Cumpleaños! Te envío esta felicitación especial."
            correo.IsBodyHtml = True
            smtpCliente.Port = _Port
            smtpCliente.Credentials = New NetworkCredential(remitente, contraseña)
            smtpCliente.EnableSsl = True
            correo.Priority = MailPriority.High


            Dim vistaHTML As AlternateView = AlternateView.CreateAlternateViewFromString(cuerpoHTML, Nothing, MediaTypeNames.Text.Html)

            Dim imgpR As LinkedResource = New LinkedResource(_url, MediaTypeNames.Image.Jpeg)
            imgpR.ContentId = "TRS2S55"
            vistaHTML.LinkedResources.Add(imgpR)
            Dim imgpL As LinkedResource = New LinkedResource("C:\Users\PC\Documents\Modelo.png", MediaTypeNames.Image.Jpeg)
            imgpL.ContentId = "TRPub2x"
            vistaHTML.LinkedResources.Add(imgpL)

            correo.AlternateViews.Add(vistaHTML)
            ' Lista de destinatarios
            Dim destinatarios() As String = {"purosnica505@gmail.com", "rmurillo.abogados@gmail.com"}

            ' Envía correos a cada destinatario
            For Each destinatario In destinatarios
                correo.To.Clear() ' Borra los destinatarios anteriores
                correo.To.Add(destinatario)
                smtpCliente.Send(correo)
            Next

            ' Limpia recursos
            correo.Dispose()
        Catch ex As Exception
            Console.WriteLine("Error al enviar el correo: " & ex.Message)
        End Try


    End Sub

End Class
