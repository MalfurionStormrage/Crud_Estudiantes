<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.table_estudiantes = New System.Windows.Forms.DataGridView()
        Me.Btn_Agregar_Estudiantes = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.table_notas = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar_Estudiante = New FontAwesome.Sharp.IconButton()
        Me.select_Eliminar_Estudiantes = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.table_estudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table_notas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btn_Minimizar)
        Me.Panel1.Controls.Add(Me.Btn_Cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.IconButton4.Location = New System.Drawing.Point(682, 92)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 180.0R
        Me.IconButton4.Size = New System.Drawing.Size(30, 30)
        Me.IconButton4.TabIndex = 4
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 21)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Filtrar estudiantes por carrera :"
        '
        'select_Seleccionar_carreras_fil
        '
        Me.select_Seleccionar_carreras_fil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.select_Seleccionar_carreras_fil.BackColor = System.Drawing.Color.White
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
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gestion De Estudiantes"
        '
        'table_estudiantes
        '
        Me.table_estudiantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.table_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_estudiantes.Location = New System.Drawing.Point(33, 174)
        Me.table_estudiantes.Name = "table_estudiantes"
        Me.table_estudiantes.ReadOnly = True
        Me.table_estudiantes.Size = New System.Drawing.Size(680, 249)
        Me.table_estudiantes.TabIndex = 7
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
        Me.Btn_Agregar_Estudiantes.TabIndex = 8
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
        Me.table_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table_notas.Location = New System.Drawing.Point(33, 473)
        Me.table_notas.Name = "table_notas"
        Me.table_notas.ReadOnly = True
        Me.table_notas.Size = New System.Drawing.Size(680, 100)
        Me.table_notas.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(884, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 22)
        Me.Label10.TabIndex = 12
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
        Me.Label8.TabIndex = 13
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
        Me.Btn_Eliminar_Estudiante.TabIndex = 15
        Me.Btn_Eliminar_Estudiante.Text = "Remover estudiante"
        Me.Btn_Eliminar_Estudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Eliminar_Estudiante.UseVisualStyleBackColor = False
        '
        'select_Eliminar_Estudiantes
        '
        Me.select_Eliminar_Estudiantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.select_Eliminar_Estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.select_Eliminar_Estudiantes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_Eliminar_Estudiantes.FormattingEnabled = True
        Me.select_Eliminar_Estudiantes.Location = New System.Drawing.Point(731, 493)
        Me.select_Eliminar_Estudiantes.Name = "select_Eliminar_Estudiantes"
        Me.select_Eliminar_Estudiantes.Size = New System.Drawing.Size(453, 25)
        Me.select_Eliminar_Estudiantes.TabIndex = 14
        Me.select_Eliminar_Estudiantes.Text = "Selecciona un estudiante"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.IconButton5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Btn_Agregar_Estudiantes)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.IconButton4)
        Me.Panel2.Controls.Add(Me.select_Seleccionar_carreras_fil)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 600)
        Me.Panel2.TabIndex = 16
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
        Me.IconButton5.TabIndex = 14
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'Aplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.Btn_Eliminar_Estudiante)
        Me.Controls.Add(Me.select_Eliminar_Estudiantes)
        Me.Controls.Add(Me.table_notas)
        Me.Controls.Add(Me.table_estudiantes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.table_estudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table_notas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents table_estudiantes As DataGridView
    Friend WithEvents Btn_Agregar_Estudiantes As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents table_notas As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_Eliminar_Estudiante As FontAwesome.Sharp.IconButton
    Friend WithEvents select_Eliminar_Estudiantes As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
End Class
