using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadFilePlano.src.Principal;

namespace ReadFilePlano.src.Main
{
    public class Iniciar
    {
        public static void Main()
        {
            Metodos getfactura = new Metodos();

            Console.WriteLine();
            Console.Write("PREGUNTA #1. Cuáles son las facturas que fueron pagadas en el mes de Enero. ");
            getfactura.FacturasPagadasEnero();

            Console.WriteLine();
            Console.Write("PREGUNTA #2. Cuál es el total de Facturas pagadas. ");
            getfactura.TotalPagadas();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"PREGUNTA #3. Cuál es el total de Facturas NO pagadas. ");
            getfactura.TotalNoPagadas();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"PREGUNTA #4. Cuáles fueron las facturas pagadas en el primer semestre\r\n(enero,febrero,marzo,abril,mayo,junio). ");
            getfactura.FacturasPrimerSemestre();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"PREGUNTA #5. Cuáles fueron las facturas pagadas en el segundo semestre\r\n(julio,agosto,septiembre,octubre,noviembre,diciembre). ");
            getfactura.FacturasSegundoSemestre();
        }
    }
}
