# ASP.NET Web SQL Server Queries Lab

Proyecto de práctica desarrollado con **ASP.NET Core MVC** y **SQL Server** que permite ejecutar consultas parametrizadas desde una aplicación web.

## Características

* Conexión a SQL Server configurable mediante `appsettings.json`.
* Uso de `Microsoft.Data.SqlClient`.
* Tres consultas SQL parametrizadas:

  * Búsqueda de clientes por edad.
  * Búsqueda de productos por categoría.
  * Búsqueda de ventas por fecha.
* Interfaz web sencilla para ejecutar consultas y visualizar resultados.
* Proyecto creado completamente desde línea de comandos utilizando .NET CLI.

## Tecnologías

* C#
* ASP.NET Core MVC
* SQL Server
* .NET SDK
* Microsoft.Data.SqlClient

## Base de datos de ejemplo

El repositorio incluye un script SQL para crear la base de datos **WebQueriesDB**, junto con tablas y datos de prueba.

## Ejecución

1. Crear la base de datos ejecutando el script SQL incluido.
2. Configurar la cadena de conexión en `appsettings.json`.
3. Restaurar dependencias:

```bash
dotnet restore
```

4. Ejecutar la aplicación:

```bash
dotnet run
```

5. Abrir la URL mostrada por la consola y acceder a:

```text
/Consultas
```

## Datos de prueba

* Edad: `25`
* Categoría: `Tecnologia`
* Fecha: `2025-02-10`
