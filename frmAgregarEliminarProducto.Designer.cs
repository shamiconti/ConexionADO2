namespace pryContiConexionBD
{
    partial class frmAgregarEliminarProducto
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
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblSignoPeso = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpAgregarProducto = new System.Windows.Forms.GroupBox();
            this.grpEliminarProducto = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.mskStock = new System.Windows.Forms.MaskedTextBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.cmbEliminarProducto = new System.Windows.Forms.ComboBox();
            this.grpAgregarProducto.SuspendLayout();
            this.grpEliminarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 168);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 18);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 82);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 18);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 212);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 18);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 125);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 18);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 25);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(149, 25);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblSignoPeso
            // 
            this.lblSignoPeso.AutoSize = true;
            this.lblSignoPeso.Location = new System.Drawing.Point(80, 125);
            this.lblSignoPeso.Name = "lblSignoPeso";
            this.lblSignoPeso.Size = new System.Drawing.Size(17, 18);
            this.lblSignoPeso.TabIndex = 5;
            this.lblSignoPeso.Text = "$";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(104, 208);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 26);
            this.cmbCategoria.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(104, 256);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 28);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpAgregarProducto
            // 
            this.grpAgregarProducto.Controls.Add(this.btnAgregar);
            this.grpAgregarProducto.Controls.Add(this.cmbCategoria);
            this.grpAgregarProducto.Controls.Add(this.lblSignoPeso);
            this.grpAgregarProducto.Controls.Add(this.mskStock);
            this.grpAgregarProducto.Controls.Add(this.mskPrecio);
            this.grpAgregarProducto.Controls.Add(this.txtDescripcion);
            this.grpAgregarProducto.Controls.Add(this.txtNombre);
            this.grpAgregarProducto.Controls.Add(this.lblPrecio);
            this.grpAgregarProducto.Controls.Add(this.lblNombre);
            this.grpAgregarProducto.Controls.Add(this.lblCategoria);
            this.grpAgregarProducto.Controls.Add(this.lblDescripcion);
            this.grpAgregarProducto.Controls.Add(this.lblStock);
            this.grpAgregarProducto.Location = new System.Drawing.Point(12, 12);
            this.grpAgregarProducto.Name = "grpAgregarProducto";
            this.grpAgregarProducto.Size = new System.Drawing.Size(302, 295);
            this.grpAgregarProducto.TabIndex = 4;
            this.grpAgregarProducto.TabStop = false;
            this.grpAgregarProducto.Text = "Agregar Producto";
            // 
            // grpEliminarProducto
            // 
            this.grpEliminarProducto.Controls.Add(this.cmbEliminarProducto);
            this.grpEliminarProducto.Controls.Add(this.btnEliminar);
            this.grpEliminarProducto.Controls.Add(this.lblNombreEliminar);
            this.grpEliminarProducto.Location = new System.Drawing.Point(327, 12);
            this.grpEliminarProducto.Name = "grpEliminarProducto";
            this.grpEliminarProducto.Size = new System.Drawing.Size(302, 105);
            this.grpEliminarProducto.TabIndex = 11;
            this.grpEliminarProducto.TabStop = false;
            this.grpEliminarProducto.Text = "Eliminar Producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(104, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 28);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Location = new System.Drawing.Point(6, 39);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(68, 18);
            this.lblNombreEliminar.TabIndex = 0;
            this.lblNombreEliminar.Text = "Nombre:";
            // 
            // mskStock
            // 
            this.mskStock.Location = new System.Drawing.Point(104, 165);
            this.mskStock.Mask = "99999";
            this.mskStock.Name = "mskStock";
            this.mskStock.Size = new System.Drawing.Size(100, 25);
            this.mskStock.TabIndex = 8;
            this.mskStock.ValidatingType = typeof(int);
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(104, 122);
            this.mskPrecio.Mask = "99999";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(100, 25);
            this.mskPrecio.TabIndex = 7;
            this.mskPrecio.ValidatingType = typeof(int);
            // 
            // cmbEliminarProducto
            // 
            this.cmbEliminarProducto.FormattingEnabled = true;
            this.cmbEliminarProducto.Location = new System.Drawing.Point(104, 36);
            this.cmbEliminarProducto.Name = "cmbEliminarProducto";
            this.cmbEliminarProducto.Size = new System.Drawing.Size(149, 26);
            this.cmbEliminarProducto.TabIndex = 12;
            // 
            // frmAgregarEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(641, 313);
            this.Controls.Add(this.grpEliminarProducto);
            this.Controls.Add(this.grpAgregarProducto);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgregarEliminarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar y Eliminar Producto";
            this.Load += new System.EventHandler(this.frmAgregarEliminarProducto_Load);
            this.grpAgregarProducto.ResumeLayout(false);
            this.grpAgregarProducto.PerformLayout();
            this.grpEliminarProducto.ResumeLayout(false);
            this.grpEliminarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblSignoPeso;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpAgregarProducto;
        private System.Windows.Forms.GroupBox grpEliminarProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.MaskedTextBox mskStock;
        private System.Windows.Forms.MaskedTextBox mskPrecio;
        private System.Windows.Forms.ComboBox cmbEliminarProducto;
    }
}