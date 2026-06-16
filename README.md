# gsColorearCodigo NET9


Utilidad para colorear código y generar código HTML para usar en publicaciones WEB. Usando gsColorearNET para .NET Standard 2.0. (para .NET 9.0  revisión del 16/Jun/2026)

<br>
Si quieres ver **el artículo relacionado con este repositorio**, pulsa en este enlace: [**gsColorearCodigo NET9**](https://www.elguillemola.com/gscolorearcodigo-net9).

<br>

## Lo que hemos hecho la IA de Google (Gemini) y un servidor

```
====================================================================
MIGRACIÓN Y ACTUALIZACIÓN DEL GENERADOR DE CÓDIGO (VB.NET)
====================================================================

1. MIGRACIÓN DE ARQUITECTURA:
   * El proyecto se ha migrado con éxito a .NET 9.0 (utilizando .NET Standard 2.0 para la librería lógica central), asegurando compatibilidad moderna, mejor rendimiento y soporte a largo plazo.

2. PROCESAMIENTO DUAL INTERACTIVO (CLARO/OSCURO):
   * Se ha diseñado e implementado el método 'ObtenerCodigoDualHTML' en la clase 'Colorear'.
   * Este método realiza un doble procesamiento del código RTF original de forma nativa utilizando expresiones regulares: una pasada optimizada para el Modo Claro y otra para el Modo Oscuro.
   * Elimina dinámicamente las etiquetas <pre> antiguas generadas por la configuración local para evitar duplicidades de contenedores en la web.

3. INYECCIÓN DE ESTILOS EN LÍNEA (INLINE CSS):
   * Para garantizar el aislamiento visual total en WordPress, las cajas <pre> finales llevan el color de fondo y de texto "grabados a fuego" mediante atributos 'style' en línea.
   * El contenedor Claro fuerza un fondo blanco (#ffffff) con texto base negro.
   * El contenedor Oscuro fuerza el fondo clásico de Visual Studio (#1e1e1e) con texto gris claro.

4. OPTIMIZACIÓN DEL VISOR HTML LOCAL:
   * Se ha corregido el método de guardado del archivo temporal ('guardarTEMP') aislando el procesamiento en variables locales. Esto evita que los reemplazos de texto (como alterar los '&nbsp;') corrompan el HTML original que se muestra en el editor.
   * Se ha inyectado un parche de compatibilidad con la directiva 'IE=edge' y JavaScript con sintaxis tradicional (usando 'var' y bucles clásicos) dentro del archivo físico temporal. Esto soluciona los molestos "errores de script" del control WebBrowser antiguo y permite probar los botones interactivos de cambio de modo directamente en el escritorio antes de publicar.
```
