<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulo))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcodart = New DevExpress.XtraEditors.TextEdit()
        Me.txtdescri = New DevExpress.XtraEditors.TextEdit()
        Me.txtmarca = New DevExpress.XtraEditors.TextEdit()
        Me.txtmodelo = New DevExpress.XtraEditors.TextEdit()
        Me.txtserie = New DevExpress.XtraEditors.TextEdit()
        Me.txtdimensiones = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.cmbempleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbarea = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbubicacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.MetroStatusBar2 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar5 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.MetroStatusBar4 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        CType(Me.txtcodart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmodelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtserie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdimensiones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbempleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbarea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbubicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(34, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Cod_Articulo "
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(34, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Descripcion"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(33, 107)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 19)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Marca"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(33, 148)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Modelo"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(33, 183)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(35, 19)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Serie"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(33, 215)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Dimensiones"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(34, 250)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(66, 19)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Asignado"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(34, 287)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Area"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(33, 320)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = " Ubicacion"
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(129, 30)
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(154, 26)
        Me.txtcodart.TabIndex = 9
        '
        'txtdescri
        '
        Me.txtdescri.Location = New System.Drawing.Point(129, 68)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(154, 26)
        Me.txtdescri.TabIndex = 10
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(129, 104)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(154, 26)
        Me.txtmarca.TabIndex = 11
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(129, 141)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(154, 26)
        Me.txtmodelo.TabIndex = 12
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(129, 176)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(154, 26)
        Me.txtserie.TabIndex = 13
        '
        'txtdimensiones
        '
        Me.txtdimensiones.Location = New System.Drawing.Point(129, 208)
        Me.txtdimensiones.Name = "txtdimensiones"
        Me.txtdimensiones.Size = New System.Drawing.Size(154, 26)
        Me.txtdimensiones.TabIndex = 14
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnGuardar.Location = New System.Drawing.Point(123, 354)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 29)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "Guardar"
        '
        'btnsalir
        '
        Me.btnsalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnsalir.Location = New System.Drawing.Point(205, 354)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 29)
        Me.btnsalir.TabIndex = 19
        Me.btnsalir.Text = "Salir"
        '
        'LabelItem3
        '
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "Inicio de Sesion"
        Me.LabelItem3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelItem3.Width = 530
        '
        'cmbempleado
        '
        Me.cmbempleado.Location = New System.Drawing.Point(129, 242)
        Me.cmbempleado.Name = "cmbempleado"
        Me.cmbempleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbempleado.Properties.NullText = ""
        Me.cmbempleado.Properties.PopupSizeable = False
        Me.cmbempleado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbempleado.Size = New System.Drawing.Size(154, 26)
        Me.cmbempleado.TabIndex = 15
        '
        'cmbarea
        '
        Me.cmbarea.Location = New System.Drawing.Point(129, 280)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbarea.Properties.NullText = ""
        Me.cmbarea.Properties.PopupSizeable = False
        Me.cmbarea.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbarea.Size = New System.Drawing.Size(154, 26)
        Me.cmbarea.TabIndex = 16
        '
        'cmbubicacion
        '
        Me.cmbubicacion.Location = New System.Drawing.Point(129, 313)
        Me.cmbubicacion.Name = "cmbubicacion"
        Me.cmbubicacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbubicacion.Properties.NullText = ""
        Me.cmbubicacion.Properties.PopupSizeable = False
        Me.cmbubicacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbubicacion.Size = New System.Drawing.Size(154, 26)
        Me.cmbubicacion.TabIndex = 17
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
        Me.MetroStatusBar2.Location = New System.Drawing.Point(321, 10)
        Me.MetroStatusBar2.Name = "MetroStatusBar2"
        Me.MetroStatusBar2.Size = New System.Drawing.Size(11, 375)
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
        Me.MetroStatusBar5.Location = New System.Drawing.Point(11, 385)
        Me.MetroStatusBar5.Name = "MetroStatusBar5"
        Me.MetroStatusBar5.Size = New System.Drawing.Size(321, 10)
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
        Me.MetroStatusBar1.Size = New System.Drawing.Size(11, 385)
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
        Me.MetroStatusBar4.Size = New System.Drawing.Size(332, 10)
        Me.MetroStatusBar4.TabIndex = 254
        Me.MetroStatusBar4.TabStop = False
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 395)
        Me.Controls.Add(Me.MetroStatusBar2)
        Me.Controls.Add(Me.MetroStatusBar5)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroStatusBar4)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtdimensiones)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.txtmodelo)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.txtdescri)
        Me.Controls.Add(Me.txtcodart)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmbempleado)
        Me.Controls.Add(Me.cmbarea)
        Me.Controls.Add(Me.cmbubicacion)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "FrmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Articulo"
        CType(Me.txtcodart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmodelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtserie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdimensiones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbempleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbarea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbubicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcodart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdescri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmodelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtserie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdimensiones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents cmbempleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbarea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbubicacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MetroStatusBar2 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar5 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents MetroStatusBar4 As DevComponents.DotNetBar.Metro.MetroStatusBar
End Class
