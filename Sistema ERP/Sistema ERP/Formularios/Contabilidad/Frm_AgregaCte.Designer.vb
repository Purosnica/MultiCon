<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AgregaCte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AgregaCte))
        Me.MetroStatusBar2 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.txtabrevia = New DevExpress.XtraEditors.TextEdit()
        Me.txtdescri = New DevExpress.XtraEditors.TextEdit()
        Me.txtauto = New DevExpress.XtraEditors.TextEdit()
        Me.Btnsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroStatusBar5 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar4 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        CType(Me.txtabrevia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtauto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroStatusBar2.Location = New System.Drawing.Point(365, 10)
        Me.MetroStatusBar2.Name = "MetroStatusBar2"
        Me.MetroStatusBar2.Size = New System.Drawing.Size(11, 164)
        Me.MetroStatusBar2.TabIndex = 261
        Me.MetroStatusBar2.TabStop = False
        Me.MetroStatusBar2.Text = "MetroStatusBar2"
        '
        'txtabrevia
        '
        Me.txtabrevia.Location = New System.Drawing.Point(116, 96)
        Me.txtabrevia.Name = "txtabrevia"
        Me.txtabrevia.Size = New System.Drawing.Size(231, 20)
        Me.txtabrevia.TabIndex = 260
        '
        'txtdescri
        '
        Me.txtdescri.Location = New System.Drawing.Point(116, 64)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(231, 20)
        Me.txtdescri.TabIndex = 259
        '
        'txtauto
        '
        Me.txtauto.EditValue = "AUTO"
        Me.txtauto.Enabled = False
        Me.txtauto.Location = New System.Drawing.Point(116, 30)
        Me.txtauto.Name = "txtauto"
        Me.txtauto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauto.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtauto.Properties.Appearance.Options.UseFont = True
        Me.txtauto.Properties.Appearance.Options.UseForeColor = True
        Me.txtauto.Size = New System.Drawing.Size(169, 20)
        Me.txtauto.TabIndex = 258
        '
        'Btnsalir
        '
        Me.Btnsalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Btnsalir.ImageOptions.Image = CType(resources.GetObject("Btnsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.Btnsalir.Location = New System.Drawing.Point(266, 131)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(79, 29)
        Me.Btnsalir.TabIndex = 257
        Me.Btnsalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(176, 131)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 29)
        Me.btnGuardar.TabIndex = 256
        Me.btnGuardar.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 255
        Me.Label2.Text = "Codigo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 254
        Me.Label1.Text = "Abreviatura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 22)
        Me.Label6.TabIndex = 253
        Me.Label6.Text = "Descripcion "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.MetroStatusBar5.Location = New System.Drawing.Point(11, 174)
        Me.MetroStatusBar5.Name = "MetroStatusBar5"
        Me.MetroStatusBar5.Size = New System.Drawing.Size(365, 10)
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
        Me.MetroStatusBar1.Size = New System.Drawing.Size(11, 174)
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
        Me.MetroStatusBar4.Size = New System.Drawing.Size(376, 10)
        Me.MetroStatusBar4.TabIndex = 250
        Me.MetroStatusBar4.TabStop = False
        '
        'Frm_AgregaCte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 184)
        Me.Controls.Add(Me.MetroStatusBar2)
        Me.Controls.Add(Me.txtabrevia)
        Me.Controls.Add(Me.txtdescri)
        Me.Controls.Add(Me.txtauto)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MetroStatusBar5)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroStatusBar4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_AgregaCte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Comprobante"
        CType(Me.txtabrevia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtauto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroStatusBar2 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents txtabrevia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdescri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtauto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Btnsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MetroStatusBar5 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar4 As DevComponents.DotNetBar.Metro.MetroStatusBar
End Class
