Imports System.Drawing

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _init()

        ' NULLがOKなDateTimePicker
        Me.NullableDateTimePicker1.Value = Nothing

        ' チェックボックスのグループ化
        Me.CheckBoxGroup1.Add(Me.CheckBox1, Moca.Win.TextBoxEx.InputFormatType.Alpha)
        Me.CheckBoxGroup1.Add(Me.CheckBox2, Moca.Win.TextBoxEx.InputFormatType.Digit)
        Me.CheckBoxGroup1.Add(Me.CheckBox3, Moca.Win.TextBoxEx.InputFormatType.Number)
        Me.CheckBoxGroup1.Add(Me.CheckBox4, Moca.Win.TextBoxEx.InputFormatType.Sign)
        Me.CheckBoxGroup1.Add(Me.CheckBox5, Moca.Win.TextBoxEx.InputFormatType.SignWithColor)
        Me.CheckBoxGroup1.Add(Me.CheckBox6, Moca.Win.TextBoxEx.InputFormatType.Symbol)
        Me.CheckBoxGroup1.Add(Me.CheckBox7, Moca.Win.TextBoxEx.InputFormatType.Upper)
        Me.CheckBoxGroup1.Add(Me.CheckBox8, Moca.Win.TextBoxEx.InputFormatType.WithSpace)
        Me.TextBoxEx1.Percision = 3

        ' ラジオボタンのグループ化（コンテナが異なってもOK）
        Me.RadioButtonGroup1.Add(Me.RadioButton1, Me.RadioButton1.Text)
        Me.RadioButtonGroup1.Add(Me.RadioButton2, Me.RadioButton2.Text)
        Me.RadioButtonGroup1.Add(Me.RadioButton3, Me.RadioButton3.Text)

        ' アラートカラー設定
        Me.AlertMessage1.ErrorBackColor = Color.FromArgb(242, 222, 222)
        Me.AlertMessage1.ErrorForeColor = Color.FromArgb(185, 74, 72)
        Me.AlertMessage1.SuccessBackColor = Color.FromArgb(223, 240, 216)
        Me.AlertMessage1.SuccessForeColor = Color.FromArgb(70, 136, 71)
        Me.AlertMessage1.WarnBackColor = Color.FromArgb(252, 248, 227)
        Me.AlertMessage1.WarnForeColor = Color.FromArgb(145, 111, 53)

        Dim lst As New List(Of KeyValuePair(Of String, Integer))
        lst.Add(New KeyValuePair(Of String, Integer)("Test", 1))
        lst.Add(New KeyValuePair(Of String, Integer)("Demo", 2))
        lst.Add(New KeyValuePair(Of String, Integer)("Sample", 3))
        Win.WinUtil.SetComboBox(ComboBoxEx1, lst, "Key", "Value")

        Dim lst2 As New List(Of Entity)
        lst2.Add(New Entity() With {
                .Day = Now,
                .SelectedValue = 2,
                .Text = "abcdefg"
                 })

        DataBinder1.DataSource = lst2
        DataBinder1.DataBinding(NullableDateTimePicker1, "Day")
        DataBinder1.DataBinding(ComboBoxEx1, "SelectedValue")
        DataBinder1.DataBinding(TextBoxEx1, "Text")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.AlertMessage1.Success("Selected CheckBox:" & String.Join(",", Me.CheckBoxGroup1.GetSelectedValue))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.AlertMessage1.Success("Selected RadioButton:" & Me.RadioButtonGroup1.SelectedValue)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using dlg As Form2 = New Form2
            dlg.ShowDialog(Me)
        End Using
    End Sub

    Private Sub _RadioButton_Click(sender As Object, e As EventArgs)
        Me.AlertMessage1.Clear()
        Select Case Me.RadioButtonGroup1.SelectedValue
            Case Me.RadioButton1.Text
                Me.AlertMessage1.Success("OK")
            Case Me.RadioButton2.Text
                Me.AlertMessage1.Warn("Warning")
            Case Me.RadioButton3.Text
                Me.AlertMessage1.Error("Error")
        End Select
    End Sub

    Private Sub _CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Me.TextBoxEx1.Text = String.Empty
        Me.TextBoxEx1.InputFormat = Moca.Win.TextBoxEx.InputFormatType.None

        For Each value As Moca.Win.TextBoxEx.InputFormatType In Me.CheckBoxGroup1.GetSelectedValue
            Me.TextBoxEx1.InputFormat = Me.TextBoxEx1.InputFormat Or value
        Next
    End Sub

#Region " Methods "

    Private Sub _init()
        Me.RadioButton1.Text = "Success Alert"
        Me.RadioButton2.Text = "Warn Alert"
        Me.RadioButton3.Text = "Error Alert"
        AddHandler Me.RadioButton1.Click, AddressOf _RadioButton_Click
        AddHandler Me.RadioButton2.Click, AddressOf _RadioButton_Click
        AddHandler Me.RadioButton3.Click, AddressOf _RadioButton_Click
        Me.CheckBox1.Text = Moca.Win.TextBoxEx.InputFormatType.Alpha.ToString
        Me.CheckBox2.Text = Moca.Win.TextBoxEx.InputFormatType.Digit.ToString
        Me.CheckBox3.Text = Moca.Win.TextBoxEx.InputFormatType.Number.ToString
        Me.CheckBox4.Text = Moca.Win.TextBoxEx.InputFormatType.Sign.ToString
        Me.CheckBox5.Text = Moca.Win.TextBoxEx.InputFormatType.SignWithColor.ToString
        Me.CheckBox6.Text = Moca.Win.TextBoxEx.InputFormatType.Symbol.ToString
        Me.CheckBox7.Text = Moca.Win.TextBoxEx.InputFormatType.Upper.ToString
        Me.CheckBox8.Text = Moca.Win.TextBoxEx.InputFormatType.WithSpace.ToString
        AddHandler Me.CheckBox1.CheckedChanged, AddressOf _CheckBox_CheckedChanged
        AddHandler Me.CheckBox2.CheckedChanged, AddressOf _CheckBox_CheckedChanged
        AddHandler Me.CheckBox3.CheckedChanged, AddressOf _CheckBox_CheckedChanged
        AddHandler Me.CheckBox4.CheckedChanged, AddressOf _CheckBox_CheckedChanged
        AddHandler Me.CheckBox5.CheckedChanged, AddressOf _CheckBox_CheckedChanged
        AddHandler Me.CheckBox6.CheckedChanged, AddressOf _CheckBox_CheckedChanged
        AddHandler Me.CheckBox7.CheckedChanged, AddressOf _CheckBox_CheckedChanged
        AddHandler Me.CheckBox8.CheckedChanged, AddressOf _CheckBox_CheckedChanged
    End Sub

#End Region

End Class
