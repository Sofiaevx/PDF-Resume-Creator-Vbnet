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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.LabelPDF = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCreate.FlatAppearance.BorderSize = 2
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCreate.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCreate.Location = New System.Drawing.Point(328, 229)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(156, 32)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "Create Resume"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'LabelPDF
        '
        Me.LabelPDF.AutoSize = True
        Me.LabelPDF.BackColor = System.Drawing.Color.Transparent
        Me.LabelPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelPDF.Font = New System.Drawing.Font("Lucida Bright", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPDF.ForeColor = System.Drawing.Color.Black
        Me.LabelPDF.Location = New System.Drawing.Point(45, 104)
        Me.LabelPDF.Name = "LabelPDF"
        Me.LabelPDF.Size = New System.Drawing.Size(394, 36)
        Me.LabelPDF.TabIndex = 1
        Me.LabelPDF.Text = "PDF RESUME CREATOR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 273)
        Me.Controls.Add(Me.LabelPDF)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDF Resume Creator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCreate As Button
    Friend WithEvents LabelPDF As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
