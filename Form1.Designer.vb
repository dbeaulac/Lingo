<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLingo
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
        Me.letterTable = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl62 = New System.Windows.Forms.Label()
        Me.lbl61 = New System.Windows.Forms.Label()
        Me.lbl63 = New System.Windows.Forms.Label()
        Me.lbl65 = New System.Windows.Forms.Label()
        Me.lbl64 = New System.Windows.Forms.Label()
        Me.lbl55 = New System.Windows.Forms.Label()
        Me.lbl54 = New System.Windows.Forms.Label()
        Me.lbl53 = New System.Windows.Forms.Label()
        Me.lbl52 = New System.Windows.Forms.Label()
        Me.lbl51 = New System.Windows.Forms.Label()
        Me.lbl45 = New System.Windows.Forms.Label()
        Me.lbl44 = New System.Windows.Forms.Label()
        Me.lbl43 = New System.Windows.Forms.Label()
        Me.lbl42 = New System.Windows.Forms.Label()
        Me.lbl41 = New System.Windows.Forms.Label()
        Me.lbl35 = New System.Windows.Forms.Label()
        Me.lbl34 = New System.Windows.Forms.Label()
        Me.lbl33 = New System.Windows.Forms.Label()
        Me.lbl32 = New System.Windows.Forms.Label()
        Me.lbl31 = New System.Windows.Forms.Label()
        Me.lbl25 = New System.Windows.Forms.Label()
        Me.lbl24 = New System.Windows.Forms.Label()
        Me.lbl23 = New System.Windows.Forms.Label()
        Me.lbl22 = New System.Windows.Forms.Label()
        Me.lbl21 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.txtSecret = New System.Windows.Forms.TextBox()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbInstructions = New System.Windows.Forms.PictureBox()
        Me.letterTable.SuspendLayout()
        CType(Me.pbInstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'letterTable
        '
        Me.letterTable.BackColor = System.Drawing.Color.MidnightBlue
        Me.letterTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.letterTable.ColumnCount = 5
        Me.letterTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.letterTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.letterTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.letterTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.letterTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.letterTable.Controls.Add(Me.lbl62, 0, 5)
        Me.letterTable.Controls.Add(Me.lbl61, 0, 5)
        Me.letterTable.Controls.Add(Me.lbl63, 0, 5)
        Me.letterTable.Controls.Add(Me.lbl65, 0, 5)
        Me.letterTable.Controls.Add(Me.lbl64, 0, 5)
        Me.letterTable.Controls.Add(Me.lbl55, 4, 4)
        Me.letterTable.Controls.Add(Me.lbl54, 3, 4)
        Me.letterTable.Controls.Add(Me.lbl53, 2, 4)
        Me.letterTable.Controls.Add(Me.lbl52, 1, 4)
        Me.letterTable.Controls.Add(Me.lbl51, 0, 4)
        Me.letterTable.Controls.Add(Me.lbl45, 4, 3)
        Me.letterTable.Controls.Add(Me.lbl44, 3, 3)
        Me.letterTable.Controls.Add(Me.lbl43, 2, 3)
        Me.letterTable.Controls.Add(Me.lbl42, 1, 3)
        Me.letterTable.Controls.Add(Me.lbl41, 0, 3)
        Me.letterTable.Controls.Add(Me.lbl35, 4, 2)
        Me.letterTable.Controls.Add(Me.lbl34, 3, 2)
        Me.letterTable.Controls.Add(Me.lbl33, 2, 2)
        Me.letterTable.Controls.Add(Me.lbl32, 1, 2)
        Me.letterTable.Controls.Add(Me.lbl31, 0, 2)
        Me.letterTable.Controls.Add(Me.lbl25, 4, 1)
        Me.letterTable.Controls.Add(Me.lbl24, 3, 1)
        Me.letterTable.Controls.Add(Me.lbl23, 2, 1)
        Me.letterTable.Controls.Add(Me.lbl22, 1, 1)
        Me.letterTable.Controls.Add(Me.lbl21, 0, 1)
        Me.letterTable.Controls.Add(Me.lbl15, 4, 0)
        Me.letterTable.Controls.Add(Me.lbl14, 3, 0)
        Me.letterTable.Controls.Add(Me.lbl13, 2, 0)
        Me.letterTable.Controls.Add(Me.lbl12, 1, 0)
        Me.letterTable.Controls.Add(Me.lbl11, 0, 0)
        Me.letterTable.ForeColor = System.Drawing.Color.White
        Me.letterTable.Location = New System.Drawing.Point(370, 24)
        Me.letterTable.Name = "letterTable"
        Me.letterTable.RowCount = 6
        Me.letterTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.letterTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.letterTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.letterTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.letterTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.letterTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.letterTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.letterTable.Size = New System.Drawing.Size(400, 475)
        Me.letterTable.TabIndex = 0
        '
        'lbl62
        '
        Me.lbl62.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl62.Location = New System.Drawing.Point(85, 393)
        Me.lbl62.Name = "lbl62"
        Me.lbl62.Size = New System.Drawing.Size(70, 75)
        Me.lbl62.TabIndex = 29
        Me.lbl62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl61
        '
        Me.lbl61.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl61.Location = New System.Drawing.Point(6, 393)
        Me.lbl61.Name = "lbl61"
        Me.lbl61.Size = New System.Drawing.Size(70, 75)
        Me.lbl61.TabIndex = 28
        Me.lbl61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl63
        '
        Me.lbl63.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl63.Location = New System.Drawing.Point(164, 393)
        Me.lbl63.Name = "lbl63"
        Me.lbl63.Size = New System.Drawing.Size(70, 75)
        Me.lbl63.TabIndex = 27
        Me.lbl63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl65
        '
        Me.lbl65.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl65.Location = New System.Drawing.Point(322, 393)
        Me.lbl65.Name = "lbl65"
        Me.lbl65.Size = New System.Drawing.Size(72, 75)
        Me.lbl65.TabIndex = 26
        Me.lbl65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl64
        '
        Me.lbl64.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl64.Location = New System.Drawing.Point(243, 393)
        Me.lbl64.Name = "lbl64"
        Me.lbl64.Size = New System.Drawing.Size(70, 75)
        Me.lbl64.TabIndex = 25
        Me.lbl64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl55
        '
        Me.lbl55.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl55.Location = New System.Drawing.Point(322, 315)
        Me.lbl55.Name = "lbl55"
        Me.lbl55.Size = New System.Drawing.Size(72, 75)
        Me.lbl55.TabIndex = 24
        Me.lbl55.Text = "."
        Me.lbl55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl54
        '
        Me.lbl54.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl54.Location = New System.Drawing.Point(243, 315)
        Me.lbl54.Name = "lbl54"
        Me.lbl54.Size = New System.Drawing.Size(70, 75)
        Me.lbl54.TabIndex = 23
        Me.lbl54.Text = "."
        Me.lbl54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl53
        '
        Me.lbl53.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl53.Location = New System.Drawing.Point(164, 315)
        Me.lbl53.Name = "lbl53"
        Me.lbl53.Size = New System.Drawing.Size(70, 75)
        Me.lbl53.TabIndex = 22
        Me.lbl53.Text = "."
        Me.lbl53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl52
        '
        Me.lbl52.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl52.Location = New System.Drawing.Point(85, 315)
        Me.lbl52.Name = "lbl52"
        Me.lbl52.Size = New System.Drawing.Size(70, 75)
        Me.lbl52.TabIndex = 21
        Me.lbl52.Text = "."
        Me.lbl52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl51
        '
        Me.lbl51.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl51.Location = New System.Drawing.Point(6, 315)
        Me.lbl51.Name = "lbl51"
        Me.lbl51.Size = New System.Drawing.Size(70, 75)
        Me.lbl51.TabIndex = 20
        Me.lbl51.Text = "."
        Me.lbl51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl45
        '
        Me.lbl45.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl45.Location = New System.Drawing.Point(322, 237)
        Me.lbl45.Name = "lbl45"
        Me.lbl45.Size = New System.Drawing.Size(72, 75)
        Me.lbl45.TabIndex = 19
        Me.lbl45.Text = "."
        Me.lbl45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl44
        '
        Me.lbl44.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl44.Location = New System.Drawing.Point(243, 237)
        Me.lbl44.Name = "lbl44"
        Me.lbl44.Size = New System.Drawing.Size(70, 75)
        Me.lbl44.TabIndex = 18
        Me.lbl44.Text = "."
        Me.lbl44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl43
        '
        Me.lbl43.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl43.Location = New System.Drawing.Point(164, 237)
        Me.lbl43.Name = "lbl43"
        Me.lbl43.Size = New System.Drawing.Size(70, 75)
        Me.lbl43.TabIndex = 17
        Me.lbl43.Text = "."
        Me.lbl43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl42
        '
        Me.lbl42.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl42.Location = New System.Drawing.Point(85, 237)
        Me.lbl42.Name = "lbl42"
        Me.lbl42.Size = New System.Drawing.Size(70, 75)
        Me.lbl42.TabIndex = 16
        Me.lbl42.Text = "."
        Me.lbl42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl41
        '
        Me.lbl41.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl41.Location = New System.Drawing.Point(6, 237)
        Me.lbl41.Name = "lbl41"
        Me.lbl41.Size = New System.Drawing.Size(70, 75)
        Me.lbl41.TabIndex = 15
        Me.lbl41.Text = "."
        Me.lbl41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl35
        '
        Me.lbl35.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl35.Location = New System.Drawing.Point(322, 159)
        Me.lbl35.Name = "lbl35"
        Me.lbl35.Size = New System.Drawing.Size(72, 75)
        Me.lbl35.TabIndex = 14
        Me.lbl35.Text = "."
        Me.lbl35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl34
        '
        Me.lbl34.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl34.Location = New System.Drawing.Point(243, 159)
        Me.lbl34.Name = "lbl34"
        Me.lbl34.Size = New System.Drawing.Size(70, 75)
        Me.lbl34.TabIndex = 13
        Me.lbl34.Text = "."
        Me.lbl34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl33
        '
        Me.lbl33.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl33.Location = New System.Drawing.Point(164, 159)
        Me.lbl33.Name = "lbl33"
        Me.lbl33.Size = New System.Drawing.Size(70, 75)
        Me.lbl33.TabIndex = 12
        Me.lbl33.Text = "."
        Me.lbl33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl32
        '
        Me.lbl32.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl32.Location = New System.Drawing.Point(85, 159)
        Me.lbl32.Name = "lbl32"
        Me.lbl32.Size = New System.Drawing.Size(70, 75)
        Me.lbl32.TabIndex = 11
        Me.lbl32.Text = "."
        Me.lbl32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl31
        '
        Me.lbl31.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl31.Location = New System.Drawing.Point(6, 159)
        Me.lbl31.Name = "lbl31"
        Me.lbl31.Size = New System.Drawing.Size(70, 75)
        Me.lbl31.TabIndex = 10
        Me.lbl31.Text = "."
        Me.lbl31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl25
        '
        Me.lbl25.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl25.Location = New System.Drawing.Point(322, 81)
        Me.lbl25.Name = "lbl25"
        Me.lbl25.Size = New System.Drawing.Size(72, 75)
        Me.lbl25.TabIndex = 9
        Me.lbl25.Text = "."
        Me.lbl25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl24
        '
        Me.lbl24.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl24.Location = New System.Drawing.Point(243, 81)
        Me.lbl24.Name = "lbl24"
        Me.lbl24.Size = New System.Drawing.Size(70, 75)
        Me.lbl24.TabIndex = 8
        Me.lbl24.Text = "."
        Me.lbl24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl23
        '
        Me.lbl23.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl23.Location = New System.Drawing.Point(164, 81)
        Me.lbl23.Name = "lbl23"
        Me.lbl23.Size = New System.Drawing.Size(70, 75)
        Me.lbl23.TabIndex = 7
        Me.lbl23.Text = "."
        Me.lbl23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl22
        '
        Me.lbl22.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl22.Location = New System.Drawing.Point(85, 81)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(70, 75)
        Me.lbl22.TabIndex = 6
        Me.lbl22.Text = "."
        Me.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl21
        '
        Me.lbl21.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl21.Location = New System.Drawing.Point(6, 81)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(70, 75)
        Me.lbl21.TabIndex = 5
        Me.lbl21.Text = "."
        Me.lbl21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl15
        '
        Me.lbl15.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15.Location = New System.Drawing.Point(322, 3)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(72, 75)
        Me.lbl15.TabIndex = 4
        Me.lbl15.Text = "."
        Me.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl14
        '
        Me.lbl14.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.Location = New System.Drawing.Point(243, 3)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(70, 75)
        Me.lbl14.TabIndex = 3
        Me.lbl14.Text = "."
        Me.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl13
        '
        Me.lbl13.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.Location = New System.Drawing.Point(164, 3)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(70, 75)
        Me.lbl13.TabIndex = 2
        Me.lbl13.Text = "."
        Me.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl12
        '
        Me.lbl12.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.Location = New System.Drawing.Point(85, 3)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(70, 75)
        Me.lbl12.TabIndex = 1
        Me.lbl12.Text = "."
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl11
        '
        Me.lbl11.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbl11.Font = New System.Drawing.Font("Arial", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.Location = New System.Drawing.Point(6, 3)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(70, 75)
        Me.lbl11.TabIndex = 0
        Me.lbl11.Text = "."
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSecret
        '
        Me.txtSecret.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSecret.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecret.Location = New System.Drawing.Point(102, 59)
        Me.txtSecret.MaxLength = 5
        Me.txtSecret.Name = "txtSecret"
        Me.txtSecret.Size = New System.Drawing.Size(119, 45)
        Me.txtSecret.TabIndex = 1
        Me.txtSecret.UseSystemPasswordChar = True
        Me.txtSecret.WordWrap = False
        '
        'txtGuess
        '
        Me.txtGuess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuess.Location = New System.Drawing.Point(102, 122)
        Me.txtGuess.MaxLength = 5
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(119, 45)
        Me.txtGuess.TabIndex = 2
        Me.txtGuess.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(227, 71)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        Me.btnSubmit.Visible = False
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(227, 131)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 4
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        Me.btnGuess.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 175
        '
        'pbInstructions
        '
        Me.pbInstructions.Image = Global.lingo.My.Resources.Resources.SecretInstructions
        Me.pbInstructions.Location = New System.Drawing.Point(20, 182)
        Me.pbInstructions.Name = "pbInstructions"
        Me.pbInstructions.Size = New System.Drawing.Size(323, 325)
        Me.pbInstructions.TabIndex = 5
        Me.pbInstructions.TabStop = False
        '
        'frmLingo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 555)
        Me.Controls.Add(Me.pbInstructions)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.txtSecret)
        Me.Controls.Add(Me.letterTable)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 602)
        Me.MinimumSize = New System.Drawing.Size(800, 602)
        Me.Name = "frmLingo"
        Me.Text = "Lingo"
        Me.letterTable.ResumeLayout(False)
        CType(Me.pbInstructions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents letterTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl55 As System.Windows.Forms.Label
    Friend WithEvents lbl54 As System.Windows.Forms.Label
    Friend WithEvents lbl53 As System.Windows.Forms.Label
    Friend WithEvents lbl52 As System.Windows.Forms.Label
    Friend WithEvents lbl51 As System.Windows.Forms.Label
    Friend WithEvents lbl45 As System.Windows.Forms.Label
    Friend WithEvents lbl44 As System.Windows.Forms.Label
    Friend WithEvents lbl43 As System.Windows.Forms.Label
    Friend WithEvents lbl42 As System.Windows.Forms.Label
    Friend WithEvents lbl41 As System.Windows.Forms.Label
    Friend WithEvents lbl35 As System.Windows.Forms.Label
    Friend WithEvents lbl34 As System.Windows.Forms.Label
    Friend WithEvents lbl33 As System.Windows.Forms.Label
    Friend WithEvents lbl32 As System.Windows.Forms.Label
    Friend WithEvents lbl31 As System.Windows.Forms.Label
    Friend WithEvents lbl25 As System.Windows.Forms.Label
    Friend WithEvents lbl24 As System.Windows.Forms.Label
    Friend WithEvents lbl23 As System.Windows.Forms.Label
    Friend WithEvents lbl22 As System.Windows.Forms.Label
    Friend WithEvents lbl21 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents txtSecret As System.Windows.Forms.TextBox
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lbl62 As System.Windows.Forms.Label
    Friend WithEvents lbl61 As System.Windows.Forms.Label
    Friend WithEvents lbl63 As System.Windows.Forms.Label
    Friend WithEvents lbl65 As System.Windows.Forms.Label
    Friend WithEvents lbl64 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbInstructions As System.Windows.Forms.PictureBox

End Class
