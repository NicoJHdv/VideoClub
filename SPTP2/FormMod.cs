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
    public partial class FormMod : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        public FormMod()
        {
            InitializeComponent();
        }

        private void FormMod_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sPTP2BDDataSetNomGen.generos' Puede moverla o quitarla según sea necesario.
            this.generosTableAdapter.Fill(this.sPTP2BDDataSetNomGen.generos);   
            conexion = new SqlConnection("Data Source=hpenvy\\sqlexpress;Initial Catalog=SPTP2BD;Integrated Security=True");//AQUÍ VA EL STRING DE CONEXIÓN DE SU PC
            adaptador = new SqlDataAdapter();
            SqlCommand modificacion = new SqlCommand("update peliculas set nom_peli = @tituloMod, web_peli = @webMod, descrip = @descripMod, id_genero = @genMod, anio = @añoMod where id_peli = @idtitulo", conexion);
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@idtitulo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@tituloMod", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@webMod", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripMod", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@genMod", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@añoMod", SqlDbType.Int));
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

        private void BtnMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("El campo 'ID del título' no puede quedar vacío.");
            }
            else
            {
                adaptador.UpdateCommand.Parameters["@idtitulo"].Value = int.Parse(txtID.Text);
                adaptador.UpdateCommand.Parameters["@tituloMod"].Value = txtNuevoTitulo.Text;
                adaptador.UpdateCommand.Parameters["@webMod"].Value = txtNuevaWeb.Text;
                adaptador.UpdateCommand.Parameters["@descripMod"].Value = txtNuevaDesc.Text;
                adaptador.UpdateCommand.Parameters["@genMod"].Value = combNuevoGenero.SelectedValue;
                adaptador.UpdateCommand.Parameters["@añoMod"].Value = txtNuevoAño.Text;
                try
                {
                    if (txtNuevaDesc.TextLength > 50)
                    {
                        MessageBox.Show("La descripción no debe superar los 50 caracteres");
                    }
                    else
                    {
                        conexion.Open();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                        ActualizarDatos();
                        MessageBox.Show("La modificación fue exitosa!");
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
