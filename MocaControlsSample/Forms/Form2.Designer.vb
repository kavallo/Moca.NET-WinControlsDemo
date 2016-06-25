<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Calendar1 = New Moca.Win.Calendar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSundayColor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHolidayColor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSaturadayColor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRoudoubiColor = New System.Windows.Forms.Label()
        Me.lblTrailColor = New System.Windows.Forms.Label()
        Me.lblTodayColor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDefaultColor = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSelectedColor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Calendar1
        '
        Me.Calendar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Calendar1.BackColor = System.Drawing.Color.White
        Me.Calendar1.DayOfMonthTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Calendar1.DefaultDayBackColor = System.Drawing.Color.White
        Me.Calendar1.DefaultDayFont = New System.Drawing.Font("メイリオ", 15.75!)
        Me.Calendar1.DefaultDayForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Calendar1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Calendar1.HeaderToolTip = Nothing
        Me.Calendar1.Location = New System.Drawing.Point(0, 0)
        Me.Calendar1.MaxDate = New Date(9999, 12, 31, 23, 59, 59, 999)
        Me.Calendar1.MinDate = New Date(CType(0, Long))
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.NextMonthToolTip = Nothing
        Me.Calendar1.Padding = New System.Windows.Forms.Padding(3)
        Me.Calendar1.PreMonthToolTip = Nothing
        Me.Calendar1.SaturdayTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Calendar1.SelectedDayBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Calendar1.SelectedDayFont = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Calendar1.SelectedDayForeColor = System.Drawing.Color.White
        Me.Calendar1.Size = New System.Drawing.Size(493, 401)
        Me.Calendar1.SundayTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Calendar1.TabIndex = 0
        Me.Calendar1.TitleFont = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Calendar1.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Calendar1.TitleFormat = "yyyy'年'M'月'"
        Me.Calendar1.TodayToolTip = Nothing
        Me.Calendar1.TrailStyle = Nothing
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(545, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 12)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "日曜日：３"
        '
        'lblSundayColor
        '
        Me.lblSundayColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblSundayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSundayColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSundayColor.ForeColor = System.Drawing.Color.White
        Me.lblSundayColor.Location = New System.Drawing.Point(500, 108)
        Me.lblSundayColor.Name = "lblSundayColor"
        Me.lblSundayColor.Size = New System.Drawing.Size(39, 24)
        Me.lblSundayColor.TabIndex = 49
        Me.lblSundayColor.Text = "31"
        Me.lblSundayColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(545, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 12)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "祝日：２"
        '
        'lblHolidayColor
        '
        Me.lblHolidayColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHolidayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHolidayColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHolidayColor.ForeColor = System.Drawing.Color.White
        Me.lblHolidayColor.Location = New System.Drawing.Point(500, 75)
        Me.lblHolidayColor.Name = "lblHolidayColor"
        Me.lblHolidayColor.Size = New System.Drawing.Size(39, 24)
        Me.lblHolidayColor.TabIndex = 47
        Me.lblHolidayColor.Text = "31"
        Me.lblHolidayColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(545, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 12)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "土曜日：１"
        '
        'lblSaturadayColor
        '
        Me.lblSaturadayColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lblSaturadayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaturadayColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSaturadayColor.ForeColor = System.Drawing.Color.White
        Me.lblSaturadayColor.Location = New System.Drawing.Point(500, 42)
        Me.lblSaturadayColor.Name = "lblSaturadayColor"
        Me.lblSaturadayColor.Size = New System.Drawing.Size(39, 24)
        Me.lblSaturadayColor.TabIndex = 45
        Me.lblSaturadayColor.Text = "31"
        Me.lblSaturadayColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(545, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 12)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "運行日：０"
        '
        'lblRoudoubiColor
        '
        Me.lblRoudoubiColor.BackColor = System.Drawing.Color.White
        Me.lblRoudoubiColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoudoubiColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblRoudoubiColor.Location = New System.Drawing.Point(500, 9)
        Me.lblRoudoubiColor.Name = "lblRoudoubiColor"
        Me.lblRoudoubiColor.Size = New System.Drawing.Size(39, 24)
        Me.lblRoudoubiColor.TabIndex = 43
        Me.lblRoudoubiColor.Text = "31"
        Me.lblRoudoubiColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrailColor
        '
        Me.lblTrailColor.BackColor = System.Drawing.Color.White
        Me.lblTrailColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrailColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTrailColor.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTrailColor.Location = New System.Drawing.Point(500, 174)
        Me.lblTrailColor.Name = "lblTrailColor"
        Me.lblTrailColor.Size = New System.Drawing.Size(39, 24)
        Me.lblTrailColor.TabIndex = 42
        Me.lblTrailColor.Text = "31"
        Me.lblTrailColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTodayColor
        '
        Me.lblTodayColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblTodayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTodayColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTodayColor.Location = New System.Drawing.Point(500, 141)
        Me.lblTodayColor.Name = "lblTodayColor"
        Me.lblTodayColor.Size = New System.Drawing.Size(39, 24)
        Me.lblTodayColor.TabIndex = 41
        Me.lblTodayColor.Text = "31"
        Me.lblTodayColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(545, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "本日"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(545, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "無効日"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(545, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 12)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "デフォルト"
        '
        'lblDefaultColor
        '
        Me.lblDefaultColor.BackColor = System.Drawing.Color.White
        Me.lblDefaultColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDefaultColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDefaultColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDefaultColor.Location = New System.Drawing.Point(500, 207)
        Me.lblDefaultColor.Name = "lblDefaultColor"
        Me.lblDefaultColor.Size = New System.Drawing.Size(39, 24)
        Me.lblDefaultColor.TabIndex = 53
        Me.lblDefaultColor.Text = "31"
        Me.lblDefaultColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(545, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "選択中"
        '
        'lblSelectedColor
        '
        Me.lblSelectedColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelectedColor.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSelectedColor.ForeColor = System.Drawing.Color.White
        Me.lblSelectedColor.Location = New System.Drawing.Point(500, 240)
        Me.lblSelectedColor.Name = "lblSelectedColor"
        Me.lblSelectedColor.Size = New System.Drawing.Size(39, 24)
        Me.lblSelectedColor.TabIndex = 55
        Me.lblSelectedColor.Text = "31"
        Me.lblSelectedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 401)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSelectedColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDefaultColor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblSundayColor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblHolidayColor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSaturadayColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRoudoubiColor)
        Me.Controls.Add(Me.lblTrailColor)
        Me.Controls.Add(Me.lblTodayColor)
        Me.Controls.Add(Me.Calendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calendar Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Calendar1 As Moca.Win.Calendar
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents lblSundayColor As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents lblHolidayColor As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents lblSaturadayColor As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents lblRoudoubiColor As System.Windows.Forms.Label
	Friend WithEvents lblTrailColor As System.Windows.Forms.Label
	Friend WithEvents lblTodayColor As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents lblDefaultColor As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents lblSelectedColor As System.Windows.Forms.Label
End Class
