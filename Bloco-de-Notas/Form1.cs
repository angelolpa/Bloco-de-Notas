using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SalvaClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvaOk(object sender, CancelEventArgs e)
        {
            string Caminho = saveFileDialog1.FileName;
            File.WriteAllText(Caminho, TxbJanela.Text);
        }
    }
}
