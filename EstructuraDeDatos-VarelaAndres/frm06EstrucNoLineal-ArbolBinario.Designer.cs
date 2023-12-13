
namespace EstructuraDeDatos_VarelaAndres
{
    partial class frm05EstrucNoLineal_ArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm05EstrucNoLineal_ArbolBinario));
            this.grbEquilibrar = new System.Windows.Forms.GroupBox();
            this.btnEquilbrar = new System.Windows.Forms.Button();
            this.grbLista = new System.Windows.Forms.GroupBox();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lstArbolPreOrden = new System.Windows.Forms.ListBox();
            this.lstArbolPostOrden = new System.Windows.Forms.ListBox();
            this.lstInOrden = new System.Windows.Forms.ListBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkOrdenDescencente = new System.Windows.Forms.CheckBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBuscarElementos = new System.Windows.Forms.GroupBox();
            this.lblCodigoABuscar = new System.Windows.Forms.Label();
            this.txtCodigoABuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramiteNodo = new System.Windows.Forms.Label();
            this.lblNombreNodo = new System.Windows.Forms.Label();
            this.lblCodigoNodo = new System.Windows.Forms.Label();
            this.picCola = new System.Windows.Forms.PictureBox();
            this.grbEquilibrar.SuspendLayout();
            this.grbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.grbBuscarElementos.SuspendLayout();
            this.grbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEquilibrar
            // 
            this.grbEquilibrar.Controls.Add(this.btnEquilbrar);
            this.grbEquilibrar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEquilibrar.Location = new System.Drawing.Point(12, 462);
            this.grbEquilibrar.Name = "grbEquilibrar";
            this.grbEquilibrar.Size = new System.Drawing.Size(189, 64);
            this.grbEquilibrar.TabIndex = 29;
            this.grbEquilibrar.TabStop = false;
            this.grbEquilibrar.Text = "Equilibrar Arbol";
            // 
            // btnEquilbrar
            // 
            this.btnEquilbrar.Enabled = false;
            this.btnEquilbrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilbrar.Location = new System.Drawing.Point(23, 21);
            this.btnEquilbrar.Name = "btnEquilbrar";
            this.btnEquilbrar.Size = new System.Drawing.Size(149, 30);
            this.btnEquilbrar.TabIndex = 9;
            this.btnEquilbrar.Text = "EQUILIBRAR";
            this.btnEquilbrar.UseVisualStyleBackColor = true;
            this.btnEquilbrar.Click += new System.EventHandler(this.btnEquilbrar_Click);
            // 
            // grbLista
            // 
            this.grbLista.Controls.Add(this.lblPreOrden);
            this.grbLista.Controls.Add(this.lblPostOrden);
            this.grbLista.Controls.Add(this.lblInOrden);
            this.grbLista.Controls.Add(this.lstArbolPreOrden);
            this.grbLista.Controls.Add(this.lstArbolPostOrden);
            this.grbLista.Controls.Add(this.lstInOrden);
            this.grbLista.Controls.Add(this.lblLeyenda);
            this.grbLista.Controls.Add(this.btnEliminar);
            this.grbLista.Controls.Add(this.chkOrdenDescencente);
            this.grbLista.Controls.Add(this.optPostOrden);
            this.grbLista.Controls.Add(this.optPreOrden);
            this.grbLista.Controls.Add(this.optInOrden);
            this.grbLista.Controls.Add(this.dgvArbolBinario);
            this.grbLista.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLista.Location = new System.Drawing.Point(207, 12);
            this.grbLista.Name = "grbLista";
            this.grbLista.Size = new System.Drawing.Size(518, 514);
            this.grbLista.TabIndex = 30;
            this.grbLista.TabStop = false;
            this.grbLista.Text = "Listado en una Lista y en una Grilla";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(173, 23);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(70, 14);
            this.lblPreOrden.TabIndex = 24;
            this.lblPreOrden.Text = "Pre Orden";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(343, 23);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(77, 14);
            this.lblPostOrden.TabIndex = 23;
            this.lblPostOrden.Text = "Post Orden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(3, 23);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(63, 14);
            this.lblInOrden.TabIndex = 22;
            this.lblInOrden.Text = "In Orden";
            // 
            // lstArbolPreOrden
            // 
            this.lstArbolPreOrden.FormattingEnabled = true;
            this.lstArbolPreOrden.ItemHeight = 14;
            this.lstArbolPreOrden.Location = new System.Drawing.Point(176, 39);
            this.lstArbolPreOrden.Name = "lstArbolPreOrden";
            this.lstArbolPreOrden.Size = new System.Drawing.Size(165, 130);
            this.lstArbolPreOrden.TabIndex = 21;
            // 
            // lstArbolPostOrden
            // 
            this.lstArbolPostOrden.FormattingEnabled = true;
            this.lstArbolPostOrden.ItemHeight = 14;
            this.lstArbolPostOrden.Location = new System.Drawing.Point(346, 39);
            this.lstArbolPostOrden.Name = "lstArbolPostOrden";
            this.lstArbolPostOrden.Size = new System.Drawing.Size(165, 130);
            this.lstArbolPostOrden.TabIndex = 20;
            // 
            // lstInOrden
            // 
            this.lstInOrden.FormattingEnabled = true;
            this.lstInOrden.ItemHeight = 14;
            this.lstInOrden.Location = new System.Drawing.Point(6, 39);
            this.lstInOrden.Name = "lstInOrden";
            this.lstInOrden.Size = new System.Drawing.Size(165, 130);
            this.lstInOrden.TabIndex = 19;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Location = new System.Drawing.Point(266, 473);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(371, 14);
            this.lblLeyenda.TabIndex = 0;
            this.lblLeyenda.Text = "Seleccione un elemento en la grilla para eliminarlo*";
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(430, 489);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 21);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkOrdenDescencente
            // 
            this.chkOrdenDescencente.AutoSize = true;
            this.chkOrdenDescencente.Enabled = false;
            this.chkOrdenDescencente.Location = new System.Drawing.Point(107, 495);
            this.chkOrdenDescencente.Name = "chkOrdenDescencente";
            this.chkOrdenDescencente.Size = new System.Drawing.Size(145, 18);
            this.chkOrdenDescencente.TabIndex = 16;
            this.chkOrdenDescencente.Text = "Orden Descendente";
            this.chkOrdenDescencente.UseVisualStyleBackColor = true;
            this.chkOrdenDescencente.CheckedChanged += new System.EventHandler(this.chkOrdenDescencente_CheckedChanged);
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Enabled = false;
            this.optPostOrden.Location = new System.Drawing.Point(6, 495);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(95, 18);
            this.optPostOrden.TabIndex = 15;
            this.optPostOrden.Text = "Post Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Enabled = false;
            this.optPreOrden.Location = new System.Drawing.Point(107, 471);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(88, 18);
            this.optPreOrden.TabIndex = 14;
            this.optPreOrden.Text = "Pre Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Checked = true;
            this.optInOrden.Enabled = false;
            this.optInOrden.Location = new System.Drawing.Point(6, 471);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(81, 18);
            this.optInOrden.TabIndex = 13;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged);
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.AllowUserToAddRows = false;
            this.dgvArbolBinario.AllowUserToDeleteRows = false;
            this.dgvArbolBinario.AllowUserToResizeColumns = false;
            this.dgvArbolBinario.AllowUserToResizeRows = false;
            this.dgvArbolBinario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvArbolBinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArbolBinario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArbolBinario.EnableHeadersVisualStyles = false;
            this.dgvArbolBinario.Location = new System.Drawing.Point(6, 179);
            this.dgvArbolBinario.MultiSelect = false;
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.ReadOnly = true;
            this.dgvArbolBinario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvArbolBinario.RowHeadersVisible = false;
            this.dgvArbolBinario.RowHeadersWidth = 51;
            this.dgvArbolBinario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArbolBinario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArbolBinario.ShowCellErrors = false;
            this.dgvArbolBinario.ShowCellToolTips = false;
            this.dgvArbolBinario.ShowEditingIcon = false;
            this.dgvArbolBinario.ShowRowErrors = false;
            this.dgvArbolBinario.Size = new System.Drawing.Size(506, 286);
            this.dgvArbolBinario.TabIndex = 1;
            this.dgvArbolBinario.Click += new System.EventHandler(this.dgvArbolBinario_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 74;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Trámite";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // grbBuscarElementos
            // 
            this.grbBuscarElementos.Controls.Add(this.lblCodigoABuscar);
            this.grbBuscarElementos.Controls.Add(this.txtCodigoABuscar);
            this.grbBuscarElementos.Controls.Add(this.btnBuscar);
            this.grbBuscarElementos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarElementos.Location = new System.Drawing.Point(12, 364);
            this.grbBuscarElementos.Name = "grbBuscarElementos";
            this.grbBuscarElementos.Size = new System.Drawing.Size(189, 92);
            this.grbBuscarElementos.TabIndex = 28;
            this.grbBuscarElementos.TabStop = false;
            this.grbBuscarElementos.Text = "Buscar Elementos";
            // 
            // lblCodigoABuscar
            // 
            this.lblCodigoABuscar.AutoSize = true;
            this.lblCodigoABuscar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoABuscar.Location = new System.Drawing.Point(6, 28);
            this.lblCodigoABuscar.Name = "lblCodigoABuscar";
            this.lblCodigoABuscar.Size = new System.Drawing.Size(103, 13);
            this.lblCodigoABuscar.TabIndex = 5;
            this.lblCodigoABuscar.Text = "Código a buscar:";
            // 
            // txtCodigoABuscar
            // 
            this.txtCodigoABuscar.Location = new System.Drawing.Point(115, 24);
            this.txtCodigoABuscar.Name = "txtCodigoABuscar";
            this.txtCodigoABuscar.Size = new System.Drawing.Size(61, 22);
            this.txtCodigoABuscar.TabIndex = 5;
            this.txtCodigoABuscar.TextChanged += new System.EventHandler(this.txtCodigoABuscar_TextChanged);
            this.txtCodigoABuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoABuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(23, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grbNuevoElemento
            // 
            this.grbNuevoElemento.Controls.Add(this.btnAgregar);
            this.grbNuevoElemento.Controls.Add(this.txtTramite);
            this.grbNuevoElemento.Controls.Add(this.txtNombre);
            this.grbNuevoElemento.Controls.Add(this.txtCodigo);
            this.grbNuevoElemento.Controls.Add(this.lblTramiteNodo);
            this.grbNuevoElemento.Controls.Add(this.lblNombreNodo);
            this.grbNuevoElemento.Controls.Add(this.lblCodigoNodo);
            this.grbNuevoElemento.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNuevoElemento.Location = new System.Drawing.Point(12, 196);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Size = new System.Drawing.Size(189, 162);
            this.grbNuevoElemento.TabIndex = 27;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 30);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(75, 95);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(83, 22);
            this.txtTramite.TabIndex = 3;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(83, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(75, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(78, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblTramiteNodo
            // 
            this.lblTramiteNodo.AutoSize = true;
            this.lblTramiteNodo.Location = new System.Drawing.Point(6, 98);
            this.lblTramiteNodo.Name = "lblTramiteNodo";
            this.lblTramiteNodo.Size = new System.Drawing.Size(63, 14);
            this.lblTramiteNodo.TabIndex = 2;
            this.lblTramiteNodo.Text = "Trámite:";
            // 
            // lblNombreNodo
            // 
            this.lblNombreNodo.AutoSize = true;
            this.lblNombreNodo.Location = new System.Drawing.Point(6, 63);
            this.lblNombreNodo.Name = "lblNombreNodo";
            this.lblNombreNodo.Size = new System.Drawing.Size(56, 14);
            this.lblNombreNodo.TabIndex = 1;
            this.lblNombreNodo.Text = "Nombre:";
            // 
            // lblCodigoNodo
            // 
            this.lblCodigoNodo.AutoSize = true;
            this.lblCodigoNodo.Location = new System.Drawing.Point(6, 27);
            this.lblCodigoNodo.Name = "lblCodigoNodo";
            this.lblCodigoNodo.Size = new System.Drawing.Size(56, 14);
            this.lblCodigoNodo.TabIndex = 0;
            this.lblCodigoNodo.Text = "Código:";
            // 
            // picCola
            // 
            this.picCola.Image = ((System.Drawing.Image)(resources.GetObject("picCola.Image")));
            this.picCola.Location = new System.Drawing.Point(12, 12);
            this.picCola.Name = "picCola";
            this.picCola.Size = new System.Drawing.Size(192, 178);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCola.TabIndex = 26;
            this.picCola.TabStop = false;
            // 
            // frm05EstrucNoLineal_ArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 534);
            this.Controls.Add(this.grbEquilibrar);
            this.Controls.Add(this.grbLista);
            this.Controls.Add(this.grbBuscarElementos);
            this.Controls.Add(this.grbNuevoElemento);
            this.Controls.Add(this.picCola);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm05EstrucNoLineal_ArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura No Lineal - Arbol Binario";
            this.grbEquilibrar.ResumeLayout(false);
            this.grbLista.ResumeLayout(false);
            this.grbLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.grbBuscarElementos.ResumeLayout(false);
            this.grbBuscarElementos.PerformLayout();
            this.grbNuevoElemento.ResumeLayout(false);
            this.grbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEquilibrar;
        private System.Windows.Forms.Button btnEquilbrar;
        private System.Windows.Forms.GroupBox grbLista;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.ListBox lstArbolPreOrden;
        private System.Windows.Forms.ListBox lstArbolPostOrden;
        private System.Windows.Forms.ListBox lstInOrden;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkOrdenDescencente;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox grbBuscarElementos;
        private System.Windows.Forms.Label lblCodigoABuscar;
        private System.Windows.Forms.TextBox txtCodigoABuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramiteNodo;
        private System.Windows.Forms.Label lblNombreNodo;
        private System.Windows.Forms.Label lblCodigoNodo;
        private System.Windows.Forms.PictureBox picCola;
    }
}