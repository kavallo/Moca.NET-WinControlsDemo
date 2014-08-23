<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MocaDi1 = New Moca.Win.MocaDi()
        Me.NullableDateTimePicker1 = New Moca.Win.NullableDateTimePicker()
        Me.TextBoxEx1 = New Moca.Win.TextBoxEx(Me.components)
        Me.WysiwygEditor1 = New Moca.Win.WYSIWYGEditor()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGroup1 = New Moca.Win.CheckBoxGroup(Me.components)
        Me.RadioButtonGroup1 = New Moca.Win.RadioButtonGroup(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.AlertMessage1 = New Moca.Win.AlertMessage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DataBinder1 = New Moca.Win.DataBinder(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MocaDi1
        '
        Me.MocaDi1.AutoSize = True
        Me.MocaDi1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MocaDi1.BackgroundImage = CType(resources.GetObject("MocaDi1.BackgroundImage"), System.Drawing.Image)
        Me.MocaDi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MocaDi1.Location = New System.Drawing.Point(0, 0)
        Me.MocaDi1.Margin = New System.Windows.Forms.Padding(0)
        Me.MocaDi1.MaximumSize = New System.Drawing.Size(16, 16)
        Me.MocaDi1.MinimumSize = New System.Drawing.Size(16, 16)
        Me.MocaDi1.Name = "MocaDi1"
        Me.MocaDi1.Size = New System.Drawing.Size(16, 16)
        Me.MocaDi1.TabIndex = 0
        Me.MocaDi1.TabStop = False
        '
        'NullableDateTimePicker1
        '
        Me.NullableDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.NullableDateTimePicker1.FormatAsString = "yyyy'年'M'月'd'日'"
        Me.NullableDateTimePicker1.Location = New System.Drawing.Point(12, 72)
        Me.NullableDateTimePicker1.Name = "NullableDateTimePicker1"
        Me.NullableDateTimePicker1.NullValue = ""
        Me.NullableDateTimePicker1.Size = New System.Drawing.Size(129, 19)
        Me.NullableDateTimePicker1.TabIndex = 1
        Me.NullableDateTimePicker1.Value = New Date(2014, 8, 22, 12, 13, 30, 969)
        '
        'TextBoxEx1
        '
        Me.TextBoxEx1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBoxEx1.InputFormat = Moca.Win.TextBoxEx.InputFormatType.None
        Me.TextBoxEx1.Location = New System.Drawing.Point(10, 32)
        Me.TextBoxEx1.MaxLength = 12
        Me.TextBoxEx1.Name = "TextBoxEx1"
        Me.TextBoxEx1.NegativeColor = System.Drawing.Color.Red
        Me.TextBoxEx1.NumericScale = 0
        Me.TextBoxEx1.Percision = 0
        Me.TextBoxEx1.PercisionSign = False
        Me.TextBoxEx1.Separator = ""
        Me.TextBoxEx1.Size = New System.Drawing.Size(156, 19)
        Me.TextBoxEx1.TabIndex = 2
        '
        'WysiwygEditor1
        '
        Me.WysiwygEditor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.WysiwygEditor1.BackColor = System.Drawing.Color.Transparent
        Me.WysiwygEditor1.Location = New System.Drawing.Point(10, 95)
        Me.WysiwygEditor1.Margin = New System.Windows.Forms.Padding(1)
        Me.WysiwygEditor1.Name = "WysiwygEditor1"
        Me.WysiwygEditor1.Rtf = "{\rtf1\ansi\ansicpg932\deff0\deflang1033\deflangfe1041{\fonttbl{\f0\fnil\fcharset" & _
    "128 MS UI Gothic;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang1041\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.WysiwygEditor1.Size = New System.Drawing.Size(358, 293)
        Me.WysiwygEditor1.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(13, 84)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(13, 110)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'RadioButtonGroup1
        '
        Me.RadioButtonGroup1.SelectedButton = Nothing
        Me.RadioButtonGroup1.SelectedValue = Nothing
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.Location = New System.Drawing.Point(10, 43)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(166, 21)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'AlertMessage1
        '
        Me.AlertMessage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.AlertMessage1.DefaultMessageBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AlertMessage1.DefaultMessageForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AlertMessage1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AlertMessage1.ErrorBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.AlertMessage1.ErrorForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.AlertMessage1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AlertMessage1.Location = New System.Drawing.Point(0, 0)
        Me.AlertMessage1.Margin = New System.Windows.Forms.Padding(0)
        Me.AlertMessage1.Name = "AlertMessage1"
        Me.AlertMessage1.Size = New System.Drawing.Size(550, 40)
        Me.AlertMessage1.SuccessBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AlertMessage1.SuccessForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.AlertMessage1.TabIndex = 10
        Me.AlertMessage1.WarnBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.AlertMessage1.WarnForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox8)
        Me.Panel1.Controls.Add(Me.CheckBox7)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.CheckBox6)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.TextBoxEx1)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Location = New System.Drawing.Point(372, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 350)
        Me.Panel1.TabIndex = 11
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(13, 240)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox8.TabIndex = 18
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(13, 214)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox7.TabIndex = 17
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Calendar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(13, 188)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox6.TabIndex = 16
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Get Selected RadioButton"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(13, 162)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox5.TabIndex = 15
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Get Selected CheckBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(13, 136)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox4.TabIndex = 14
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(166, 22)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.Location = New System.Drawing.Point(195, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(166, 22)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DataBinder1
        '
        Me.DataBinder1.DataMember = ""
        Me.DataBinder1.DataSource = Nothing
        Me.DataBinder1.Position = -1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 40)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Moca.NET Windows Form Controls Sample"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "<- Delete Key = NULL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 395)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AlertMessage1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.WysiwygEditor1)
        Me.Controls.Add(Me.NullableDateTimePicker1)
        Me.Controls.Add(Me.MocaDi1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moca.NET Windows Form Controls Demo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents MocaDi1 As Moca.Win.MocaDi
	Friend WithEvents NullableDateTimePicker1 As Moca.Win.NullableDateTimePicker
	Friend WithEvents TextBoxEx1 As Moca.Win.TextBoxEx
	Friend WithEvents WysiwygEditor1 As Moca.Win.WYSIWYGEditor
	Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
	Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
	Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
	Friend WithEvents CheckBoxGroup1 As Moca.Win.CheckBoxGroup
	Friend WithEvents RadioButtonGroup1 As Moca.Win.RadioButtonGroup
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents AlertMessage1 As Moca.Win.AlertMessage
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents DataBinder1 As Moca.Win.DataBinder
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents Button3 As System.Windows.Forms.Button
	Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
	Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
	Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
	Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
	Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
