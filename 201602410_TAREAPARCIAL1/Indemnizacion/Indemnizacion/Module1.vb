Module Module1
    Public Sueldo As Integer
    Public Años As Integer
    Public Bono As Double
    Public Aguinaldo As Double
    Public P_extra As Double
    Public C_extra As Double
    Public Subt As Double
    Public Total As Double

    Sub Mostrar_Resultados()
        MsgBox(Bono)
    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
    End Sub
End Module
