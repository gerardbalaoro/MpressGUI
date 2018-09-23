<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.helpbtn = New MetroFramework.Controls.MetroButton()
        Me.Compress = New MetroFramework.Controls.MetroButton()
        Me.Browse = New MetroFramework.Controls.MetroButton()
        Me.OutFile = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Import = New MetroFramework.Controls.MetroButton()
        Me.OrigFile = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Aboutbtn = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.upperL = New MetroFramework.Controls.MetroCheckBox()
        Me.i = New MetroFramework.Controls.MetroCheckBox()
        Me.u = New MetroFramework.Controls.MetroCheckBox()
        Me.lowerx = New MetroFramework.Controls.MetroCheckBox()
        Me.m = New MetroFramework.Controls.MetroCheckBox()
        Me.lowers = New MetroFramework.Controls.MetroCheckBox()
        Me.b = New MetroFramework.Controls.MetroCheckBox()
        Me.uppers = New MetroFramework.Controls.MetroCheckBox()
        Me.r = New MetroFramework.Controls.MetroCheckBox()
        Me.Log = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.AutoScroll = True
        Me.MetroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.helpbtn)
        Me.MetroPanel1.Controls.Add(Me.Compress)
        Me.MetroPanel1.Controls.Add(Me.Browse)
        Me.MetroPanel1.Controls.Add(Me.OutFile)
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.Controls.Add(Me.Import)
        Me.MetroPanel1.Controls.Add(Me.OrigFile)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.HorizontalScrollbar = True
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(13, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(375, 163)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Black
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbar = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'helpbtn
        '
        Me.helpbtn.Location = New System.Drawing.Point(9, 129)
        Me.helpbtn.Name = "helpbtn"
        Me.helpbtn.Size = New System.Drawing.Size(23, 23)
        Me.helpbtn.TabIndex = 9
        Me.helpbtn.Text = "?"
        '
        'Compress
        '
        Me.Compress.Location = New System.Drawing.Point(38, 129)
        Me.Compress.Name = "Compress"
        Me.Compress.Size = New System.Drawing.Size(325, 23)
        Me.Compress.Style = MetroFramework.MetroColorStyle.Green
        Me.Compress.TabIndex = 8
        Me.Compress.Text = "Compress"
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(304, 89)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(59, 23)
        Me.Browse.TabIndex = 7
        Me.Browse.Text = "Browse"
        '
        'OutFile
        '
        Me.OutFile.Location = New System.Drawing.Point(9, 89)
        Me.OutFile.Name = "OutFile"
        Me.OutFile.Size = New System.Drawing.Size(289, 23)
        Me.OutFile.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Output File:"
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(305, 33)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(59, 23)
        Me.Import.TabIndex = 4
        Me.Import.Text = "Import"
        '
        'OrigFile
        '
        Me.OrigFile.Location = New System.Drawing.Point(10, 33)
        Me.OrigFile.Name = "OrigFile"
        Me.OrigFile.Size = New System.Drawing.Size(289, 23)
        Me.OrigFile.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Original File:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Options:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(10, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Log:"
        '
        'Aboutbtn
        '
        Me.Aboutbtn.Location = New System.Drawing.Point(138, 0)
        Me.Aboutbtn.Name = "Aboutbtn"
        Me.Aboutbtn.Size = New System.Drawing.Size(75, 23)
        Me.Aboutbtn.TabIndex = 16
        Me.Aboutbtn.Text = "About"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel3.Controls.Add(Me.Aboutbtn)
        Me.MetroPanel3.Controls.Add(Me.Label3)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(399, 60)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(213, 292)
        Me.MetroPanel3.TabIndex = 17
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.upperL)
        Me.MetroPanel2.Controls.Add(Me.i)
        Me.MetroPanel2.Controls.Add(Me.u)
        Me.MetroPanel2.Controls.Add(Me.lowerx)
        Me.MetroPanel2.Controls.Add(Me.m)
        Me.MetroPanel2.Controls.Add(Me.lowers)
        Me.MetroPanel2.Controls.Add(Me.b)
        Me.MetroPanel2.Controls.Add(Me.uppers)
        Me.MetroPanel2.Controls.Add(Me.r)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 29)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(213, 263)
        Me.MetroPanel2.TabIndex = 17
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'upperL
        '
        Me.upperL.AutoSize = True
        Me.upperL.BackColor = System.Drawing.Color.Transparent
        Me.upperL.Location = New System.Drawing.Point(5, 89)
        Me.upperL.Name = "upperL"
        Me.upperL.Size = New System.Drawing.Size(95, 15)
        Me.upperL.Style = MetroFramework.MetroColorStyle.Green
        Me.upperL.TabIndex = 38
        Me.upperL.Text = "Short liscense"
        Me.upperL.UseVisualStyleBackColor = False
        '
        'i
        '
        Me.i.AutoSize = True
        Me.i.BackColor = System.Drawing.Color.Transparent
        Me.i.Location = New System.Drawing.Point(5, 5)
        Me.i.Name = "i"
        Me.i.Size = New System.Drawing.Size(160, 15)
        Me.i.Style = MetroFramework.MetroColorStyle.Green
        Me.i.TabIndex = 30
        Me.i.Text = "Ignore compression result"
        Me.i.UseVisualStyleBackColor = False
        '
        'u
        '
        Me.u.AutoSize = True
        Me.u.BackColor = System.Drawing.Color.Transparent
        Me.u.Location = New System.Drawing.Point(5, 111)
        Me.u.Name = "u"
        Me.u.Size = New System.Drawing.Size(176, 30)
        Me.u.Style = MetroFramework.MetroColorStyle.Green
        Me.u.TabIndex = 34
        Me.u.Text = "Do not remove unsupported " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "architectures (mac osx, -ub)"
        Me.u.UseVisualStyleBackColor = False
        '
        'lowerx
        '
        Me.lowerx.AutoSize = True
        Me.lowerx.BackColor = System.Drawing.Color.Transparent
        Me.lowerx.Location = New System.Drawing.Point(5, 219)
        Me.lowerx.Name = "lowerx"
        Me.lowerx.Size = New System.Drawing.Size(162, 30)
        Me.lowerx.Style = MetroFramework.MetroColorStyle.Green
        Me.lowerx.TabIndex = 32
        Me.lowerx.Text = "Don't manage exceptions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(64 bit PE32+)"
        Me.lowerx.UseVisualStyleBackColor = False
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.BackColor = System.Drawing.Color.Transparent
        Me.m.Location = New System.Drawing.Point(5, 47)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(129, 15)
        Me.m.Style = MetroFramework.MetroColorStyle.Green
        Me.m.TabIndex = 35
        Me.m.Text = "Force to use LZMAT"
        Me.m.UseVisualStyleBackColor = False
        '
        'lowers
        '
        Me.lowers.AutoSize = True
        Me.lowers.BackColor = System.Drawing.Color.Transparent
        Me.lowers.Location = New System.Drawing.Point(5, 183)
        Me.lowers.Name = "lowers"
        Me.lowers.Size = New System.Drawing.Size(203, 30)
        Me.lowers.Style = MetroFramework.MetroColorStyle.Green
        Me.lowers.TabIndex = 37
        Me.lowers.Text = "Search the best LZMA parameters " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(slower but better)"
        Me.lowers.UseVisualStyleBackColor = False
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.BackColor = System.Drawing.Color.Transparent
        Me.b.Location = New System.Drawing.Point(5, 26)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(118, 15)
        Me.b.Style = MetroFramework.MetroColorStyle.Green
        Me.b.TabIndex = 31
        Me.b.Text = "Create backup file"
        Me.b.UseVisualStyleBackColor = False
        '
        'uppers
        '
        Me.uppers.AutoSize = True
        Me.uppers.BackColor = System.Drawing.Color.Transparent
        Me.uppers.Location = New System.Drawing.Point(5, 147)
        Me.uppers.Name = "uppers"
        Me.uppers.Size = New System.Drawing.Size(158, 30)
        Me.uppers.Style = MetroFramework.MetroColorStyle.Green
        Me.uppers.TabIndex = 33
        Me.uppers.Text = "Don't patch strong name " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "signature (.NET)"
        Me.uppers.UseVisualStyleBackColor = False
        '
        'r
        '
        Me.r.AutoSize = True
        Me.r.BackColor = System.Drawing.Color.Transparent
        Me.r.Location = New System.Drawing.Point(5, 68)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(166, 15)
        Me.r.Style = MetroFramework.MetroColorStyle.Green
        Me.r.TabIndex = 36
        Me.r.Text = "Do not compress resources"
        Me.r.UseVisualStyleBackColor = False
        '
        'Log
        '
        Me.Log.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Log.Enabled = False
        Me.Log.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Log.Location = New System.Drawing.Point(-1, -1)
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(375, 100)
        Me.Log.TabIndex = 15
        Me.Log.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Matcode comPRESSor for executables" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright (c) 2007-2009, Vitaly Evseenko, M" & _
    "ATCODE Software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mpress Graphic User Interface" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by Gerard Balaoro"
        Me.Log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Log)
        Me.Panel1.Location = New System.Drawing.Point(13, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 100)
        Me.Panel1.TabIndex = 19
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(4.0!, 7.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(625, 363)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "MainFrm"
        Me.Padding = New System.Windows.Forms.Padding(13, 60, 13, 11)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Mpress Graphic User Interface"
        Me.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Browse As MetroFramework.Controls.MetroButton
    Friend WithEvents OutFile As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Import As MetroFramework.Controls.MetroButton
    Friend WithEvents OrigFile As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Compress As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Aboutbtn As MetroFramework.Controls.MetroButton
    Friend WithEvents helpbtn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents upperL As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents i As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents u As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lowerx As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents m As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lowers As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents b As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents uppers As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents r As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Log As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
