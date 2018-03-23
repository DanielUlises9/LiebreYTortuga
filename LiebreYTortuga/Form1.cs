using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiebreYTortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.ScrollBars = ScrollBars.Vertical;
            Corredor liebre = new Liebre();
            Corredor tortuga = new Tortuga();

            while (tortuga.Avance <80 && liebre.Avance <80)
            {
                tortuga.Avanzando(); liebre.Avanzando();
                txtResultado.Text += "Tortuga {"+tortuga.Avance+"} \r\n" + "Liebre {" + liebre.Avance+ "} \r\n";
            }

            if (tortuga.Avance >= 80 && liebre.Avance >= 80)
                txtResultado.Text += "Empate\r\n";
            else if (tortuga.Avance > liebre.Avance)
                txtResultado.Text += "Gano la tortuga\r\n";
            else
                txtResultado.Text += "Gano la liebre\r\n";
        }
    }
}
