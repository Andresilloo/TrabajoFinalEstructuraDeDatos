
namespace EstructuraDeDatos_VarelaAndres
{
    partial class EstructuraLineal_ListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstructuraLineal_ListaSimple));
            this.grbElimElemento = new System.Windows.Forms.GroupBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.LblElimCodigo = new System.Windows.Forms.Label();
            this.grbListados = new System.Windows.Forms.GroupBox();
            this.dgvListaSimp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaSimp = new System.Windows.Forms.ListBox();
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNuevoTramite = new System.Windows.Forms.TextBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevoCodigo = new System.Windows.Forms.TextBox();
            this.LblNuevTramite = new System.Windows.Forms.Label();
            this.LblNuevNombre = new System.Windows.Forms.Label();
            this.LblNuevCodigo = new System.Windows.Forms.Label();
            this.ImgSimple = new System.Windows.Forms.PictureBox();
            this.grbElimElemento.SuspendLayout();
            this.grbListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimp)).BeginInit();
            this.grbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSimple)).BeginInit();
            this.SuspendLayout();
            // 
            // grbElimElemento
            // 
            this.grbElimElemento.Controls.Add(this.cmbEliminar);
            this.grbElimElemento.Controls.Add(this.btnEliminar);
            this.grbElimElemento.Controls.Add(this.LblElimCodigo);
            this.grbElimElemento.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElimElemento.Location = new System.Drawing.Point(547, 12);
            this.grbElimElemento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbElimElemento.Name = "grbElimElemento";
            this.grbElimElemento.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbElimElemento.Size = new System.Drawing.Size(312, 216);
            this.grbElimElemento.TabIndex = 16;
            this.grbElimElemento.TabStop = false;
            this.grbElimElemento.Text = "Eliminar Elemento";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(88, 74);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(121, 26);
            this.cmbEliminar.TabIndex = 7;
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
            // LblElimCodigo
            // 
            this.LblElimCodigo.AutoSize = true;
            this.LblElimCodigo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElimCodigo.Location = new System.Drawing.Point(7, 38);
            this.LblElimCodigo.Name = "LblElimCodigo";
            this.LblElimCodigo.Size = new System.Drawing.Size(272, 18);
            this.LblElimCodigo.TabIndex = 0;
            this.LblElimCodigo.Text = "Selecciona elemento a a eliminar:";
            // 
            // grbListados
            // 
            this.grbListados.Controls.Add(this.dgvListaSimp);
            this.grbListados.Controls.Add(this.lstListaSimp);
            this.grbListados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListados.Location = new System.Drawing.Point(11, 234);
            this.grbListados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbListados.Name = "grbListados";
            this.grbListados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbListados.Size = new System.Drawing.Size(848, 389);
            this.grbListados.TabIndex = 15;
            this.grbListados.TabStop = false;
            this.grbListados.Text = "Listado en una Lista y en una Grilla";
            // 
            // dgvListaSimp
            // 
            this.dgvListaSimp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaSimp.Location = new System.Drawing.Point(263, 24);
            this.dgvListaSimp.Name = "dgvListaSimp";
            this.dgvListaSimp.Size = new System.Drawing.Size(576, 349);
            this.dgvListaSimp.TabIndex = 1;
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
            // lstListaSimp
            // 
            this.lstListaSimp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaSimp.FormattingEnabled = true;
            this.lstListaSimp.ItemHeight = 15;
            this.lstListaSimp.Location = new System.Drawing.Point(7, 24);
            this.lstListaSimp.Name = "lstListaSimp";
            this.lstListaSimp.Size = new System.Drawing.Size(250, 349);
            this.lstListaSimp.TabIndex = 0;
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
            this.grbNuevoElemento.TabIndex = 14;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Enabled = false;
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
            // ImgSimple
            // 
            this.ImgSimple.Image = ((System.Drawing.Image)(resources.GetObject("ImgSimple.Image")));
            this.ImgSimple.Location = new System.Drawing.Point(21, 6);
            this.ImgSimple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ImgSimple.Name = "ImgSimple";
            this.ImgSimple.Size = new System.Drawing.Size(192, 216);
            this.ImgSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgSimple.TabIndex = 10;
            this.ImgSimple.TabStop = false;
            // 
            // EstructuraLineal_ListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 636);
            this.Controls.Add(this.ImgSimple);
            this.Controls.Add(this.grbElimElemento);
            this.Controls.Add(this.grbListados);
            this.Controls.Add(this.grbNuevoElemento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstructuraLineal_ListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lineal - Lista Simple";
            this.grbElimElemento.ResumeLayout(false);
            this.grbElimElemento.PerformLayout();
            this.grbListados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimp)).EndInit();
            this.grbNuevoElemento.ResumeLayout(false);
            this.grbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSimple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbElimElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label LblElimCodigo;
        private System.Windows.Forms.GroupBox grbListados;
        private System.Windows.Forms.DataGridView dgvListaSimp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaSimp;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNuevoTramite;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoCodigo;
        private System.Windows.Forms.Label LblNuevTramite;
        private System.Windows.Forms.Label LblNuevNombre;
        private System.Windows.Forms.Label LblNuevCodigo;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.PictureBox ImgSimple;
    }
}