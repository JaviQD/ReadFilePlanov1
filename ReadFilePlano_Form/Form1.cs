using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadFilePlano_Form.src.Data;
using ReadFilePlano_Form.src.Model;

namespace ReadFilePlano_Form
{
    public partial class Lector_ArchivosPlanos : Form
    {
        DataTable tabla;
        DataUser dato = new DataUser();

        public Lector_ArchivosPlanos()
        {
            InitializeComponent();
            Iniciar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void brnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("FACTURA PLANA");

            Grilla.DataSource = tabla;
        }

        private void Guardar()
        {
            DataModel modelo = new DataModel()
            {
                Prefijo = txtPrefijo.Text,
                Total = double.Parse(txtTotal.Text),
                Impuesto = double.Parse(txtImpuesto.Text),
                TotalConImpuesto = double.Parse(txtTotalImpuesto.Text),
                Mes = txtMes.Text,
                Pagado = txtPagado.Text
            };

            string DataPlana = $"{modelo.Prefijo};{modelo.Total};{modelo.Impuesto};{modelo.TotalConImpuesto};{modelo.Mes};{modelo.Pagado}";
            dato.Guardar(DataPlana);
        }

        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                string fila = $"{item.Prefijo};{item.Total};{item.Impuesto};{item.TotalConImpuesto};{item.Mes};{item.Pagado}";

                tabla.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            txtPrefijo.Text = "";
            txtTotal.Text = "";
            txtImpuesto.Text = "";
            txtTotalImpuesto.Text = "";
            txtMes.Text = "";
            txtPagado.Text = "";
        }
    }
}
