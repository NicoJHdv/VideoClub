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
    public partial class FormBaja : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        public FormBaja()
        {
            InitializeComponent();
        }

        private void FormBaja_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=hpenvy\\sqlexpress;Initial Catalog=SPTP2BD;Integrated Security=True");//AQUÍ VA EL STRING DE CONEXIÓN DE SU PC
            adaptador = new SqlDataAdapter();
            SqlCommand baja = new SqlCommand("delete from peliculas where nom_peli = @tituloBaja", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@tituloBaja", SqlDbType.VarChar));
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

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["@tituloBaja"].Value = txtBajaTitulo.Text;
            try
            {
                conexion.Open();
                int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                if (cantidad == 0)
                {
                    MessageBox.Show("No existe el titulo ingresado, o no lo escribió correctamente.\n\n" + "Pruebe ingresarlo nuevamente, o ingrése otro título por favor.");
                }
                else
                {
                    ActualizarDatos();
                    MessageBox.Show("Se ha realizado la baja con éxito!");
                }
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
