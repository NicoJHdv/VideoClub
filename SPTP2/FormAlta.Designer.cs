namespace SPTP2
{
    partial class FormAlta
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
            this.combGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPTP2BDDataSetNomGen = new SPTP2.SPTP2BDDataSetNomGen();
            this.sPTP2BDDataSetGenerosFull = new SPTP2.SPTP2BDDataSetGenerosFull();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generosTableAdapter1 = new SPTP2.SPTP2BDDataSetNomGenTableAdapters.generosTableAdapter();
            this.menuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetNomGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetGenerosFull)).BeginInit();
            this.SuspendLayout();
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
            // combGenero
            // 
            this.combGenero.DataSource = this.generosBindingSource1;
            this.combGenero.DisplayMember = "nom_gen";
            this.combGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGenero.FormattingEnabled = true;
            this.combGenero.Location = new System.Drawing.Point(175, 163);
            this.combGenero.Name = "combGenero";
            this.combGenero.Size = new System.Drawing.Size(237, 26);
            this.combGenero.TabIndex = 51;
            this.combGenero.ValueMember = "id_gen";
            // 
            // generosBindingSource1
            // 
            this.generosBindingSource1.DataMember = "generos";
            this.generosBindingSource1.DataSource = this.sPTP2BDDataSetNomGen;
            // 
            // sPTP2BDDataSetNomGen
            // 
            this.sPTP2BDDataSetNomGen.DataSetName = "SPTP2BDDataSetNomGen";
            this.sPTP2BDDataSetNomGen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPTP2BDDataSetGenerosFull
            // 
            this.sPTP2BDDataSetGenerosFull.DataSetName = "SPTP2BDDataSetGenerosFull";
            this.sPTP2BDDataSetGenerosFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(175, 86);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(237, 24);
            this.txtTitulo.TabIndex = 41;
            // 
            // txtWeb
            // 
            this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeb.Location = new System.Drawing.Point(175, 125);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(237, 24);
            this.txtWeb.TabIndex = 42;
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(175, 341);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(237, 28);
            this.btnAlta.TabIndex = 45;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.Location = new System.Drawing.Point(97, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 18);
            this.label12.TabIndex = 50;
            this.label12.Text = "Web:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(175, 203);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(237, 24);
            this.txtDesc.TabIndex = 43;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(175, 242);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(237, 24);
            this.txtAño.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(92, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(49, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(78, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(102, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Año:";
            // 
            // generosTableAdapter1
            // 
            this.generosTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 410);
            this.Controls.Add(this.combGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuItem);
            this.Name = "FormAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestión para VideoClub- Alta de datos";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            this.menuItem.ResumeLayout(false);
            this.menuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetNomGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetGenerosFull)).EndInit();
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
        private System.Windows.Forms.ComboBox combGenero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private SPTP2BDDataSetGenerosFull sPTP2BDDataSetGenerosFull;
        private SPTP2BDDataSetNomGen sPTP2BDDataSetNomGen;
        private System.Windows.Forms.BindingSource generosBindingSource1;
        private SPTP2BDDataSetNomGenTableAdapters.generosTableAdapter generosTableAdapter1;
    }
}