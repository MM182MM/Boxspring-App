Public Class KlantenbestandForm
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KlantenbestandDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.KlantenbestandDataSet.Table1)

    End Sub

    Private Sub ToevoegenBTN_Click(sender As Object, e As EventArgs) Handles ToevoegenBTN.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub VorigeBTN_Click(sender As Object, e As EventArgs) Handles VorigeBTN.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub VolgendeBTN_Click(sender As Object, e As EventArgs) Handles VolgendeBTN.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub OpslaanBTN_Click(sender As Object, e As EventArgs) Handles OpslaanBTN.Click
        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(KlantenbestandDataSet.Table1)
        MessageBox.Show("OK MAURITS")

SaveErr:
        Exit Sub

    End Sub

    Private Sub VerwijderenBTN_Click(sender As Object, e As EventArgs) Handles VerwijderenBTN.Click
        Table1BindingSource.RemoveCurrent()
    End Sub

    Private Sub AfsluitenBTN_Click(sender As Object, e As EventArgs) Handles AfsluitenBTN.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Dieks_btn.Click

    End Sub
End Class
