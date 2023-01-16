<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    Private Function GetDataRepeater1() As Microsoft.VisualBasic.PowerPacks.DataRepeater
        Return Me.DataRepeater1
    End Function

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent(dataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater)
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost
        Me.ElementHost2 = New System.Windows.Forms.Integration.ElementHost
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ShapeContainer1 = New WindowsApplication1.Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New WindowsApplication1.Microsoft.VisualBasic.PowerPacks.LineShape
        Me.OvalShape1 = New WindowsApplication1.Microsoft.VisualBasic.PowerPacks.OvalShape
        Me.RectangleShape1 = New WindowsApplication1.Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater
        Me.ElementHost3 = New System.Windows.Forms.Integration.ElementHost
        Me.UserControl11 = New WindowsApplication1.UserControl1
        Me.ElementHost4 = New System.Windows.Forms.Integration.ElementHost
        Me.UserControl21 = New WindowsApplication1.UserControl2
        Me.DataRepeater1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(440, -4)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(100, 100)
        Me.PrintPreviewControl1.TabIndex = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ElementHost1
        '
        Me.ElementHost1.Location = New System.Drawing.Point(-5, 171)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(206, 100)
        Me.ElementHost1.TabIndex = 1
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Nothing
        '
        'ElementHost2
        '
        Me.ElementHost2.Location = New System.Drawing.Point(234, -5)
        Me.ElementHost2.Name = "ElementHost2"
        Me.ElementHost2.Size = New System.Drawing.Size(200, 100)
        Me.ElementHost2.TabIndex = 2
        Me.ElementHost2.Text = "ElementHost2"
        Me.ElementHost2.Child = Nothing
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Dim v = Me.ShapeContainer1.Shapes.AddRange(New WindowsApplication1.Microsoft.VisualBasic.PowerPacks.Shape() {
            Me.RectangleShape1,
            Me.OvalShape1,
            Me.LineShape1
        })
        Me.ShapeContainer1.Size = New System.Drawing.Size(532, 749)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 237
        Me.LineShape1.X2 = 312
        Me.LineShape1.Y1 = 153
        Me.LineShape1.Y2 = 176
        '
        'OvalShape1
        '
        Me.OvalShape1.Location = New System.Drawing.Point(234, 186)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(75, 23)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(193, 188)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(75, 23)
        '
        'DataRepeater1
        '
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(232, 72)
        Me.DataRepeater1.Location = New System.Drawing.Point(-39, 26)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(240, 150)
        Me.DataRepeater1.TabIndex = 4
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'ElementHost3
        '
        Me.ElementHost3.Location = New System.Drawing.Point(440, 123)
        Me.ElementHost3.Name = "ElementHost3"
        Me.ElementHost3.Size = New System.Drawing.Size(200, 100)
        Me.ElementHost3.TabIndex = 5
        Me.ElementHost3.Text = "ElementHost3"
        Me.ElementHost3.Child = Me.UserControl11
        '
        'ElementHost4
        '
        Me.ElementHost4.Location = New System.Drawing.Point(440, 230)
        Me.ElementHost4.Name = "ElementHost4"
        Me.ElementHost4.Size = New System.Drawing.Size(200, 100)
        Me.ElementHost4.TabIndex = 6
        Me.ElementHost4.Text = "ElementHost4"
        Me.ElementHost4.Child = Me.UserControl21
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 749)
        Me.Controls.Add(Me.ElementHost4)
        Me.Controls.Add(Me.ElementHost3)
        Me.Controls.Add(dataRepeater1)
        Me.Controls.Add(Me.ElementHost2)
        Me.Controls.Add(Me.ElementHost1)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.DataRepeater1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ElementHost1 As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents ElementHost2 As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents PrintForm1 As WindowsApplication1.Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ElementHost4 As System.Windows.Forms.Integration.ElementHost
    Friend UserControl21 As WindowsApplication1.UserControl2
    Friend WithEvents ElementHost3 As System.Windows.Forms.Integration.ElementHost
    Friend UserControl11 As WindowsApplication1.UserControl1
    Friend WithEvents DataRepeater1 As WindowsApplication1.Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents ShapeContainer1 As WindowsApplication1.Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As WindowsApplication1.Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents OvalShape1 As WindowsApplication1.Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LineShape1 As WindowsApplication1.Microsoft.VisualBasic.PowerPacks.LineShape
End Class
