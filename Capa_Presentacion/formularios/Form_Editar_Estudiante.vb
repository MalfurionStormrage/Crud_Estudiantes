Imports System.Runtime.InteropServices

Public Class Form_Editar_Estudiante

#Region "Codigo para mover elementos"

    'dependencia para asignar movilidad a lementos'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub
#End Region

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Btn_Cerrar_frm_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar_frm.Click
        Me.Close()
    End Sub

    Private Sub Form_Editar_Estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim carrera As New Carreras()
        Dim result = carrera.ObtenerDesCarreras()
        Dim fila = result.NewRow()
        fila("Descripcion") = "-- Selecciona un carrera --"
        result.Rows.InsertAt(fila, 0)

        Me.Select_Edit_Carrera_Estu.DataSource = result
        Me.Select_Edit_Carrera_Estu.DisplayMember = "Descripcion"

    End Sub

    Private Sub Form_Editar_Estudiante_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim carrera As New Carreras()

        If TextBox1.Text.Length > 1 Then
            Dim codigo = carrera.obtenerIdCarrerasPorDescripcion(TextBox1.Text)
            Dim cod = codigo.Rows(0).Item(0).ToString()
            Me.Select_Edit_Carrera_Estu.SelectedIndex = cod
        Else
            Select_Edit_Carrera_Estu.SelectedIndex = Convert.ToInt32(TextBox1.Text)
        End If

    End Sub

    Private Sub Btn_Editar_Datos_Click(sender As Object, e As EventArgs) Handles Btn_Editar_Datos.Click
        'se valdia que la accion modifica no tenga campos vacios'
        If input_Edit_Nombre_Estu.Text <> "" And input_Edit_Edad_Estu.Text <> "" And input_Edit_Usuario_Estu.Text <> "" And Select_Edit_Carrera_Estu.SelectedIndex.ToString() <> "0" Then
            'se pregunta por la confirmacion de la edicion de datos'
            If MessageBox.Show("¿ Estas seguro de editar los datos ?", "Actualizar los datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim estudiante As New Estudiantes()
                Dim carrera As New Carreras()

                Dim codigo = carrera.obtenerIdCarrerasPorDescripcion(Select_Edit_Carrera_Estu.Text)
                Dim cod = codigo.Rows(0).Item(0).ToString()

                'se realiza la accion sql'
                estudiante.updataEstudiante(id_Es:=input_Edit_Ide_Estu.Text, Nombre:=input_Edit_Nombre_Estu.Text, Edad:=input_Edit_Edad_Estu.Text, Carrera:=cod, Usuario_Edita:=input_Edit_Usuario_Estu.Text)
                Aplicacion.cargarDatos()

                Me.Close()
            End If
        Else
            MessageBox.Show("Todo los campos son obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class