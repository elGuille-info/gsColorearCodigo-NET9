<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAcercaDe
    Inherits Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAcercaDe))
        TableLayoutPanel1 = New TableLayoutPanel()
        labelWeb = New Label()
        labelDescripcion = New Label()
        labelAutor = New Label()
        labelTitulo = New Label()
        btnAceptar = New Button()
        linkBug = New LinkLabel()
        linkPrograma = New LinkLabel()
        ToolTip1 = New ToolTip(components)
        linkURL = New LinkLabel()
        timerWeb = New Timer(components)
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 474F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 140F))
        TableLayoutPanel1.Controls.Add(labelWeb, 0, 3)
        TableLayoutPanel1.Controls.Add(labelDescripcion, 0, 2)
        TableLayoutPanel1.Controls.Add(labelAutor, 0, 5)
        TableLayoutPanel1.Controls.Add(labelTitulo, 0, 0)
        TableLayoutPanel1.Controls.Add(btnAceptar, 1, 8)
        TableLayoutPanel1.Controls.Add(linkBug, 0, 7)
        TableLayoutPanel1.Controls.Add(linkPrograma, 0, 8)
        TableLayoutPanel1.Location = New Point(386, 15)
        TableLayoutPanel1.Margin = New Padding(6, 5, 6, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 9
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 122F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 8F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 303F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 92F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 8F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 52F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 8F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 227F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        TableLayoutPanel1.Size = New Size(614, 700)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' labelWeb
        ' 
        TableLayoutPanel1.SetColumnSpan(labelWeb, 2)
        labelWeb.Dock = DockStyle.Fill
        labelWeb.Font = New Font("Tahoma", 9F)
        labelWeb.ForeColor = Color.White
        labelWeb.Location = New Point(6, 433)
        labelWeb.Margin = New Padding(6, 0, 6, 0)
        labelWeb.Name = "labelWeb"
        labelWeb.Size = New Size(602, 92)
        labelWeb.TabIndex = 2
        labelWeb.Text = "Info actualización" & vbCrLf & "Segunda línea" & vbCrLf & "Tercera"
        ' 
        ' labelDescripcion
        ' 
        TableLayoutPanel1.SetColumnSpan(labelDescripcion, 2)
        labelDescripcion.Dock = DockStyle.Fill
        labelDescripcion.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        labelDescripcion.ForeColor = Color.White
        labelDescripcion.Location = New Point(6, 130)
        labelDescripcion.Margin = New Padding(6, 0, 6, 0)
        labelDescripcion.Name = "labelDescripcion"
        labelDescripcion.Padding = New Padding(7, 8, 13, 8)
        labelDescripcion.Size = New Size(602, 303)
        labelDescripcion.TabIndex = 1
        labelDescripcion.Text = "gsColorearCodigo v1.0.0.0"
        ' 
        ' labelAutor
        ' 
        TableLayoutPanel1.SetColumnSpan(labelAutor, 2)
        labelAutor.Dock = DockStyle.Fill
        labelAutor.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        labelAutor.ForeColor = Color.White
        labelAutor.Location = New Point(6, 533)
        labelAutor.Margin = New Padding(6, 0, 6, 0)
        labelAutor.Name = "labelAutor"
        labelAutor.Size = New Size(602, 52)
        labelAutor.TabIndex = 3
        labelAutor.Text = "©Guillermo 'guille' Som, 2005-2007"
        labelAutor.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' labelTitulo
        ' 
        TableLayoutPanel1.SetColumnSpan(labelTitulo, 2)
        labelTitulo.Dock = DockStyle.Fill
        labelTitulo.Font = New Font("Tahoma", 24F, FontStyle.Bold)
        labelTitulo.ForeColor = Color.White
        labelTitulo.Location = New Point(6, 0)
        labelTitulo.Margin = New Padding(6, 0, 6, 0)
        labelTitulo.Name = "labelTitulo"
        labelTitulo.Size = New Size(602, 122)
        labelTitulo.TabIndex = 0
        labelTitulo.Text = "gsColorearCodigo"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = Color.DarkBlue
        btnAceptar.FlatAppearance.BorderColor = Color.White
        btnAceptar.FlatAppearance.MouseDownBackColor = Color.RoyalBlue
        btnAceptar.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(480, 648)
        btnAceptar.Margin = New Padding(6, 5, 6, 5)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(126, 45)
        btnAceptar.TabIndex = 5
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' linkBug
        ' 
        linkBug.ActiveLinkColor = Color.White
        TableLayoutPanel1.SetColumnSpan(linkBug, 2)
        linkBug.Dock = DockStyle.Fill
        linkBug.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        linkBug.LinkColor = Color.White
        linkBug.Location = New Point(6, 593)
        linkBug.Margin = New Padding(6, 0, 6, 0)
        linkBug.Name = "linkBug"
        linkBug.Size = New Size(602, 50)
        linkBug.TabIndex = 4
        linkBug.TabStop = True
        linkBug.Text = "Reportar un bug o una mejora"
        ToolTip1.SetToolTip(linkBug, " Pulsa en este link para reportar un bug o alguna mejora (te llevará al repositorio de github)")
        linkBug.VisitedLinkColor = Color.White
        ' 
        ' linkPrograma
        ' 
        linkPrograma.ActiveLinkColor = Color.White
        linkPrograma.AutoSize = True
        linkPrograma.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        linkPrograma.LinkColor = Color.White
        linkPrograma.Location = New Point(6, 643)
        linkPrograma.Margin = New Padding(6, 0, 6, 0)
        linkPrograma.Name = "linkPrograma"
        linkPrograma.Size = New Size(284, 24)
        linkPrograma.TabIndex = 6
        linkPrograma.TabStop = True
        linkPrograma.Text = "Ir a la página de la utilidad"
        ToolTip1.SetToolTip(linkPrograma, " Ir a https://www.elguillemola.com/gscolorearcodigo-net9/")
        linkPrograma.VisitedLinkColor = Color.White
        ' 
        ' linkURL
        ' 
        linkURL.ActiveLinkColor = Color.White
        linkURL.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        linkURL.BackColor = Color.Transparent
        linkURL.DisabledLinkColor = Color.White
        linkURL.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        linkURL.LinkColor = Color.White
        linkURL.Location = New Point(13, 663)
        linkURL.Margin = New Padding(6, 0, 6, 0)
        linkURL.Name = "linkURL"
        linkURL.Padding = New Padding(7, 0, 0, 0)
        linkURL.Size = New Size(361, 45)
        linkURL.TabIndex = 1
        linkURL.TabStop = True
        linkURL.Text = "https://elguillemola.com"
        ToolTip1.SetToolTip(linkURL, " Ir a mi blog")
        linkURL.VisitedLinkColor = Color.White
        ' 
        ' timerWeb
        ' 
        ' 
        ' fAcercaDe
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1013, 730)
        Controls.Add(linkURL)
        Controls.Add(TableLayoutPanel1)
        ForeColor = SystemColors.WindowText
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6, 5, 6, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "fAcercaDe"
        Opacity = 0.95R
        Padding = New Padding(13, 15, 13, 15)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Acerca de..."
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Private WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents btnAceptar As Button
    Private WithEvents labelAutor As Label
    Private WithEvents labelDescripcion As Label
    Private WithEvents ToolTip1 As ToolTip
    Private WithEvents linkBug As LinkLabel
    Private WithEvents linkURL As LinkLabel
    Private WithEvents timerWeb As Timer
    Private WithEvents labelWeb As Label
    Private WithEvents linkPrograma As LinkLabel
    Private WithEvents labelTitulo As Label
End Class
