namespace SPTP2
{
    partial class FormMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sPTP2BDDataSetGenerosFull = new SPTP2.SPTP2BDDataSetGenerosFull();
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
            this.txtNuevaWeb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNuevoAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combNuevoGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNuevaDesc = new System.Windows.Forms.TextBox();
            this.txtNuevoTitulo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.sPTP2BDDataSetNomGen = new SPTP2.SPTP2BDDataSetNomGen();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter = new SPTP2.SPTP2BDDataSetNomGenTableAdapters.generosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetGenerosFull)).BeginInit();
            this.menuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetNomGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPTP2BDDataSetGenerosFull
            // 
            this.sPTP2BDDataSetGenerosFull.DataSetName = "SPTP2BDDataSetGenerosFull";
            this.sPTP2BDDataSetGenerosFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.menuItem.Size = new System.Drawing.Size(481, 29);
            this.menuItem.TabIndex = 40;
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
            // txtNuevaWeb
            // 
            this.txtNuevaWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaWeb.Location = new System.Drawing.Point(202, 155);
            this.txtNuevaWeb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaWeb.Name = "txtNuevaWeb";
            this.txtNuevaWeb.Size = new System.Drawing.Size(237, 24);
            this.txtNuevaWeb.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(79, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Nueva Web:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 274);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Nuevo año:";
            // 
            // txtNuevoAño
            // 
            this.txtNuevoAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoAño.Location = new System.Drawing.Point(202, 271);
            this.txtNuevoAño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoAño.Name = "txtNuevoAño";
            this.txtNuevoAño.Size = new System.Drawing.Size(237, 24);
            this.txtNuevoAño.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(64, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nuevo género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(34, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Nueva descripción:";
            // 
            // combNuevoGenero
            // 
            this.combNuevoGenero.DataSource = this.generosBindingSource;
            this.combNuevoGenero.DisplayMember = "nom_gen";
            this.combNuevoGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combNuevoGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combNuevoGenero.FormattingEnabled = true;
            this.combNuevoGenero.Location = new System.Drawing.Point(202, 194);
            this.combNuevoGenero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combNuevoGenero.Name = "combNuevoGenero";
            this.combNuevoGenero.Size = new System.Drawing.Size(237, 26);
            this.combNuevoGenero.TabIndex = 44;
            this.combNuevoGenero.ValueMember = "id_gen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(76, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Nuevo título:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(84, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "ID del título:";
            // 
            // txtNuevaDesc
            // 
            this.txtNuevaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaDesc.Location = new System.Drawing.Point(202, 234);
            this.txtNuevaDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaDesc.Name = "txtNuevaDesc";
            this.txtNuevaDesc.Size = new System.Drawing.Size(237, 24);
            this.txtNuevaDesc.TabIndex = 45;
            // 
            // txtNuevoTitulo
            // 
            this.txtNuevoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoTitulo.Location = new System.Drawing.Point(202, 117);
            this.txtNuevoTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoTitulo.Name = "txtNuevoTitulo";
            this.txtNuevoTitulo.Size = new System.Drawing.Size(237, 24);
            this.txtNuevoTitulo.TabIndex = 42;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(202, 78);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(237, 24);
            this.txtID.TabIndex = 41;
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(202, 336);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(236, 28);
            this.btnMod.TabIndex = 47;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // sPTP2BDDataSetNomGen
            // 
            this.sPTP2BDDataSetNomGen.DataSetName = "SPTP2BDDataSetNomGen";
            this.sPTP2BDDataSetNomGen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "generos";
            this.generosBindingSource.DataSource = this.sPTP2BDDataSetNomGen;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // FormMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 410);
            this.Controls.Add(this.txtNuevaWeb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNuevoAño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combNuevoGenero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNuevaDesc);
            this.Controls.Add(this.txtNuevoTitulo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.menuItem);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestión para VideoClub- Modificación de datos";
            this.Load += new System.EventHandler(this.FormMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetGenerosFull)).EndInit();
            this.menuItem.ResumeLayout(false);
            this.menuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetNomGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private SPTP2BDDataSetGenerosFull sPTP2BDDataSetGenerosFull;
        private System.Windows.Forms.TextBox txtNuevaWeb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNuevoAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combNuevoGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNuevaDesc;
        private System.Windows.Forms.TextBox txtNuevoTitulo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMod;
        private SPTP2BDDataSetNomGen sPTP2BDDataSetNomGen;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SPTP2BDDataSetNomGenTableAdapters.generosTableAdapter generosTableAdapter;
    }
}