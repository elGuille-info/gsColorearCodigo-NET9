<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fColorear
    Inherits Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    '


    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fColorear))
        statusInfo = New ToolStripStatusLabel()
        mnuFic = New ToolStripMenuItem()
        mnuFicAbrir = New ToolStripMenuItem()
        mnuFicGuardar = New ToolStripMenuItem()
        mnuFicSep1 = New ToolStripSeparator()
        mnuFicVerRTF = New ToolStripMenuItem()
        mnuFicSep2 = New ToolStripSeparator()
        mnuFicNavegar = New ToolStripMenuItem()
        mnuFicSep3 = New ToolStripSeparator()
        mnuFicAcerca = New ToolStripMenuItem()
        mnuFicSep4 = New ToolStripSeparator()
        mnuFicSalir = New ToolStripMenuItem()
        mnuSintaxColorear = New ToolStripMenuItem()
        mnuSintaxColorearEnRTF = New ToolStripMenuItem()
        mnuSintaxColorearDeRTF = New ToolStripMenuItem()
        mnuEdi = New ToolStripMenuItem()
        mnuEdiDeshacer = New ToolStripMenuItem()
        mnuEdiSep1 = New ToolStripSeparator()
        mnuEdiCortar = New ToolStripMenuItem()
        mnuEdiCopiar = New ToolStripMenuItem()
        mnuEdiPegar = New ToolStripMenuItem()
        mnuEdiSep2 = New ToolStripSeparator()
        mnuEdiSeleccionarTodo = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tpPrincipal = New TabPage()
        GroupBox1 = New GroupBox()
        btnColorear = New Button()
        btnTextoNormal = New Button()
        txtIndentar = New NumericUpDown()
        chkIndentar = New CheckBox()
        chkQuitarEspacios = New CheckBox()
        rtEditor = New RichTextBox()
        tpVisor = New TabPage()
        WebBrowser1 = New WebBrowser()
        tpConfig = New TabPage()
        btnCfgRestablecer = New Button()
        btnCfgDeshacer = New Button()
        btnCfgAplicar = New Button()
        tabControlCfg = New TabControl()
        tpColores = New TabPage()
        btnColorClases = New Button()
        LabelColorClases = New Label()
        txtColorClases = New TextBox()
        Label3 = New Label()
        chkUsarTemaOscuro = New CheckBox()
        chkRecordarUltimoTexto = New CheckBox()
        chkNotify = New CheckBox()
        chkUsarSpanStyle = New CheckBox()
        chkSyntaxMayusc = New CheckBox()
        cboTamFuente = New ComboBox()
        cboFuentes = New ComboBox()
        Label8 = New Label()
        btnColorKeywords = New Button()
        LabelColorKeywords = New Label()
        txtColorKeywords = New TextBox()
        Label7 = New Label()
        btnColorXML = New Button()
        LabelColorXML = New Label()
        txtColorXML = New TextBox()
        Label51 = New Label()
        btnColorRem = New Button()
        LabelColorRem = New Label()
        txtColorRem = New TextBox()
        Label41 = New Label()
        btnColorTexto = New Button()
        LabelColorTexto = New Label()
        txtColorTexto = New TextBox()
        cboPre = New ComboBox()
        cboPreContextMenu = New ContextMenuStrip(components)
        mnuCboPreEliminar = New ToolStripMenuItem()
        Label21 = New Label()
        Label11 = New Label()
        menuStrip1 = New MenuStrip()
        mnuSintax = New ToolStripMenuItem()
        mnuSintaxObtenerCodigoDualHTML = New ToolStripMenuItem()
        mnuSintaxSep1 = New ToolStripSeparator()
        mnuSintax_Ninguno = New ToolStripMenuItem()
        mnuSintax_dotNet = New ToolStripMenuItem()
        mnuSintax_VB = New ToolStripMenuItem()
        mnuSintax_CS = New ToolStripMenuItem()
        mnuSintax_Java = New ToolStripMenuItem()
        mnuSintax_FSharp = New ToolStripMenuItem()
        mnuSintax_IL = New ToolStripMenuItem()
        mnuSintax_CPP = New ToolStripMenuItem()
        mnuSintax_Pascal = New ToolStripMenuItem()
        mnuSintax_SQL = New ToolStripMenuItem()
        mnuSintax_VB6 = New ToolStripMenuItem()
        mnuSintax_XML = New ToolStripMenuItem()
        toolStrip1 = New ToolStrip()
        tsbColorear = New ToolStripButton()
        tsbSep0 = New ToolStripSeparator()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        tsbSep1 = New ToolStripSeparator()
        tsbCortar = New ToolStripButton()
        tsbCopiar = New ToolStripButton()
        tsbPegar = New ToolStripButton()
        tsbDeshacer = New ToolStripButton()
        tsbSep2 = New ToolStripSeparator()
        tsbSintax = New ToolStripSplitButton()
        tsbSep3 = New ToolStripSeparator()
        tsbNavegar = New ToolStripButton()
        tsbSep4 = New ToolStripSeparator()
        tsbAcerca = New ToolStripButton()
        tsbSep5 = New ToolStripSeparator()
        tsbSalir = New ToolStripButton()
        statusStrip1 = New StatusStrip()
        statusSintax = New ToolStripStatusLabel()
        toolTip1 = New ToolTip(components)
        TabControl1.SuspendLayout()
        tpPrincipal.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(txtIndentar, ComponentModel.ISupportInitialize).BeginInit()
        tpVisor.SuspendLayout()
        tpConfig.SuspendLayout()
        tabControlCfg.SuspendLayout()
        tpColores.SuspendLayout()
        cboPreContextMenu.SuspendLayout()
        menuStrip1.SuspendLayout()
        toolStrip1.SuspendLayout()
        statusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' statusInfo
        ' 
        statusInfo.Name = "statusInfo"
        statusInfo.Size = New Size(1011, 25)
        statusInfo.Spring = True
        statusInfo.Text = "©Guillermo (elGuille) Som, 2006-2020"
        statusInfo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' mnuFic
        ' 
        mnuFic.DropDownItems.AddRange(New ToolStripItem() {mnuFicAbrir, mnuFicGuardar, mnuFicSep1, mnuFicVerRTF, mnuFicSep2, mnuFicNavegar, mnuFicSep3, mnuFicAcerca, mnuFicSep4, mnuFicSalir})
        mnuFic.Name = "mnuFic"
        mnuFic.Size = New Size(85, 29)
        mnuFic.Text = "&Fichero"
        ' 
        ' mnuFicAbrir
        ' 
        mnuFicAbrir.Name = "mnuFicAbrir"
        mnuFicAbrir.Size = New Size(271, 34)
        mnuFicAbrir.Text = "Abrir..."
        mnuFicAbrir.ToolTipText = " Abrir un fichero de código"
        ' 
        ' mnuFicGuardar
        ' 
        mnuFicGuardar.Name = "mnuFicGuardar"
        mnuFicGuardar.Size = New Size(271, 34)
        mnuFicGuardar.Text = "Guardar como..."
        mnuFicGuardar.ToolTipText = " Guardar el texto actual"
        ' 
        ' mnuFicSep1
        ' 
        mnuFicSep1.Name = "mnuFicSep1"
        mnuFicSep1.Size = New Size(268, 6)
        ' 
        ' mnuFicVerRTF
        ' 
        mnuFicVerRTF.Name = "mnuFicVerRTF"
        mnuFicVerRTF.Size = New Size(271, 34)
        mnuFicVerRTF.Text = "Ver RTF"
        mnuFicVerRTF.ToolTipText = "Ver el RTF generado en una ventana aparte"
        ' 
        ' mnuFicSep2
        ' 
        mnuFicSep2.Name = "mnuFicSep2"
        mnuFicSep2.Size = New Size(268, 6)
        ' 
        ' mnuFicNavegar
        ' 
        mnuFicNavegar.Name = "mnuFicNavegar"
        mnuFicNavegar.Size = New Size(271, 34)
        mnuFicNavegar.Text = "Ver en el navegador"
        mnuFicNavegar.ToolTipText = " Ver en el navegador con los cambios realizados en el texto "
        ' 
        ' mnuFicSep3
        ' 
        mnuFicSep3.Name = "mnuFicSep3"
        mnuFicSep3.Size = New Size(268, 6)
        ' 
        ' mnuFicAcerca
        ' 
        mnuFicAcerca.ImageTransparentColor = Color.Magenta
        mnuFicAcerca.Name = "mnuFicAcerca"
        mnuFicAcerca.Size = New Size(271, 34)
        mnuFicAcerca.Text = "Acerca de..."
        mnuFicAcerca.ToolTipText = " Muestra la info del programa "
        ' 
        ' mnuFicSep4
        ' 
        mnuFicSep4.Name = "mnuFicSep4"
        mnuFicSep4.Size = New Size(268, 6)
        ' 
        ' mnuFicSalir
        ' 
        mnuFicSalir.ImageTransparentColor = Color.Magenta
        mnuFicSalir.Name = "mnuFicSalir"
        mnuFicSalir.Size = New Size(271, 34)
        mnuFicSalir.Text = "&Salir"
        mnuFicSalir.ToolTipText = " Terminar el programa "
        ' 
        ' mnuSintaxColorear
        ' 
        mnuSintaxColorear.Name = "mnuSintaxColorear"
        mnuSintaxColorear.ShortcutKeys = Keys.F8
        mnuSintaxColorear.Size = New Size(335, 34)
        mnuSintaxColorear.Text = "Colorear"
        mnuSintaxColorear.ToolTipText = " Colorea el código usando el lenguaje y el formato indicados "
        ' 
        ' mnuSintaxColorearEnRTF
        ' 
        mnuSintaxColorearEnRTF.Name = "mnuSintaxColorearEnRTF"
        mnuSintaxColorearEnRTF.Size = New Size(335, 34)
        mnuSintaxColorearEnRTF.Text = "Colorear en RTF (o HTML)"
        mnuSintaxColorearEnRTF.ToolTipText = " Marca esta opción para generar en formato RTF (si no lo marcas, se genera en HTML) "
        ' 
        ' mnuSintaxColorearDeRTF
        ' 
        mnuSintaxColorearDeRTF.Name = "mnuSintaxColorearDeRTF"
        mnuSintaxColorearDeRTF.Size = New Size(335, 34)
        mnuSintaxColorearDeRTF.Text = "Colorear desde RTF"
        mnuSintaxColorearDeRTF.ToolTipText = "Si el texto pegado ya tiene colores," & vbCrLf & "usa esta opción para generar el código HTML con ese coloreado."
        ' 
        ' mnuEdi
        ' 
        mnuEdi.DropDownItems.AddRange(New ToolStripItem() {mnuEdiDeshacer, mnuEdiSep1, mnuEdiCortar, mnuEdiCopiar, mnuEdiPegar, mnuEdiSep2, mnuEdiSeleccionarTodo})
        mnuEdi.Name = "mnuEdi"
        mnuEdi.Size = New Size(73, 29)
        mnuEdi.Text = "&Editar"
        ' 
        ' mnuEdiDeshacer
        ' 
        mnuEdiDeshacer.Name = "mnuEdiDeshacer"
        mnuEdiDeshacer.ShortcutKeys = Keys.Control Or Keys.Z
        mnuEdiDeshacer.Size = New Size(309, 34)
        mnuEdiDeshacer.Text = "&Deshacer"
        ' 
        ' mnuEdiSep1
        ' 
        mnuEdiSep1.Name = "mnuEdiSep1"
        mnuEdiSep1.Size = New Size(306, 6)
        ' 
        ' mnuEdiCortar
        ' 
        mnuEdiCortar.Name = "mnuEdiCortar"
        mnuEdiCortar.ShortcutKeys = Keys.Control Or Keys.X
        mnuEdiCortar.Size = New Size(309, 34)
        mnuEdiCortar.Text = "Cor&tar"
        ' 
        ' mnuEdiCopiar
        ' 
        mnuEdiCopiar.Name = "mnuEdiCopiar"
        mnuEdiCopiar.ShortcutKeys = Keys.Control Or Keys.C
        mnuEdiCopiar.Size = New Size(309, 34)
        mnuEdiCopiar.Text = "&Copiar"
        ' 
        ' mnuEdiPegar
        ' 
        mnuEdiPegar.Name = "mnuEdiPegar"
        mnuEdiPegar.ShortcutKeys = Keys.Control Or Keys.V
        mnuEdiPegar.Size = New Size(309, 34)
        mnuEdiPegar.Text = "&Pegar"
        ' 
        ' mnuEdiSep2
        ' 
        mnuEdiSep2.Name = "mnuEdiSep2"
        mnuEdiSep2.Size = New Size(306, 6)
        ' 
        ' mnuEdiSeleccionarTodo
        ' 
        mnuEdiSeleccionarTodo.Name = "mnuEdiSeleccionarTodo"
        mnuEdiSeleccionarTodo.ShortcutKeys = Keys.Control Or Keys.A
        mnuEdiSeleccionarTodo.Size = New Size(309, 34)
        mnuEdiSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(tpPrincipal)
        TabControl1.Controls.Add(tpVisor)
        TabControl1.Controls.Add(tpConfig)
        TabControl1.Location = New Point(17, 93)
        TabControl1.Margin = New Padding(4, 5, 4, 5)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1070, 793)
        TabControl1.TabIndex = 2
        ' 
        ' tpPrincipal
        ' 
        tpPrincipal.Controls.Add(GroupBox1)
        tpPrincipal.Controls.Add(rtEditor)
        tpPrincipal.Location = New Point(4, 34)
        tpPrincipal.Margin = New Padding(4, 5, 4, 5)
        tpPrincipal.Name = "tpPrincipal"
        tpPrincipal.Padding = New Padding(4, 5, 4, 5)
        tpPrincipal.Size = New Size(1062, 755)
        tpPrincipal.TabIndex = 5
        tpPrincipal.Text = "Principal"
        tpPrincipal.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnColorear)
        GroupBox1.Controls.Add(btnTextoNormal)
        GroupBox1.Controls.Add(txtIndentar)
        GroupBox1.Controls.Add(chkIndentar)
        GroupBox1.Controls.Add(chkQuitarEspacios)
        GroupBox1.Location = New Point(9, 10)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(1036, 80)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Opciones:"
        ' 
        ' btnColorear
        ' 
        btnColorear.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnColorear.Location = New Point(523, 27)
        btnColorear.Margin = New Padding(4, 5, 4, 5)
        btnColorear.Name = "btnColorear"
        btnColorear.Size = New Size(224, 38)
        btnColorear.TabIndex = 4
        btnColorear.Text = "Colorear en HTML"
        btnColorear.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip1.SetToolTip(btnColorear, "Colorear el código usando el lenguaje indicado")
        btnColorear.UseVisualStyleBackColor = True
        ' 
        ' btnTextoNormal
        ' 
        btnTextoNormal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTextoNormal.Location = New Point(756, 25)
        btnTextoNormal.Margin = New Padding(4, 5, 4, 5)
        btnTextoNormal.Name = "btnTextoNormal"
        btnTextoNormal.Size = New Size(271, 38)
        btnTextoNormal.TabIndex = 5
        btnTextoNormal.Text = "Mostrar el texto sin procesar"
        toolTip1.SetToolTip(btnTextoNormal, "Mostrar el último texto antes de colorear")
        btnTextoNormal.UseVisualStyleBackColor = True
        ' 
        ' txtIndentar
        ' 
        txtIndentar.Location = New Point(396, 30)
        txtIndentar.Margin = New Padding(4, 5, 4, 5)
        txtIndentar.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        txtIndentar.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        txtIndentar.Name = "txtIndentar"
        txtIndentar.Size = New Size(63, 31)
        txtIndentar.TabIndex = 3
        txtIndentar.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ' 
        ' chkIndentar
        ' 
        chkIndentar.AutoSize = True
        chkIndentar.Location = New Point(294, 32)
        chkIndentar.Margin = New Padding(4, 5, 4, 5)
        chkIndentar.Name = "chkIndentar"
        chkIndentar.Size = New Size(104, 29)
        chkIndentar.TabIndex = 2
        chkIndentar.Text = "Indentar"
        toolTip1.SetToolTip(chkIndentar, "Si se debe indentar el código al colorearlo (funciona bien en VB)")
        chkIndentar.UseVisualStyleBackColor = True
        ' 
        ' chkQuitarEspacios
        ' 
        chkQuitarEspacios.AutoSize = True
        chkQuitarEspacios.Location = New Point(9, 32)
        chkQuitarEspacios.Margin = New Padding(4, 5, 4, 5)
        chkQuitarEspacios.Name = "chkQuitarEspacios"
        chkQuitarEspacios.Size = New Size(291, 29)
        chkQuitarEspacios.TabIndex = 1
        chkQuitarEspacios.Text = "Quitar los espacios del principio"
        toolTip1.SetToolTip(chkQuitarEspacios, "Si se deben quitar los espacios iniciales al colorear")
        chkQuitarEspacios.UseVisualStyleBackColor = True
        ' 
        ' rtEditor
        ' 
        rtEditor.AcceptsTab = True
        rtEditor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        rtEditor.DetectUrls = False
        rtEditor.Font = New Font("Courier New", 8.25F)
        rtEditor.HideSelection = False
        rtEditor.Location = New Point(9, 100)
        rtEditor.Margin = New Padding(4, 5, 4, 5)
        rtEditor.Name = "rtEditor"
        rtEditor.Size = New Size(1034, 637)
        rtEditor.TabIndex = 1
        rtEditor.Text = "Algo para que cambie"
        rtEditor.WordWrap = False
        ' 
        ' tpVisor
        ' 
        tpVisor.Controls.Add(WebBrowser1)
        tpVisor.Location = New Point(4, 34)
        tpVisor.Margin = New Padding(4, 5, 4, 5)
        tpVisor.Name = "tpVisor"
        tpVisor.Padding = New Padding(4, 5, 4, 5)
        tpVisor.Size = New Size(1062, 755)
        tpVisor.TabIndex = 6
        tpVisor.Text = "Visor HTML"
        tpVisor.UseVisualStyleBackColor = True
        ' 
        ' WebBrowser1
        ' 
        WebBrowser1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        WebBrowser1.Location = New Point(9, 10)
        WebBrowser1.Margin = New Padding(4, 5, 4, 5)
        WebBrowser1.MinimumSize = New Size(29, 33)
        WebBrowser1.Name = "WebBrowser1"
        WebBrowser1.Size = New Size(986, 730)
        WebBrowser1.TabIndex = 0
        ' 
        ' tpConfig
        ' 
        tpConfig.Controls.Add(btnCfgRestablecer)
        tpConfig.Controls.Add(btnCfgDeshacer)
        tpConfig.Controls.Add(btnCfgAplicar)
        tpConfig.Controls.Add(tabControlCfg)
        tpConfig.Location = New Point(4, 34)
        tpConfig.Margin = New Padding(4, 5, 4, 5)
        tpConfig.Name = "tpConfig"
        tpConfig.Padding = New Padding(6, 7, 6, 7)
        tpConfig.Size = New Size(1062, 755)
        tpConfig.TabIndex = 7
        tpConfig.Text = "Configuración"
        tpConfig.UseVisualStyleBackColor = True
        ' 
        ' btnCfgRestablecer
        ' 
        btnCfgRestablecer.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCfgRestablecer.Location = New Point(654, 700)
        btnCfgRestablecer.Margin = New Padding(4, 5, 4, 5)
        btnCfgRestablecer.Name = "btnCfgRestablecer"
        btnCfgRestablecer.Size = New Size(107, 38)
        btnCfgRestablecer.TabIndex = 3
        btnCfgRestablecer.Text = "Restablecer"
        btnCfgRestablecer.UseVisualStyleBackColor = True
        ' 
        ' btnCfgDeshacer
        ' 
        btnCfgDeshacer.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCfgDeshacer.Location = New Point(770, 700)
        btnCfgDeshacer.Margin = New Padding(4, 5, 4, 5)
        btnCfgDeshacer.Name = "btnCfgDeshacer"
        btnCfgDeshacer.Size = New Size(107, 38)
        btnCfgDeshacer.TabIndex = 2
        btnCfgDeshacer.Text = "Deshacer"
        btnCfgDeshacer.UseVisualStyleBackColor = True
        ' 
        ' btnCfgAplicar
        ' 
        btnCfgAplicar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCfgAplicar.Location = New Point(886, 700)
        btnCfgAplicar.Margin = New Padding(4, 5, 4, 5)
        btnCfgAplicar.Name = "btnCfgAplicar"
        btnCfgAplicar.Size = New Size(107, 38)
        btnCfgAplicar.TabIndex = 1
        btnCfgAplicar.Text = "Aplicar"
        btnCfgAplicar.UseVisualStyleBackColor = True
        ' 
        ' tabControlCfg
        ' 
        tabControlCfg.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabControlCfg.Controls.Add(tpColores)
        tabControlCfg.Location = New Point(17, 20)
        tabControlCfg.Margin = New Padding(11, 13, 11, 13)
        tabControlCfg.Name = "tabControlCfg"
        tabControlCfg.SelectedIndex = 0
        tabControlCfg.Size = New Size(969, 662)
        tabControlCfg.TabIndex = 0
        ' 
        ' tpColores
        ' 
        tpColores.AutoScroll = True
        tpColores.BackColor = Color.WhiteSmoke
        tpColores.Controls.Add(btnColorClases)
        tpColores.Controls.Add(LabelColorClases)
        tpColores.Controls.Add(txtColorClases)
        tpColores.Controls.Add(Label3)
        tpColores.Controls.Add(chkUsarTemaOscuro)
        tpColores.Controls.Add(chkRecordarUltimoTexto)
        tpColores.Controls.Add(chkNotify)
        tpColores.Controls.Add(chkUsarSpanStyle)
        tpColores.Controls.Add(chkSyntaxMayusc)
        tpColores.Controls.Add(cboTamFuente)
        tpColores.Controls.Add(cboFuentes)
        tpColores.Controls.Add(Label8)
        tpColores.Controls.Add(btnColorKeywords)
        tpColores.Controls.Add(LabelColorKeywords)
        tpColores.Controls.Add(txtColorKeywords)
        tpColores.Controls.Add(Label7)
        tpColores.Controls.Add(btnColorXML)
        tpColores.Controls.Add(LabelColorXML)
        tpColores.Controls.Add(txtColorXML)
        tpColores.Controls.Add(Label51)
        tpColores.Controls.Add(btnColorRem)
        tpColores.Controls.Add(LabelColorRem)
        tpColores.Controls.Add(txtColorRem)
        tpColores.Controls.Add(Label41)
        tpColores.Controls.Add(btnColorTexto)
        tpColores.Controls.Add(LabelColorTexto)
        tpColores.Controls.Add(txtColorTexto)
        tpColores.Controls.Add(cboPre)
        tpColores.Controls.Add(Label21)
        tpColores.Controls.Add(Label11)
        tpColores.Location = New Point(4, 34)
        tpColores.Margin = New Padding(4, 5, 4, 5)
        tpColores.Name = "tpColores"
        tpColores.Padding = New Padding(11, 13, 11, 13)
        tpColores.Size = New Size(961, 624)
        tpColores.TabIndex = 4
        tpColores.Text = "Colores, fuente y <pre>"
        ' 
        ' btnColorClases
        ' 
        btnColorClases.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnColorClases.FlatStyle = FlatStyle.System
        btnColorClases.Location = New Point(907, 295)
        btnColorClases.Margin = New Padding(4, 5, 4, 5)
        btnColorClases.Name = "btnColorClases"
        btnColorClases.Size = New Size(34, 38)
        btnColorClases.TabIndex = 32
        btnColorClases.Text = "..."
        ' 
        ' LabelColorClases
        ' 
        LabelColorClases.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LabelColorClases.BackColor = Color.Transparent
        LabelColorClases.Font = New Font("Courier New", 9F)
        LabelColorClases.ForeColor = Color.FromArgb(CByte(43), CByte(145), CByte(175))
        LabelColorClases.Location = New Point(331, 302)
        LabelColorClases.Margin = New Padding(4, 0, 4, 0)
        LabelColorClases.Name = "LabelColorClases"
        LabelColorClases.Size = New Size(560, 27)
        LabelColorClases.TabIndex = 31
        LabelColorClases.Text = "Color de los tipos (clases)"
        ' 
        ' txtColorClases
        ' 
        txtColorClases.Font = New Font("Courier New", 8.25F)
        txtColorClases.ForeColor = SystemColors.ControlText
        txtColorClases.Location = New Point(200, 298)
        txtColorClases.Margin = New Padding(4, 5, 4, 5)
        txtColorClases.Name = "txtColorClases"
        txtColorClases.Size = New Size(113, 26)
        txtColorClases.TabIndex = 30
        txtColorClases.Text = "2B91AF"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(19, 303)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 27)
        Label3.TabIndex = 29
        Label3.Text = "Color clases (&tipos):"
        ' 
        ' chkUsarTemaOscuro
        ' 
        chkUsarTemaOscuro.AutoSize = True
        chkUsarTemaOscuro.ImeMode = ImeMode.NoControl
        chkUsarTemaOscuro.Location = New Point(23, 27)
        chkUsarTemaOscuro.Margin = New Padding(4, 5, 4, 5)
        chkUsarTemaOscuro.Name = "chkUsarTemaOscuro"
        chkUsarTemaOscuro.Size = New Size(239, 29)
        chkUsarTemaOscuro.TabIndex = 28
        chkUsarTemaOscuro.Text = "Usar colores tema oscuro"
        toolTip1.SetToolTip(chkUsarTemaOscuro, "Marca esta opción para usar los colores del tema oscuro." & vbCrLf & "No marcado usará los colores del tema claro." & vbCrLf & "Indefinido (cuadro en negro) usa los colores personalizados (beta).")
        chkUsarTemaOscuro.UseVisualStyleBackColor = True
        ' 
        ' chkRecordarUltimoTexto
        ' 
        chkRecordarUltimoTexto.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        chkRecordarUltimoTexto.AutoSize = True
        chkRecordarUltimoTexto.Checked = True
        chkRecordarUltimoTexto.CheckState = CheckState.Checked
        chkRecordarUltimoTexto.ImeMode = ImeMode.NoControl
        chkRecordarUltimoTexto.Location = New Point(459, 542)
        chkRecordarUltimoTexto.Margin = New Padding(11, 13, 11, 13)
        chkRecordarUltimoTexto.Name = "chkRecordarUltimoTexto"
        chkRecordarUltimoTexto.Size = New Size(328, 29)
        chkRecordarUltimoTexto.TabIndex = 26
        chkRecordarUltimoTexto.Text = "Recordar el último código coloreado"
        toolTip1.SetToolTip(chkRecordarUltimoTexto, "Si se debe recordar el texto a colorear cada vez que se inicia la aplicación")
        chkRecordarUltimoTexto.UseVisualStyleBackColor = True
        ' 
        ' chkNotify
        ' 
        chkNotify.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        chkNotify.AutoSize = True
        chkNotify.ImeMode = ImeMode.NoControl
        chkNotify.Location = New Point(23, 542)
        chkNotify.Margin = New Padding(11, 13, 11, 13)
        chkNotify.Name = "chkNotify"
        chkNotify.Size = New Size(399, 29)
        chkNotify.TabIndex = 25
        chkNotify.Text = "Al minimi&zar hacerlo en el área de notificación"
        toolTip1.SetToolTip(chkNotify, "Cuando se minimiza la aplicación, ocultarla y mostrar solo el icono en el área de notificación")
        chkNotify.UseVisualStyleBackColor = True
        ' 
        ' chkUsarSpanStyle
        ' 
        chkUsarSpanStyle.AutoSize = True
        chkUsarSpanStyle.Checked = True
        chkUsarSpanStyle.CheckState = CheckState.Checked
        chkUsarSpanStyle.Location = New Point(23, 392)
        chkUsarSpanStyle.Margin = New Padding(9, 10, 9, 10)
        chkUsarSpanStyle.Name = "chkUsarSpanStyle"
        chkUsarSpanStyle.Size = New Size(465, 29)
        chkUsarSpanStyle.TabIndex = 21
        chkUsarSpanStyle.Text = "Usar 'span style' en lugar de 'font' para colorear HTML"
        toolTip1.SetToolTip(chkUsarSpanStyle, "Si al crear el tag para el color se usa <span style en vez de <font (recomendado)")
        chkUsarSpanStyle.UseVisualStyleBackColor = True
        ' 
        ' chkSyntaxMayusc
        ' 
        chkSyntaxMayusc.AutoSize = True
        chkSyntaxMayusc.ImeMode = ImeMode.NoControl
        chkSyntaxMayusc.Location = New Point(23, 435)
        chkSyntaxMayusc.Margin = New Padding(4, 5, 4, 5)
        chkSyntaxMayusc.Name = "chkSyntaxMayusc"
        chkSyntaxMayusc.Size = New Size(512, 29)
        chkSyntaxMayusc.TabIndex = 22
        chkSyntaxMayusc.Text = "Con&vertir las palabras a mayúsculas/minúsculas del lenguaje"
        toolTip1.SetToolTip(chkSyntaxMayusc, "Si al colorear se deben convertir las palabras al estado recomendado por el lenguaje")
        chkSyntaxMayusc.UseVisualStyleBackColor = True
        ' 
        ' cboTamFuente
        ' 
        cboTamFuente.DropDownStyle = ComboBoxStyle.DropDownList
        cboTamFuente.FormattingEnabled = True
        cboTamFuente.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18"})
        cboTamFuente.Location = New Point(429, 342)
        cboTamFuente.Margin = New Padding(4, 5, 4, 5)
        cboTamFuente.Name = "cboTamFuente"
        cboTamFuente.Size = New Size(63, 33)
        cboTamFuente.TabIndex = 20
        ' 
        ' cboFuentes
        ' 
        cboFuentes.AutoCompleteMode = AutoCompleteMode.Append
        cboFuentes.AutoCompleteSource = AutoCompleteSource.ListItems
        cboFuentes.FormattingEnabled = True
        cboFuentes.Items.AddRange(New Object() {"Courier New", "Consolas", "Lucida Console", "Arial", "Courier", "Fixedsys", "Lucida Sans Typewriter", "Microsoft Sans Serif", "MS Sans Serif", "Tahoma", "Times New Roman", "Verdana"})
        cboFuentes.Location = New Point(200, 342)
        cboFuentes.Margin = New Padding(4, 5, 4, 5)
        cboFuentes.Name = "cboFuentes"
        cboFuentes.Size = New Size(218, 33)
        cboFuentes.TabIndex = 19
        cboFuentes.Text = "Courier New"
        ' 
        ' Label8
        ' 
        Label8.ImeMode = ImeMode.NoControl
        Label8.Location = New Point(19, 345)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(177, 27)
        Label8.TabIndex = 18
        Label8.Text = "&Fuente:"
        ' 
        ' btnColorKeywords
        ' 
        btnColorKeywords.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnColorKeywords.FlatStyle = FlatStyle.System
        btnColorKeywords.Location = New Point(907, 252)
        btnColorKeywords.Margin = New Padding(4, 5, 4, 5)
        btnColorKeywords.Name = "btnColorKeywords"
        btnColorKeywords.Size = New Size(34, 38)
        btnColorKeywords.TabIndex = 17
        btnColorKeywords.Text = "..."
        ' 
        ' LabelColorKeywords
        ' 
        LabelColorKeywords.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LabelColorKeywords.BackColor = Color.Transparent
        LabelColorKeywords.Font = New Font("Courier New", 9F)
        LabelColorKeywords.ForeColor = Color.Blue
        LabelColorKeywords.Location = New Point(331, 258)
        LabelColorKeywords.Margin = New Padding(4, 0, 4, 0)
        LabelColorKeywords.Name = "LabelColorKeywords"
        LabelColorKeywords.Size = New Size(560, 27)
        LabelColorKeywords.TabIndex = 16
        LabelColorKeywords.Text = "Color de las instrucciones"
        ' 
        ' txtColorKeywords
        ' 
        txtColorKeywords.Font = New Font("Courier New", 8.25F)
        txtColorKeywords.ForeColor = SystemColors.ControlText
        txtColorKeywords.Location = New Point(200, 255)
        txtColorKeywords.Margin = New Padding(4, 5, 4, 5)
        txtColorKeywords.Name = "txtColorKeywords"
        txtColorKeywords.Size = New Size(113, 26)
        txtColorKeywords.TabIndex = 15
        txtColorKeywords.Text = "0000FF"
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(19, 260)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(177, 27)
        Label7.TabIndex = 14
        Label7.Text = "Color &instrucciones:"
        ' 
        ' btnColorXML
        ' 
        btnColorXML.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnColorXML.FlatStyle = FlatStyle.System
        btnColorXML.Location = New Point(907, 208)
        btnColorXML.Margin = New Padding(4, 5, 4, 5)
        btnColorXML.Name = "btnColorXML"
        btnColorXML.Size = New Size(34, 38)
        btnColorXML.TabIndex = 13
        btnColorXML.Text = "..."
        ' 
        ' LabelColorXML
        ' 
        LabelColorXML.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LabelColorXML.BackColor = Color.Transparent
        LabelColorXML.Font = New Font("Courier New", 9F)
        LabelColorXML.ForeColor = Color.FromArgb(CByte(92), CByte(92), CByte(92))
        LabelColorXML.Location = New Point(331, 215)
        LabelColorXML.Margin = New Padding(4, 0, 4, 0)
        LabelColorXML.Name = "LabelColorXML"
        LabelColorXML.Size = New Size(560, 27)
        LabelColorXML.TabIndex = 12
        LabelColorXML.Text = "Color de la documentación XML"
        ' 
        ' txtColorXML
        ' 
        txtColorXML.Font = New Font("Courier New", 8.25F)
        txtColorXML.ForeColor = SystemColors.ControlText
        txtColorXML.Location = New Point(200, 212)
        txtColorXML.Margin = New Padding(4, 5, 4, 5)
        txtColorXML.Name = "txtColorXML"
        txtColorXML.Size = New Size(113, 26)
        txtColorXML.TabIndex = 11
        txtColorXML.Text = "5C5C5C"
        ' 
        ' Label51
        ' 
        Label51.Location = New Point(19, 217)
        Label51.Margin = New Padding(4, 0, 4, 0)
        Label51.Name = "Label51"
        Label51.Size = New Size(177, 27)
        Label51.TabIndex = 10
        Label51.Text = "Color &documentación:"
        ' 
        ' btnColorRem
        ' 
        btnColorRem.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnColorRem.FlatStyle = FlatStyle.System
        btnColorRem.Location = New Point(907, 165)
        btnColorRem.Margin = New Padding(4, 5, 4, 5)
        btnColorRem.Name = "btnColorRem"
        btnColorRem.Size = New Size(34, 38)
        btnColorRem.TabIndex = 9
        btnColorRem.Text = "..."
        ' 
        ' LabelColorRem
        ' 
        LabelColorRem.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LabelColorRem.BackColor = Color.Transparent
        LabelColorRem.Font = New Font("Courier New", 9F)
        LabelColorRem.ForeColor = Color.Green
        LabelColorRem.Location = New Point(331, 172)
        LabelColorRem.Margin = New Padding(4, 0, 4, 0)
        LabelColorRem.Name = "LabelColorRem"
        LabelColorRem.Size = New Size(560, 27)
        LabelColorRem.TabIndex = 8
        LabelColorRem.Text = "Color de los comentarios"
        ' 
        ' txtColorRem
        ' 
        txtColorRem.Font = New Font("Courier New", 8.25F)
        txtColorRem.Location = New Point(200, 168)
        txtColorRem.Margin = New Padding(4, 5, 4, 5)
        txtColorRem.Name = "txtColorRem"
        txtColorRem.Size = New Size(113, 26)
        txtColorRem.TabIndex = 7
        txtColorRem.Text = "008000"
        ' 
        ' Label41
        ' 
        Label41.Location = New Point(19, 175)
        Label41.Margin = New Padding(4, 0, 4, 0)
        Label41.Name = "Label41"
        Label41.Size = New Size(177, 27)
        Label41.TabIndex = 6
        Label41.Text = "Color &comentarios:"
        ' 
        ' btnColorTexto
        ' 
        btnColorTexto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnColorTexto.FlatStyle = FlatStyle.System
        btnColorTexto.Location = New Point(907, 122)
        btnColorTexto.Margin = New Padding(4, 5, 4, 5)
        btnColorTexto.Name = "btnColorTexto"
        btnColorTexto.Size = New Size(34, 38)
        btnColorTexto.TabIndex = 5
        btnColorTexto.Text = "..."
        ' 
        ' LabelColorTexto
        ' 
        LabelColorTexto.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LabelColorTexto.BackColor = Color.Transparent
        LabelColorTexto.Font = New Font("Courier New", 9F)
        LabelColorTexto.ForeColor = Color.Firebrick
        LabelColorTexto.Location = New Point(331, 128)
        LabelColorTexto.Margin = New Padding(4, 0, 4, 0)
        LabelColorTexto.Name = "LabelColorTexto"
        LabelColorTexto.Size = New Size(560, 27)
        LabelColorTexto.TabIndex = 4
        LabelColorTexto.Text = "Color del texto entre comillas"
        ' 
        ' txtColorTexto
        ' 
        txtColorTexto.Font = New Font("Courier New", 8.25F)
        txtColorTexto.Location = New Point(200, 125)
        txtColorTexto.Margin = New Padding(4, 5, 4, 5)
        txtColorTexto.Name = "txtColorTexto"
        txtColorTexto.Size = New Size(113, 26)
        txtColorTexto.TabIndex = 3
        txtColorTexto.Text = "B22222"
        ' 
        ' cboPre
        ' 
        cboPre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboPre.ContextMenuStrip = cboPreContextMenu
        cboPre.Font = New Font("Courier New", 8.25F)
        cboPre.Items.AddRange(New Object() {"<pre>", "<pre style=""background-color:black; color:#dcdcdc;"">", "<pre style=""font-size:medium;"">", "<pre style=""background-color:black; color:#dcdcdc;font-size:medium;"">", "<pre style=""white-space:pre; font-family:courier new, monospace; font-size:10pt;"">", "<pre style=""white-space:pre; font-family:courier new, monospace"">"})
        cboPre.Location = New Point(200, 70)
        cboPre.Margin = New Padding(11, 13, 11, 13)
        cboPre.Name = "cboPre"
        cboPre.Size = New Size(740, 28)
        cboPre.TabIndex = 1
        ' 
        ' cboPreContextMenu
        ' 
        cboPreContextMenu.ImageScalingSize = New Size(24, 24)
        cboPreContextMenu.Items.AddRange(New ToolStripItem() {mnuCboPreEliminar})
        cboPreContextMenu.Name = "cboPreContextMenu"
        cboPreContextMenu.Size = New Size(147, 36)
        ' 
        ' mnuCboPreEliminar
        ' 
        mnuCboPreEliminar.Name = "mnuCboPreEliminar"
        mnuCboPreEliminar.Size = New Size(146, 32)
        mnuCboPreEliminar.Text = "Eliminar"
        ' 
        ' Label21
        ' 
        Label21.Location = New Point(19, 130)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(177, 27)
        Label21.TabIndex = 2
        Label21.Text = "Color &texto:"
        ' 
        ' Label11
        ' 
        Label11.Location = New Point(19, 75)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(177, 33)
        Label11.TabIndex = 0
        Label11.Text = "Tag de formato <&pre>:"
        ' 
        ' menuStrip1
        ' 
        menuStrip1.GripStyle = ToolStripGripStyle.Visible
        menuStrip1.ImageScalingSize = New Size(24, 24)
        menuStrip1.Items.AddRange(New ToolStripItem() {mnuFic, mnuEdi, mnuSintax})
        menuStrip1.Location = New Point(0, 0)
        menuStrip1.Name = "menuStrip1"
        menuStrip1.Padding = New Padding(4, 3, 0, 3)
        menuStrip1.Size = New Size(1104, 35)
        menuStrip1.TabIndex = 0
        menuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuSintax
        ' 
        mnuSintax.DropDownItems.AddRange(New ToolStripItem() {mnuSintaxColorear, mnuSintaxColorearEnRTF, mnuSintaxColorearDeRTF, mnuSintaxObtenerCodigoDualHTML, mnuSintaxSep1, mnuSintax_Ninguno, mnuSintax_dotNet, mnuSintax_VB, mnuSintax_CS, mnuSintax_Java, mnuSintax_FSharp, mnuSintax_IL, mnuSintax_CPP, mnuSintax_Pascal, mnuSintax_SQL, mnuSintax_VB6, mnuSintax_XML})
        mnuSintax.Name = "mnuSintax"
        mnuSintax.Size = New Size(87, 29)
        mnuSintax.Text = "&Sintaxis"
        ' 
        ' mnuSintaxObtenerCodigoDualHTML
        ' 
        mnuSintaxObtenerCodigoDualHTML.Name = "mnuSintaxObtenerCodigoDualHTML"
        mnuSintaxObtenerCodigoDualHTML.Size = New Size(335, 34)
        mnuSintaxObtenerCodigoDualHTML.Text = "Obtener Codigo Dual HTML"
        ' 
        ' mnuSintaxSep1
        ' 
        mnuSintaxSep1.Name = "mnuSintaxSep1"
        mnuSintaxSep1.Size = New Size(332, 6)
        ' 
        ' mnuSintax_Ninguno
        ' 
        mnuSintax_Ninguno.Name = "mnuSintax_Ninguno"
        mnuSintax_Ninguno.Size = New Size(335, 34)
        mnuSintax_Ninguno.Text = "Ninguno"
        ' 
        ' mnuSintax_dotNet
        ' 
        mnuSintax_dotNet.ImageTransparentColor = Color.Magenta
        mnuSintax_dotNet.Name = "mnuSintax_dotNet"
        mnuSintax_dotNet.Size = New Size(335, 34)
        mnuSintax_dotNet.Text = "dot&Net"
        ' 
        ' mnuSintax_VB
        ' 
        mnuSintax_VB.ImageTransparentColor = Color.White
        mnuSintax_VB.Name = "mnuSintax_VB"
        mnuSintax_VB.Size = New Size(335, 34)
        mnuSintax_VB.Text = "&Visual Basic"
        ' 
        ' mnuSintax_CS
        ' 
        mnuSintax_CS.ImageTransparentColor = Color.White
        mnuSintax_CS.Name = "mnuSintax_CS"
        mnuSintax_CS.Size = New Size(335, 34)
        mnuSintax_CS.Text = "&C#"
        ' 
        ' mnuSintax_Java
        ' 
        mnuSintax_Java.ImageTransparentColor = Color.Magenta
        mnuSintax_Java.Name = "mnuSintax_Java"
        mnuSintax_Java.Size = New Size(335, 34)
        mnuSintax_Java.Text = "&Java (J#)"
        ' 
        ' mnuSintax_FSharp
        ' 
        mnuSintax_FSharp.ImageTransparentColor = Color.Magenta
        mnuSintax_FSharp.Name = "mnuSintax_FSharp"
        mnuSintax_FSharp.Size = New Size(335, 34)
        mnuSintax_FSharp.Text = "&F#"
        ' 
        ' mnuSintax_IL
        ' 
        mnuSintax_IL.ImageTransparentColor = Color.Magenta
        mnuSintax_IL.Name = "mnuSintax_IL"
        mnuSintax_IL.Size = New Size(335, 34)
        mnuSintax_IL.Text = "&IL (ILASM)"
        ' 
        ' mnuSintax_CPP
        ' 
        mnuSintax_CPP.ImageTransparentColor = Color.White
        mnuSintax_CPP.Name = "mnuSintax_CPP"
        mnuSintax_CPP.Size = New Size(335, 34)
        mnuSintax_CPP.Text = "C/C&++"
        ' 
        ' mnuSintax_Pascal
        ' 
        mnuSintax_Pascal.ImageTransparentColor = Color.White
        mnuSintax_Pascal.Name = "mnuSintax_Pascal"
        mnuSintax_Pascal.Size = New Size(335, 34)
        mnuSintax_Pascal.Text = "&Pascal (Delphi/Freya)"
        ' 
        ' mnuSintax_SQL
        ' 
        mnuSintax_SQL.ImageTransparentColor = Color.Magenta
        mnuSintax_SQL.Name = "mnuSintax_SQL"
        mnuSintax_SQL.Size = New Size(335, 34)
        mnuSintax_SQL.Text = "&SQL"
        ' 
        ' mnuSintax_VB6
        ' 
        mnuSintax_VB6.ImageTransparentColor = Color.Magenta
        mnuSintax_VB6.Name = "mnuSintax_VB6"
        mnuSintax_VB6.Size = New Size(335, 34)
        mnuSintax_VB6.Text = "VB&6"
        ' 
        ' mnuSintax_XML
        ' 
        mnuSintax_XML.Name = "mnuSintax_XML"
        mnuSintax_XML.Size = New Size(335, 34)
        mnuSintax_XML.Text = "&XML (HTML, xaml)"
        mnuSintax_XML.ToolTipText = "Colorea los ficheros tipo XML y HTML "
        ' 
        ' toolStrip1
        ' 
        toolStrip1.ImageScalingSize = New Size(24, 24)
        toolStrip1.Items.AddRange(New ToolStripItem() {tsbColorear, tsbSep0, tsbAbrir, tsbGuardar, tsbSep1, tsbCortar, tsbCopiar, tsbPegar, tsbDeshacer, tsbSep2, tsbSintax, tsbSep3, tsbNavegar, tsbSep4, tsbAcerca, tsbSep5, tsbSalir})
        toolStrip1.Location = New Point(0, 35)
        toolStrip1.Margin = New Padding(6, 7, 6, 7)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.Padding = New Padding(0, 0, 3, 0)
        toolStrip1.Size = New Size(1104, 25)
        toolStrip1.TabIndex = 1
        toolStrip1.Text = "ToolStrip1"
        ' 
        ' tsbColorear
        ' 
        tsbColorear.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbColorear.ImageTransparentColor = Color.Magenta
        tsbColorear.Name = "tsbColorear"
        tsbColorear.Size = New Size(34, 20)
        tsbColorear.Text = "Colorear"
        tsbColorear.ToolTipText = " Colorear el código (F8) "
        ' 
        ' tsbSep0
        ' 
        tsbSep0.Name = "tsbSep0"
        tsbSep0.Size = New Size(6, 25)
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(34, 20)
        tsbAbrir.Text = "Abrir fichero"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(34, 20)
        tsbGuardar.Text = "Guardar"
        ' 
        ' tsbSep1
        ' 
        tsbSep1.Name = "tsbSep1"
        tsbSep1.Size = New Size(6, 25)
        ' 
        ' tsbCortar
        ' 
        tsbCortar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCortar.ImageTransparentColor = Color.Magenta
        tsbCortar.Name = "tsbCortar"
        tsbCortar.Size = New Size(34, 20)
        tsbCortar.Text = "Cortar"
        ' 
        ' tsbCopiar
        ' 
        tsbCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCopiar.ImageTransparentColor = Color.Magenta
        tsbCopiar.Name = "tsbCopiar"
        tsbCopiar.Size = New Size(34, 20)
        tsbCopiar.Text = "Copiar"
        ' 
        ' tsbPegar
        ' 
        tsbPegar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPegar.ImageTransparentColor = Color.Magenta
        tsbPegar.Name = "tsbPegar"
        tsbPegar.Size = New Size(34, 20)
        tsbPegar.Text = "Pegar"
        ' 
        ' tsbDeshacer
        ' 
        tsbDeshacer.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbDeshacer.ImageTransparentColor = Color.Magenta
        tsbDeshacer.Name = "tsbDeshacer"
        tsbDeshacer.Size = New Size(34, 20)
        tsbDeshacer.Text = "Deshacer"
        ' 
        ' tsbSep2
        ' 
        tsbSep2.Name = "tsbSep2"
        tsbSep2.Size = New Size(6, 25)
        ' 
        ' tsbSintax
        ' 
        tsbSintax.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSintax.ImageTransparentColor = Color.Magenta
        tsbSintax.Name = "tsbSintax"
        tsbSintax.Size = New Size(21, 20)
        tsbSintax.Text = "Sintaxis"
        ' 
        ' tsbSep3
        ' 
        tsbSep3.Name = "tsbSep3"
        tsbSep3.Size = New Size(6, 25)
        ' 
        ' tsbNavegar
        ' 
        tsbNavegar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNavegar.ImageTransparentColor = Color.Magenta
        tsbNavegar.Name = "tsbNavegar"
        tsbNavegar.Size = New Size(34, 20)
        tsbNavegar.Text = "Ver en el navegador"
        tsbNavegar.ToolTipText = " Actualizar el navegador con los cambios "
        ' 
        ' tsbSep4
        ' 
        tsbSep4.Name = "tsbSep4"
        tsbSep4.Size = New Size(6, 25)
        ' 
        ' tsbAcerca
        ' 
        tsbAcerca.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAcerca.ImageTransparentColor = Color.Magenta
        tsbAcerca.Name = "tsbAcerca"
        tsbAcerca.Size = New Size(34, 20)
        tsbAcerca.Text = "Acerca de"
        ' 
        ' tsbSep5
        ' 
        tsbSep5.Name = "tsbSep5"
        tsbSep5.Size = New Size(6, 25)
        ' 
        ' tsbSalir
        ' 
        tsbSalir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSalir.ImageTransparentColor = Color.Magenta
        tsbSalir.Name = "tsbSalir"
        tsbSalir.Size = New Size(34, 20)
        tsbSalir.Text = "Salir"
        ' 
        ' statusStrip1
        ' 
        statusStrip1.ImageScalingSize = New Size(24, 24)
        statusStrip1.Items.AddRange(New ToolStripItem() {statusInfo, statusSintax})
        statusStrip1.Location = New Point(0, 903)
        statusStrip1.Margin = New Padding(6, 7, 6, 7)
        statusStrip1.Name = "statusStrip1"
        statusStrip1.Padding = New Padding(1, 0, 20, 0)
        statusStrip1.Size = New Size(1104, 32)
        statusStrip1.TabIndex = 3
        statusStrip1.Text = "StatusStrip1"
        ' 
        ' statusSintax
        ' 
        statusSintax.AutoSize = False
        statusSintax.BorderSides = ToolStripStatusLabelBorderSides.Left
        statusSintax.Name = "statusSintax"
        statusSintax.Size = New Size(72, 25)
        statusSintax.Text = "VB"
        statusSintax.ToolTipText = " El lenguaje seleccionado para colorear "
        ' 
        ' fColorear
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CausesValidation = False
        ClientSize = New Size(1104, 935)
        Controls.Add(statusStrip1)
        Controls.Add(toolStrip1)
        Controls.Add(TabControl1)
        Controls.Add(menuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MaximumSize = New Size(2276, 1629)
        MinimumSize = New Size(933, 946)
        Name = "fColorear"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Utilidad para colorear el código"
        TabControl1.ResumeLayout(False)
        tpPrincipal.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(txtIndentar, ComponentModel.ISupportInitialize).EndInit()
        tpVisor.ResumeLayout(False)
        tpConfig.ResumeLayout(False)
        tabControlCfg.ResumeLayout(False)
        tpColores.ResumeLayout(False)
        tpColores.PerformLayout()
        cboPreContextMenu.ResumeLayout(False)
        menuStrip1.ResumeLayout(False)
        menuStrip1.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        statusStrip1.ResumeLayout(False)
        statusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Private WithEvents statusInfo As ToolStripStatusLabel
    Private WithEvents mnuFic As ToolStripMenuItem
    Private WithEvents mnuFicAcerca As ToolStripMenuItem
    Private mnuFicSep4 As ToolStripSeparator
    Private WithEvents mnuFicSalir As ToolStripMenuItem
    Private WithEvents mnuEdi As ToolStripMenuItem
    Private WithEvents mnuEdiDeshacer As ToolStripMenuItem
    Private mnuEdiSep1 As ToolStripSeparator
    Private WithEvents mnuEdiCortar As ToolStripMenuItem
    Private WithEvents mnuEdiCopiar As ToolStripMenuItem
    Private WithEvents mnuEdiPegar As ToolStripMenuItem
    Private mnuEdiSep2 As ToolStripSeparator
    Private WithEvents tpPrincipal As TabPage
    Private WithEvents tpVisor As TabPage
    Private WithEvents WebBrowser1 As WebBrowser
    Private WithEvents mnuSintax As ToolStripMenuItem
    Private WithEvents mnuSintax_VB As ToolStripMenuItem
    Private WithEvents mnuSintax_CS As ToolStripMenuItem
    Private WithEvents mnuSintax_Java As ToolStripMenuItem
    Private WithEvents mnuSintax_FSharp As ToolStripMenuItem
    Private WithEvents mnuSintax_dotNet As ToolStripMenuItem
    Private WithEvents mnuSintax_IL As ToolStripMenuItem
    Private WithEvents mnuSintax_CPP As ToolStripMenuItem
    Private WithEvents mnuSintax_Pascal As ToolStripMenuItem
    Private WithEvents mnuSintax_SQL As ToolStripMenuItem
    Private WithEvents mnuSintax_VB6 As ToolStripMenuItem
    Private WithEvents mnuSintax_Ninguno As ToolStripMenuItem
    Private WithEvents mnuSintaxColorear As ToolStripMenuItem
    Private WithEvents tsbColorear As ToolStripButton
    Private tsbSep0 As ToolStripSeparator
    Private WithEvents tsbCortar As ToolStripButton
    Private WithEvents tsbCopiar As ToolStripButton
    Private WithEvents tsbPegar As ToolStripButton
    Private WithEvents tsbDeshacer As ToolStripButton
    Private tsbSep2 As ToolStripSeparator
    Private tsbSep3 As ToolStripSeparator
    Private tsbSep5 As ToolStripSeparator
    Private WithEvents tsbSalir As ToolStripButton
    Private WithEvents tsbSintax As ToolStripSplitButton
    Private WithEvents rtEditor As RichTextBox
    Private WithEvents statusSintax As ToolStripStatusLabel
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents txtIndentar As NumericUpDown
    Private WithEvents chkIndentar As CheckBox
    Private WithEvents chkQuitarEspacios As CheckBox
    Private WithEvents tpConfig As TabPage
    Private WithEvents btnCfgAplicar As Button
    Private WithEvents btnCfgRestablecer As Button
    Private WithEvents tabControlCfg As TabControl
    Private WithEvents tpColores As TabPage
    Private WithEvents btnTextoNormal As Button
    Private WithEvents btnColorear As Button
    Private WithEvents tsbGuardar As ToolStripButton
    Private tsbSep1 As ToolStripSeparator
    Private WithEvents mnuFicGuardar As ToolStripMenuItem
    Private mnuFicSep2 As ToolStripSeparator
    Private WithEvents tsbAbrir As ToolStripButton
    Private WithEvents mnuFicAbrir As ToolStripMenuItem
    Private WithEvents mnuSintax_XML As ToolStripMenuItem
    Private WithEvents tsbNavegar As ToolStripButton
    Private tsbSep4 As ToolStripSeparator
    Private WithEvents tsbAcerca As ToolStripButton
    Private mnuFicSep1 As ToolStripSeparator
    Private WithEvents mnuFicNavegar As ToolStripMenuItem
    Private WithEvents mnuSintaxColorearDeRTF As ToolStripMenuItem
    Private WithEvents toolTip1 As ToolTip
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents cboPreContextMenu As ContextMenuStrip
    Private WithEvents mnuCboPreEliminar As ToolStripMenuItem
    Private WithEvents TabControl1 As TabControl
    Private WithEvents btnCfgDeshacer As Button
    Private WithEvents chkUsarTemaOscuro As CheckBox
    Private WithEvents chkSyntaxMayusc As CheckBox
    Private WithEvents chkNotify As CheckBox
    Private WithEvents chkUsarSpanStyle As CheckBox
    Private WithEvents cboTamFuente As ComboBox
    Private WithEvents cboFuentes As ComboBox
    Private WithEvents Label8 As Label
    Private WithEvents btnColorKeywords As Button
    Private WithEvents LabelColorKeywords As Label
    Private WithEvents txtColorKeywords As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents btnColorXML As Button
    Private WithEvents LabelColorXML As Label
    Private WithEvents txtColorXML As TextBox
    Private WithEvents Label51 As Label
    Private WithEvents btnColorRem As Button
    Private WithEvents LabelColorRem As Label
    Private WithEvents txtColorRem As TextBox
    Private WithEvents Label41 As Label
    Private WithEvents btnColorTexto As Button
    Private WithEvents LabelColorTexto As Label
    Private WithEvents txtColorTexto As TextBox
    Private WithEvents cboPre As ComboBox
    Private WithEvents Label21 As Label
    Private WithEvents Label11 As Label
    'Private WithEvents picColor As PictureBox
    'Private WithEvents cboColores As ComboBox
    'Private WithEvents Label1 As Label
    Private WithEvents chkRecordarUltimoTexto As CheckBox
    Private WithEvents btnColorClases As Button
    Private WithEvents LabelColorClases As Label
    Private WithEvents txtColorClases As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents mnuSintaxColorearEnRTF As ToolStripMenuItem
    Private WithEvents mnuEdiSeleccionarTodo As ToolStripMenuItem
    Private mnuSintaxSep1 As ToolStripSeparator
    Private WithEvents mnuFicVerRTF As ToolStripMenuItem
    Private WithEvents mnuFicSep3 As ToolStripSeparator
    Friend WithEvents mnuSintaxObtenerCodigoDualHTML As ToolStripMenuItem
End Class
