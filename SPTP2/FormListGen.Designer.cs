namespace SPTP2
{
    partial class FormListGen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sPTP2BDDataSetGenerosFull = new SPTP2.SPTP2BDDataSetGenerosFull();
            this.generosTableAdapter1 = new SPTP2.SPTP2BDDataSetGenerosFullTableAdapters.generosTableAdapter();
            this.menuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource2)).BeginInit();
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
            this.menuItem.Size = new System.Drawing.Size(829, 29);
            this.menuItem.TabIndex = 42;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomgenDataGridViewTextBoxColumn,
            this.descgenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.generosBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(805, 399);
            this.dataGridView1.TabIndex = 43;
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
            // descgenDataGridViewTextBoxColumn
            // 
            this.descgenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descgenDataGridViewTextBoxColumn.DataPropertyName = "desc_gen";
            this.descgenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descgenDataGridViewTextBoxColumn.Name = "descgenDataGridViewTextBoxColumn";
            this.descgenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generosBindingSource2
            // 
            this.generosBindingSource2.DataMember = "generos";
            this.generosBindingSource2.DataSource = this.sPTP2BDDataSetGenerosFull;
            // 
            // sPTP2BDDataSetGenerosFull
            // 
            this.sPTP2BDDataSetGenerosFull.DataSetName = "SPTP2BDDataSetGenerosFull";
            this.sPTP2BDDataSetGenerosFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosTableAdapter1
            // 
            this.generosTableAdapter1.ClearBeforeFill = true;
            // 
            // FormListGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuItem);
            this.Name = "FormListGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestión para VideoClub- Géneros disponíbles";
            this.Load += new System.EventHandler(this.FormListGen_Load);
            this.menuItem.ResumeLayout(false);
            this.menuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private SPTP2BDDataSetGenerosFull sPTP2BDDataSetGenerosFull;
        private System.Windows.Forms.BindingSource generosBindingSource2;
        private SPTP2BDDataSetGenerosFullTableAdapters.generosTableAdapter generosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descgenDataGridViewTextBoxColumn;
    }
}