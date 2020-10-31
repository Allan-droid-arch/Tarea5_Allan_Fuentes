using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_Allan_Fuentes.Formularios
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.Frmporcentaje pr = new Formularios.Frmporcentaje();
            pr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmCantidaddelitros li = new Formularios.FrmCantidaddelitros();
            li.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmNota n = new Formularios.FrmNota();
            n.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.Frmnotadevarios no = new Formularios.Frmnotadevarios();
            no.ShowDialog();
        }
    }
}
