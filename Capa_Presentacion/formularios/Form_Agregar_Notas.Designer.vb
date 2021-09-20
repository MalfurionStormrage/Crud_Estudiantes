<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Agregar_Notas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Agregar_Notas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.select_materia = New System.Windows.Forms.ComboBox()
        Me.Btn_Agregar_Notas = New FontAwesome.Sharp.IconButton()
        Me.select_nota = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.input_Nota1 = New System.Windows.Forms.TextBox()
        Me.input_Nota3 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.input_Nota2 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Asignacion de notas"
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(340, 0)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(40, 40)
        Me.IconButton2.TabIndex = 8
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(30, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ID_Estudiante"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(30, 129)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(320, 27)
        Me.TextBox4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(30, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Materia"
        '
        'select_materia
        '
        Me.select_materia.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.select_materia.FormattingEnabled = True
        Me.select_materia.Location = New System.Drawing.Point(30, 181)
        Me.select_materia.Name = "select_materia"
        Me.select_materia.Size = New System.Drawing.Size(320, 29)
        Me.select_materia.TabIndex = 2
        '
        'Btn_Agregar_Notas
        '
        Me.Btn_Agregar_Notas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Agregar_Notas.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Btn_Agregar_Notas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Agregar_Notas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar_Notas.ForeColor = System.Drawing.Color.White
        Me.Btn_Agregar_Notas.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.Btn_Agregar_Notas.IconColor = System.Drawing.Color.White
        Me.Btn_Agregar_Notas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Agregar_Notas.IconSize = 30
        Me.Btn_Agregar_Notas.Location = New System.Drawing.Point(29, 375)
        Me.Btn_Agregar_Notas.Name = "Btn_Agregar_Notas"
        Me.Btn_Agregar_Notas.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.Btn_Agregar_Notas.Size = New System.Drawing.Size(320, 40)
        Me.Btn_Agregar_Notas.TabIndex = 7
        Me.Btn_Agregar_Notas.Text = "Asignar notas"
        Me.Btn_Agregar_Notas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar_Notas.UseVisualStyleBackColor = False
        '
        'select_nota
        '
        Me.select_nota.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.select_nota.FormattingEnabled = True
        Me.select_nota.Items.AddRange(New Object() {"-- Selecciona nota a asignar --", "Nota 1", "Nota 2", "Nota 3"})
        Me.select_nota.Location = New System.Drawing.Point(29, 237)
        Me.select_nota.Name = "select_nota"
        Me.select_nota.Size = New System.Drawing.Size(320, 29)
        Me.select_nota.TabIndex = 3
        Me.select_nota.Text = "Notas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asignar Notas "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(29, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Notas"
        '
        'input_Nota1
        '
        Me.input_Nota1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Nota1.Location = New System.Drawing.Point(29, 290)
        Me.input_Nota1.MaxLength = 3
        Me.input_Nota1.Name = "input_Nota1"
        Me.input_Nota1.Size = New System.Drawing.Size(320, 27)
        Me.input_Nota1.TabIndex = 4
        Me.input_Nota1.Text = "Escribe La Nota 1"
        '
        'input_Nota3
        '
        Me.input_Nota3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Nota3.Location = New System.Drawing.Point(29, 290)
        Me.input_Nota3.MaxLength = 3
        Me.input_Nota3.Name = "input_Nota3"
        Me.input_Nota3.Size = New System.Drawing.Size(320, 27)
        Me.input_Nota3.TabIndex = 6
        Me.input_Nota3.Text = "Escribe La Nota 3"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.input_Nota3)
        Me.Panel2.Controls.Add(Me.input_Nota2)
        Me.Panel2.Controls.Add(Me.input_Nota1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.select_nota)
        Me.Panel2.Controls.Add(Me.Btn_Agregar_Notas)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 450)
        Me.Panel2.TabIndex = 17
        '
        'input_Nota2
        '
        Me.input_Nota2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Nota2.Location = New System.Drawing.Point(29, 290)
        Me.input_Nota2.MaxLength = 3
        Me.input_Nota2.Name = "input_Nota2"
        Me.input_Nota2.Size = New System.Drawing.Size(320, 27)
        Me.input_Nota2.TabIndex = 5
        Me.input_Nota2.Text = "Escribe La Nota 2"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(378, 448)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 62
        Me.LineShape1.X2 = 327
        Me.LineShape1.Y1 = 81
        Me.LineShape1.Y2 = 81
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 335)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(316, 20)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = "false"
        Me.TextBox1.Visible = False
        '
        'Form_Agregar_Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.select_materia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Agregar_Notas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Agregar_Notas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents select_materia As ComboBox
    Friend WithEvents Btn_Agregar_Notas As FontAwesome.Sharp.IconButton
    Friend WithEvents select_nota As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents input_Nota1 As TextBox
    Friend WithEvents input_Nota3 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents input_Nota2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
