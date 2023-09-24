<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Campañas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Campañas))
        Me.MetroStatusBar2 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar5 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar4 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.txtdescri = New DevExpress.XtraEditors.TextEdit()
        Me.txtauto = New DevExpress.XtraEditors.TextEdit()
        Me.Btnsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnagregar = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtauto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroStatusBar2.Location = New System.Drawing.Point(554, 10)
        Me.MetroStatusBar2.Name = "MetroStatusBar2"
        Me.MetroStatusBar2.Size = New System.Drawing.Size(11, 521)
        Me.MetroStatusBar2.TabIndex = 257
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
        Me.MetroStatusBar5.Location = New System.Drawing.Point(11, 531)
        Me.MetroStatusBar5.Name = "MetroStatusBar5"
        Me.MetroStatusBar5.Size = New System.Drawing.Size(554, 10)
        Me.MetroStatusBar5.TabIndex = 256
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
        Me.MetroStatusBar1.Size = New System.Drawing.Size(11, 531)
        Me.MetroStatusBar1.TabIndex = 255
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
        Me.MetroStatusBar4.Size = New System.Drawing.Size(565, 10)
        Me.MetroStatusBar4.TabIndex = 254
        Me.MetroStatusBar4.TabStop = False
        '
        'txtdescri
        '
        Me.txtdescri.Location = New System.Drawing.Point(102, 76)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(320, 20)
        Me.txtdescri.TabIndex = 276
        '
        'txtauto
        '
        Me.txtauto.EditValue = "AUTO"
        Me.txtauto.Enabled = False
        Me.txtauto.Location = New System.Drawing.Point(102, 20)
        Me.txtauto.Name = "txtauto"
        Me.txtauto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauto.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtauto.Properties.Appearance.Options.UseFont = True
        Me.txtauto.Properties.Appearance.Options.UseForeColor = True
        Me.txtauto.Size = New System.Drawing.Size(77, 20)
        Me.txtauto.TabIndex = 275
        '
        'Btnsalir
        '
        Me.Btnsalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Btnsalir.ImageOptions.Image = CType(resources.GetObject("Btnsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.Btnsalir.Location = New System.Drawing.Point(465, 496)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(79, 29)
        Me.Btnsalir.TabIndex = 274
        Me.Btnsalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(355, 496)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 29)
        Me.btnGuardar.TabIndex = 273
        Me.btnGuardar.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 22)
        Me.Label2.TabIndex = 272
        Me.Label2.Text = "Codigo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 28)
        Me.Label6.TabIndex = 271
        Me.Label6.Text = "Descripcion "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(102, 48)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(114, 20)
        Me.DateEdit1.TabIndex = 277
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(308, 48)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(114, 20)
        Me.DateEdit2.TabIndex = 278
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 279
        Me.Label1.Text = "Fecha Inicio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 28)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "Fecha Final"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtauto)
        Me.GroupBox1.Controls.Add(Me.txtdescri)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateEdit1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateEdit2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 112)
        Me.GroupBox1.TabIndex = 282
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Campañas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 295)
        Me.GroupBox2.TabIndex = 283
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Segmento"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 18)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(520, 274)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnagregar)
        Me.GroupBox3.Controls.Add(Me.LookUpEdit1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(527, 55)
        Me.GroupBox3.TabIndex = 284
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Segmentos"
        '
        'btnagregar
        '
        Me.btnagregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnagregar.ImageOptions.Image = CType(resources.GetObject("btnagregar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnagregar.Location = New System.Drawing.Point(350, 14)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(72, 29)
        Me.btnagregar.TabIndex = 286
        Me.btnagregar.Text = "Agregar"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(92, 23)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Size = New System.Drawing.Size(140, 20)
        Me.LookUpEdit1.TabIndex = 285
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 28)
        Me.Label4.TabIndex = 284
        Me.Label4.Text = "Segmentos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnLimpiar.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(274, 14)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(70, 29)
        Me.btnLimpiar.TabIndex = 287
        Me.btnLimpiar.Text = "Limpiar"
        '
        'Frm_Campañas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 541)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MetroStatusBar2)
        Me.Controls.Add(Me.MetroStatusBar5)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroStatusBar4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_Campañas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campañas"
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtauto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroStatusBar2 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar5 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar4 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents txtdescri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtauto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Btnsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnagregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
End Class
