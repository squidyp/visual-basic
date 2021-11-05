Public Class frmReport
    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click

        'This the variable to be added with all the user inputs
        Dim sum As Decimal = 0

        'This section is for the Blood work group
        If chkBlood.Checked Then
            If radBasic.Checked Then
                sum += 79.99
            ElseIf radAdvanced.Checked Then
                sum += 129.99
            ElseIf radSugar.Checked Then
                sum += 179.99
            ElseIf radVitamin.Checked Then
                sum += 229.99
            Else
                MessageBox.Show("Please make a selection")

            End If
        End If

        'This section is for the Nutritional Evaluation group
        If chkEval.Checked Then
            If radBronze.Checked Then
                sum += 199.99
            ElseIf radSilver.Checked Then
                sum += 299.99
            ElseIf radGold.Checked Then
                sum += 399.99
            Else
                MessageBox.Show("Please make a selection")
            End If
        End If

        'This section is for the Nutrintional Journals group
        If chkJournals.Checked Then
            If radBronze.Checked Then
                sum += 199.99
            ElseIf radIntake.Checked Then
                sum += 9.99
            ElseIf radActivity.Checked Then
                sum += 14.99
            Else
                MessageBox.Show("Please make a selection")
            End If
        End If
        'Output the total
        txtTotal.Text = sum.ToString("C")
    End Sub

End Class
