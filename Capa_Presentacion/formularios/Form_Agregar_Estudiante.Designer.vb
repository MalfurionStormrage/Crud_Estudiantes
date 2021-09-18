<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Agregar_Estudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Agregar_Estudiante))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cerrar_Ventana = New FontAwesome.Sharp.IconButton()
        Me.Btn_Minimizar_Ventana = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Select_Carrera = New System.Windows.Forms.ComboBox()
        Me.Btn_Agregar_Estudiantes = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Input_Usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Input_Edad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Input_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Input_Identificacion = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btn_Cerrar_Ventana)
        Me.Panel1.Controls.Add(Me.Btn_Minimizar_Ventana)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 40)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Nuevo Estudiante"
        '
        'Btn_Cerrar_Ventana
        '
        Me.Btn_Cerrar_Ventana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar_Ventana.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Btn_Cerrar_Ventana.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar_Ventana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar_Ventana.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.Btn_Cerrar_Ventana.IconColor = System.Drawing.Color.White
        Me.Btn_Cerrar_Ventana.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Cerrar_Ventana.IconSize = 20
        Me.Btn_Cerrar_Ventana.Location = New System.Drawing.Point(340, 1)
        Me.Btn_Cerrar_Ventana.Name = "Btn_Cerrar_Ventana"
        Me.Btn_Cerrar_Ventana.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Cerrar_Ventana.TabIndex = 0
        Me.Btn_Cerrar_Ventana.UseVisualStyleBackColor = False
        '
        'Btn_Minimizar_Ventana
        '
        Me.Btn_Minimizar_Ventana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimizar_Ventana.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Btn_Minimizar_Ventana.FlatAppearance.BorderSize = 0
        Me.Btn_Minimizar_Ventana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimizar_Ventana.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.Btn_Minimizar_Ventana.IconColor = System.Drawing.Color.White
        Me.Btn_Minimizar_Ventana.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Minimizar_Ventana.IconSize = 20
        Me.Btn_Minimizar_Ventana.Location = New System.Drawing.Point(300, 1)
        Me.Btn_Minimizar_Ventana.Name = "Btn_Minimizar_Ventana"
        Me.Btn_Minimizar_Ventana.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Minimizar_Ventana.TabIndex = 0
        Me.Btn_Minimizar_Ventana.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Select_Carrera)
        Me.Panel2.Controls.Add(Me.Btn_Agregar_Estudiantes)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Input_Usuario)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Input_Edad)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Input_Nombre)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Input_Identificacion)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 410)
        Me.Panel2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Datos del estudiantes"
        '
        'Select_Carrera
        '
        Me.Select_Carrera.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_Carrera.FormattingEnabled = True
        Me.Select_Carrera.Location = New System.Drawing.Point(11, 256)
        Me.Select_Carrera.Name = "Select_Carrera"
        Me.Select_Carrera.Size = New System.Drawing.Size(355, 29)
        Me.Select_Carrera.TabIndex = 15
        '
        'Btn_Agregar_Estudiantes
        '
        Me.Btn_Agregar_Estudiantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Btn_Agregar_Estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Agregar_Estudiantes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar_Estudiantes.ForeColor = System.Drawing.Color.White
        Me.Btn_Agregar_Estudiantes.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.Btn_Agregar_Estudiantes.IconColor = System.Drawing.Color.White
        Me.Btn_Agregar_Estudiantes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Agregar_Estudiantes.IconSize = 35
        Me.Btn_Agregar_Estudiantes.Location = New System.Drawing.Point(11, 358)
        Me.Btn_Agregar_Estudiantes.Name = "Btn_Agregar_Estudiantes"
        Me.Btn_Agregar_Estudiantes.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Btn_Agregar_Estudiantes.Size = New System.Drawing.Size(355, 40)
        Me.Btn_Agregar_Estudiantes.TabIndex = 17
        Me.Btn_Agregar_Estudiantes.Text = "Agregar estudiante"
        Me.Btn_Agregar_Estudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar_Estudiantes.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 21)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Carrera Del Estudiante"
        '
        'Input_Usuario
        '
        Me.Input_Usuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_Usuario.Location = New System.Drawing.Point(11, 312)
        Me.Input_Usuario.Name = "Input_Usuario"
        Me.Input_Usuario.Size = New System.Drawing.Size(355, 27)
        Me.Input_Usuario.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Edad De Estudiante"
        '
        'Input_Edad
        '
        Me.Input_Edad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_Edad.Location = New System.Drawing.Point(11, 202)
        Me.Input_Edad.MaxLength = 2
        Me.Input_Edad.Name = "Input_Edad"
        Me.Input_Edad.Size = New System.Drawing.Size(355, 27)
        Me.Input_Edad.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre De Estudiante"
        '
        'Input_Nombre
        '
        Me.Input_Nombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_Nombre.Location = New System.Drawing.Point(11, 148)
        Me.Input_Nombre.Name = "Input_Nombre"
        Me.Input_Nombre.Size = New System.Drawing.Size(355, 27)
        Me.Input_Nombre.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Identificacion De Usuario"
        '
        'Input_Identificacion
        '
        Me.Input_Identificacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_Identificacion.Location = New System.Drawing.Point(11, 94)
        Me.Input_Identificacion.Name = "Input_Identificacion"
        Me.Input_Identificacion.Size = New System.Drawing.Size(355, 27)
        Me.Input_Identificacion.TabIndex = 12
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(378, 408)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 60
        Me.LineShape1.X2 = 325
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'Form_Agregar_Estudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Agregar_Estudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Agregar_Estudiante"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cerrar_Ventana As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Minimizar_Ventana As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Select_Carrera As ComboBox
    Friend WithEvents Btn_Agregar_Estudiantes As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Input_Usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Input_Edad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Input_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Input_Identificacion As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
