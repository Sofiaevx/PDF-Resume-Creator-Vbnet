Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Image = iTextSharp.text.Image
Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Form1
    Private jsonpath As String = "SofiaVillanueva.json"
    Private openjson As String

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        openjson = File.ReadAllText(jsonpath)
        Dim output As Information_json = JsonConvert.DeserializeObject(Of Information_json)(openjson)
        Dim jsontopdf As Document = New Document()
        PdfWriter.GetInstance(jsontopdf, New FileStream("VILLANUEVA_SOFIARUTH.pdf", FileMode.Create))
        jsontopdf.Open()
        Dim variable As String() = {"CONTACT", "PHONE", "ADDRESS", "EMAIL", "OBJECTIVE", "EXPERTISE", "EDUCATIONAL BACKGROUND", "REFFERENCE", "EXPERIENCE"}
        Dim myimage As Image = Image.GetInstance(output.MYIMAGE)
        Dim f_name As Paragraph = New Paragraph(output.FULLNAME)
        Dim f_name1 As Paragraph = New Paragraph(vbLf & vbLf & output.FULLNAME)
    End Sub
    Public Class Information_json
        Public Property MYIMAGE As String
        Public Property FULLNAME As String
        Public Property PROFESSION As String
        Public Property PHONE As String
        Public Property ADDRESS As String
        Public Property EMAIL As String
        Public Property ABOUTME As String
        Public Property SKILL1 As String
        Public Property SKILL2 As String
        Public Property SKILL3 As String
        Public Property SKILL4 As String
        Public Property ELEM As String
        Public Property SECONDARY As String
        Public Property COLLEGE As String
        Public Property REF1 As String
        Public Property REF2 As String
        Public Property EXP1 As String
        Public Property EXP2 As String
        Public Property HEREBY As String
        Public Property SIGNATURE As String
    End Class

End Class
