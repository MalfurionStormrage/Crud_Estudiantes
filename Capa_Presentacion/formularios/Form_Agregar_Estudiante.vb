Imports System.Runtime.InteropServices

Public Class Form_Agregar_Estudiante

#Region "Codigo para mover elementos"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub
#End Region

#Region "btn ventana"

    Private Sub Btn_Cerrar_Ventana_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar_Ventana.Click
        Me.Close()
    End Sub

    Private Sub Btn_Minimizar_Ventana_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar_Ventana.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        'codigo para mover ventana a partir del panel'
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Form_Agregar_Estudiante_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Input_Identificacion.Focus()
    End Sub

    Private Sub Form_Agregar_Estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_Carrera.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Input_Edad.KeyPress, Input_Identificacion.KeyPress
        'solo permitir numeros en textbox'
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        'If e.KeyChar = Convert.ToChar(Keys.Enter) Then

        '    'If Input_Identificacion.Text <> "" Then
        '    '    Input_Nombre.Focus()
        '    'ElseIf Input_Nombre.Text <> "" Then
        '    '    Input_Edad.Focus()
        '    'ElseIf Input_Edad.Text <> "" Then
        '    '    Me.Select_Carrera.Focus()
        '    'ElseIf (Me.Select_Carrera.SelectedIndex.ToString() <> "1") Then
        '    '    Btn_Agregar_Estudiantes.Focus()
        '    'End If

        '    If Input_Identificacion.Text <> "" Then
        '        Input_Nombre.Focus()
        '    Else
        '        Input_Identificacion.Focus()
        '    End If

        '    If Input_Nombre.Text <> "" Then
        '        Input_Edad.Focus()
        '    Else
        '        Input_Nombre.Focus()
        '    End If

        '    If Input_Edad.Text <> "" Then
        '        Select_Carrera.Focus()
        '    Else
        '        Input_Edad.Focus()
        '    End If

        '    If Select_Carrera.SelectedIndex <> "0" Then
        '        Btn_Agregar_Estudiantes.Focus()
        '    Else
        '        Select_Carrera.Focus()
        '    End If

        'End If
    End Sub


#End Region

End Class