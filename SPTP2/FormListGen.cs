using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPTP2
{
    public partial class FormListGen : Form
    {
        public FormListGen()
        {
            InitializeComponent();
        }

        private void FormListGen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sPTP2BDDataSetGenerosFull.generos' Puede moverla o quitarla según sea necesario.
            this.generosTableAdapter1.Fill(this.sPTP2BDDataSetGenerosFull.generos);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void AltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlta form = new FormAlta();
            form.Show();
        }

        private void ModificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMod form = new FormMod();
            form.Show();
        }

        private void BajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBaja form = new FormBaja();
            form.Show();
        }

        private void ListPelisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListPelis form = new FormListPelis();
            form.Show();
        }

        private void ListaDeGénerosDisponíblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListGen form = new FormListGen();
            form.Show();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercaDe a = new acercaDe();
            a.Show();
        }
    }
}
