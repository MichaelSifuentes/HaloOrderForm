Public Class Form1
    Private arrMenu() As String = {"Homer", "Bart", "Lisa", "Marge"}

    Private lstCboItem As New ArrayList
    Private lstLblItem As New ArrayList

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        For i As Integer = 1 To (lstCboItem.Count - 1 + Me.txtLines.Text)
            'Get the location from the existing control
            Dim iTop = lstCboItem(i - 1).Location.Y + lstCboItem(i - 1).height
            Dim iLeft = lstCboItem(i - 1).Location.X

            'Create a new control and set its properties
            Dim ctrlCboItem As New ComboBox
            ctrlCboItem.Parent = Me.pnlDetails
            ctrlCboItem.Location = New Point(iLeft, iTop)
            ctrlCboItem.Width = lstCboItem(i - 1).Width
            ctrlCboItem.Height = lstCboItem(i - 1).Height
            ctrlCboItem.Items.AddRange(arrMenu)
            ctrlCboItem.Visible = True

            'Add the control to the panel
            Me.pnlDetails.Controls.Add(ctrlCboItem)

            'Associate the control with an event handler
            'syntax: AddHandler control.event, AddressOf event_procedure_name
            'http://msdn2.microsoft.com/en-us/library/7taxzxka(vs.80).aspx

            AddHandler ctrlCboItem.SelectedIndexChanged, AddressOf cis338 'ctrlCboItem_SelectedIndexChanged

            'Add control to our arraylist of controls
            lstCboItem.Add(ctrlCboItem)

            addLabels(i)

        Next
    End Sub

    Private Sub addLabels(ByVal i As Integer)
        'Get the location from the existing control
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).height
        Dim iLeft = lstLblItem(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlLblItem As New Label
        ctrlLblItem.Parent = Me.pnlDetails
        ctrlLblItem.Location = New Point(iLeft, iTop)
        ctrlLblItem.Width = lstLblItem(i - 1).Width
        ctrlLblItem.Height = lstLblItem(i - 1).Height
        ctrlLblItem.Text = i + 1
        ctrlLblItem.Visible = True

        'Add the control to the panel
        Me.pnlDetails.Controls.Add(ctrlLblItem)

       
        'Add control to our arraylist of controls
        lstLblItem.Add(ctrlLblItem)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load the first control
        ComboBox1.Items.AddRange(arrMenu)


        'Add control to arraylist of controls
        lstCboItem.Add(Me.ComboBox1)
        lstLblItem.Add(Me.lblLine)
    End Sub

    Private Sub cis338(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(CType(sender, ComboBox).SelectedIndex)
    End Sub

    Private Sub ctrlCboItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Event handler for when the combo box selection is changed
        'We are getting an object called sender at run-time
        'the type of object is not known until we run the program
        'We can cast the object to the combobox type using two methods
        'CType or DirectCast. What's the difference?
        'hint: speed, and knowing for sure what type we are getting back
        'http://msdn2.microsoft.com/en-us/library/7k6y2h6x(vs.80).aspx
        MessageBox.Show("Index Changed: " & DirectCast(sender, ComboBox).SelectedIndex)
        MessageBox.Show("Value Changed: " & CType(sender, ComboBox).Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Remove the control from the list
        'Starting from the last element added to the list
        'Do not remove the last existing control from the form
        If (lstCboItem.Count() - 1) > 0 Then
            Dim ctrlCboItem As New ComboBox
            ctrlCboItem = lstCboItem(lstCboItem.Count - 1)
            ctrlCboItem.Visible = False

            'Remove from panel
            pnlDetails.Controls.Remove(ctrlCboItem)

            'Remove association from event handler
            'http://msdn2.microsoft.com/en-us/library/3xz97kac(VS.80).aspx
            RemoveHandler ctrlCboItem.SelectedIndexChanged, AddressOf ctrlCboItem_SelectedIndexChanged

            'Remove from controls arrayList
            lstCboItem.Remove(ctrlCboItem)

            'Release resources
            ctrlCboItem = Nothing
        Else
            MessageBox.Show("Cannot remove the last control!","Line Removal",MessageBoxButtons.OK,MessageBoxIcon.Error)
        End If

    End Sub
End Class
