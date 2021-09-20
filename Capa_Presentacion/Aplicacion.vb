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

        '--------------------------------------------------------------------------------'

        result = carrera.ObtenerDesCarreras()
        fila = result.NewRow()
        fila("Descripcion") = "-- Selecciona un carrera --"
        result.Rows.InsertAt(fila, 0)

        Me.Select_Edit_Carrera_Estu.DataSource = result
        Me.Select_Edit_Carrera_Estu.DisplayMember = "Descripcion"

    End Sub

    Sub LimpiarFormEditar()
        input_Edit_Ide_Estu.Text = ""
        input_Edit_Nombre_Estu.Text = ""
        input_Edit_Edad_Estu.Text = ""
        input_Edit_Usuario_Estu.Text = ""
        Me.Select_Edit_Carrera_Estu.SelectedIndex = 0
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

    Private Sub Btn_Eliminar_Estudiante_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar_Estudiante.Click
        If select_Eliminar_Estudiantes.SelectedIndex <> "0" Then
            If MessageBox.Show("¿  Estas seguro de eliminar este estudiante ?", "Eliminar estudiante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                Dim estudiante = New Estudiantes()
                estudiante.deleteEstudiante(select_Eliminar_Estudiantes.Text)
                select_Eliminar_Estudiantes.SelectedIndex = 0
                cargarDatos()
                table_notas.DataSource = ""

            End If
        Else
            MessageBox.Show(" Debes seleccionar un estudiante para poder eliminar. ", "Eliminar estudiante", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub table_estudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles  table_estudiantes.CellClick

        Dim numero = table_estudiantes.Rows.Count
        'realizar consulta de notas a los estudiantes siempre y cuando se de click en fila con datos'
        If e.RowIndex >= 0 And e.RowIndex < numero - 1 Then
            Dim notas As New Notas()
            Dim carrera As New Carreras()
            Dim dato = table_estudiantes.Item(0, e.RowIndex).Value.ToString
            Dim td = notas.obtenerNotaPorIdDeEstudiante(dato)
            Me.table_notas.DataSource = td

            If td.rows(0).item(2).ToString = "0" Or td.rows(0).item(3).ToString = "0" Or td.rows(0).item(4).ToString = "0" Then
                If MessageBox.Show("El presente estudiante tiene dato en cero , deseas asignar sus notas ? ", "Notas del estudiante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = MessageBoxButtons.OK Then
                    Form_Agregar_Notas.Show()
                    Form_Agregar_Notas.TextBox1.Text = "true"
                    Form_Agregar_Notas.TextBox4.Text = td.rows(0).item(0).ToString
                    Form_Agregar_Notas.select_materia.SelectedIndex = td.rows(0).item(1)
                End If
            End If

            Me.input_Edit_Ide_Estu.Text = table_estudiantes.Item(0, e.RowIndex).Value.ToString
            Me.input_Edit_Nombre_Estu.Text = Me.table_estudiantes.Item(1, e.RowIndex).Value.ToString
            Me.input_Edit_Edad_Estu.Text = Me.table_estudiantes.Item(2, e.RowIndex).Value.ToString

            If Me.table_estudiantes.Item(3, e.RowIndex).Value.ToString.Length > 1 Then
                Dim codigo = carrera.obtenerIdCarrerasPorDescripcion(Me.table_estudiantes.Item(3, e.RowIndex).Value.ToString)
                Dim cod = codigo.Rows(0).Item(0).ToString()
                Me.Select_Edit_Carrera_Estu.SelectedIndex = cod
            Else
                Me.Select_Edit_Carrera_Estu.SelectedIndex = Me.table_estudiantes.Item(3, e.RowIndex).Value.ToString
            End If

            End If
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        table_notas.DataSource = ""
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        MessageBox.Show("Para utilizar este apartado debes seleccionar un estudiante de la tabla estudiantes y posterior a ello editar sus datos.", "Apartado de ediccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        'se valdia que la accion modifica no tenga campos vacios'
        If input_Edit_Nombre_Estu.Text <> "" And input_Edit_Edad_Estu.Text <> "" And input_Edit_Usuario_Estu.Text <> "" And Select_Edit_Carrera_Estu.SelectedIndex.ToString() <> "0" Then
            'se pregunta por la confirmacion de la edicion de datos'
            If MessageBox.Show("¿ Estas seguro de editar los datos ?", "Actualizar los datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                'se realiza la accion sql'
                Dim estudiante As New Estudiantes()

                Dim carrera As New Carreras()
                Dim codigo = carrera.obtenerIdCarrerasPorDescripcion(Select_Edit_Carrera_Estu.Text)
                Dim cod = codigo.Rows(0).Item(0).ToString()

                estudiante.updataEstudiante(id_Es:=input_Edit_Ide_Estu.Text, Nombre:=input_Edit_Nombre_Estu.Text, Edad:=input_Edit_Edad_Estu.Text, Carrera:=cod, Usuario_Edita:=input_Edit_Usuario_Estu.Text)
                cargarDatos()

                'se aplica reset a los textbox y combobox'
                LimpiarFormEditar()

            End If
        Else
            MessageBox.Show("Todo los campos son obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        LimpiarFormEditar()
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        Me.select_Eliminar_Estudiantes.SelectedIndex = 0
    End Sub

    Private Sub table_notas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table_notas.CellClick

    End Sub

#End Region

End Class