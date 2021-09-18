Imports System.Runtime.InteropServices

Public Class Form_Agregar_Notas

    Private nota1 As Double = 0
    Private nota2 As Double = 0
    Private nota3 As Double = 0

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
    Private Sub InputNota1_Enter(sender As Object, e As EventArgs) Handles input_Nota1.Enter
        If Me.input_Nota1.Text = "Escribe La Nota 1" Then
            Me.input_Nota1.Text = ""
        End If
    End Sub

    Private Sub InputNota2_Enter(sender As Object, e As EventArgs) Handles input_Nota2.Enter
        If Me.input_Nota2.Text = "Escribe La Nota 2" Then
            Me.input_Nota2.Text = ""
        End If
    End Sub

    Private Sub InputNota3_Enter(sender As Object, e As EventArgs) Handles input_Nota3.Enter
        If Me.input_Nota3.Text = "Escribe La Nota 3" Then
            Me.input_Nota3.Text = ""
        End If
    End Sub

    Private Sub InputNota1_Leave(sender As Object, e As EventArgs) Handles input_Nota1.Leave
        If Me.input_Nota1.Text = "" Then
            Me.input_Nota1.Text = "Escribe La Nota 1"
        End If
    End Sub

    Private Sub InputNota2_Leave(sender As Object, e As EventArgs) Handles input_Nota2.Leave
        If Me.input_Nota2.Text = "" Then
            Me.input_Nota2.Text = "Escribe La Nota 2"
        End If
    End Sub

    Private Sub InputNota3_Leave(sender As Object, e As EventArgs) Handles input_Nota3.Leave
        If Me.input_Nota3.Text = "" Then
            Me.input_Nota3.Text = "Escribe La Nota 3"
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input_Nota1.KeyPress
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


        Select Case select_nota.SelectedIndex
            Case "0"
                Me.input_Nota1.Visible = False
                Me.input_Nota2.Visible = False
                Me.input_Nota3.Visible = False

            Case "1"

                Me.input_Nota1.Visible = True
                Me.input_Nota2.Visible = False
                Me.input_Nota3.Visible = False

            Case "2"
                Me.input_Nota1.Visible = False
                Me.input_Nota2.Visible = True
                Me.input_Nota3.Visible = False

            Case "3"
                Me.input_Nota1.Visible = False
                Me.input_Nota2.Visible = False
                Me.input_Nota3.Visible = True

        End Select

    End Sub

#End Region

End Class