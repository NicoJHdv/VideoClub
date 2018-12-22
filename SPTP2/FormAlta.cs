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
    public partial class FormAlta : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sPTP2BDDataSetNomGen.generos' Puede moverla o quitarla según sea necesario.
            this.generosTableAdapter1.Fill(this.sPTP2BDDataSetNomGen.generos);
            // TODO: esta línea de código carga datos en la tabla 'sPTP2BDDataSetGenerosFull.generos' Puede moverla o quitarla según sea necesario.
            conexion = new SqlConnection("Data Source=hpenvy\\sqlexpress;Initial Catalog=SPTP2BD;Integrated Security=True");//AQUÍ VA EL STRING DE CONEXIÓN DE SU PC
            adaptador = new SqlDataAdapter();
            SqlCommand alta = new SqlCommand("insert into peliculas(nom_peli, web_peli, descrip, id_genero, anio) values(@titulo, @web, @descripcion, @genero, @año)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@titulo", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@web", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@genero", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@año", SqlDbType.Int));
            SqlCommand consulta = new SqlCommand("select * from peliculas", conexion);
            adaptador.SelectCommand = consulta;
            datos = new DataSet();
            conexion.Open();
            adaptador.Fill(datos, "peliculas");
            conexion.Close();
        }

        private void ActualizarDatos()
        {
            datos.Clear();
            adaptador.Fill(datos, "peliculas");
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar un título!");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@titulo"].Value = txtTitulo.Text;
                adaptador.InsertCommand.Parameters["@web"].Value = txtWeb.Text;
                adaptador.InsertCommand.Parameters["@descripcion"].Value = txtDesc.Text;
                adaptador.InsertCommand.Parameters["@genero"].Value = combGenero.SelectedValue;
                adaptador.InsertCommand.Parameters["@año"].Value = txtAño.Text;
                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    ActualizarDatos();
                    MessageBox.Show("Los datos han sido cargados exitosamente!");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }
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
