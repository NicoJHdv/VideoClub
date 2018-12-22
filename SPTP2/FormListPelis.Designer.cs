namespace SPTP2
{
    partial class FormListPelis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grillaPelis = new System.Windows.Forms.DataGridView();
            this.idpeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webpeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listapelisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPTP2BDDataSetListaPelis = new SPTP2.SPTP2BDDataSetListaPelis();
            this.listapelisTableAdapter = new SPTP2.SPTP2BDDataSetListaPelisTableAdapters.listapelisTableAdapter();
            this.menuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPelis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listapelisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetListaPelis)).BeginInit();
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
            this.menuItem.Size = new System.Drawing.Size(833, 29);
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
            // grillaPelis
            // 
            this.grillaPelis.AllowUserToAddRows = false;
            this.grillaPelis.AllowUserToDeleteRows = false;
            this.grillaPelis.AutoGenerateColumns = false;
            this.grillaPelis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaPelis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaPelis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPelis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeliDataGridViewTextBoxColumn,
            this.nompeliDataGridViewTextBoxColumn,
            this.nomgenDataGridViewTextBoxColumn,
            this.descripDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn,
            this.webpeliDataGridViewTextBoxColumn});
            this.grillaPelis.DataSource = this.listapelisBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaPelis.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaPelis.Location = new System.Drawing.Point(12, 43);
            this.grillaPelis.Name = "grillaPelis";
            this.grillaPelis.ReadOnly = true;
            this.grillaPelis.Size = new System.Drawing.Size(809, 372);
            this.grillaPelis.TabIndex = 41;
            // 
            // idpeliDataGridViewTextBoxColumn
            // 
            this.idpeliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idpeliDataGridViewTextBoxColumn.DataPropertyName = "id_peli";
            this.idpeliDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idpeliDataGridViewTextBoxColumn.Name = "idpeliDataGridViewTextBoxColumn";
            this.idpeliDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpeliDataGridViewTextBoxColumn.Width = 49;
            // 
            // nompeliDataGridViewTextBoxColumn
            // 
            this.nompeliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nompeliDataGridViewTextBoxColumn.DataPropertyName = "nom_peli";
            this.nompeliDataGridViewTextBoxColumn.HeaderText = "Título";
            this.nompeliDataGridViewTextBoxColumn.Name = "nompeliDataGridViewTextBoxColumn";
            this.nompeliDataGridViewTextBoxColumn.ReadOnly = true;
            this.nompeliDataGridViewTextBoxColumn.Width = 75;
            // 
            // nomgenDataGridViewTextBoxColumn
            // 
            this.nomgenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomgenDataGridViewTextBoxColumn.DataPropertyName = "nom_gen";
            this.nomgenDataGridViewTextBoxColumn.HeaderText = "Género";
            this.nomgenDataGridViewTextBoxColumn.Name = "nomgenDataGridViewTextBoxColumn";
            this.nomgenDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomgenDataGridViewTextBoxColumn.Width = 89;
            // 
            // descripDataGridViewTextBoxColumn
            // 
            this.descripDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripDataGridViewTextBoxColumn.DataPropertyName = "descrip";
            this.descripDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripDataGridViewTextBoxColumn.Name = "descripDataGridViewTextBoxColumn";
            this.descripDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripDataGridViewTextBoxColumn.Width = 123;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Año";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            this.anioDataGridViewTextBoxColumn.ReadOnly = true;
            this.anioDataGridViewTextBoxColumn.Width = 62;
            // 
            // webpeliDataGridViewTextBoxColumn
            // 
            this.webpeliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.webpeliDataGridViewTextBoxColumn.DataPropertyName = "web_peli";
            this.webpeliDataGridViewTextBoxColumn.HeaderText = "URL";
            this.webpeliDataGridViewTextBoxColumn.Name = "webpeliDataGridViewTextBoxColumn";
            this.webpeliDataGridViewTextBoxColumn.ReadOnly = true;
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
            // listapelisTableAdapter
            // 
            this.listapelisTableAdapter.ClearBeforeFill = true;
            // 
            // FormListPelis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 427);
            this.Controls.Add(this.grillaPelis);
            this.Controls.Add(this.menuItem);
            this.Name = "FormListPelis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestión para VideoClub- Películas disponíbles";
            this.Load += new System.EventHandler(this.FormListPelis_Load);
            this.menuItem.ResumeLayout(false);
            this.menuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPelis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listapelisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTP2BDDataSetListaPelis)).EndInit();
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
        private System.Windows.Forms.DataGridView grillaPelis;
        private SPTP2BDDataSetListaPelis sPTP2BDDataSetListaPelis;
        private System.Windows.Forms.BindingSource listapelisBindingSource;
        private SPTP2BDDataSetListaPelisTableAdapters.listapelisTableAdapter listapelisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webpeliDataGridViewTextBoxColumn;
    }
}