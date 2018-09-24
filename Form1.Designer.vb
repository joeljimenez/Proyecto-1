<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.progreso = New System.Windows.Forms.Label()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.indice = New System.Windows.Forms.Label()
        Me.borrar = New System.Windows.Forms.Label()
        Me.resul = New System.Windows.Forms.Label()
        Me.temporal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcorrecta = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tem = New System.Windows.Forms.Label()
        Me.conta = New System.Windows.Forms.Label()
        Me.r = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_iniciar
        '
        Me.btn_iniciar.BackColor = System.Drawing.Color.White
        Me.btn_iniciar.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciar.Location = New System.Drawing.Point(315, 258)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(144, 55)
        Me.btn_iniciar.TabIndex = 0
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(389, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 55)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "borrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(559, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 55)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Siguiente"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(64, 329)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 55)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Resolver"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(227, 329)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 55)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Borrar Todo"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'reloj
        '
        Me.reloj.Interval = 1000
        '
        'progreso
        '
        Me.progreso.AutoSize = True
        Me.progreso.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progreso.Location = New System.Drawing.Point(650, 34)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(36, 22)
        Me.progreso.TabIndex = 6
        Me.progreso.Text = "60"
        '
        'txtresultado
        '
        Me.txtresultado.BackColor = System.Drawing.Color.White
        Me.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtresultado.Enabled = False
        Me.txtresultado.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresultado.Location = New System.Drawing.Point(629, 95)
        Me.txtresultado.MaxLength = 2
        Me.txtresultado.Multiline = True
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(74, 39)
        Me.txtresultado.TabIndex = 55
        Me.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(84, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 27)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Operaciones Matematicas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Penultimate", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(626, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Correcta"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.Proyecto1._0.My.Resources.Resources.if_minus_1772613
        Me.Button8.Location = New System.Drawing.Point(315, 209)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 43)
        Me.Button8.TabIndex = 61
        Me.Button8.Text = "-"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.Proyecto1._0.My.Resources.Resources.if_division_1772625
        Me.Button7.Location = New System.Drawing.Point(376, 209)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 43)
        Me.Button7.TabIndex = 60
        Me.Button7.Text = "/"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.Proyecto1._0.My.Resources.Resources.if_multiplication_1772632
        Me.Button6.Location = New System.Drawing.Point(435, 209)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 43)
        Me.Button6.TabIndex = 59
        Me.Button6.Text = "*"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Proyecto1._0.My.Resources.Resources.if_plus_1772631
        Me.Button1.Location = New System.Drawing.Point(252, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 43)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'indice
        '
        Me.indice.AutoSize = True
        Me.indice.Location = New System.Drawing.Point(112, 258)
        Me.indice.Name = "indice"
        Me.indice.Size = New System.Drawing.Size(45, 17)
        Me.indice.TabIndex = 62
        Me.indice.Text = "Indice"
        Me.indice.Visible = False
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.Location = New System.Drawing.Point(96, 279)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(77, 17)
        Me.borrar.TabIndex = 63
        Me.borrar.Text = "ContBorrar"
        Me.borrar.Visible = False
        '
        'resul
        '
        Me.resul.AutoSize = True
        Me.resul.Font = New System.Drawing.Font("Penultimate", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resul.ForeColor = System.Drawing.Color.Red
        Me.resul.Location = New System.Drawing.Point(650, 175)
        Me.resul.Name = "resul"
        Me.resul.Size = New System.Drawing.Size(23, 21)
        Me.resul.TabIndex = 64
        Me.resul.Text = "0"
        Me.resul.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'temporal
        '
        Me.temporal.AutoSize = True
        Me.temporal.Location = New System.Drawing.Point(95, 296)
        Me.temporal.Name = "temporal"
        Me.temporal.Size = New System.Drawing.Size(68, 17)
        Me.temporal.TabIndex = 65
        Me.temporal.Text = "Temporal"
        Me.temporal.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Penultimate", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Penultimate", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(626, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Respuesta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(63, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 27)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "JOEL JIMENEZ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(325, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 27)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "8-923-678"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Penultimate", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(556, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 27)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "1LS-231"
        '
        'txtcorrecta
        '
        Me.txtcorrecta.AutoSize = True
        Me.txtcorrecta.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcorrecta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcorrecta.Location = New System.Drawing.Point(650, 255)
        Me.txtcorrecta.Name = "txtcorrecta"
        Me.txtcorrecta.Size = New System.Drawing.Size(23, 22)
        Me.txtcorrecta.TabIndex = 71
        Me.txtcorrecta.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Penultimate", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(626, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Resueltas"
        '
        'tem
        '
        Me.tem.AutoSize = True
        Me.tem.Location = New System.Drawing.Point(106, 241)
        Me.tem.Name = "tem"
        Me.tem.Size = New System.Drawing.Size(51, 17)
        Me.tem.TabIndex = 73
        Me.tem.Text = "Label9"
        Me.tem.Visible = False
        '
        'conta
        '
        Me.conta.AutoSize = True
        Me.conta.Location = New System.Drawing.Point(106, 224)
        Me.conta.Name = "conta"
        Me.conta.Size = New System.Drawing.Size(51, 17)
        Me.conta.TabIndex = 74
        Me.conta.Text = "Label9"
        Me.conta.Visible = False
        '
        'r
        '
        Me.r.AutoSize = True
        Me.r.Location = New System.Drawing.Point(636, 298)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(51, 17)
        Me.r.TabIndex = 75
        Me.r.Text = "Label9"
        Me.r.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Penultimate", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(557, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 21)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Tiempo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 445)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.r)
        Me.Controls.Add(Me.conta)
        Me.Controls.Add(Me.tem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcorrecta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.temporal)
        Me.Controls.Add(Me.resul)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.indice)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Juego-Matematico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_iniciar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents reloj As Timer
    Friend WithEvents progreso As Label
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents indice As Label
    Friend WithEvents borrar As Label
    Friend WithEvents resul As Label
    Friend WithEvents temporal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcorrecta As Label
    Public WithEvents Label8 As Label
    Friend WithEvents tem As Label
    Friend WithEvents conta As Label
    Friend WithEvents r As Label
    Friend WithEvents Label9 As Label
End Class
