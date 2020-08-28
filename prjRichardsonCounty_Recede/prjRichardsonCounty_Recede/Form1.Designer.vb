<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtAssessedValue = New System.Windows.Forms.TextBox()
        Me.txtPropertyTax = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tax Calculator"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(47, 110)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(84, 13)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "Assessed value:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(231, 110)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(66, 13)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Property tax:"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAssessedValue
        '
        Me.txtAssessedValue.Location = New System.Drawing.Point(137, 107)
        Me.txtAssessedValue.Name = "txtAssessedValue"
        Me.txtAssessedValue.Size = New System.Drawing.Size(79, 20)
        Me.txtAssessedValue.TabIndex = 1
        '
        'txtPropertyTax
        '
        Me.txtPropertyTax.Enabled = False
        Me.txtPropertyTax.Location = New System.Drawing.Point(303, 107)
        Me.txtPropertyTax.Name = "txtPropertyTax"
        Me.txtPropertyTax.Size = New System.Drawing.Size(56, 20)
        Me.txtPropertyTax.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(44, 185)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(125, 185)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(206, 185)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(287, 185)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 235)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPropertyTax)
        Me.Controls.Add(Me.txtAssessedValue)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "                                 Richardson County"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents txtAssessedValue As TextBox
    Friend WithEvents txtPropertyTax As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
