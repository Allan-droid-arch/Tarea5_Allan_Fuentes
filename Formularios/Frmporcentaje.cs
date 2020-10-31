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
    public partial class Frmporcentaje : Form
    {
        Clases.operacion z = new Clases.operacion();
        public Frmporcentaje()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            double f = double.Parse(pre.Text.Trim());
            double g = double.Parse(prev.Text.Trim());
            double j = g-f;
            ganan.Text = j.ToString();
            
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
           
            
                foreach (TextBox b in this.Controls.OfType<TextBox>())
                {
                    b.Clear();
                }
            
        }
    }
}
