
namespace EstructuraDeDatos_VarelaAndres
{
    partial class frm02EstrucLineal_Cola
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm02EstrucLineal_Cola));
            this.grbElimElemento = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtElimTramite = new System.Windows.Forms.TextBox();
            this.txtElimNombre = new System.Windows.Forms.TextBox();
            this.txtElimCodigo = new System.Windows.Forms.TextBox();
            this.LblElimTramite = new System.Windows.Forms.Label();
            this.LblElimNombre = new System.Windows.Forms.Label();
            this.LblElimCodigo = new System.Windows.Forms.Label();
            this.grbListados = new System.Windows.Forms.GroupBox();
            this.dgvListCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNuevoTramite = new System.Windows.Forms.TextBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevoCodigo = new System.Windows.Forms.TextBox();
            this.LblNuevTramite = new System.Windows.Forms.Label();
            this.LblNuevNombre = new System.Windows.Forms.Label();
            this.LblNuevCodigo = new System.Windows.Forms.Label();
            this.imgCola = new System.Windows.Forms.PictureBox();
            this.grbElimElemento.SuspendLayout();
            this.grbListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCola)).BeginInit();
            this.grbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).BeginInit();
            this.SuspendLayout();
            // 
            // grbElimElemento
            // 
            this.grbElimElemento.Controls.Add(this.btnEliminar);
            this.grbElimElemento.Controls.Add(this.txtElimTramite);
            this.grbElimElemento.Controls.Add(this.txtElimNombre);
            this.grbElimElemento.Controls.Add(this.txtElimCodigo);
            this.grbElimElemento.Controls.Add(this.LblElimTramite);
            this.grbElimElemento.Controls.Add(this.LblElimNombre);
            this.grbElimElemento.Controls.Add(this.LblElimCodigo);
            this.grbElimElemento.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElimElemento.Location = new System.Drawing.Point(547, 12);
            this.grbElimElemento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbElimElemento.Name = "grbElimElemento";
            this.grbElimElemento.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbElimElemento.Size = new System.Drawing.Size(312, 216);
            this.grbElimElemento.TabIndex = 8;
            this.grbElimElemento.TabStop = false;
            this.grbElimElemento.Text = "Eliminar Elemento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(35, 159);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(254, 51);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtElimTramite
            // 
            this.txtElimTramite.Enabled = false;
            this.txtElimTramite.Location = new System.Drawing.Point(94, 122);
            this.txtElimTramite.Name = "txtElimTramite";
            this.txtElimTramite.Size = new System.Drawing.Size(211, 25);
            this.txtElimTramite.TabIndex = 5;
            // 
            // txtElimNombre
            // 
            this.txtElimNombre.Enabled = false;
            this.txtElimNombre.Location = new System.Drawing.Point(94, 77);
            this.txtElimNombre.Name = "txtElimNombre";
            this.txtElimNombre.Size = new System.Drawing.Size(211, 25);
            this.txtElimNombre.TabIndex = 4;
            // 
            // txtElimCodigo
            // 
            this.txtElimCodigo.Enabled = false;
            this.txtElimCodigo.Location = new System.Drawing.Point(137, 35);
            this.txtElimCodigo.Name = "txtElimCodigo";
            this.txtElimCodigo.Size = new System.Drawing.Size(168, 25);
            this.txtElimCodigo.TabIndex = 3;
            // 
            // LblElimTramite
            // 
            this.LblElimTramite.AutoSize = true;
            this.LblElimTramite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElimTramite.Location = new System.Drawing.Point(7, 125);
            this.LblElimTramite.Name = "LblElimTramite";
            this.LblElimTramite.Size = new System.Drawing.Size(81, 19);
            this.LblElimTramite.TabIndex = 2;
            this.LblElimTramite.Text = "Trámite:";
            // 
            // LblElimNombre
            // 
            this.LblElimNombre.AutoSize = true;
            this.LblElimNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElimNombre.Location = new System.Drawing.Point(7, 80);
            this.LblElimNombre.Name = "LblElimNombre";
            this.LblElimNombre.Size = new System.Drawing.Size(72, 19);
            this.LblElimNombre.TabIndex = 1;
            this.LblElimNombre.Text = "Nombre:";
            // 
            // LblElimCodigo
            // 
            this.LblElimCodigo.AutoSize = true;
            this.LblElimCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElimCodigo.Location = new System.Drawing.Point(7, 38);
            this.LblElimCodigo.Name = "LblElimCodigo";
            this.LblElimCodigo.Size = new System.Drawing.Size(72, 19);
            this.LblElimCodigo.TabIndex = 0;
            this.LblElimCodigo.Text = "Código:";
            // 
            // grbListados
            // 
            this.grbListados.Controls.Add(this.dgvListCola);
            this.grbListados.Controls.Add(this.lstCola);
            this.grbListados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListados.Location = new System.Drawing.Point(11, 234);
            this.grbListados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbListados.Name = "grbListados";
            this.grbListados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbListados.Size = new System.Drawing.Size(848, 389);
            this.grbListados.TabIndex = 7;
            this.grbListados.TabStop = false;
            this.grbListados.Text = "Listado en una Lista y en una Grilla";
            // 
            // dgvListCola
            // 
            this.dgvListCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListCola.Location = new System.Drawing.Point(263, 24);
            this.dgvListCola.Name = "dgvListCola";
            this.dgvListCola.Size = new System.Drawing.Size(576, 349);
            this.dgvListCola.TabIndex = 1;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // lstCola
            // 
            this.lstCola.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 15;
            this.lstCola.Location = new System.Drawing.Point(7, 24);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(250, 349);
            this.lstCola.TabIndex = 0;
            // 
            // grbNuevoElemento
            // 
            this.grbNuevoElemento.Controls.Add(this.btnAgregar);
            this.grbNuevoElemento.Controls.Add(this.txtNuevoTramite);
            this.grbNuevoElemento.Controls.Add(this.txtNuevoNombre);
            this.grbNuevoElemento.Controls.Add(this.txtNuevoCodigo);
            this.grbNuevoElemento.Controls.Add(this.LblNuevTramite);
            this.grbNuevoElemento.Controls.Add(this.LblNuevNombre);
            this.grbNuevoElemento.Controls.Add(this.LblNuevCodigo);
            this.grbNuevoElemento.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNuevoElemento.Location = new System.Drawing.Point(213, 12);
            this.grbNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbNuevoElemento.Size = new System.Drawing.Size(312, 216);
            this.grbNuevoElemento.TabIndex = 6;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(35, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(254, 51);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNuevoTramite
            // 
            this.txtNuevoTramite.Location = new System.Drawing.Point(94, 123);
            this.txtNuevoTramite.Name = "txtNuevoTramite";
            this.txtNuevoTramite.Size = new System.Drawing.Size(211, 25);
            this.txtNuevoTramite.TabIndex = 5;
            this.txtNuevoTramite.TextChanged += new System.EventHandler(this.txtNuevoTramite_TextChanged);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(94, 78);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(211, 25);
            this.txtNuevoNombre.TabIndex = 4;
            this.txtNuevoNombre.TextChanged += new System.EventHandler(this.txtNuevoNombre_TextChanged);
            // 
            // txtNuevoCodigo
            // 
            this.txtNuevoCodigo.Location = new System.Drawing.Point(94, 36);
            this.txtNuevoCodigo.Name = "txtNuevoCodigo";
            this.txtNuevoCodigo.Size = new System.Drawing.Size(124, 25);
            this.txtNuevoCodigo.TabIndex = 3;
            this.txtNuevoCodigo.TextChanged += new System.EventHandler(this.txtNuevoCodigo_TextChanged);
            // 
            // LblNuevTramite
            // 
            this.LblNuevTramite.AutoSize = true;
            this.LblNuevTramite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevTramite.Location = new System.Drawing.Point(7, 126);
            this.LblNuevTramite.Name = "LblNuevTramite";
            this.LblNuevTramite.Size = new System.Drawing.Size(81, 19);
            this.LblNuevTramite.TabIndex = 2;
            this.LblNuevTramite.Text = "Trámite:";
            // 
            // LblNuevNombre
            // 
            this.LblNuevNombre.AutoSize = true;
            this.LblNuevNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevNombre.Location = new System.Drawing.Point(7, 81);
            this.LblNuevNombre.Name = "LblNuevNombre";
            this.LblNuevNombre.Size = new System.Drawing.Size(72, 19);
            this.LblNuevNombre.TabIndex = 1;
            this.LblNuevNombre.Text = "Nombre:";
            // 
            // LblNuevCodigo
            // 
            this.LblNuevCodigo.AutoSize = true;
            this.LblNuevCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevCodigo.Location = new System.Drawing.Point(7, 39);
            this.LblNuevCodigo.Name = "LblNuevCodigo";
            this.LblNuevCodigo.Size = new System.Drawing.Size(72, 19);
            this.LblNuevCodigo.TabIndex = 0;
            this.LblNuevCodigo.Text = "Código:";
            // 
            // imgCola
            // 
            this.imgCola.Image = ((System.Drawing.Image)(resources.GetObject("imgCola.Image")));
            this.imgCola.Location = new System.Drawing.Point(13, 12);
            this.imgCola.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgCola.Name = "imgCola";
            this.imgCola.Size = new System.Drawing.Size(192, 216);
            this.imgCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCola.TabIndex = 5;
            this.imgCola.TabStop = false;
            // 
            // frm02EstrucLineal_Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 635);
            this.Controls.Add(this.grbElimElemento);
            this.Controls.Add(this.grbListados);
            this.Controls.Add(this.grbNuevoElemento);
            this.Controls.Add(this.imgCola);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm02EstrucLineal_Cola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lineal - Cola";
            this.Load += new System.EventHandler(this.frm02EstrucLineal_Cola_Load);
            this.grbElimElemento.ResumeLayout(false);
            this.grbElimElemento.PerformLayout();
            this.grbListados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCola)).EndInit();
            this.grbNuevoElemento.ResumeLayout(false);
            this.grbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbElimElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtElimTramite;
        private System.Windows.Forms.TextBox txtElimNombre;
        private System.Windows.Forms.TextBox txtElimCodigo;
        private System.Windows.Forms.Label LblElimTramite;
        private System.Windows.Forms.Label LblElimNombre;
        private System.Windows.Forms.Label LblElimCodigo;
        private System.Windows.Forms.GroupBox grbListados;
        private System.Windows.Forms.DataGridView dgvListCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNuevoTramite;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoCodigo;
        private System.Windows.Forms.Label LblNuevTramite;
        private System.Windows.Forms.Label LblNuevNombre;
        private System.Windows.Forms.Label LblNuevCodigo;
        private System.Windows.Forms.PictureBox imgCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}