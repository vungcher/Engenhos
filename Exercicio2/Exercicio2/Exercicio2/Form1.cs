using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bateria bateria = new Bateria();
            bateria.carga = pBarCarga.Value;

            cBoxOff.Checked = true;
            txtBoxPorcentagem.Text = pBarCarga.Value.ToString() + "%";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cBoxOn.Checked = true;
            cBoxOff.Checked = false;
            if (pBarCarga.Value == 0)
            {
                cBoxOn.Checked = false;
                cBoxOff.Checked = true;
                MessageBox.Show("Favor recarregar a bateria.");
                return;
            }
            else
            { 
                pBarCarga.Value = pBarCarga.Value - 1;
                while(pBarCarga.Minimum <= pBarCarga.Value)
                {
                    txtBoxPorcentagem.Text = pBarCarga.Value.ToString() + "%";
                    Thread.Sleep(1000);
                    if(pBarCarga.Value == 0)
                    {
                        cBoxOn.Checked = false;
                        cBoxOff.Checked = true;
                        break;
                    };
                    pBarCarga.Value--;
                };
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            Bateria bateria = new Bateria();
            pBarCarga.Value = bateria.carga;

            cBoxOff.Checked = true;
            cBoxOn.Checked = false;
            txtBoxPorcentagem.Text = pBarCarga.Value.ToString() + "%";

        }

        public class Bateria
        {
            public int carga = 100;

        }

        public class Lanterna
        {
            public string status;
        }

    }
}
