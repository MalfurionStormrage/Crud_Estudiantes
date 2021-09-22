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

    Sub comparar(e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Input_Identificacion.Text = "" Then
                Input_Identificacion.Focus()
            ElseIf Input_Nombre.Text = "" Then
                Input_Nombre.Focus()
            ElseIf Input_Edad.Text = "" Then
                Input_Edad.Focus()
            ElseIf Select_Carrera.SelectedIndex = "0" Then
                Select_Carrera.Focus()
            ElseIf Input_Usuario.Text = "" Then
                Input_Usuario.Focus()
            Else
                Btn_Agregar_Estudiantes.Focus()
            End If
        End If
    End Sub

    Private Sub Btn_Cerrar_Ventana_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar_Ventana.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        'codigo para mover ventana a partir del panel'
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Input_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Input_Nombre.KeyPress, Select_Carrera.KeyPress, Input_Usuario.KeyPress
        comparar(e)
    End Sub

    Private Sub Form_Agregar_Estudiante_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Input_Identificacion.Text = ""
        Me.Input_Nombre.Text = ""
        Me.Input_Edad.Text = ""
        Me.Select_Carrera.SelectedIndex = 0
        Me.Input_Usuario.Text = ""
        Input_Identificacion.Focus()
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
        comparar(e)
    End Sub

    Private Sub Form_Agregar_Estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'iniciar clase'
        Dim carreras As New Carreras()

        'quitar opcion de editar en combobox'
        Me.Select_Carrera.DropDownStyle = ComboBoxStyle.DropDownList

        'asignar valor por default al combobox'
        Dim td = carreras.ObtenerDesCarreras()
        Dim fila = td.NewRow()
        fila("Descripcion") = "-- Selecciona una carrera --"
        td.Rows.InsertAt(fila, 0)

        'asigno los valores al combobox'
        Me.Select_Carrera.DataSource = td
        Me.Select_Carrera.DisplayMember = "Descripcion"

    End Sub

    Private Sub Btn_Agregar_Estudiantes_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Estudiantes.Click
        If Input_Identificacion.Text <> "" And Input_Nombre.Text <> "" And Input_Edad.Text <> "" And Select_Carrera.SelectedIndex <> "0" And Input_Usuario.Text <> "" Then

            'inicializar clase'
            Dim carreras As New Carreras()
            Dim estudiante As New Estudiantes()
            'se obtiene el codigo de la carrera'
            Dim resultado = carreras.obtenerIdCarrerasPorDescripcion(Select_Carrera.Text)
            Dim cod = resultado.Rows(0).Item(0).ToString()

            'se realiza la consulta sql con los parametro de esta misma'
            estudiante.insertarEstudiante(id:=Input_Identificacion.Text, nombre:=Input_Nombre.Text, edad:=Input_Edad.Text, carrera:=cod, usuario:=Input_Usuario.Text)

            'se refresca la ventana principal para notar los cambios de la consulta'
            Aplicacion.cargarDatos()
            Aplicacion.Refresh()

            'se envia el id del estudiante el cual se le asignara las notas y ademas se abre la venta de asignacion de notas'
            Form_Agregar_Notas.TextBox4.Text = Input_Identificacion.Text

            Form_Agregar_Notas.ShowDialog()

            'cierro formulario'
            Me.Close()
            Me.Visible = False

        Else
            MessageBox.Show("Todos los campos son obligatios.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

End Class