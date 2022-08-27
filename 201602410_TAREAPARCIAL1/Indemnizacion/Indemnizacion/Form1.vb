Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            MsgBox("ERROR, NO INGRESÓ NOMBRE DEL EMPLEADO")
            TextBox1.Focus()
            Exit Sub
        End If

        Sueldo = TextBox2.Text
        Años = TextBox3.Text
        Bono = Sueldo / 12
        Aguinaldo = Sueldo / 12

        If (RadioButton1.Checked) Then
            P_extra = Sueldo * 0.06
        ElseIf (RadioButton2.Checked) Then
            P_extra = Sueldo * 0.04
        ElseIf (RadioButton3.Checked) Then
            P_extra = Sueldo * 0.02
        Else MsgBox("ERROR, NO SELECCINÓ PUESTO QUE DESEMPEÑA")
        End If

        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub


    End Sub
End Class
