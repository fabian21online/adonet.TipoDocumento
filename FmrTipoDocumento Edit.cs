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
    public partial class FmrTipoDocumento_Edit : Form
    {
        private int? id;
        public FmrTipoDocumento_Edit(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsafe_Click(object sender, EventArgs e)
        {
            int estado = chkEstado.Checked ? 1 : 0;
            string nombre = txtnombre.Text;
            var adaptador = new dsAppDocumentosTableAdapters.TipoDocumentoTableAdapter();
            if (this.id == null)
            {
                adaptador.Add(txtnombre.Text, (byte)estado);
            }else
            {
                adaptador.edit(nombre, (byte) estado, (int) this.id);
            }
            this.Close();
        }

        private void FmrTipoDocumento_Edit_Load(object sender, EventArgs e)
        {
            if(this.id != null)
            {
                this.Text = "editar";
                var adaptador = new dsAppDocumentosTableAdapters.TipoDocumentoTableAdapter();
                var tabla = adaptador.GetDataById ((int) this.id);
                var fila = (dsAppDocumentos.TipoDocumentoRow) tabla.Rows[0];
                txtnombre.Text = fila.Nombre;
                chkEstado.Checked = fila.Estado == 1 ? true: false ;
            } else
            {
                this.Text = "nuevo"; 
            }
        }
    }
}
