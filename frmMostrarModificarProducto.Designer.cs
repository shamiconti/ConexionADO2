namespace pryContiConexionBD
{
    partial class frmMostrarModificarProducto
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.grpModificarPrecio = new System.Windows.Forms.GroupBox();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.cmbModificarPrecio = new System.Windows.Forms.ComboBox();
            this.btnModifcar = new System.Windows.Forms.Button();
            this.lblCodigoPrecio = new System.Windows.Forms.Label();
            this.grpModificarDescripcion = new System.Windows.Forms.GroupBox();
            this.txtNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.cmbModificarDescripcion = new System.Windows.Forms.ComboBox();
            this.btnModificarDescripcion = new System.Windows.Forms.Button();
            this.lblCodigoDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.grpModificarPrecio.SuspendLayout();
            this.grpModificarDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.ForeColor = System.Drawing.Color.SlateGray;
            this.btnMostrar.Location = new System.Drawing.Point(246, 352);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(148, 28);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(170, 186);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(301, 158);
            this.dgvMostrar.TabIndex = 1;
            // 
            // grpModificarPrecio
            // 
            this.grpModificarPrecio.Controls.Add(this.txtNuevoPrecio);
            this.grpModificarPrecio.Controls.Add(this.lblNuevoPrecio);
            this.grpModificarPrecio.Controls.Add(this.cmbModificarPrecio);
            this.grpModificarPrecio.Controls.Add(this.btnModifcar);
            this.grpModificarPrecio.Controls.Add(this.lblCodigoPrecio);
            this.grpModificarPrecio.Location = new System.Drawing.Point(12, 12);
            this.grpModificarPrecio.Name = "grpModificarPrecio";
            this.grpModificarPrecio.Size = new System.Drawing.Size(303, 166);
            this.grpModificarPrecio.TabIndex = 2;
            this.grpModificarPrecio.TabStop = false;
            this.grpModificarPrecio.Text = "Modificar Precio";
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(118, 35);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(149, 25);
            this.txtNuevoPrecio.TabIndex = 17;
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.AutoSize = true;
            this.lblNuevoPrecio.Location = new System.Drawing.Point(5, 38);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(102, 18);
            this.lblNuevoPrecio.TabIndex = 16;
            this.lblNuevoPrecio.Text = "Nuevo Precio:";
            // 
            // cmbModificarPrecio
            // 
            this.cmbModificarPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarPrecio.FormattingEnabled = true;
            this.cmbModificarPrecio.Location = new System.Drawing.Point(118, 73);
            this.cmbModificarPrecio.Name = "cmbModificarPrecio";
            this.cmbModificarPrecio.Size = new System.Drawing.Size(149, 26);
            this.cmbModificarPrecio.TabIndex = 15;
            this.cmbModificarPrecio.SelectedIndexChanged += new System.EventHandler(this.cmbModificarPrecio_SelectedIndexChanged);
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.SlateGray;
            this.btnModifcar.Location = new System.Drawing.Point(119, 128);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(148, 28);
            this.btnModifcar.TabIndex = 14;
            this.btnModifcar.Text = "MODIFICAR";
            this.btnModifcar.UseVisualStyleBackColor = false;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // lblCodigoPrecio
            // 
            this.lblCodigoPrecio.AutoSize = true;
            this.lblCodigoPrecio.Location = new System.Drawing.Point(5, 76);
            this.lblCodigoPrecio.Name = "lblCodigoPrecio";
            this.lblCodigoPrecio.Size = new System.Drawing.Size(59, 18);
            this.lblCodigoPrecio.TabIndex = 13;
            this.lblCodigoPrecio.Text = "Codigo:";
            // 
            // grpModificarDescripcion
            // 
            this.grpModificarDescripcion.Controls.Add(this.txtNuevaDescripcion);
            this.grpModificarDescripcion.Controls.Add(this.lblNuevaDescripcion);
            this.grpModificarDescripcion.Controls.Add(this.cmbModificarDescripcion);
            this.grpModificarDescripcion.Controls.Add(this.btnModificarDescripcion);
            this.grpModificarDescripcion.Controls.Add(this.lblCodigoDescripcion);
            this.grpModificarDescripcion.Location = new System.Drawing.Point(321, 12);
            this.grpModificarDescripcion.Name = "grpModificarDescripcion";
            this.grpModificarDescripcion.Size = new System.Drawing.Size(308, 166);
            this.grpModificarDescripcion.TabIndex = 18;
            this.grpModificarDescripcion.TabStop = false;
            this.grpModificarDescripcion.Text = "Modificar Descrpción";
            // 
            // txtNuevaDescripcion
            // 
            this.txtNuevaDescripcion.Location = new System.Drawing.Point(153, 35);
            this.txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            this.txtNuevaDescripcion.Size = new System.Drawing.Size(149, 25);
            this.txtNuevaDescripcion.TabIndex = 17;
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(9, 38);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(138, 18);
            this.lblNuevaDescripcion.TabIndex = 16;
            this.lblNuevaDescripcion.Text = "Nueva Descripción:";
            // 
            // cmbModificarDescripcion
            // 
            this.cmbModificarDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarDescripcion.FormattingEnabled = true;
            this.cmbModificarDescripcion.Location = new System.Drawing.Point(153, 73);
            this.cmbModificarDescripcion.Name = "cmbModificarDescripcion";
            this.cmbModificarDescripcion.Size = new System.Drawing.Size(149, 26);
            this.cmbModificarDescripcion.TabIndex = 15;
            // 
            // btnModificarDescripcion
            // 
            this.btnModificarDescripcion.BackColor = System.Drawing.Color.SlateGray;
            this.btnModificarDescripcion.Location = new System.Drawing.Point(119, 128);
            this.btnModificarDescripcion.Name = "btnModificarDescripcion";
            this.btnModificarDescripcion.Size = new System.Drawing.Size(148, 28);
            this.btnModificarDescripcion.TabIndex = 14;
            this.btnModificarDescripcion.Text = "MODIFICAR";
            this.btnModificarDescripcion.UseVisualStyleBackColor = false;
            this.btnModificarDescripcion.Click += new System.EventHandler(this.btnModificarDescripcion_Click);
            // 
            // lblCodigoDescripcion
            // 
            this.lblCodigoDescripcion.AutoSize = true;
            this.lblCodigoDescripcion.Location = new System.Drawing.Point(9, 76);
            this.lblCodigoDescripcion.Name = "lblCodigoDescripcion";
            this.lblCodigoDescripcion.Size = new System.Drawing.Size(59, 18);
            this.lblCodigoDescripcion.TabIndex = 13;
            this.lblCodigoDescripcion.Text = "Código:";
            this.lblCodigoDescripcion.Click += new System.EventHandler(this.lblCodigoDescripcion_Click);
            // 
            // frmMostrarModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(641, 381);
            this.Controls.Add(this.grpModificarDescripcion);
            this.Controls.Add(this.grpModificarPrecio);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.btnMostrar);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMostrarModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar y Mostrar Productos";
            this.Load += new System.EventHandler(this.frmMostrarModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.grpModificarPrecio.ResumeLayout(false);
            this.grpModificarPrecio.PerformLayout();
            this.grpModificarDescripcion.ResumeLayout(false);
            this.grpModificarDescripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox grpModificarPrecio;
        private System.Windows.Forms.ComboBox cmbModificarPrecio;
        private System.Windows.Forms.Button btnModifcar;
        private System.Windows.Forms.Label lblCodigoPrecio;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.GroupBox grpModificarDescripcion;
        private System.Windows.Forms.TextBox txtNuevaDescripcion;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.ComboBox cmbModificarDescripcion;
        private System.Windows.Forms.Button btnModificarDescripcion;
        private System.Windows.Forms.Label lblCodigoDescripcion;
    }
}