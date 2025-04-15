# CrudJobsHR

Este proyecto es una aplicación web ASP.NET Core MVC que implementa un CRUD completo para la tabla **Jobs** del modelo de base de datos HR (Human Resources).

## 🛠️ Tecnologías utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Visual Studio 2022
- Bootstrap 5

## 📂 Estructura del proyecto

├── Controllers/ │ └── JobsController.cs │ ├── Models/ │ └── Job.cs │ ├── Views/ │ └── Jobs/ │ ├──
 Create.cshtml │ ├── Delete.cshtml │ ├── Details.cshtml │ ├── Edit.cshtml │ └── Index.cshtml │ ├──
 Data/ │ └── HRDbContext.cs │ ├── appsettings.json └── Program.cs

markdown


## 🚀 Funcionalidades

- ✅ Crear un nuevo trabajo
- ✅ Editar datos de un trabajo
- ✅ Eliminar un trabajo existente
- ✅ Visualizar todos los trabajos

## 💾 Base de datos

La aplicación se conecta a una base de datos SQL Server con la tabla `jobs` que contiene los siguientes campos:

- `job_id` (PK, int)
- `job_title` (string)
- `min_salary` (decimal?)
- `max_salary` (decimal?)

## 📎 Requisitos para ejecutar

- .NET 6 SDK o superior
- SQL Server local o remoto
- Visual Studio 2022 o Visual Studio Code

## ⚙️ Configuración

1. Clona el repositorio:
```bash
git clone https://github.com/Georiell/CrudJobsHR.git


## 🚀 Funcionalidades

- ✅ Crear un nuevo trabajo
- ✅ Editar datos de un trabajo
- ✅ Eliminar un trabajo existente
- ✅ Visualizar todos los trabajos

## 💾 Base de datos

La aplicación se conecta a una base de datos SQL Server con la tabla `jobs` que contiene los siguientes campos:

- `job_id` (PK, int)
- `job_title` (string)
- `min_salary` (decimal?)
- `max_salary` (decimal?)

## 📎 Requisitos para ejecutar

- .NET 6 SDK o superior
- SQL Server local o remoto
- Visual Studio 2022 o Visual Studio Code

## ⚙️ Configuración

1. Clona el repositorio:
```bash
git clone https://github.com/Georiell/CrudJobsHR.git

2. Ajusta la cadena de conexión en appsettings.json.

3. Ejecuta el proyecto desde Visual Studio.

👤 Autor
Georiell
Desarrollador en formación – Cibertec – 5to ciclo


---

### ✅ 3. Guardar, cerrar el bloc y luego en la terminal haz:

```bash
git add README.md
git commit -m "Agregando README con descripción del proyecto"
git push origin main

