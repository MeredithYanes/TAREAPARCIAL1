Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Math.Round(Bono)
        Mostrar_Resultados()

        TextBox2.Text = Aguinaldo
        Subt = (Bono + Aguinaldo + Sueldo) * Años
        TextBox3.Text = Math.Round(Subt, 2)
        TextBox4.Text = P_extra

        If (Form1.RadioButton4.Checked) Then
            C_extra = 0.05 * Subt
        ElseIf (Form1.RadioButton5.Checked) Then
            C_extra = 0.03 * Subt
        ElseIf MsgBox("ERROR, NO SELECCIONÓ COBRO EXTRA") Then
            Me.Hide()
            Form1.Show()
        End If
        TextBox5.Text = C_extra

        Total = Subt + P_extra - C_extra
        TextBox6.Text = Math.Round(Total, 2)
    End Sub
End Class