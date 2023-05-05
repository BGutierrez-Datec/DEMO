# Demo Ambiente

Demo de ejemplo para la configuración del ambiente de pruebas para la aplicación de .Net Core 6

todas las configuraciones realizadas en este proyecto se pueden aplicar al proyecto k.monitor con la diferencia que este proyecto es de .Net Core 6 y el proyecto k.monitor se debe migrar desde ASP .NET

## Configuración del ambiente

### Instalación de .Net Core 6

Esta es la versión de .Net Core que se debe utilizar para el proyecto k-monitor, es la versión LTS de .Net Core y la que se recomienda utilizar para los proyectos de producción.
Para instalar .Net Core 6 se debe descargar el instalador desde el siguiente enlace:

https://dotnet.microsoft.com/download/dotnet/6.0

### Instalación de Docker

de preferencia utilizar la versión 4.1.1 de Docker Desktop, ya que la versión 5.0.0 tiene problemas con la comunicación con la base de datos de Postgres.
Para instalar Docker se debe descargar el instalador desde el siguiente enlace:

https://www.docker.com/products/docker-desktop

### Instalación de Visual Studio 2022 Community

Para instalar Visual Studio 2022 Comunity se debe descargar el instalador desde el siguiente enlace:

https://visualstudio.microsoft.com/es/downloads/


## Configuración del proyecto

### Configuración de Postgres

Para configurar la base de datos se debe ejecutar el siguiente comando en la consola de comandos de Docker:

```bash
docker run --name postgres -e POSTGRES_PASSWORD=postgres -POSTGRES_DB=monitor -p 5432:5432 -d postgres
```