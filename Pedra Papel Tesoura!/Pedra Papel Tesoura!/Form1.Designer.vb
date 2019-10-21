<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rdbRock = New System.Windows.Forms.RadioButton()
        Me.rdbPaper = New System.Windows.Forms.RadioButton()
        Me.rdbScissor = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Luta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rdbRock
        '
        Me.rdbRock.AutoSize = True
        Me.rdbRock.Location = New System.Drawing.Point(94, 324)
        Me.rdbRock.Name = "rdbRock"
        Me.rdbRock.Size = New System.Drawing.Size(53, 17)
        Me.rdbRock.TabIndex = 1
        Me.rdbRock.TabStop = True
        Me.rdbRock.Text = "Pedra"
        Me.rdbRock.UseVisualStyleBackColor = True
        '
        'rdbPaper
        '
        Me.rdbPaper.AutoSize = True
        Me.rdbPaper.Location = New System.Drawing.Point(363, 324)
        Me.rdbPaper.Name = "rdbPaper"
        Me.rdbPaper.Size = New System.Drawing.Size(52, 17)
        Me.rdbPaper.TabIndex = 2
        Me.rdbPaper.TabStop = True
        Me.rdbPaper.Text = "Papel"
        Me.rdbPaper.UseVisualStyleBackColor = True
        '
        'rdbScissor
        '
        Me.rdbScissor.AutoSize = True
        Me.rdbScissor.Location = New System.Drawing.Point(613, 324)
        Me.rdbScissor.Name = "rdbScissor"
        Me.rdbScissor.Size = New System.Drawing.Size(64, 17)
        Me.rdbScissor.TabIndex = 3
        Me.rdbScissor.TabStop = True
        Me.rdbScissor.Text = "Tesoura"
        Me.rdbScissor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escolhe"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pedra_Papel_Tesoura_.My.Resources.Resources.ROCK
        Me.PictureBox1.Location = New System.Drawing.Point(70, 154)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Pedra_Papel_Tesoura_.My.Resources.Resources.PAPER
        Me.PictureBox2.Location = New System.Drawing.Point(331, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Pedra_Papel_Tesoura_.My.Resources.Resources.SCISSORS
        Me.PictureBox3.Location = New System.Drawing.Point(602, 154)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(123, 134)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdbScissor)
        Me.Controls.Add(Me.rdbPaper)
        Me.Controls.Add(Me.rdbRock)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents rdbRock As RadioButton
    Friend WithEvents rdbPaper As RadioButton
    Friend WithEvents rdbScissor As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
