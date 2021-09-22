Imports System.Runtime.InteropServices

Public Class Aplicacion

    Private id_E As String

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
            progresibar.Close()
            Application.Exit()
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

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        select_Seleccionar_carreras_fil.SelectedIndex = 0
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        table_notas.DataSource = ""
    End Sub

#End Region

#Region "funciones"

    Sub cargarDatos()
        'cargar datos en tablas'
        Dim estudiante = New Estudiantes()
        Dim result = estudiante.getEstudiantes()
        Me.table_estudiantes.DataSource = result

        '--------------------------------------------------------------------------------'

        Dim carrera As New Carreras()
        result = carrera.ObtenerDesCarreras()
        Dim fila = result.NewRow()
        fila("Descripcion") = "-- Selecciona un carrera --"
        result.Rows.InsertAt(fila, 0)

        Me.select_Seleccionar_carreras_fil.DataSource = result
        Me.select_Seleccionar_carreras_fil.DisplayMember = "Descripcion"

        '--------------------------------------------------------------------------------'

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

#End Region

#Region "eventos"

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown, IconButton1.MouseDown
        'codigo para mover ventana a partir del panel'
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Aplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub Aplicacion_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WindowState = FormWindowState.Maximized
        btnViewport()
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
        table_notas.DataSource = ""
        Me.table_estudiantes.ClearSelection()
        Btn_Editar_Estudiante.Enabled = False
        Btn_Eliminar_Estudiante.Enabled = False
    End Sub

    Private Sub table_estudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_estudiantes.CellClick

        Dim numero = table_estudiantes.Rows.Count
        'realizar consulta de notas a los estudiantes siempre y cuando se de click en fila con datos'
        If e.RowIndex >= 0 And e.RowIndex < numero Then

            Dim notas As New Notas()
            Dim carrera As New Carreras()
            Dim materias As New Materias()
            Dim td = notas.obtenerNotaPorIdDeEstudiante(table_estudiantes.Item(0, e.RowIndex).Value.ToString)
            Dim ID_M = td.rows(0).item(1)
            Dim result = materias.getDescripcionPorId(td.rows(0).item(1).ToString)

            result.rows(0).item(0).ToString()
            td.rows(0).item(1) = result.rows(0).item(0).ToString()

            Me.table_notas.DataSource = td
            Me.table_notas.ClearSelection()

            If td.rows(0).item(2).ToString = "0" Or td.rows(0).item(3).ToString = "0" Or td.rows(0).item(4).ToString = "0" Then
                If MessageBox.Show("El presente estudiante tiene dato en cero , deseas asignar sus notas ? ", "Notas del estudiante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Form_Agregar_Notas.TextBox1.Text = "true"
                    Form_Agregar_Notas.TextBox4.Text = td.rows(0).item(0).ToString
                    Form_Agregar_Notas.TextBox2.Text = ID_M
                    Form_Agregar_Notas.ShowDialog()
                End If
            End If

            Btn_Editar_Estudiante.Enabled = True
            Btn_Eliminar_Estudiante.Enabled = True

            id_E = Me.table_estudiantes.Item(0, e.RowIndex).Value.ToString
            Form_Editar_Estudiante.input_Edit_Ide_Estu.Text = id_E
            Form_Editar_Estudiante.input_Edit_Nombre_Estu.Text = Me.table_estudiantes.Item(1, e.RowIndex).Value.ToString
            Form_Editar_Estudiante.input_Edit_Edad_Estu.Text = Me.table_estudiantes.Item(2, e.RowIndex).Value.ToString
            Form_Editar_Estudiante.TextBox1.Text = Me.table_estudiantes.Item(3, e.RowIndex).Value.ToString


        Else
            Btn_Eliminar_Estudiante.Enabled = False
            Btn_Editar_Estudiante.Enabled = False

        End If
    End Sub

    Private Sub Btn_Consultar_Click(sender As Object, e As EventArgs) Handles Btn_Consultar.Click
        cargarDatos()
        Me.table_estudiantes.ClearSelection()
        Btn_Editar_Estudiante.Enabled = False
        Btn_Eliminar_Estudiante.Enabled = False
    End Sub

    Private Sub Btn_Agregar_Estudiantes_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Estudiantes.Click
        Form_Agregar_Estudiante.ShowDialog()
    End Sub

    Private Sub Btn_Editar_Estudiante_Click(sender As Object, e As EventArgs) Handles Btn_Editar_Estudiante.Click
        Form_Editar_Estudiante.ShowDialog()
    End Sub

    Private Sub Btn_Eliminar_Estudiante_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar_Estudiante.Click
        If table_estudiantes.Rows.Count > 0 Then
            If MessageBox.Show("¿  Estas seguro de eliminar este estudiante ?", "Eliminar estudiante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                Dim estudiante = New Estudiantes()
                estudiante.deleteEstudiante(id_E)
                cargarDatos()
                table_notas.DataSource = ""

            End If
        Else
            MessageBox.Show(" Debes seleccionar un estudiante para poder eliminar. ", "Eliminar estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

End Class