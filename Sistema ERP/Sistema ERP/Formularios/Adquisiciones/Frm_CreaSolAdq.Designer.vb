<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CreaSolAdq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CreaSolAdq))
        Me.MetroStatusBar2 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar5 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar4 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Btnsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcantidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtmedida = New DevExpress.XtraEditors.TextEdit()
        Me.txtdescicod = New DevExpress.XtraEditors.TextEdit()
        Me.btnbuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtcodigo = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grdsolicitud = New DevExpress.XtraGrid.GridControl()
        Me.gvsolicitud = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtobs = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.cmbuso = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbcompraT = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdepto = New DevExpress.XtraEditors.TextEdit()
        Me.txtcargo = New DevExpress.XtraEditors.TextEdit()
        Me.cmbcompra = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbsolicitante = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbdeptodes = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtcantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmedida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescicod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grdsolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvsolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtobs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbuso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcompraT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbsolicitante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbdeptodes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroStatusBar2.Location = New System.Drawing.Point(816, 10)
        Me.MetroStatusBar2.Name = "MetroStatusBar2"
        Me.MetroStatusBar2.Size = New System.Drawing.Size(11, 585)
        Me.MetroStatusBar2.TabIndex = 285
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
        Me.MetroStatusBar5.Location = New System.Drawing.Point(11, 595)
        Me.MetroStatusBar5.Name = "MetroStatusBar5"
        Me.MetroStatusBar5.Size = New System.Drawing.Size(816, 10)
        Me.MetroStatusBar5.TabIndex = 284
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
        Me.MetroStatusBar1.Size = New System.Drawing.Size(11, 595)
        Me.MetroStatusBar1.TabIndex = 283
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
        Me.MetroStatusBar4.Size = New System.Drawing.Size(827, 10)
        Me.MetroStatusBar4.TabIndex = 282
        Me.MetroStatusBar4.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.Btnsalir)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txtcantidad)
        Me.GroupControl1.Controls.Add(Me.txtmedida)
        Me.GroupControl1.Controls.Add(Me.txtdescicod)
        Me.GroupControl1.Controls.Add(Me.btnbuscar)
        Me.GroupControl1.Controls.Add(Me.txtcodigo)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(11, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(805, 585)
        Me.GroupControl1.TabIndex = 286
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(533, 548)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(84, 29)
        Me.SimpleButton2.TabIndex = 301
        Me.SimpleButton2.Text = "Eliminar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(434, 548)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(84, 29)
        Me.SimpleButton1.TabIndex = 300
        Me.SimpleButton1.Text = "Editar"
        '
        'Btnsalir
        '
        Me.Btnsalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Btnsalir.ImageOptions.Image = CType(resources.GetObject("Btnsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.Btnsalir.Location = New System.Drawing.Point(716, 548)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(79, 29)
        Me.Btnsalir.TabIndex = 299
        Me.Btnsalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(344, 548)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 29)
        Me.btnGuardar.TabIndex = 298
        Me.btnGuardar.Text = "Guardar"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(702, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 19)
        Me.Label12.TabIndex = 297
        Me.Label12.Text = "Cantidad"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(611, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 296
        Me.Label11.Text = "Medida"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(702, 218)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(95, 26)
        Me.txtcantidad.TabIndex = 295
        '
        'txtmedida
        '
        Me.txtmedida.Enabled = False
        Me.txtmedida.Location = New System.Drawing.Point(611, 218)
        Me.txtmedida.Name = "txtmedida"
        Me.txtmedida.Size = New System.Drawing.Size(88, 26)
        Me.txtmedida.TabIndex = 294
        '
        'txtdescicod
        '
        Me.txtdescicod.Enabled = False
        Me.txtdescicod.Location = New System.Drawing.Point(319, 218)
        Me.txtdescicod.Name = "txtdescicod"
        Me.txtdescicod.Size = New System.Drawing.Size(286, 26)
        Me.txtdescicod.TabIndex = 293
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(238, 216)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 22)
        Me.btnbuscar.TabIndex = 292
        Me.btnbuscar.Text = "Buscar"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(123, 218)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(109, 26)
        Me.txtcodigo.TabIndex = 291
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 22)
        Me.Label10.TabIndex = 290
        Me.Label10.Text = "Digite el Codigo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupControl2
        '
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GroupControl2.Controls.Add(Me.grdsolicitud)
        Me.GroupControl2.Location = New System.Drawing.Point(7, 250)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(790, 292)
        Me.GroupControl2.TabIndex = 289
        '
        'grdsolicitud
        '
        Me.grdsolicitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdsolicitud.Location = New System.Drawing.Point(3, 30)
        Me.grdsolicitud.MainView = Me.gvsolicitud
        Me.grdsolicitud.Name = "grdsolicitud"
        Me.grdsolicitud.Size = New System.Drawing.Size(784, 259)
        Me.grdsolicitud.TabIndex = 0
        Me.grdsolicitud.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvsolicitud})
        '
        'gvsolicitud
        '
        Me.gvsolicitud.GridControl = Me.grdsolicitud
        Me.gvsolicitud.Name = "gvsolicitud"
        Me.gvsolicitud.OptionsView.ShowGroupPanel = False
        '
        'GroupControl3
        '
        Me.GroupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl3.Controls.Add(Me.txtobs)
        Me.GroupControl3.Controls.Add(Me.Label9)
        Me.GroupControl3.Controls.Add(Me.Label8)
        Me.GroupControl3.Controls.Add(Me.fecha)
        Me.GroupControl3.Controls.Add(Me.cmbuso)
        Me.GroupControl3.Controls.Add(Me.cmbcompraT)
        Me.GroupControl3.Controls.Add(Me.Label7)
        Me.GroupControl3.Controls.Add(Me.Label6)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.txtdepto)
        Me.GroupControl3.Controls.Add(Me.txtcargo)
        Me.GroupControl3.Controls.Add(Me.cmbcompra)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Controls.Add(Me.cmbsolicitante)
        Me.GroupControl3.Controls.Add(Me.cmbdeptodes)
        Me.GroupControl3.Location = New System.Drawing.Point(9, 23)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(786, 170)
        Me.GroupControl3.TabIndex = 288
        '
        'txtobs
        '
        Me.txtobs.Location = New System.Drawing.Point(123, 146)
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(630, 26)
        Me.txtobs.TabIndex = 290
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 22)
        Me.Label9.TabIndex = 289
        Me.Label9.Text = "Observaciones"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(397, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 22)
        Me.Label8.TabIndex = 286
        Me.Label8.Text = "Departamento Destino"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fecha
        '
        Me.fecha.EditValue = New Date(2019, 10, 31, 15, 46, 46, 0)
        Me.fecha.Location = New System.Drawing.Point(551, 86)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Size = New System.Drawing.Size(202, 26)
        Me.fecha.TabIndex = 285
        '
        'cmbuso
        '
        Me.cmbuso.EditValue = "USO DIRECTO"
        Me.cmbuso.Location = New System.Drawing.Point(551, 56)
        Me.cmbuso.Name = "cmbuso"
        Me.cmbuso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbuso.Properties.DropDownRows = 2
        Me.cmbuso.Properties.Items.AddRange(New Object() {"USO DIRECTO", "EXISTENCIA"})
        Me.cmbuso.Size = New System.Drawing.Size(202, 26)
        Me.cmbuso.TabIndex = 284
        '
        'cmbcompraT
        '
        Me.cmbcompraT.EditValue = "Compra"
        Me.cmbcompraT.Location = New System.Drawing.Point(553, 20)
        Me.cmbcompraT.Name = "cmbcompraT"
        Me.cmbcompraT.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcompraT.Properties.Appearance.Options.UseFont = True
        Me.cmbcompraT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcompraT.Properties.DropDownRows = 2
        Me.cmbcompraT.Properties.Items.AddRange(New Object() {"COMPRA", "SERVICIOS"})
        Me.cmbcompraT.Size = New System.Drawing.Size(202, 28)
        Me.cmbcompraT.TabIndex = 283
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(397, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 22)
        Me.Label7.TabIndex = 282
        Me.Label7.Text = "Fecha de Solicitud"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(397, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Tipo de Uso :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(397, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 22)
        Me.Label5.TabIndex = 280
        Me.Label5.Text = "Tipo de Compra Local :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdepto
        '
        Me.txtdepto.Enabled = False
        Me.txtdepto.Location = New System.Drawing.Point(136, 115)
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.Size = New System.Drawing.Size(217, 26)
        Me.txtdepto.TabIndex = 279
        '
        'txtcargo
        '
        Me.txtcargo.Enabled = False
        Me.txtcargo.Location = New System.Drawing.Point(136, 84)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(217, 26)
        Me.txtcargo.TabIndex = 278
        '
        'cmbcompra
        '
        Me.cmbcompra.EditValue = "Local"
        Me.cmbcompra.Location = New System.Drawing.Point(136, 20)
        Me.cmbcompra.Name = "cmbcompra"
        Me.cmbcompra.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcompra.Properties.Appearance.Options.UseFont = True
        Me.cmbcompra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcompra.Properties.DropDownRows = 2
        Me.cmbcompra.Properties.Items.AddRange(New Object() {"LOCAL", "IMPORTACIONES"})
        Me.cmbcompra.Size = New System.Drawing.Size(219, 28)
        Me.cmbcompra.TabIndex = 276
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 22)
        Me.Label4.TabIndex = 275
        Me.Label4.Text = "Depto Empleado:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 274
        Me.Label2.Text = "Cargo Empleado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 22)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "Solicitado Por:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 272
        Me.Label3.Text = "Tipo de Compra :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbsolicitante
        '
        Me.cmbsolicitante.EditValue = ""
        Me.cmbsolicitante.Location = New System.Drawing.Point(134, 51)
        Me.cmbsolicitante.Name = "cmbsolicitante"
        Me.cmbsolicitante.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsolicitante.Properties.Appearance.Options.UseFont = True
        Me.cmbsolicitante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbsolicitante.Properties.NullText = ""
        Me.cmbsolicitante.Properties.PopupSizeable = False
        Me.cmbsolicitante.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbsolicitante.Size = New System.Drawing.Size(219, 28)
        Me.cmbsolicitante.TabIndex = 291
        '
        'cmbdeptodes
        '
        Me.cmbdeptodes.Location = New System.Drawing.Point(551, 116)
        Me.cmbdeptodes.Name = "cmbdeptodes"
        Me.cmbdeptodes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbdeptodes.Properties.NullText = ""
        Me.cmbdeptodes.Properties.PopupSizeable = False
        Me.cmbdeptodes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbdeptodes.Size = New System.Drawing.Size(202, 26)
        Me.cmbdeptodes.TabIndex = 287
        '
        'Frm_CreaSolAdq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 605)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.MetroStatusBar2)
        Me.Controls.Add(Me.MetroStatusBar5)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroStatusBar4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_CreaSolAdq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Compra"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtcantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmedida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescicod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grdsolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvsolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtobs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbuso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcompraT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbsolicitante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbdeptodes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroStatusBar2 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar5 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar4 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbuso As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbcompraT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbcompra As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtobs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmedida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdescicod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnbuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As Label
    Friend WithEvents grdsolicitud As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvsolicitud As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Btnsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbsolicitante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbdeptodes As DevExpress.XtraEditors.LookUpEdit
End Class
