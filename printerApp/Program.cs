using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args == null) {

                System.Environment.Exit(0); // Cerrar aplicacion
            }
            else {
                string printerName = ""; // Nombre impresora
                readPrinter(ref printerName);

                // print://1000/ ejemplo de lo que recibimos
                string Saleid = args[0].Replace("print://", string.Empty).Replace("/", string.Empty);

                clsDocs.Receipt(Saleid, printerName);
            }
        } 

        private static void readPrinter(ref string printerName)
        {
            // obtenemos la ruta del ejecutable 
            string rootFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string textFile = rootFolder + @"\printer.txt"; //C:\Users\marlon\source\repos\printerApp\printerApp\bin\Debug

            if (File.Exists(textFile)) { 
                printerName = File.ReadAllText(textFile);
            }
            else
            {
                printerName = "POS-58";
            }
        }

    }
}
