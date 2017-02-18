Public Class MaxText

    Private Sub txtMaxText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaxText.TextChanged
        'Declare variables
        'hold maximum length of text to be entered
        Dim maxLength As Integer = txtMaxText.MaxLength

        'holds the length of the text currently entered
        Dim currLength As Integer = txtMaxText.Text.Length

        'Display the number of remaining characters
        lblCharsLeft.Text = maxLength - currLength

        'Display a visual representation of how many characters are left
        'We get closer to the RED as there are less characters left to be entered
        'convert the current length to the number of boxes we
        'have available for display
        Dim visibleControls As Integer = CInt((currLength * 6) / maxLength)

        'Fill a control array with the colored label controls
        Dim arrControls(5) As Control
        arrControls(0) = Me.lbl1
        arrControls(1) = Me.lbl2
        arrControls(2) = Me.lbl3
        arrControls(3) = Me.lbl4
        arrControls(4) = Me.lbl5
        arrControls(5) = Me.lbl6

        'Loop through the colored labels and make a percent
        'of them visible
        For i As Integer = 1 To arrControls.Length
            If (i <= visibleControls) Then
                arrControls(i - 1).Visible = True
            Else
                arrControls(i - 1).Visible = False
            End If
        Next
    End Sub
End Class
