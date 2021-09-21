<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aplicacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aplicacion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Minimizar = New FontAwesome.Sharp.IconButton()
        Me.Btn_Cerrar = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.select_Seleccionar_carreras_fil = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Agregar_Estudiantes = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.table_notas = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar_Estudiante = New FontAwesome.Sharp.IconButton()
        Me.select_Eliminar_Estudiantes = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton9 = New FontAwesome.Sharp.IconButton()
        Me.table_estudiantes = New System.Windows.Forms.DataGridView()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.input_Edit_Ide_Estu = New System.Windows.Forms.TextBox()
        Me.Select_Edit_Carrera_Estu = New System.Windows.Forms.ComboBox()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.input_Edit_Usuario_Estu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.input_Edit_Edad_Estu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.input_Edit_Nombre_Estu = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        CType(Me.table_notas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.table_estudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btn_Minimizar)
        Me.Panel1.Controls.Add(Me.Btn_Cerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 40)
        Me.Panel1.TabIndex = 0
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 20
        Me.IconButton3.Location = New System.Drawing.Point(1119, 1)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(40, 40)
        Me.IconButton3.TabIndex = 0
        Me.IconButton3.UseVisualStyleBackColor = True
        Me.IconButton3.Visible = False
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(1119, 1)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(40, 40)
        Me.IconButton2.TabIndex = 0
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.IconButton1.Enabled = False
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.HospitalUser
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.Location = New System.Drawing.Point(4, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(40, 40)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion"
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Btn_Minimizar.FlatAppearance.BorderSize = 0
        Me.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.Btn_Minimizar.IconColor = System.Drawing.Color.White
        Me.Btn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Minimizar.IconSize = 20
        Me.Btn_Minimizar.Location = New System.Drawing.Point(1079, 1)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Minimizar.TabIndex = 0
        Me.Btn_Minimizar.UseVisualStyleBackColor = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.Btn_Cerrar.IconColor = System.Drawing.Color.White
        Me.Btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Cerrar.IconSize = 20
        Me.Btn_Cerrar.Location = New System.Drawing.Point(1159, 1)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Cerrar.TabIndex = 0
        Me.Btn_Cerrar.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton4.BackColor = System.Drawing.Color.Gainsboro
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Brush
        Me.IconButton4.IconColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 20
        Me.IconButton4.Location = New System.Drawing.Point(682, 96)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 180.0R
        Me.IconButton4.Size = New System.Drawing.Size(30, 30)
        Me.IconButton4.TabIndex = 0
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Filtrar estudiantes por carrera :"
        '
        'select_Seleccionar_carreras_fil
        '
        Me.select_Seleccionar_carreras_fil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.select_Seleccionar_carreras_fil.BackColor = System.Drawing.Color.White
        Me.select_Seleccionar_carreras_fil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.select_Seleccionar_carreras_fil.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_Seleccionar_carreras_fil.FormattingEnabled = True
        Me.select_Seleccionar_carreras_fil.Location = New System.Drawing.Point(32, 100)
        Me.select_Seleccionar_carreras_fil.Name = "select_Seleccionar_carreras_fil"
        Me.select_Seleccionar_carreras_fil.Size = New System.Drawing.Size(644, 25)
        Me.select_Seleccionar_carreras_fil.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Gestion De Estudiantes"
        '
        'Btn_Agregar_Estudiantes
        '
        Me.Btn_Agregar_Estudiantes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar_Estudiantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Btn_Agregar_Estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Agregar_Estudiantes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar_Estudiantes.ForeColor = System.Drawing.Color.White
        Me.Btn_Agregar_Estudiantes.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.Btn_Agregar_Estudiantes.IconColor = System.Drawing.Color.White
        Me.Btn_Agregar_Estudiantes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Agregar_Estudiantes.IconSize = 30
        Me.Btn_Agregar_Estudiantes.Location = New System.Drawing.Point(32, 128)
        Me.Btn_Agregar_Estudiantes.Name = "Btn_Agregar_Estudiantes"
        Me.Btn_Agregar_Estudiantes.Padding = New System.Windows.Forms.Padding(140, 0, 0, 0)
        Me.Btn_Agregar_Estudiantes.Size = New System.Drawing.Size(680, 39)
        Me.Btn_Agregar_Estudiantes.TabIndex = 0
        Me.Btn_Agregar_Estudiantes.Text = "Agregar Nuevo Estudiantes"
        Me.Btn_Agregar_Estudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar_Estudiantes.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tabla De Notas"
        '
        'table_notas
        '
        Me.table_notas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_notas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.table_notas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_notas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_notas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.table_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_notas.DefaultCellStyle = DataGridViewCellStyle2
        Me.table_notas.EnableHeadersVisualStyles = False
        Me.table_notas.GridColor = System.Drawing.Color.Black
        Me.table_notas.Location = New System.Drawing.Point(33, 473)
        Me.table_notas.Name = "table_notas"
        Me.table_notas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_notas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.table_notas.RowHeadersVisible = False
        Me.table_notas.Size = New System.Drawing.Size(680, 100)
        Me.table_notas.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(869, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Eliminar Estudiante"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(731, 472)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Identificacion De Estudiante :"
        '
        'Btn_Eliminar_Estudiante
        '
        Me.Btn_Eliminar_Estudiante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar_Estudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Btn_Eliminar_Estudiante.FlatAppearance.BorderSize = 0
        Me.Btn_Eliminar_Estudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar_Estudiante.ForeColor = System.Drawing.Color.White
        Me.Btn_Eliminar_Estudiante.IconChar = FontAwesome.Sharp.IconChar.UserTimes
        Me.Btn_Eliminar_Estudiante.IconColor = System.Drawing.Color.White
        Me.Btn_Eliminar_Estudiante.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Eliminar_Estudiante.IconSize = 30
        Me.Btn_Eliminar_Estudiante.Location = New System.Drawing.Point(731, 529)
        Me.Btn_Eliminar_Estudiante.Name = "Btn_Eliminar_Estudiante"
        Me.Btn_Eliminar_Estudiante.Padding = New System.Windows.Forms.Padding(120, 0, 0, 0)
        Me.Btn_Eliminar_Estudiante.Size = New System.Drawing.Size(455, 40)
        Me.Btn_Eliminar_Estudiante.TabIndex = 0
        Me.Btn_Eliminar_Estudiante.Text = "Remover estudiante"
        Me.Btn_Eliminar_Estudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Eliminar_Estudiante.UseVisualStyleBackColor = False
        '
        'select_Eliminar_Estudiantes
        '
        Me.select_Eliminar_Estudiantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.select_Eliminar_Estudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.select_Eliminar_Estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.select_Eliminar_Estudiantes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_Eliminar_Estudiantes.FormattingEnabled = True
        Me.select_Eliminar_Estudiantes.Location = New System.Drawing.Point(731, 493)
        Me.select_Eliminar_Estudiantes.Name = "select_Eliminar_Estudiantes"
        Me.select_Eliminar_Estudiantes.Size = New System.Drawing.Size(453, 25)
        Me.select_Eliminar_Estudiantes.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.IconButton9)
        Me.Panel2.Controls.Add(Me.table_estudiantes)
        Me.Panel2.Controls.Add(Me.IconButton5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Btn_Agregar_Estudiantes)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.IconButton4)
        Me.Panel2.Controls.Add(Me.select_Seleccionar_carreras_fil)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 600)
        Me.Panel2.TabIndex = 16
        '
        'IconButton9
        '
        Me.IconButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton9.FlatAppearance.BorderSize = 0
        Me.IconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton9.IconChar = FontAwesome.Sharp.IconChar.Brush
        Me.IconButton9.IconColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton9.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton9.IconSize = 20
        Me.IconButton9.Location = New System.Drawing.Point(1153, 459)
        Me.IconButton9.Name = "IconButton9"
        Me.IconButton9.Rotation = 180.0R
        Me.IconButton9.Size = New System.Drawing.Size(30, 30)
        Me.IconButton9.TabIndex = 0
        Me.IconButton9.UseVisualStyleBackColor = False
        '
        'table_estudiantes
        '
        Me.table_estudiantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.table_estudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.table_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_estudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_estudiantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.table_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table_estudiantes.DefaultCellStyle = DataGridViewCellStyle5
        Me.table_estudiantes.EnableHeadersVisualStyles = False
        Me.table_estudiantes.GridColor = System.Drawing.Color.Black
        Me.table_estudiantes.Location = New System.Drawing.Point(32, 173)
        Me.table_estudiantes.Name = "table_estudiantes"
        Me.table_estudiantes.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table_estudiantes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.table_estudiantes.RowHeadersVisible = False
        Me.table_estudiantes.Size = New System.Drawing.Size(680, 257)
        Me.table_estudiantes.TabIndex = 0
        '
        'IconButton5
        '
        Me.IconButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton5.BackColor = System.Drawing.Color.Gainsboro
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Brush
        Me.IconButton5.IconColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 20
        Me.IconButton5.Location = New System.Drawing.Point(682, 436)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Rotation = 180.0R
        Me.IconButton5.Size = New System.Drawing.Size(30, 30)
        Me.IconButton5.TabIndex = 0
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.IconButton8)
        Me.GroupBox1.Controls.Add(Me.IconButton7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.input_Edit_Ide_Estu)
        Me.GroupBox1.Controls.Add(Me.Select_Edit_Carrera_Estu)
        Me.GroupBox1.Controls.Add(Me.IconButton6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.input_Edit_Usuario_Estu)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.input_Edit_Edad_Estu)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.input_Edit_Nombre_Estu)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(722, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 363)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editar Datos De Estudiante"
        '
        'IconButton8
        '
        Me.IconButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.Brush
        Me.IconButton8.IconColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton8.IconSize = 20
        Me.IconButton8.Location = New System.Drawing.Point(435, 12)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Rotation = 180.0R
        Me.IconButton8.Size = New System.Drawing.Size(30, 30)
        Me.IconButton8.TabIndex = 0
        Me.IconButton8.UseVisualStyleBackColor = False
        '
        'IconButton7
        '
        Me.IconButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.IconButton7.IconColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.IconSize = 20
        Me.IconButton7.Location = New System.Drawing.Point(399, 12)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Size = New System.Drawing.Size(30, 30)
        Me.IconButton7.TabIndex = 0
        Me.IconButton7.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Identificacion"
        '
        'input_Edit_Ide_Estu
        '
        Me.input_Edit_Ide_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Ide_Estu.Enabled = False
        Me.input_Edit_Ide_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Ide_Estu.Location = New System.Drawing.Point(6, 59)
        Me.input_Edit_Ide_Estu.Name = "input_Edit_Ide_Estu"
        Me.input_Edit_Ide_Estu.ReadOnly = True
        Me.input_Edit_Ide_Estu.Size = New System.Drawing.Size(459, 27)
        Me.input_Edit_Ide_Estu.TabIndex = 0
        '
        'Select_Edit_Carrera_Estu
        '
        Me.Select_Edit_Carrera_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Select_Edit_Carrera_Estu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_Edit_Carrera_Estu.FormattingEnabled = True
        Me.Select_Edit_Carrera_Estu.Location = New System.Drawing.Point(6, 221)
        Me.Select_Edit_Carrera_Estu.Name = "Select_Edit_Carrera_Estu"
        Me.Select_Edit_Carrera_Estu.Size = New System.Drawing.Size(459, 25)
        Me.Select_Edit_Carrera_Estu.TabIndex = 0
        '
        'IconButton6
        '
        Me.IconButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton6.ForeColor = System.Drawing.Color.White
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.IconButton6.IconColor = System.Drawing.Color.White
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 25
        Me.IconButton6.Location = New System.Drawing.Point(4, 308)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Size = New System.Drawing.Size(459, 41)
        Me.IconButton6.TabIndex = 0
        Me.IconButton6.Text = "Editar Datos"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Usuario que modifica"
        '
        'input_Edit_Usuario_Estu
        '
        Me.input_Edit_Usuario_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Usuario_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Usuario_Estu.Location = New System.Drawing.Point(6, 273)
        Me.input_Edit_Usuario_Estu.Name = "input_Edit_Usuario_Estu"
        Me.input_Edit_Usuario_Estu.Size = New System.Drawing.Size(459, 27)
        Me.input_Edit_Usuario_Estu.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Carrera"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Edad Del Estudiante"
        '
        'input_Edit_Edad_Estu
        '
        Me.input_Edit_Edad_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Edad_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Edad_Estu.Location = New System.Drawing.Point(6, 167)
        Me.input_Edit_Edad_Estu.MaxLength = 2
        Me.input_Edit_Edad_Estu.Name = "input_Edit_Edad_Estu"
        Me.input_Edit_Edad_Estu.Size = New System.Drawing.Size(459, 27)
        Me.input_Edit_Edad_Estu.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre Del Estudiante"
        '
        'input_Edit_Nombre_Estu
        '
        Me.input_Edit_Nombre_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Nombre_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Nombre_Estu.Location = New System.Drawing.Point(6, 113)
        Me.input_Edit_Nombre_Estu.Name = "input_Edit_Nombre_Estu"
        Me.input_Edit_Nombre_Estu.Size = New System.Drawing.Size(459, 27)
        Me.input_Edit_Nombre_Estu.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1198, 598)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 723
        Me.LineShape1.X2 = 1193
        Me.LineShape1.Y1 = 432
        Me.LineShape1.Y2 = 432
        '
        'Aplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Eliminar_Estudiante)
        Me.Controls.Add(Me.select_Eliminar_Estudiantes)
        Me.Controls.Add(Me.table_notas)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.table_notas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.table_estudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Minimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Cerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents select_Seleccionar_carreras_fil As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Agregar_Estudiantes As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents table_notas As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_Eliminar_Estudiante As FontAwesome.Sharp.IconButton
    Friend WithEvents select_Eliminar_Estudiantes As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents table_estudiantes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents input_Edit_Ide_Estu As TextBox
    Friend WithEvents Select_Edit_Carrera_Estu As ComboBox
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label7 As Label
    Friend WithEvents input_Edit_Usuario_Estu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents input_Edit_Edad_Estu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents input_Edit_Nombre_Estu As TextBox
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton9 As FontAwesome.Sharp.IconButton
End Class
