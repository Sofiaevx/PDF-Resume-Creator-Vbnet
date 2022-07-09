<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.LabelPDF = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCreate.Location = New System.Drawing.Point(156, 158)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(162, 32)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "Create Resume"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'LabelPDF
        '
        Me.LabelPDF.AutoSize = True
        Me.LabelPDF.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPDF.Location = New System.Drawing.Point(81, 54)
        Me.LabelPDF.Name = "LabelPDF"
        Me.LabelPDF.Size = New System.Drawing.Size(332, 31)
        Me.LabelPDF.TabIndex = 1
        Me.LabelPDF.Text = "PDF RESUME CREATOR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 273)
        Me.Controls.Add(Me.LabelPDF)
        Me.Controls.Add(Me.BtnCreate)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDF Resume Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCreate As Button
    Friend WithEvents LabelPDF As Label
End Class
