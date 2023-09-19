<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.MetroStatusBar3 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroStatusBar2 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.MetroStatusBar4 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Ingrese su Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Ingrese su Usuario"
        '
        'MetroStatusBar1
        '
        Me.MetroStatusBar1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar1.BackgroundStyle.BackColor = System.Drawing.Color.SlateBlue
        Me.MetroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar1.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroStatusBar1.DragDropSupport = True
        Me.MetroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar1.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar1.ItemSpacing = 10
        Me.MetroStatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(11, 158)
        Me.MetroStatusBar1.TabIndex = 82
        Me.MetroStatusBar1.TabStop = False
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(281, 71)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(93, 20)
        Me.txtpass.TabIndex = 80
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(281, 40)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(93, 20)
        Me.txtusuario.TabIndex = 79
        '
        'MetroStatusBar3
        '
        Me.MetroStatusBar3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar3.BackgroundStyle.BackColor = System.Drawing.Color.SlateBlue
        Me.MetroStatusBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar3.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar3.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroStatusBar3.DragDropSupport = True
        Me.MetroStatusBar3.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar3.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar3.ItemSpacing = 10
        Me.MetroStatusBar3.Location = New System.Drawing.Point(392, 0)
        Me.MetroStatusBar3.Name = "MetroStatusBar3"
        Me.MetroStatusBar3.Size = New System.Drawing.Size(11, 158)
        Me.MetroStatusBar3.TabIndex = 87
        Me.MetroStatusBar3.TabStop = False
        Me.MetroStatusBar3.Text = "MetroStatusBar3"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(126, 110)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(74, 32)
        Me.SimpleButton1.TabIndex = 88
        Me.SimpleButton1.Text = "Entrar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(215, 110)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(67, 32)
        Me.SimpleButton2.TabIndex = 89
        Me.SimpleButton2.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'MetroStatusBar2
        '
        Me.MetroStatusBar2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar2.BackgroundStyle.BackColor = System.Drawing.Color.SlateBlue
        Me.MetroStatusBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar2.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroStatusBar2.DragDropSupport = True
        Me.MetroStatusBar2.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar2.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1})
        Me.MetroStatusBar2.ItemSpacing = 10
        Me.MetroStatusBar2.Location = New System.Drawing.Point(11, 0)
        Me.MetroStatusBar2.Name = "MetroStatusBar2"
        Me.MetroStatusBar2.Size = New System.Drawing.Size(381, 15)
        Me.MetroStatusBar2.TabIndex = 91
        Me.MetroStatusBar2.TabStop = False
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelItem1.Width = 530
        '
        'MetroStatusBar4
        '
        Me.MetroStatusBar4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar4.BackgroundStyle.BackColor = System.Drawing.Color.SlateBlue
        Me.MetroStatusBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar4.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroStatusBar4.DragDropSupport = True
        Me.MetroStatusBar4.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar4.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar4.ItemSpacing = 10
        Me.MetroStatusBar4.Location = New System.Drawing.Point(0, 158)
        Me.MetroStatusBar4.Name = "MetroStatusBar4"
        Me.MetroStatusBar4.Size = New System.Drawing.Size(403, 16)
        Me.MetroStatusBar4.TabIndex = 81
        Me.MetroStatusBar4.TabStop = False
        '
        'LabelItem3
        '
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelItem3.Width = 530
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(403, 174)
        Me.Controls.Add(Me.MetroStatusBar2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.MetroStatusBar3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroStatusBar4)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents MetroStatusBar3 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroStatusBar2 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents MetroStatusBar4 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
End Class
