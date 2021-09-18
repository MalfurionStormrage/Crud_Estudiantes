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


#End Region

#Region "funciones"
    Sub cargarDatos()
        'cargar datos en tablas'
        Dim estudiante = New Estudiantes()
        Dim result = estudiante.getEstudiantes()
        Me.table_estudiantes.DataSource = result
        '--------------------------------------------------------------------------------'

        result = estudiante.getEstudiantes()
        Dim fila = result.NewRow()
        fila("ID_E") = "-- Selecciona un estudiante --"
        result.Rows.InsertAt(fila, 0)

        Me.select_Eliminar_Estudiantes.DataSource = result
        Me.select_Eliminar_Estudiantes.DisplayMember = "ID_E"

        '--------------------------------------------------------------------------------'

        Dim carrera As New Carreras()
        result = carrera.ObtenerDesCarreras()
        fila = result.NewRow()
        fila("Descripcion") = "-- Selecciona un carrera --"
        result.Rows.InsertAt(fila, 0)

        Me.select_Seleccionar_carreras_fil.DataSource = result
        Me.select_Seleccionar_carreras_fil.DisplayMember = "Descripcion"

    End Sub
#End Region

#Region "eventos"
    Sub btnViewport()
        If Me.IconButton2.Visible = True Then
            IconButton3.Visible = True
            IconButton2.Visible = False
        ElseIf IconButton3.Visible = True Then
            IconButton3.Visible = False
            IconButton2.Visible = True
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown, IconButton1.MouseDown
        'codigo para mover ventana a partir del panel'
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Aplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        'Me.Combobox_Seleccionar_carrera.DropDownStyle = ComboBoxStyle.DropDownList
        Me.select_Eliminar_Estudiantes.DropDownStyle = ComboBoxStyle.DropDownList
        Me.select_Seleccionar_carreras_fil.DropDownStyle = ComboBoxStyle.DropDownList

        ''
        cargarDatos()
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

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        select_Seleccionar_carreras_fil.SelectedIndex = 0
    End Sub

    Private Sub select_Seleccionar_carreras_fil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_Seleccionar_carreras_fil.SelectedIndexChanged
        Dim estudiante As New Estudiantes()
        Dim carreras As New Carreras()
        If select_Seleccionar_carreras_fil.SelectedIndex.ToString <> "0" Then
            Dim codigo = carreras.obtenerIdCarrerasPorDescripcion(select_Seleccionar_carreras_fil.Text)
            Dim cod = codigo.Rows(0).Item(0).ToString()
            Me.table_estudiantes.DataSource = estudiante.getEstudiantesPorFiltro(cod)
        Else
            Me.table_estudiantes.DataSource = estudiante.getEstudiantes()
        End If
    End Sub

#End Region

End Class