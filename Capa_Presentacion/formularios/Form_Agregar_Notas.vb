Imports System.Runtime.InteropServices

Public Class Form_Agregar_Notas

#Region "Codigo para mover elementos"

    'dependencia para asignar movilidad a lementos'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub
#End Region

#Region "Control de ventana"

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label7.MouseDown
        'utilizar user32.dll para mover elementos'
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'solo permitir numeros en textbox'
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Form_Agregar_Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        select_materia.DropDownStyle = ComboBoxStyle.DropDownList
        select_nota.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

#End Region

End Class