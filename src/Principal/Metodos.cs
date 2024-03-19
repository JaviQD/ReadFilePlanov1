using ReadFilePlano.src.Planos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadFilePlano.src.GetterSetter;

namespace ReadFilePlano.src.Principal
{
    public class Metodos
    {
        //Clase para crear cada metodo que devuelve una respuesta

        /// <summary>
        /// Metodo que devuelve las facturas pagadas en el mes de enero.
        /// </summary>
        public void FacturasPagadasEnero()
        {
            ArchivosPlanos planos = new ArchivosPlanos();
            string[] Facturas = planos.GetFacturas();

            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva variable
            Console.WriteLine();
            Console.Write("RESPUESTA #1: ");
            Console.WriteLine();
            foreach (string item in Facturas)
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] partes = item.Split(';');

                if (partes.Length == 6)
                {
                    Get_y_Set variable = new Get_y_Set();
                    variable.NumeroFactura = partes[0];
                    variable.MontoTotal = partes[1];
                    variable.Impuestos = partes[2];
                    variable.TotalConImpuestos = partes[3];
                    variable.Mes = partes[4];
                    variable.Pagadas = partes[5];


                    if (variable.Mes == "Enero")
                    {
                        Console.WriteLine($"FACTURAS '{variable.NumeroFactura}' del mes '{variable.Mes}'");
                    }

                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
        }

        /// <summary>
        /// Metodo que devuelve el total de las facturas pagadas parseado
        /// </summary>
        public void TotalPagadas()
        {
            ArchivosPlanos planos = new ArchivosPlanos();
            string[] Facturas = planos.GetFacturas();

            double TotalPagado = 0;

            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva variable
            Console.WriteLine();
            Console.Write("RESPUESTA #2: ");
            foreach (string item in Facturas)
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] partes = item.Split(';');

                if (partes.Length == 6)
                {
                    Get_y_Set variable = new Get_y_Set();
                    variable.NumeroFactura = partes[0];
                    variable.MontoTotal = partes[1];
                    variable.Impuestos = partes[2];
                    variable.TotalConImpuestos = partes[3];
                    variable.Mes = partes[4];
                    variable.Pagadas = partes[5];


                    if (variable.Pagadas == "SI")
                    {
                        TotalPagado += double.Parse(variable.TotalConImpuestos);
                    }

                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
            Console.Write($"${TotalPagado}");
        }

        /// <summary>
        /// Metodo que devuelve el total de las facturas NO pagadas parseado
        /// </summary>
        public void TotalNoPagadas()
        {
            ArchivosPlanos planos = new ArchivosPlanos();
            string[] Facturas = planos.GetFacturas();

            double TotalNoPagado = 0;

            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva variable
            Console.WriteLine();
            Console.Write("RESPUESTA #3: ");
            foreach (string item in Facturas)
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] partes = item.Split(';');

                if (partes.Length == 6)
                {
                    Get_y_Set variable = new Get_y_Set();
                    variable.NumeroFactura = partes[0];
                    variable.MontoTotal = partes[1];
                    variable.Impuestos = partes[2];
                    variable.TotalConImpuestos = partes[3];
                    variable.Mes = partes[4];
                    variable.Pagadas = partes[5];


                    if (variable.Pagadas == "NO")
                    {
                        TotalNoPagado += double.Parse(variable.TotalConImpuestos);
                    }

                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
            Console.Write($"${TotalNoPagado}");
            Console.WriteLine();
        }

        /// <summary>
        /// Metodo que devuelve las facturas pagadas en los primeros 6 meses del anio
        /// </summary>
        public void FacturasPrimerSemestre()
        {
            ArchivosPlanos planos = new ArchivosPlanos();
            string[] Facturas = planos.GetFacturas();

            //Meses del primer semestre
            string[] PrimerSemestre = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };

            double TotalNoPagado = 0;

            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva variable
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("RESPUESTA #4: ");
            foreach (string item in Facturas)
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] partes = item.Split(';');

                if (partes.Length == 6)
                {
                    Get_y_Set variable = new Get_y_Set();
                    variable.NumeroFactura = partes[0];
                    variable.MontoTotal = partes[1];
                    variable.Impuestos = partes[2];
                    variable.TotalConImpuestos = partes[3];
                    variable.Mes = partes[4];
                    variable.Pagadas = partes[5];


                    if (variable.Pagadas == "SI" &&
                        PrimerSemestre.Contains(variable.Mes))
                    {
                        Console.WriteLine($"Facturas '{variable.NumeroFactura}' del mes '{variable.Mes}'");
                    }

                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
        }

        /// <summary>
        /// Metodo que devuelve las facturas pagadas en los Ultimos 6 meses del anio
        /// </summary>
        public void FacturasSegundoSemestre()
        {
            ArchivosPlanos planos = new ArchivosPlanos();
            string[] Facturas = planos.GetFacturas();

            //Meses del primer semestre
            string[] SegundoSemestre = { "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            double TotalNoPagado = 0;

            //Hacemos un ciclo para que cada item del arreglo de factura sea pasado a mi nueva variable
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("RESPUESTA #5: ");
            foreach (string item in Facturas)
            {
                //Divido la factura en subcadenas usando el dilimitador ;
                string[] partes = item.Split(';');

                if (partes.Length == 6)
                {
                    Get_y_Set variable = new Get_y_Set();
                    variable.NumeroFactura = partes[0];
                    variable.MontoTotal = partes[1];
                    variable.Impuestos = partes[2];
                    variable.TotalConImpuestos = partes[3];
                    variable.Mes = partes[4];
                    variable.Pagadas = partes[5];


                    if (variable.Pagadas == "SI" &&
                        SegundoSemestre.Contains(variable.Mes))
                    {
                        Console.WriteLine($"Facturas '{variable.NumeroFactura}' del mes '{variable.Mes}'");
                    }

                }
                else
                {
                    Console.WriteLine("La estrutura de el plano esta incompleta o supera los limites");
                }
            }
        }
    }
}
