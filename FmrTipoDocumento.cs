using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinForm2
{
    public partial class FmrTipoDocumento : Form
    {
        public FmrTipoDocumento()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            var adaptador = new dsAppDocumentosTableAdapters.TipoDocumentoTableAdapter();
            var tabla = adaptador.GetData();
            dgvDatos.DataSource = tabla;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var frm = new FmrTipoDocumento_Edit();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = getId();
            if (id > 0)
            {
                var frm = new FmrTipoDocumento_Edit(id);
                frm.ShowDialog();
                CargarDatos();
            } else
            {
                MessageBox.Show("seleccione un Id valido", "sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private int getId()
        {
            try
            {
                DataGridViewRow filaActual = dgvDatos.CurrentRow;
                if (filaActual == null)
                {
                    return 0;
                }
                return int.Parse(dgvDatos.Rows[filaActual.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return 0;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = getId();
            if (id > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿realmente desea eliminar el registro?", "sistemas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    var adaptador = new dsAppDocumentos.TipoDocumentoDataTable();
                    adaptador.Remove(id);
                    MessageBox.Show("registro eliminado", "sistemas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }else
                {
                    MessageBox.Show("debe seleccionar un id valido", "sistemas",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                }
            }
        }
    }
}
