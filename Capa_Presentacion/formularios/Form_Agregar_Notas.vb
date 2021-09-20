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

    Private Sub InputNota1_Leave(sender As Object, e As EventArgs) Handles input_Nota1.Leave
        If Me.input_Nota1.Text <> "" And Me.input_Nota1.Text <> "Escribe La Nota 1" Then
            nota1 = input_Nota1.Text
        End If
    End Sub

    Private Sub InputNota2_Enter(sender As Object, e As EventArgs) Handles input_Nota2.Enter
        If Me.input_Nota2.Text = "Escribe La Nota 2" Then
            Me.input_Nota2.Text = ""
        End If
    End Sub

    Private Sub InputNota2_Leave(sender As Object, e As EventArgs) Handles input_Nota2.Leave
        If Me.input_Nota2.Text <> "" And Me.input_Nota2.Text <> "Escribe La Nota 2" Then
            nota2 = Me.input_Nota2.Text
        End If
    End Sub

    Private Sub InputNota3_Enter(sender As Object, e As EventArgs) Handles input_Nota3.Enter
        If Me.input_Nota3.Text = "Escribe La Nota 3" Then
            Me.input_Nota3.Text = ""
        End If
    End Sub

    Private Sub InputNota3_Leave(sender As Object, e As EventArgs) Handles input_Nota3.Leave
        If Me.input_Nota3.Text <> "" And Me.input_Nota3.Text <> "Escribe La Nota 3" Then
            nota3 = Me.input_Nota3.Text
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

        Dim fila As DataRow
        ''inicializar la clase GestionEstudiantes'
        Dim Materias As New Materias()
        'consulta sql para cargar combobox'
        Dim tabla = Materias.GetDescripcionMaterias()

        ''asignar valor por default'
        fila = tabla.NewRow()
        fila("Descripcion") = "-- Selecciona una materia --"
        tabla.Rows.InsertAt(fila, 0)

        ''se cargan los datos en el combobox'
        Me.select_materia.DataSource = tabla
        Me.select_materia.ValueMember = "Descripcion"

        Me.select_nota.DropDownStyle = ComboBoxStyle.DropDownList
        Me.select_materia.DropDownStyle = ComboBoxStyle.DropDownList
        Me.select_nota.SelectedIndex = 0

        If TextBox1.Text = "true" Then
            Me.Btn_Agregar_Notas.Text = "Actualizar las notas"
            Me.Btn_Agregar_Notas.BackColor = Color.FromArgb(255, 185, 7)
        End If

    End Sub

    Private Sub select_nota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_nota.SelectedIndexChanged


        Select Case Me.select_nota.SelectedIndex
            Case "0"
                input_Nota1.Visible = False
                input_Nota2.Visible = False
                input_Nota3.Visible = False

            Case "1"

                If nota1 = 0 Then
                    input_Nota1.Text = "Escribe La Nota 1"
                Else
                    input_Nota1.Text = nota1
                End If

                input_Nota1.Visible = True
                input_Nota2.Visible = False
                input_Nota3.Visible = False

            Case "2"

                If nota2 = 0 Then
                    input_Nota2.Text = "Escribe La Nota 2"
                Else
                    input_Nota2.Text = nota2
                End If

                input_Nota1.Visible = False
                input_Nota2.Visible = True
                input_Nota3.Visible = False

            Case "3"

                If nota3 = 0 Then
                    input_Nota3.Text = "Escribe La Nota 3"
                Else
                    input_Nota3.Text = nota3
                End If

                input_Nota1.Visible = False
                input_Nota2.Visible = False
                input_Nota3.Visible = True

        End Select

    End Sub

    Private Sub Btn_Agregar_Notas_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Notas.Click
        'Se debe seleccionar una materia para asignar notas'
        If Me.select_materia.SelectedIndex.ToString() <> "0" Then

            'iniciar clase'
            Dim notas As New Notas()

            'datos a insertar'
            Dim id_e As Integer = Convert.ToInt32(Me.TextBox4.Text)
            Dim descripcion_Materia As String = Me.select_materia.SelectedValue.ToString()


            'obtengo valor del id de la materia para asignar nota
            Dim resultado = notas.GetIdNotas(descripcion_Materia)
            Dim cod = resultado.Rows(0).Item(0).ToString()

            If TextBox1.Text = "false" Then
                'consulta sql / asignar notas'
                notas.setNotas(id_e:=id_e, id_m:=cod, nota1:=nota1, nota2:=nota2, nota3:=nota3)
            Else
                'consulta sql / asignar notas'
                notas.updatenotas(id_e:=id_e, id_m:=cod, nota1:=nota1, nota2:=nota2, nota3:=nota3)
            End If

            'refresco el form principal'
            Aplicacion.cargarDatos()
            Aplicacion.Refresh()
            Aplicacion.table_notas.DataSource = ""
            Me.Close()

        Else

            MessageBox.Show("Selecciona una materia para asignar las notas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

#End Region

End Class