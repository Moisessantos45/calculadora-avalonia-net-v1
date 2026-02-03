<div align="center">

# 🧮 Calculadora Avalonia

### Una calculadora moderna con conversión de bases numéricas

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Avalonia UI](https://img.shields.io/badge/Avalonia_UI-11.3-8B44AC?style=for-the-badge&logo=avalonia&logoColor=white)](https://avaloniaui.net/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D4?style=for-the-badge&logo=windows&logoColor=white)](https://www.microsoft.com/windows)
[![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)](LICENSE)

*Calculadora de escritorio desarrollada con tecnología moderna y diseño elegante*

---

</div>

## ✨ Características

| Característica | Descripción |
|----------------|-------------|
| 🔢 **Operaciones básicas** | Suma, resta, multiplicación y división |
| 🔄 **Conversión de bases** | Hexadecimal, Decimal, Octal y Binario en tiempo real |
| 🎨 **Interfaz moderna** | Diseño fluent con tema oscuro |
| ⌨️ **Entrada flexible** | Soporte para caracteres hexadecimales (A-F) |
| 📐 **Redimensionable** | Ventana ajustable según tus preferencias |

## 🖥️ Capturas de Pantalla

> *Próximamente se añadirán capturas de pantalla de la aplicación*

## 🚀 Instalación

### Opción 1: Descargar el instalador (Recomendado)

| Versión | Enlace de descarga |
|---------|-------------------|
| **v2.5** (Última) | [📥 Descargar](https://drive.google.com/file/d/1LgE4bStFBimSQPhDjuRyzdqa34n4O6VR/view?usp=sharing) |
| v2.0 | [📥 Descargar](https://drive.google.com/file/d/1YwTwMwjYrmHyg1UGFkeS7MQBVq5LaSVU/view?usp=sharing) |

### Opción 2: Compilar desde el código fuente

#### Requisitos previos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/es-es/download/dotnet/9.0) o [.NET 8.0 SDK](https://dotnet.microsoft.com/es-es/download/dotnet/8.0)
- Windows 10/11 (64-bit)

#### Pasos de compilación

```bash
# 1. Clonar el repositorio
git clone https://github.com/Moisessantos45/calculadora-avalonia-net-v1.git
cd calculadora-avalonia-net-v1

# 2. Restaurar dependencias
dotnet restore

# 3. Ejecutar en modo desarrollo
dotnet run

# 4. O publicar para producción
dotnet publish -c Release -r win-x64 --self-contained true -o publish-win
```

#### Crear instalador (Opcional)

Para crear un instalador `.exe`, necesitas tener instalado [NSIS](https://nsis.sourceforge.io/):

```bash
makensis installer.nsi
```

## 🛠️ Tecnologías

<div align="center">

| Tecnología | Versión | Propósito |
|------------|---------|-----------|
| ![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white) | 9.0 | Framework principal |
| ![Avalonia](https://img.shields.io/badge/Avalonia-8B44AC?style=flat-square&logo=avalonia&logoColor=white) | 11.3.11 | Framework de UI multiplataforma |
| ![CommunityToolkit](https://img.shields.io/badge/MVVM_Toolkit-512BD4?style=flat-square&logo=dotnet&logoColor=white) | 8.2.1 | Patrón MVVM |

</div>

## 📁 Estructura del Proyecto

```
calculadora-avalonia-net-v1/
├── 📂 Assets/              # Iconos y recursos
├── 📂 Components/          # Componentes reutilizables (CalcButton)
├── 📂 Converters/          # Conversores de datos
├── 📂 Models/              # Modelos de datos
├── 📂 Styles/              # Estilos XAML
├── 📂 ViewModels/          # Lógica de presentación (MVVM)
├── 📂 Views/               # Vistas de la aplicación
├── 📄 App.axaml            # Configuración de la aplicación
├── 📄 Program.cs           # Punto de entrada
└── 📄 Calculadora.csproj   # Configuración del proyecto
```

## 🎯 Uso

1. **Ingresa números** usando el teclado numérico de la aplicación
2. **Utiliza caracteres hexadecimales** (A-F) para valores en base 16
3. **Observa las conversiones** automáticas en HEX, DEC, OCT y BIN
4. **Navega** con los botones `<<` y `>>` para mover el cursor
5. **Limpia** con `CE` o elimina caracteres con `DEL`
6. **Calcula** presionando `=`

## 🤝 Contribuir

¡Las contribuciones son bienvenidas! Si deseas mejorar este proyecto:

1. Haz un Fork del repositorio
2. Crea una rama para tu feature (`git checkout -b feature/NuevaCaracteristica`)
3. Realiza tus cambios y haz commit (`git commit -m 'Añadir nueva característica'`)
4. Sube los cambios a tu rama (`git push origin feature/NuevaCaracteristica`)
5. Abre un Pull Request

## 📝 Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.

## 👨‍💻 Autor

Desarrollado con ❤️ por **Moises Santos**

---

<div align="center">

⭐ **¡Si te gusta este proyecto, dale una estrella!** ⭐

</div>