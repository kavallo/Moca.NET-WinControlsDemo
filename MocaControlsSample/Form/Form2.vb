Public Class Form2

	''' <summary>当日</summary>
	Public Const C_STYLETODAY As String = "ToDay"
	''' <summary>営業日</summary>
	Public Const C_STYLEWORKDAY As String = "WorkDay"
	''' <summary>土曜日</summary>
	Public Const C_STYLESATURDAY As String = "Saturday"
	''' <summary>日曜日</summary>
	Public Const C_STYLESUNDAY As String = "Sunday"
	''' <summary>祝日</summary>
	Public Const C_STYLEHOLIDAY As String = "Holiday"

	''' <summary>日付種別</summary>
	Public HolidayIDs() As String = New String() {String.Empty, C_STYLESUNDAY, C_STYLESATURDAY, C_STYLEHOLIDAY}

	''' <summary>
	''' 休日種別
	''' </summary>
	''' <remarks></remarks>
	Public Enum HolidayType
		''' <summary>営業日</summary>
		None = 0
		''' <summary>日曜日</summary>
		Sunday
		''' <summary>土曜日</summary>
		Saturday
		''' <summary>休日</summary>
		Holiday
	End Enum

#Region " コンストラクタ "

	Public Sub New()

		' この呼び出しはデザイナーで必要です。
		InitializeComponent()

		' InitializeComponent() 呼び出しの後で初期化を追加します。

		' カレンダー初期設定
		_initializeStyle()
	End Sub

#End Region

#Region " Handles "

	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' カレンダー表示範囲設定
		Me.Calendar1.MinDate = Date.Today
		Me.Calendar1.MaxDate = Date.Today.AddMonths(3)
	End Sub

	''' <summary>
	''' カレンダーで日が変更された時
	''' </summary>
	''' <param name="day">変更された日</param>
	''' <param name="e">日変更イベント引数</param>
	''' <remarks></remarks>
	Private Sub Calendar1_ChangedDay(day As Date, e As System.EventArgs) Handles Calendar1.ChangedDay
	End Sub

	''' <summary>
	''' カレンダーで月が変更された時
	''' </summary>
	''' <param name="month">変更された月</param>
	''' <param name="e">月変更イベント引数</param>
	''' <remarks></remarks>
	Private Sub Calendar1_ChangedMonth(month As Date, e As System.EventArgs) Handles Calendar1.ChangedMonth
		Dim startDay As Integer = 1
		For value As Integer = startDay To Date.DaysInMonth(month.Year, month.Month)
			Dim day As Date = New Date(month.Year, month.Month, value)

			If Me.Calendar1.Holiday.ContainsKey(day) Then
				Continue For
			End If

			Select Case day.DayOfWeek
				Case DayOfWeek.Saturday
					Me.Calendar1.Holiday.Add(day, C_STYLESATURDAY)
				Case DayOfWeek.Sunday
					Me.Calendar1.Holiday.Add(day, C_STYLESUNDAY)
			End Select
		Next
	End Sub

	''' <summary>
	''' カレンダーでキー押下時
	''' </summary>
	''' <param name="day">押下された日付</param>
	''' <param name="e">キーイベント引数</param>
	''' <remarks></remarks>
	Private Sub Calendar1_DayKeyDown(day As Date, e As System.Windows.Forms.KeyEventArgs) Handles Calendar1.DayKeyDown
		' ０～３が押下されたときのみ処理する
		Select Case e.KeyCode
			Case Keys.D0, Keys.D1, Keys.D2, Keys.D3 _
			 , Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3
				If Me.Calendar1.IsHoliday(day) Then
					Me.Calendar1.Holiday.Remove(day)
				End If
			Case Else
				Return
		End Select

		Dim styleName As String
		Dim styleType As HolidayType

		Select Case e.KeyCode
			Case Keys.D1, Keys.NumPad1	' 土曜日
				styleName = C_STYLESATURDAY
				styleType = HolidayType.Saturday
			Case Keys.D2, Keys.NumPad2	' 祝日
				styleName = C_STYLEHOLIDAY
				styleType = HolidayType.Holiday
			Case Keys.D3, Keys.NumPad3	' 日曜日
				styleName = C_STYLESUNDAY
				styleType = HolidayType.Sunday
			Case Else					' 休日以外
				styleName = vbNullString
				styleType = HolidayType.None
		End Select

		Me.Calendar1.Holiday.Add(day, HolidayIDs(styleType))
		Me.Calendar1.Value = day
	End Sub

#End Region
#Region " Methods "

	''' <summary>
	''' カレンダースタイル初期化
	''' </summary>
	''' <remarks></remarks>
	Private Sub _initializeStyle()
		' 各日のスタイル設定
		_calendarStyleSetHoliday(C_STYLESATURDAY, Me.lblSaturadayColor, "土曜日")
		_calendarStyleSetHoliday(C_STYLESUNDAY, Me.lblSundayColor, "日曜日")
		_calendarStyleSetHoliday(C_STYLEHOLIDAY, Me.lblHolidayColor, "祝日")

		' ツールチップ設定
		Me.Calendar1.HeaderToolTip = "年月変更"
		Me.Calendar1.NextMonthToolTip = "次月へ"
		Me.Calendar1.PreMonthToolTip = "前月へ"
		Me.Calendar1.TodayToolTip = "本日へ"

		' 選択されている日付のスタイル設定
		Me.Calendar1.SelectedDayForeColor = Me.lblSelectedColor.ForeColor
		Me.Calendar1.SelectedDayFont = Me.lblSelectedColor.Font
		Me.Calendar1.SelectedDayBackColor = Me.lblSelectedColor.BackColor

		' 標準の日付のスタイル設定
		Me.Calendar1.DefaultDayForeColor = Me.lblDefaultColor.ForeColor
		Me.Calendar1.DefaultDayFont = Me.lblDefaultColor.Font
		Me.Calendar1.DefaultDayBackColor = Me.lblDefaultColor.BackColor
	End Sub

	''' <summary>
	''' 休日スタイル設定
	''' </summary>
	''' <param name="styleName">スタイル名</param>
	''' <param name="styleTemplate">テンプレートのラベルコントロール</param>
	''' <param name="holidayName">休日名</param>
	''' <returns>日のスタイル</returns>
	''' <remarks></remarks>
	Private Function _calendarStyleSetHoliday(ByVal styleName As String, ByVal styleTemplate As Label, Optional ByVal holidayName As String = vbNullString) As Moca.Win.DayStyle
		Dim style As Moca.Win.DayStyle

		style = New Moca.Win.DayStyle(styleName)
		style.Title = holidayName
		style.BackColor = styleTemplate.BackColor
		style.ForeColor = styleTemplate.ForeColor
		style.Font = styleTemplate.Font
		Me.Calendar1.HolidayStyles.Add(style.Name, style)

		Return style
	End Function

#End Region

End Class
