Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtMessage.Click
        MessageBox.Show("Hello " & txtName.Text)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        txtName.Text = "Hello " & txtName.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAddValue1_TextChanged(sender As Object, e As EventArgs) Handles txtAddValue1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAddValues.Click
        Try
            Dim firstNum As Integer = CInt(txtAddValue1.Text)
            Dim secondNum As Integer = CInt(txtAddValue2.Text)
            Dim sum = firstNum + secondNum

            txtSumAnswer.Text = CStr(sum)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers to sum", "Error")
        Catch ex As Exception
            MessageBox.Show("An unknown error occured", "Error")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAddEqual.Click

    End Sub

    Private Sub txtDivideValue2_TextChanged(sender As Object, e As EventArgs) Handles txtDivideValue2.TextChanged

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Try
            Dim firstNum As Decimal = CDec(txtDivideValue1.Text)
            Dim secondNum As Decimal = CDec(txtDivideValue2.Text)
            Dim intSolution As Integer = CType(firstNum / secondNum, Integer)
            txtDivideAnswer.Text = CStr(intSolution)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers to divide", "Error")
        Catch ex As Exception
            MessageBox.Show("An unknown error occured", "Error")
        End Try
    End Sub
End Class
