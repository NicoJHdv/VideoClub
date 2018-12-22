namespace SPTP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPTP2BDDataSetNomGen = new SPTP2.SPTP2BDDataSetNomGen();
            this.listapelisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPTP2BDDataSetListaPelis = new SPTP2.SPTP2BDDataSetListaPelis();
            this.generosTableAdapter = new SPTP2.SPTP2BDDataSetNomGenTableAdapters.generosTableAdapter();
            this.menuItem = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeGénerosDisponíblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listapelisTableAdapter = new SPTP2.SPTP2BDDataSetListaPelisTableAdapters.listapelisTableAdapter();
            this.generosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sPTP2BDDataSetGenerosFull = new SPTP2.SPTP2BDDataSetGenerosFull();
            this.generosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter1 = new SPTP2.SPTP2BDDataSetGenerosFullTableAdapters.generosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetNomGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listapelisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetListaPelis)).BeginInit();
            this.menuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetGenerosFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "generos";
            this.generosBindingSource.DataSource = this.sPTP2BDDataSetNomGen;
            // 
            // sPTP2BDDataSetNomGen
            // 
            this.sPTP2BDDataSetNomGen.DataSetName = "SPTP2BDDataSetNomGen";
            this.sPTP2BDDataSetNomGen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listapelisBindingSource
            // 
            this.listapelisBindingSource.DataMember = "listapelis";
            this.listapelisBindingSource.DataSource = this.sPTP2BDDataSetListaPelis;
            // 
            // sPTP2BDDataSetListaPelis
            // 
            this.sPTP2BDDataSetListaPelis.DataSetName = "SPTP2BDDataSetListaPelis";
            this.sPTP2BDDataSetListaPelis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // menuItem
            // 
            this.menuItem.BackColor = System.Drawing.Color.LightGray;
            this.menuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuItem.Location = new System.Drawing.Point(0, 0);
            this.menuItem.Name = "menuItem";
            this.menuItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuItem.Size = new System.Drawing.Size(370, 29);
            this.menuItem.TabIndex = 39;
            this.menuItem.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem,
            this.verToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.menuToolStripMenuItem.Text = "Menú";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificaciónToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.baseDeDatosToolStripMenuItem.Text = "Base de datos...";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.AltaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.BajaToolStripMenuItem_Click);
            // 
            // modificaciónToolStripMenuItem
            // 
            this.modificaciónToolStripMenuItem.Name = "modificaciónToolStripMenuItem";
            this.modificaciónToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.modificaciónToolStripMenuItem.Text = "Modificación";
            this.modificaciónToolStripMenuItem.Click += new System.EventHandler(this.ModificaciónToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDePelículasToolStripMenuItem,
            this.listaDeGénerosDisponíblesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.verToolStripMenuItem.Text = "Ver...";
            // 
            // listadoDePelículasToolStripMenuItem
            // 
            this.listadoDePelículasToolStripMenuItem.Name = "listadoDePelículasToolStripMenuItem";
            this.listadoDePelículasToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.listadoDePelículasToolStripMenuItem.Text = "Listado de películas";
            this.listadoDePelículasToolStripMenuItem.Click += new System.EventHandler(this.ListPelisToolStripMenuItem_Click);
            // 
            // listaDeGénerosDisponíblesToolStripMenuItem
            // 
            this.listaDeGénerosDisponíblesToolStripMenuItem.Name = "listaDeGénerosDisponíblesToolStripMenuItem";
            this.listaDeGénerosDisponíblesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.listaDeGénerosDisponíblesToolStripMenuItem.Text = "Lista de géneros disponíbles";
            this.listaDeGénerosDisponíblesToolStripMenuItem.Click += new System.EventHandler(this.ListaDeGénerosDisponíblesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // listapelisTableAdapter
            // 
            this.listapelisTableAdapter.ClearBeforeFill = true;
            // 
            // generosBindingSource3
            // 
            this.generosBindingSource3.DataMember = "generos";
            this.generosBindingSource3.DataSource = this.sPTP2BDDataSetGenerosFull;
            // 
            // sPTP2BDDataSetGenerosFull
            // 
            this.sPTP2BDDataSetGenerosFull.DataSetName = "SPTP2BDDataSetGenerosFull";
            this.sPTP2BDDataSetGenerosFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosBindingSource1
            // 
            this.generosBindingSource1.DataMember = "generos";
            this.generosBindingSource1.DataSource = this.sPTP2BDDataSetNomGen;
            // 
            // generosBindingSource2
            // 
            this.generosBindingSource2.DataMember = "generos";
            this.generosBindingSource2.DataSource = this.sPTP2BDDataSetGenerosFull;
            // 
            // generosTableAdapter1
            // 
            this.generosTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 362);
            this.Controls.Add(this.menuItem);
            this.Location = new System.Drawing.Point(3, 51);
            this.MainMenuStrip = this.menuItem;
            this.MinimumSize = new System.Drawing.Size(386, 401);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestión para VideoClub";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetNomGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listapelisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetListaPelis)).EndInit();
            this.menuItem.ResumeLayout(false);
            this.menuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetGenerosFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SPTP2BDDataSetNomGen sPTP2BDDataSetNomGen;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SPTP2BDDataSetNomGenTableAdapters.generosTableAdapter generosTableAdapter;
        private System.Windows.Forms.MenuStrip menuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePelículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeGénerosDisponíblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private SPTP2BDDataSetListaPelis sPTP2BDDataSetListaPelis;
        private System.Windows.Forms.BindingSource listapelisBindingSource;
        private SPTP2BDDataSetListaPelisTableAdapters.listapelisTableAdapter listapelisTableAdapter;
        private System.Windows.Forms.BindingSource generosBindingSource1;
        private SPTP2BDDataSetGenerosFull sPTP2BDDataSetGenerosFull;
        private System.Windows.Forms.BindingSource generosBindingSource2;
        private SPTP2BDDataSetGenerosFullTableAdapters.generosTableAdapter generosTableAdapter1;
        private System.Windows.Forms.BindingSource generosBindingSource3;
    }
}

