Imports System.Runtime.InteropServices

Public Class Aplicacion

#Region "Codigo para mover elementos"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

#End Region

#Region "Controles de ventana"

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        If MessageBox.Show("¿ Estas seguro de cerrar la aplicacion ?", "Cerrar aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        WindowState = FormWindowState.Maximized
        btnViewport()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        WindowState = FormWindowState.Normal
        btnViewport()
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Sub btnViewport()
        If Me.IconButton2.Visible = True Then
            IconButton3.Visible = True
            IconButton2.Visible = False
        ElseIf IconButton3.Visible = True Then
            IconButton3.Visible = False
            IconButton2.Visible = True
        End If
    End Sub

    Private Sub Aplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size

        'Me.Combobox_Seleccionar_carrera.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_Eliminar_Estudiantes.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Combobox_Seleccionar_carreras_fil.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown, IconButton1.MouseDown
        'codigo para mover ventana a partir del panel'
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        If (WindowState = FormWindowState.Maximized) Then
            WindowState = FormWindowState.Normal
            btnViewport()
        Else
            WindowState = FormWindowState.Maximized
            btnViewport()
        End If

    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        WindowState = FormWindowState.Maximized
        btnViewport()
    End Sub

    Private Sub Btn_Agregar_Estudiantes_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Estudiantes.Click
        Form_Agregar_Estudiante.Show()
    End Sub


#End Region

End Class