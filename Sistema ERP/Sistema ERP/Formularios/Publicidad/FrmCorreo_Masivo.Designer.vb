<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorreo_Masivo
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCorreo_Masivo))
        Me.MetroStatusBar2 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar5 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar4 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCargaCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiarC = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnasignarImg = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiarImg = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescri = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroStatusBar2
        '
        Me.MetroStatusBar2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar2.BackgroundStyle.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MetroStatusBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar2.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroStatusBar2.DragDropSupport = True
        Me.MetroStatusBar2.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar2.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar2.ItemSpacing = 10
        Me.MetroStatusBar2.Location = New System.Drawing.Point(895, 10)
        Me.MetroStatusBar2.Name = "MetroStatusBar2"
        Me.MetroStatusBar2.Size = New System.Drawing.Size(11, 456)
        Me.MetroStatusBar2.TabIndex = 253
        Me.MetroStatusBar2.TabStop = False
        Me.MetroStatusBar2.Text = "MetroStatusBar2"
        '
        'MetroStatusBar5
        '
        Me.MetroStatusBar5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar5.BackgroundStyle.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MetroStatusBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar5.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroStatusBar5.DragDropSupport = True
        Me.MetroStatusBar5.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar5.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar5.ItemSpacing = 10
        Me.MetroStatusBar5.Location = New System.Drawing.Point(11, 466)
        Me.MetroStatusBar5.Name = "MetroStatusBar5"
        Me.MetroStatusBar5.Size = New System.Drawing.Size(895, 10)
        Me.MetroStatusBar5.TabIndex = 252
        Me.MetroStatusBar5.TabStop = False
        Me.MetroStatusBar5.Text = "MetroStatusBar5"
        '
        'MetroStatusBar1
        '
        Me.MetroStatusBar1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar1.BackgroundStyle.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MetroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar1.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroStatusBar1.DragDropSupport = True
        Me.MetroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar1.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar1.ItemSpacing = 10
        Me.MetroStatusBar1.Location = New System.Drawing.Point(0, 10)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(11, 466)
        Me.MetroStatusBar1.TabIndex = 251
        Me.MetroStatusBar1.TabStop = False
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'MetroStatusBar4
        '
        Me.MetroStatusBar4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroStatusBar4.BackgroundStyle.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MetroStatusBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar4.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroStatusBar4.DragDropSupport = True
        Me.MetroStatusBar4.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar4.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar4.ItemSpacing = 10
        Me.MetroStatusBar4.Location = New System.Drawing.Point(0, 0)
        Me.MetroStatusBar4.Name = "MetroStatusBar4"
        Me.MetroStatusBar4.Size = New System.Drawing.Size(906, 10)
        Me.MetroStatusBar4.TabIndex = 250
        Me.MetroStatusBar4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnCargaCliente)
        Me.GroupBox1.Controls.Add(Me.btnLimpiarC)
        Me.GroupBox1.Controls.Add(Me.GridControl2)
        Me.GroupBox1.Controls.Add(Me.btnEnviar)
        Me.GroupBox1.Controls.Add(Me.btnasignarImg)
        Me.GroupBox1.Controls.Add(Me.btnLimpiarImg)
        Me.GroupBox1.Controls.Add(Me.PictureEdit1)
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdescri)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 444)
        Me.GroupBox1.TabIndex = 254
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Envio"
        '
        'btnSalir
        '
        Me.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(753, 409)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(109, 29)
        Me.btnSalir.TabIndex = 274
        Me.btnSalir.Text = "Cancelar"
        '
        'btnCargaCliente
        '
        Me.btnCargaCliente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCargaCliente.ImageOptions.Image = CType(resources.GetObject("btnCargaCliente.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCargaCliente.Location = New System.Drawing.Point(728, 33)
        Me.btnCargaCliente.Name = "btnCargaCliente"
        Me.btnCargaCliente.Size = New System.Drawing.Size(138, 29)
        Me.btnCargaCliente.TabIndex = 273
        Me.btnCargaCliente.Text = "Carga Campaña"
        '
        'btnLimpiarC
        '
        Me.btnLimpiarC.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnLimpiarC.ImageOptions.Image = CType(resources.GetObject("btnLimpiarC.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLimpiarC.Location = New System.Drawing.Point(638, 33)
        Me.btnLimpiarC.Name = "btnLimpiarC"
        Me.btnLimpiarC.Size = New System.Drawing.Size(84, 29)
        Me.btnLimpiarC.TabIndex = 272
        Me.btnLimpiarC.Text = "Limpiar"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(638, 75)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(228, 328)
        Me.GridControl2.TabIndex = 271
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'btnEnviar
        '
        Me.btnEnviar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnEnviar.ImageOptions.Image = CType(resources.GetObject("btnEnviar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEnviar.Location = New System.Drawing.Point(638, 409)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(109, 29)
        Me.btnEnviar.TabIndex = 270
        Me.btnEnviar.Text = "Enviar"
        '
        'btnasignarImg
        '
        Me.btnasignarImg.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnasignarImg.ImageOptions.Image = CType(resources.GetObject("btnasignarImg.ImageOptions.Image"), System.Drawing.Image)
        Me.btnasignarImg.Location = New System.Drawing.Point(457, 75)
        Me.btnasignarImg.Name = "btnasignarImg"
        Me.btnasignarImg.Size = New System.Drawing.Size(174, 29)
        Me.btnasignarImg.TabIndex = 269
        Me.btnasignarImg.Text = "Asignar Imagen"
        '
        'btnLimpiarImg
        '
        Me.btnLimpiarImg.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnLimpiarImg.ImageOptions.Image = CType(resources.GetObject("btnLimpiarImg.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLimpiarImg.Location = New System.Drawing.Point(421, 75)
        Me.btnLimpiarImg.Name = "btnLimpiarImg"
        Me.btnLimpiarImg.Size = New System.Drawing.Size(30, 29)
        Me.btnLimpiarImg.TabIndex = 268
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(421, 110)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(210, 179)
        Me.PictureEdit1.TabIndex = 267
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(100, 295)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(531, 143)
        Me.GridControl1.TabIndex = 266
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Adjunto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 75)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(315, 214)
        Me.TextBox1.TabIndex = 264
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Cuerpo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdescri
        '
        Me.txtdescri.Location = New System.Drawing.Point(100, 33)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtdescri.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtdescri.Properties.Appearance.Options.UseBackColor = True
        Me.txtdescri.Properties.Appearance.Options.UseForeColor = True
        Me.txtdescri.Size = New System.Drawing.Size(531, 20)
        Me.txtdescri.TabIndex = 262
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 261
        Me.Label6.Text = "Asunto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = "XtraOpenFileDialog1"
        '
        'FrmCorreo_Masivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(906, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroStatusBar2)
        Me.Controls.Add(Me.MetroStatusBar5)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroStatusBar4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "FrmCorreo_Masivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Correos Masivos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroStatusBar2 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar5 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar4 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdescri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents btnasignarImg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiarImg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCargaCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiarC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
End Class
