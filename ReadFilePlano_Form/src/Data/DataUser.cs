using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadFilePlano_Form.src.Model;

namespace ReadFilePlano_Form.src.Data
{
    public class DataUser
    {
        //List <DataModel> lista = new List <DataModel> ();
        string DataPlana = "";

        /// <summary>
        /// Guarda la informacion
        /// </summary>
        /// <param name="modelo">Datos del plano</param>
        public void Guardar(string datosFormateados)
        {
            DataPlana = datosFormateados;
        }


        /// <summary>
        /// Consulta toda la info
        /// </summary>
        /// <returns>la lista</returns>
        public List<DataModel> Consultar()
        {
            //terminar esto y hallar el error
            List<DataModel> lista = new List<DataModel>();

            // Verificar si DataPlana está vacío
            if (!string.IsNullOrEmpty(DataPlana))
            {
                string[] partes = DataPlana.Split(';');

                foreach (string parte in partes)
                {
                    // Verificar si parte está vacía
                    if (!string.IsNullOrEmpty(parte))
                    {
                        string[] datos = parte.Split(';');

                        // Asegurarse de que datos tiene al menos 6 elementos antes de acceder a ellos
                        if (datos.Length >= 6)
                        {
                            DataModel modelo = new DataModel()
                            {
                                Prefijo = datos[0],
                                Total = double.Parse(datos[1]),
                                Impuesto = double.Parse(datos[2]),
                                TotalConImpuesto = double.Parse(datos[3]),
                                Mes = datos[4],
                                Pagado = datos[5]
                            };

                            lista.Add(modelo);
                        }
                        else
                        {
                            // Maneja el caso donde la parte no tiene suficientes elementos
                            // Puedes imprimir un mensaje de error o realizar alguna otra acción
                            Console.WriteLine("La parte no tiene suficientes elementos");
                        }
                    }
                }
            }

            return lista;
        }
    }
}
