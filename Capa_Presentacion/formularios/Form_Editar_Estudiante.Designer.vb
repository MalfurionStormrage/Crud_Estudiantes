<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Estudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Editar_Estudiante))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.input_Edit_Ide_Estu = New System.Windows.Forms.TextBox()
        Me.Select_Edit_Carrera_Estu = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.input_Edit_Usuario_Estu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.input_Edit_Edad_Estu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.input_Edit_Nombre_Estu = New System.Windows.Forms.TextBox()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Identificacion"
        '
        'input_Edit_Ide_Estu
        '
        Me.input_Edit_Ide_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Ide_Estu.Enabled = False
        Me.input_Edit_Ide_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Ide_Estu.Location = New System.Drawing.Point(24, 93)
        Me.input_Edit_Ide_Estu.Name = "input_Edit_Ide_Estu"
        Me.input_Edit_Ide_Estu.ReadOnly = True
        Me.input_Edit_Ide_Estu.Size = New System.Drawing.Size(322, 27)
        Me.input_Edit_Ide_Estu.TabIndex = 2
        '
        'Select_Edit_Carrera_Estu
        '
        Me.Select_Edit_Carrera_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Select_Edit_Carrera_Estu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_Edit_Carrera_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Select_Edit_Carrera_Estu.FormattingEnabled = True
        Me.Select_Edit_Carrera_Estu.Location = New System.Drawing.Point(24, 255)
        Me.Select_Edit_Carrera_Estu.Name = "Select_Edit_Carrera_Estu"
        Me.Select_Edit_Carrera_Estu.Size = New System.Drawing.Size(322, 29)
        Me.Select_Edit_Carrera_Estu.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Usuario que modifica"
        '
        'input_Edit_Usuario_Estu
        '
        Me.input_Edit_Usuario_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Usuario_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Usuario_Estu.Location = New System.Drawing.Point(24, 311)
        Me.input_Edit_Usuario_Estu.Name = "input_Edit_Usuario_Estu"
        Me.input_Edit_Usuario_Estu.Size = New System.Drawing.Size(322, 27)
        Me.input_Edit_Usuario_Estu.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Carrera"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Edad Del Estudiante"
        '
        'input_Edit_Edad_Estu
        '
        Me.input_Edit_Edad_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Edad_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Edad_Estu.Location = New System.Drawing.Point(24, 201)
        Me.input_Edit_Edad_Estu.MaxLength = 2
        Me.input_Edit_Edad_Estu.Name = "input_Edit_Edad_Estu"
        Me.input_Edit_Edad_Estu.Size = New System.Drawing.Size(322, 27)
        Me.input_Edit_Edad_Estu.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre Del Estudiante"
        '
        'input_Edit_Nombre_Estu
        '
        Me.input_Edit_Nombre_Estu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.input_Edit_Nombre_Estu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_Edit_Nombre_Estu.Location = New System.Drawing.Point(24, 147)
        Me.input_Edit_Nombre_Estu.Name = "input_Edit_Nombre_Estu"
        Me.input_Edit_Nombre_Estu.Size = New System.Drawing.Size(322, 27)
        Me.input_Edit_Nombre_Estu.TabIndex = 10
        '
        'IconButton6
        '
        Me.IconButton6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton6.ForeColor = System.Drawing.Color.White
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.IconButton6.IconColor = System.Drawing.Color.White
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 25
        Me.IconButton6.Location = New System.Drawing.Point(24, 366)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Size = New System.Drawing.Size(322, 53)
        Me.IconButton6.TabIndex = 11
        Me.IconButton6.Text = "Editar Datos"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 40)
        Me.Panel1.TabIndex = 12
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.Location = New System.Drawing.Point(340, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(40, 39)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Editar datos del estudiante"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(24, 425)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 27)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Visible = False
        '
        'Form_Editar_Estudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IconButton6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.input_Edit_Ide_Estu)
        Me.Controls.Add(Me.Select_Edit_Carrera_Estu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.input_Edit_Usuario_Estu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.input_Edit_Edad_Estu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.input_Edit_Nombre_Estu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Editar_Estudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Editar_Estudiante"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents input_Edit_Ide_Estu As TextBox
    Friend WithEvents Select_Edit_Carrera_Estu As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents input_Edit_Usuario_Estu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents input_Edit_Edad_Estu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents input_Edit_Nombre_Estu As TextBox
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox1 As TextBox
End Class
