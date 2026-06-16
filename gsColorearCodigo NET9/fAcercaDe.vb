'------------------------------------------------------------------------------
' Formulario Acerca de "el Guille"                                  (12/Jul/06)
' Adaptado del AcercaDe del visor de imágenes.
'
'
' ©Guillermo 'guille' Som, 2006, 2020, 2026
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports Microsoft.VisualBasic
Imports vb = Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing

'Imports clickOnce = System.Deployment
Imports System.Text.RegularExpressions

Public Class fAcercaDe

    ' Datos a configurar en cada uso de este formulario:

    ' Nueva URL de la utilidad en el blog                       (15/jun/26 21.27)

    Const laURL As String = "https://www.elguillemola.com/gscolorearcodigo-net9/"
    ' Para mover la ventana
    Private ratonPulsado As Boolean
    Private pX, pY As Integer
    Private bugInfo As String
    'Private fvi As System.Diagnostics.FileVersionInfo
    Private ficVers As String = ""
    '
    Private Sub fAcercaDe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ensamblado As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
        'fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(ensamblado.Location)


        Dim copyrAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyCopyrightAttribute), False)
        Dim copyr = If(copyrAttr.Length > 0, TryCast(copyrAttr(0), System.Reflection.AssemblyCopyrightAttribute).Copyright,
                                            "Copyright © Guillermo Som (Guille), 2020, 2026")
        ' Información de Copyright
        labelAutor.Text = copyr

        Dim versionAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyVersionAttribute), False)
        Dim vers = If(versionAttr.Length > 0, TryCast(versionAttr(0), System.Reflection.AssemblyVersionAttribute).Version,
                                                "2.0.0.0")
        Dim fileVerAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyFileVersionAttribute), False)
        Dim versF = If(fileVerAttr.Length > 0, TryCast(fileVerAttr(0), System.Reflection.AssemblyFileVersionAttribute).Version,
                                                "2.0.0.0")
        ficVers = vers

        Dim prodAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyProductAttribute), False)
        Dim producto = If(prodAttr.Length > 0, TryCast(prodAttr(0), System.Reflection.AssemblyProductAttribute).Product,
                                                "gsColorearCodigo NET9")

        ' La descripción, tomar solo el final                   (11/Sep/20)
        Dim descAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyDescriptionAttribute), False)
        Dim desc = If(descAttr.Length > 0, TryCast(descAttr(0), System.Reflection.AssemblyDescriptionAttribute).Description,
                                                "(para .NET 9.0 revisión del 16/Jun/2026)")
        desc = desc.Substring(desc.IndexOf("(para .NET"))

        labelTitulo.Text = producto
        bugInfo = $"{labelTitulo.Text} v {versF}"

        Dim descColorear = gsColorearNET.Colorear.Version(True)
        Dim i = descColorear.IndexOf("(para .NET")
        descColorear = descColorear.Substring(0, i) & vbCrLf & descColorear.Substring(i)

        labelDescripcion.Text = labelTitulo.Text &
                        $" v{vers} ({versF})" & vbCrLf & vbCrLf &
                        desc & vbCrLf & vbCrLf &
                        descColorear


        Me.labelWeb.Text = "Comprobando si hay actualizaciones..."
        timerWeb.Enabled = True
    End Sub

    Private Sub pMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                    Handles Me.MouseDown, TableLayoutPanel1.MouseDown,
                            labelTitulo.MouseDown, labelDescripcion.MouseDown, labelAutor.MouseDown
        ' Mover el formulario mientras se mantenga el ratón pulsado
        ratonPulsado = True
        pX = e.X
        pY = e.Y
    End Sub
    Private Sub pMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                    Handles Me.MouseMove, TableLayoutPanel1.MouseMove,
                            labelTitulo.MouseMove, labelDescripcion.MouseMove, labelAutor.MouseMove
        If ratonPulsado Then
            Me.Left += e.X - pX
            Me.Top += e.Y - pY
        End If
    End Sub
    Private Sub pMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                    Handles Me.MouseUp, TableLayoutPanel1.MouseUp,
                            labelTitulo.MouseUp, labelDescripcion.MouseUp, labelAutor.MouseUp
        ratonPulsado = False
    End Sub

    Private Sub LinkURL_LinkClicked(sender As System.Object,
                                    e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkURL.LinkClicked
        Try
            'System.Diagnostics.Process.Start(linkURL.Text)
            Dim p As New Process
            p.StartInfo.FileName = linkURL.Text
            p.StartInfo.UseShellExecute = True
            p.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al abrir la página de la utilidad")
        End Try

        'End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub linkBug_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkBug.LinkClicked
        ' Enviar un bug o mejora                                    (13/Jul/06)
        'If My.Computer.Network.IsAvailable Then
        'Dim sb As New System.Text.StringBuilder
        Dim sb = "https://github.com/elGuille-info/gsColorearCodigo-NET9"
        Try
            'System.Diagnostics.Process.Start(sb.ToString)
            Dim p As New Process
            p.StartInfo.FileName = sb
            p.StartInfo.UseShellExecute = True
            p.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al abrir la página de reportar bug o mejora")
        End Try

        'End If
    End Sub
    '
    Private Function versionWeb() As String
        Try
            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(laURL)
            Dim response As System.Net.WebResponse
            Dim reader As System.IO.StreamReader
            ' Obtener la respuesta.
            response = request.GetResponse()
            ' Abrir el stream de la respuesta recibida.
            reader = New System.IO.StreamReader(response.GetResponseStream())
            ' Leer el contenido.
            Dim s As String = reader.ReadToEnd()
            ' Cerrar los streams abiertos.
            reader.Close()
            response.Close()
            '
            ' Comprobar el valor de <meta name="version" 
            ' Usar esta expresión regular: <meta name="version" content="(\d.\d.\d.\d)" />
            ' En Groups(1) estará la versión
            Dim r As New Regex("<meta name=""version"" content=""(\d{1,}.\d{1,}.\d{1,}.\d{1,})"" />")
            For Each m As Match In r.Matches(s)
                If m.Groups.Count > 1 Then
                    Return m.Groups(1).Value
                End If
            Next
        Catch ex As Exception
            Return ""
        End Try
        Return ""
    End Function
    '
    Private Sub timerWeb_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerWeb.Tick
        timerWeb.Enabled = False

        Dim sb As New System.Text.StringBuilder
        'If clickOnce.Application.ApplicationDeployment.IsNetworkDeployed Then
        '    sb.Append("Aplicación instalada con ClickOnce")
        '    sb.AppendLine()
        '    Dim inf As clickOnce.Application.UpdateCheckInfo
        '    inf = My.Application.Deployment.CheckForDetailedUpdate
        '    If inf.UpdateAvailable Then
        '        sb.AppendFormat("Hay una nueva versión disponible: v{0}", inf.AvailableVersion.ToString)
        '    Else
        '        sb.Append("Esta es la versión más reciente, no hay nuevas actualizaciones.")
        '    End If
        'Else
        sb.Append("Aplicación instalada directamente (sin usar ClickOnce)")
        sb.AppendLine()
        Dim vWeb As String = "2.0.0.0" ' versionWeb()
        '' Por si la versión está vacía                          (17/Abr/07)
        'If String.IsNullOrEmpty(vWeb) Then
        '    vWeb = "0.0.0.0"
        'End If

        ' Solo funcionará bien con valores de 1 cifra           (14/Feb/07)
        ' ya que 1.0.3.11 será menor que 1.0.3.9 aunque no sea así...
        ' Convertirlo en cadena de números de dos cifras
        Dim aWeb() As String = vWeb.Split("."c)
        Dim aFic() As String = ficVers.Split("."c)
        Dim wMayor As Boolean = False
        vWeb = ""
        Dim sFic As String = ""
        ' Para que se muestre bien, añadir puntos               (17/Abr/07)
        For i As Integer = 0 To aWeb.Length - 1
            vWeb &= CInt(aWeb(i)).ToString("00") & "."
            'sFic &= CInt(aFic(i)).ToString("00")
        Next
        For i As Integer = 0 To aFic.Length - 1
            sFic &= CInt(aFic(i)).ToString("00") & "."
        Next
        If vWeb > sFic Then ' fvi.FileVersion Then
            sb.AppendFormat("Hay una nueva versión disponible en mi sitio: v{0}", vWeb)
            'sb.AppendFormat("La última versión en la Web es: v{0}, la actual es: v{1}", vWeb, fvi.FileVersion)
        Else
            sb.Append("Esta es la versión más reciente, no hay nuevas actualizaciones.")
        End If
        'End If

        Me.labelWeb.Text = sb.ToString
    End Sub

    Private Sub linkPrograma_LinkClicked(ByVal sender As System.Object,
                                         ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPrograma.LinkClicked
        ' Ir a la página de la utilidad                             (14/Feb/07)
        'If My.Computer.Network.IsAvailable Then
        '    System.Diagnostics.Process.Start(laURL)
        'End If
        Try
            'System.Diagnostics.Process.Start(laURL)
            Dim p As New Process
            p.StartInfo.FileName = laURL
            p.StartInfo.UseShellExecute = True
            p.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al abrir la página de utilidad")
        End Try
    End Sub
End Class
