# Crear un proyecto de tipo libreria de clases en .Net
dotnet new classlib -o src\Application

# Crear un un proyecto de tipo consola en .Net
dotnet new console -o src\ConsoleApp
dotnet add src\ConsoleApp reference src\Application

# Crear un proyecto de tipo web en .Net
dotnet new web -o src\WebApp
dotnet add src\WebApp reference src\Application

# Abrir el directorio con vs code
code .

# Eliminar y crear archivos necesarios
rm src\Application\Class1.cs
code src\Application\Cuadrado.cs
code src\Application\PrismaCuadrangular.cs
code src\WebApp\Pages\Index.cshtml
code src\ConsoleApp\Program.cs
code src\WebApp\Program.cs