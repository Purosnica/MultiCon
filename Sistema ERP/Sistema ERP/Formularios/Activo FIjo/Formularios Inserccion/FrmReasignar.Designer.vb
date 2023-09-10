<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReasignar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReasignar))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nomb_Art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridEmpleados = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnbusca = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GroupBox1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(628, 369)
        Me.GroupControl1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnbusca)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 353)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Empleado", "Departamento", "Ubicacion_Fisica"})
        Me.ComboBox1.Location = New System.Drawing.Point(440, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 27)
        Me.ComboBox1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.gridEmpleados)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 297)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empleados"
        '
        'btnsalir
        '
        Me.btnsalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnsalir.ImageOptions.Image = CType(resources.GetObject("btnsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsalir.Location = New System.Drawing.Point(497, 249)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 29)
        Me.btnsalir.TabIndex = 74
        Me.btnsalir.Text = "Salir"
        '
        'btnguardar
        '
        Me.btnguardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnguardar.ImageOptions.Image = CType(resources.GetObject("btnguardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(394, 249)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 29)
        Me.btnguardar.TabIndex = 73
        Me.btnguardar.Text = "Guardar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 210)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 21)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Asignar A :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nomb_Art, Me.Marca, Me.Serie, Me.Modelo, Me.CodEtiqueta})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(582, 174)
        Me.DataGridView1.TabIndex = 0
        '
        'Nomb_Art
        '
        Me.Nomb_Art.Frozen = True
        Me.Nomb_Art.HeaderText = "Nombre_Art"
        Me.Nomb_Art.Name = "Nomb_Art"
        Me.Nomb_Art.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.Frozen = True
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        '
        'Serie
        '
        Me.Serie.Frozen = True
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        '
        'Modelo
        '
        Me.Modelo.Frozen = True
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'CodEtiqueta
        '
        Me.CodEtiqueta.Frozen = True
        Me.CodEtiqueta.HeaderText = "Cod_Etiqueta"
        Me.CodEtiqueta.Name = "CodEtiqueta"
        Me.CodEtiqueta.ReadOnly = True
        '
        'gridEmpleados
        '
        Me.gridEmpleados.Location = New System.Drawing.Point(114, 203)
        Me.gridEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridEmpleados.Name = "gridEmpleados"
        Me.gridEmpleados.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridEmpleados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridEmpleados.Size = New System.Drawing.Size(297, 26)
        Me.gridEmpleados.TabIndex = 72
        '
        'btnbusca
        '
        Me.btnbusca.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnbusca.ImageOptions.Image = CType(resources.GetObject("btnbusca.ImageOptions.Image"), System.Drawing.Image)
        Me.btnbusca.Location = New System.Drawing.Point(267, 26)
        Me.btnbusca.Name = "btnbusca"
        Me.btnbusca.Size = New System.Drawing.Size(88, 23)
        Me.btnbusca.TabIndex = 1
        Me.btnbusca.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Articulo a Reasignar"
        '
        'FrmReasignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 369)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "FrmReasignar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reasignacion de Activos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nomb_Art As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Serie As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents CodEtiqueta As DataGridViewTextBoxColumn
    Friend WithEvents btnbusca As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents gridEmpleados As DevExpress.XtraEditors.LookUpEdit
End Class
