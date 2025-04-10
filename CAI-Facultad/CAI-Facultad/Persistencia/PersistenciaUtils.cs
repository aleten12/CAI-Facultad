﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Facultad.Persistencia
{
    internal class PersistenciaUtils

    {
        string archivoCsv = @"D:\Datos\OneDrive\Documentos\GitHub\CAI-Facultad\CAI-Facultad\CAI-Facultad\Datos\";
        public List<String> LeerRegistro(String nombreArchivo)
        {
            archivoCsv = archivoCsv + nombreArchivo; // Cambia esta ruta al archivo CSV que deseas leer

            String rutaArchivo = Path.GetFullPath(archivoCsv); // Normaliza la ruta

            List<String> listado = new List<String>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        listado.Add(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return listado;
        }

        // Método para borrar un registro
        public void BorrarRegistro(string id, String nombreArchivo)
        {
            archivoCsv = archivoCsv + nombreArchivo; // Cambia esta ruta al archivo CSV que deseas leer

            String rutaArchivo = Path.GetFullPath(archivoCsv); // Normaliza la ruta

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + archivoCsv);
                    return;
                }

                // Leer el archivo y obtener las líneas
                List<string> listado = LeerRegistro(nombreArchivo);

                // Filtrar las líneas que no coinciden con el ID a borrar (comparar solo la primera columna)
                List<string> registrosRestantes = new List<string>();

                foreach (string linea in listado)
                {
                    string[] campos = linea.Split(';');

                    if (campos.Length > 0 && campos[0] != id) // Verifica que haya al menos un campo
                    {
                        registrosRestantes.Add(linea); // Solo agrega si el ID no coincide
                    }
                }

                // Sobrescribir el archivo con las líneas restantes
                File.WriteAllLines(archivoCsv, registrosRestantes);

                Console.WriteLine($"Registro con ID {id} borrado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar borrar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        // Método para agregar un registro
        public void AgregarRegistro(string nombreArchivo, string nuevoRegistro)
        {
            string archivoCsv = Path.Combine(Directory.GetCurrentDirectory(), "Persistencia", "Datos", nombreArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(archivoCsv))
                {
                    Console.WriteLine("El archivo no existe: " + archivoCsv);
                    return;
                }

                // Abrir el archivo y agregar el nuevo registro
                using (StreamWriter sw = new StreamWriter(archivoCsv, append: true))
                {
                    sw.WriteLine(nuevoRegistro); // Agregar la nueva línea
                }

                Console.WriteLine("Registro agregado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar agregar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }
    }
}
