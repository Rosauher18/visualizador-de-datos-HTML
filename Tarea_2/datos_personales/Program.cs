using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace datos_personales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar datos al usuario
            Console.WriteLine("Introduce tu cedula: ");
            string cedula = Convert.ToString(Console.ReadLine());

            Console.Write("Introduce el nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Introduce el correo electrónico: ");
            string correo = Console.ReadLine();

            Console.WriteLine("Introduce los estudios realizados: ");
            string erealizados = Console.ReadLine();

            Console.WriteLine("Introduce idiomas que dominas: ");
            string idiomas = Console.ReadLine();

            Console.WriteLine("Introduce un comentario: ");
            string comentrario = Console.ReadLine();

            // Generar contenido HTML
            string htmlContent = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Datos de la Persona</title>
            </head>
            <body>
                <h1>Datos de la Persona</h1>
             <p><strong>Cedula:</strong> {cedula}</p>
                <p><strong>Nombre:</strong> {nombre}</p>
                <p><strong>Apellido:</strong> {apellido}</p>
                <p><strong>Correo Electrónico:</strong> {correo}</p>
             <p><strong>Estudios realizados:</strong> {erealizados}</p>
             <p><strong>Idiomas que domina:</strong> {idiomas}</p>
             <p><strong>Comentario:</strong> {comentrario}</p>
            </body>
            </html>";

            // Guardar el contenido HTML en un archivo
            string filePath = "personData.html";
            File.WriteAllText(filePath, htmlContent);

            // Mostrar el archivo HTML en el navegador
            ShowHtmlInBrowser(filePath);

            Console.WriteLine("El archivo HTML ha sido generado y mostrado en el navegador.");
        }

        static void ShowHtmlInBrowser(string filePath)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(filePath)
            {
                UseShellExecute = true
            };
            p.Start();





        }
    }
}
