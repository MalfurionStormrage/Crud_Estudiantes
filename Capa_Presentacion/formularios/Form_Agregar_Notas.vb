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

#Region "Efecto placeholder"
    'Se utiliza los evento enter y leave para realiar efecto "placeholder" '
    Private Sub InputNota1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If Me.TextBox1.Text = "Escribe La Nota 1" Then
            Me.TextBox1.Text = ""
        End If
    End Sub

    Private Sub InputNota2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If Me.TextBox2.Text = "Escribe La Nota 2" Then
            Me.TextBox2.Text = ""
        End If
    End Sub

    Private Sub InputNota3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        If Me.TextBox3.Text = "Escribe La Nota 3" Then
            Me.TextBox3.Text = ""
        End If
    End Sub

    Private Sub InputNota1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If Me.TextBox1.Text = "" Then
            Me.TextBox1.Text = "Escribe La Nota 1"
        End If
    End Sub

    Private Sub InputNota2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If Me.TextBox2.Text = "" Then
            Me.TextBox2.Text = "Escribe La Nota 2"
        End If
    End Sub

    Private Sub InputNota3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If Me.TextBox3.Text = "" Then
            Me.TextBox3.Text = "Escribe La Nota 3"
        End If
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
        Me.select_nota.DropDownStyle = ComboBoxStyle.DropDownList
        Me.select_materia.DropDownStyle = ComboBoxStyle.DropDownList
        Me.select_nota.SelectedIndex = 0
    End Sub

    Private Sub select_nota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_nota.SelectedIndexChanged
        If (select_nota.SelectedIndex <> "0") Then
            Me.panel_Notas.Visible = True
        Else
            Me.panel_Notas.Visible = False
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter

    End Sub

#End Region

End Class