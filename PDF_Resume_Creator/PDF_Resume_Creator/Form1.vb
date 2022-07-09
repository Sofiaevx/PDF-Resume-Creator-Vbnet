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
        Dim prof As Paragraph = New Paragraph(output.PROFESSION)
        Dim phone As Paragraph = New Paragraph(output.PHONE)
        Dim address As Paragraph = New Paragraph(output.ADDRESS)
        Dim email As Paragraph = New Paragraph(output.EMAIL)
        Dim about As Paragraph = New Paragraph(output.ABOUTME)
        Dim skill1 As Paragraph = New Paragraph(output.SKILL1)
        Dim skill2 As Paragraph = New Paragraph(output.SKILL2)
        Dim skill3 As Paragraph = New Paragraph(output.SKILL3)
        Dim skill4 As Paragraph = New Paragraph(output.SKILL4)
        Dim elem As Paragraph = New Paragraph(output.ELEM)
        Dim second As Paragraph = New Paragraph(output.SECONDARY)
        Dim college As Paragraph = New Paragraph(output.COLLEGE)
        Dim ref1 As Paragraph = New Paragraph(output.REF1)
        Dim ref2 As Paragraph = New Paragraph(output.REF2)
        Dim ex1 As Paragraph = New Paragraph(output.EXP1)
        Dim ex2 As Paragraph = New Paragraph(output.EXP2)
        Dim hereby As Paragraph = New Paragraph(vbLf & vbLf & vbLf & output.HEREBY)
        Dim Signature As Image = Image.GetInstance(output.SIGNATURE)
        Dim con As Paragraph = New Paragraph(variable(0))
        Dim ph As Paragraph = New Paragraph(variable(1))
        Dim add As Paragraph = New Paragraph(variable(2))
        Dim em As Paragraph = New Paragraph(variable(3))
        Dim ob As Paragraph = New Paragraph(variable(4))
        Dim exp As Paragraph = New Paragraph(variable(5))
        Dim edu As Paragraph = New Paragraph(variable(6))
        Dim refference As Paragraph = New Paragraph(variable(7))
        Dim experience As Paragraph = New Paragraph(variable(8))
        con.Font.Size = 18
        con.Alignment = Element.ALIGN_CENTER
        con.SetLeading(10, 1)
        ph.Font.Size = 12
        ph.Alignment = Element.ALIGN_CENTER
        ph.SetLeading(10, 1)
        add.Font.Size = 12
        add.Alignment = Element.ALIGN_CENTER
        add.SetLeading(10, 1)
        em.Font.Size = 12
        em.Alignment = Element.ALIGN_CENTER
        em.SetLeading(10, 1)
        ob.Font.Size = 18
        ob.IndentationLeft = 5
        refference.Font.Size = 18
        refference.Alignment = Element.ALIGN_CENTER
        refference.IndentationLeft = 5
        experience.Font.Size = 18
        experience.IndentationLeft = 5
        experience.SetLeading(10, 1)
        exp.Font.Color = BaseColor.ORANGE
        con.Font.Color = BaseColor.ORANGE
        ph.Font.Color = BaseColor.WHITE
        add.Font.Color = BaseColor.WHITE
        em.Font.Color = BaseColor.WHITE
        refference.Font.Color = BaseColor.ORANGE
        myimage.ScaleAbsolute(100, 100)
        f_name.Font.Size = 15
        f_name.Font.Color = BaseColor.BLACK
        prof.Font.Size = 15
        prof.Font.Color = BaseColor.BLACK
        phone.Font.Color = BaseColor.LIGHT_GRAY
        phone.Alignment = Element.ALIGN_CENTER
        phone.SetLeading(6, 1)
        email.Font.Color = BaseColor.LIGHT_GRAY
        email.Alignment = Element.ALIGN_CENTER
        email.SetLeading(6, 1)
        address.Font.Color = BaseColor.LIGHT_GRAY
        address.Alignment = Element.ALIGN_CENTER
        address.SetLeading(6, 1)
        about.Font.Size = 12
        about.IndentationRight = 5
        about.IndentationLeft = 5
        about.Alignment = Element.ALIGN_JUSTIFIED
        about.SetLeading(10, 1)
        exp.Font.Size = 18
        exp.Alignment = Element.ALIGN_CENTER
        exp.SetLeading(10, 1)
        edu.Font.Size = 18
        edu.IndentationLeft = 5
        elem.IndentationLeft = 50
        second.IndentationLeft = 50
        college.IndentationLeft = 50
        skill1.Font.Color = BaseColor.LIGHT_GRAY
        skill1.Alignment = Element.ALIGN_CENTER
        skill1.SetLeading(8, 1)
        skill2.Font.Color = BaseColor.LIGHT_GRAY
        skill2.Alignment = Element.ALIGN_CENTER
        skill2.SetLeading(6, 1)
        skill3.Font.Color = BaseColor.LIGHT_GRAY
        skill3.Alignment = Element.ALIGN_CENTER
        skill3.SetLeading(6, 1)
        skill4.Font.Color = BaseColor.LIGHT_GRAY
        skill4.Alignment = Element.ALIGN_CENTER
        skill4.SetLeading(6, 1)
        ref1.Font.Color = BaseColor.LIGHT_GRAY
        ref1.Alignment = Element.ALIGN_CENTER
        ref1.SetLeading(6, 1)
        ref2.Font.Color = BaseColor.LIGHT_GRAY
        ref2.Alignment = Element.ALIGN_CENTER
        ref2.SetLeading(6, 1)
        ex1.IndentationLeft = 50
        ex2.IndentationLeft = 50
        hereby.Alignment = Element.ALIGN_CENTER
        f_name1.Alignment = Element.ALIGN_RIGHT
        Signature.IndentationRight = 20
        Signature.ScalePercent(30.0F)
        Signature.Alignment = Image.UNDERLYING Or Image.ALIGN_RIGHT
        Dim table As PdfPTable = New PdfPTable(3)
        table.HorizontalAlignment = 1
        table.WidthPercentage = 100.0F
        Dim contact As PdfPCell = New PdfPCell(New Phrase(con))
        Dim add1 As PdfPCell = New PdfPCell(New Phrase(add))
        Dim ph1 As PdfPCell = New PdfPCell(New Phrase(ph))
        Dim em1 As PdfPCell = New PdfPCell(New Phrase(em))
        Dim ob1 As PdfPCell = New PdfPCell(New Phrase(ob))
        Dim exp1 As PdfPCell = New PdfPCell(New Phrase(exp))
        Dim edu1 As PdfPCell = New PdfPCell(New Phrase(edu))
        Dim reff As PdfPCell = New PdfPCell(New Phrase(refference))
        Dim exper As PdfPCell = New PdfPCell(New Phrase(experience))
        Dim my_img As PdfPCell = New PdfPCell(myimage, False)
        Dim my_fullname As PdfPCell = New PdfPCell(New Phrase(f_name))
        Dim my_prof As PdfPCell = New PdfPCell(New Phrase(prof))
        Dim my_phone As PdfPCell = New PdfPCell(New Phrase(phone))
        Dim my_address As PdfPCell = New PdfPCell(New Phrase(address))
        Dim my_email As PdfPCell = New PdfPCell(New Phrase(email))
        Dim my_about As PdfPCell = New PdfPCell(New Phrase(about))
        Dim my_skill1 As PdfPCell = New PdfPCell(New Phrase(skill1))
        Dim my_skill2 As PdfPCell = New PdfPCell(New Phrase(skill2))
        Dim my_skill3 As PdfPCell = New PdfPCell(New Phrase(skill3))
        Dim my_skill4 As PdfPCell = New PdfPCell(New Phrase(skill4))
        Dim my_elem As PdfPCell = New PdfPCell(New Phrase(elem))
        Dim my_second As PdfPCell = New PdfPCell(New Phrase(second))
        Dim my_college As PdfPCell = New PdfPCell(New Phrase(college))
        Dim my_ref1 As PdfPCell = New PdfPCell(New Phrase(ref1))
        Dim my_ref2 As PdfPCell = New PdfPCell(New Phrase(ref2))
        Dim my_ex1 As PdfPCell = New PdfPCell(New Phrase(ex1))
        Dim my_ex2 As PdfPCell = New PdfPCell(New Phrase(ex2))
        Dim my_hereby As PdfPCell = New PdfPCell(New Phrase(hereby))
        my_img.BackgroundColor = BaseColor.LIGHT_GRAY
        my_img.HorizontalAlignment = 1
        my_fullname.HorizontalAlignment = Element.ALIGN_CENTER
        my_fullname.VerticalAlignment = Element.ALIGN_MIDDLE
        my_fullname.BackgroundColor = BaseColor.LIGHT_GRAY
        my_prof.HorizontalAlignment = Element.ALIGN_CENTER
        my_prof.VerticalAlignment = Element.ALIGN_MIDDLE
        my_prof.BackgroundColor = BaseColor.LIGHT_GRAY
        my_address.AddElement(address)
        my_email.AddElement(email)
        my_address.BackgroundColor = BaseColor.BLACK
        my_email.BackgroundColor = BaseColor.BLACK
        ob1.Colspan = 2
        ob1.AddElement(ob)
        contact.BackgroundColor = BaseColor.BLACK
        contact.AddElement(con)
        exp1.AddElement(exp)
        exp1.BackgroundColor = BaseColor.BLACK
        add1.AddElement(add)
        ph1.AddElement(ph)
        em1.AddElement(em)
        add1.BackgroundColor = BaseColor.BLACK
        ph1.BackgroundColor = BaseColor.BLACK
        em1.BackgroundColor = BaseColor.BLACK
        edu1.AddElement(edu)
        edu1.Colspan = 2
        edu1.Rowspan = 2
        reff.BackgroundColor = BaseColor.BLACK
        reff.AddElement(refference)
        exper.AddElement(experience)
        my_phone.AddElement(phone)
        my_phone.BackgroundColor = BaseColor.BLACK
        my_about.Rowspan = 6
        my_about.Colspan = 2
        my_about.Indent = 15
        my_about.AddElement(about)
        my_skill1.AddElement(skill1)
        my_skill2.AddElement(skill2)
        my_skill3.AddElement(skill3)
        my_skill4.AddElement(skill4)
        my_skill1.BackgroundColor = BaseColor.BLACK
        my_skill2.BackgroundColor = BaseColor.BLACK
        my_skill3.BackgroundColor = BaseColor.BLACK
        my_skill4.BackgroundColor = BaseColor.BLACK
        my_elem.Colspan = 2
        my_second.Colspan = 2
        my_college.Colspan = 2
        my_elem.AddElement(elem)
        my_second.AddElement(second)
        my_college.AddElement(college)
        my_ref1.AddElement(ref1)
        my_ref2.AddElement(ref2)
        my_ref1.BackgroundColor = BaseColor.BLACK
        my_ref2.BackgroundColor = BaseColor.BLACK
        exper.Colspan = 2
        my_ex1.Colspan = 2
        my_ex1.AddElement(ex1)
        my_ex1.VerticalAlignment = Element.ALIGN_MIDDLE
        my_ex2.Colspan = 2
        my_ex2.AddElement(ex2)
        my_img.BorderWidth = 0
        my_fullname.BorderWidth = 0
        my_prof.BorderWidth = 0
        my_about.BorderWidth = 0
        ob1.BorderWidth = 0
        edu1.BorderWidth = 0
        my_elem.BorderWidth = 0
        my_second.BorderWidth = 0
        my_college.BorderWidth = 0
        exper.BorderWidth = 0
        my_ex1.BorderWidth = 0
        my_ex2.BorderWidth = 0
        table.AddCell(my_img)
        table.AddCell(my_fullname)
        table.AddCell(my_prof)
        table.AddCell(contact)
        table.AddCell(ob1)
        table.AddCell(ph1)
        table.AddCell(my_about)
        table.AddCell(my_phone)
        table.AddCell(add1)
        table.AddCell(my_address)
        table.AddCell(em1)
        table.AddCell(my_email)
        table.AddCell(exp1)
        table.AddCell(edu1)
        table.AddCell(my_skill1)
        table.AddCell(my_skill2)
        table.AddCell(my_elem)
        table.AddCell(my_skill3)
        table.AddCell(my_second)
        table.AddCell(my_skill4)
        table.AddCell(my_college)
        table.AddCell(reff)
        table.AddCell(exper)
        table.AddCell(my_ref1)
        table.AddCell(my_ex1)
        table.AddCell(my_ref2)
        table.AddCell(my_ex2)
        jsontopdf.Add(table)
        jsontopdf.Add(hereby)
        jsontopdf.Add(Signature)
        jsontopdf.Add(f_name1)
        jsontopdf.Close()
        MessageBox.Show("Pdf Create Successfully!!!")
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
