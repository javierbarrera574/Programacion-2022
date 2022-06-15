namespace Clases
{
    partial class Productos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btcargar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProductos = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabMovimiento = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblStockMovimiento = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtCantidadMovimiento = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcionMovimiento = new System.Windows.Forms.Label();
            this.lblCodigoMovimiento = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.tbProductos.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(579, 94);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(75, 23);
            this.btcargar.TabIndex = 0;
            this.btcargar.Text = "Cargar";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(75, 44);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 15);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(75, 94);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(69, 15);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(75, 162);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(36, 15);
            this.lblstock.TabIndex = 3;
            this.lblstock.Text = "Stock";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(373, 44);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 23);
            this.txtcodigo.TabIndex = 4;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(373, 95);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 23);
            this.txtdescripcion.TabIndex = 5;
            // 
            // txtstock
            // 
            this.txtstock.Enabled = false;
            this.txtstock.Location = new System.Drawing.Point(373, 154);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 23);
            this.txtstock.TabIndex = 6;
            this.txtstock.TextChanged += new System.EventHandler(this.txtstock_TextChanged);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion});
            this.dgProductos.Location = new System.Drawing.Point(193, 212);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowTemplate.Height = 25;
            this.dgProductos.Size = new System.Drawing.Size(243, 150);
            this.dgProductos.TabIndex = 7;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // tbProductos
            // 
            this.tbProductos.Controls.Add(this.tabProductos);
            this.tbProductos.Controls.Add(this.tabMovimiento);
            this.tbProductos.Location = new System.Drawing.Point(35, 26);
            this.tbProductos.Name = "tbProductos";
            this.tbProductos.SelectedIndex = 0;
            this.tbProductos.Size = new System.Drawing.Size(742, 412);
            this.tbProductos.TabIndex = 8;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.btSalir);
            this.tabProductos.Controls.Add(this.txtcodigo);
            this.tabProductos.Controls.Add(this.dgProductos);
            this.tabProductos.Controls.Add(this.lblcodigo);
            this.tabProductos.Controls.Add(this.btcargar);
            this.tabProductos.Controls.Add(this.lblstock);
            this.tabProductos.Controls.Add(this.txtstock);
            this.tabProductos.Controls.Add(this.txtdescripcion);
            this.tabProductos.Controls.Add(this.lbldescripcion);
            this.tabProductos.Location = new System.Drawing.Point(4, 24);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(734, 384);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Carga de productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            this.tabProductos.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabMovimiento
            // 
            this.tabMovimiento.Controls.Add(this.dataGridView1);
            this.tabMovimiento.Controls.Add(this.lblStockMovimiento);
            this.tabMovimiento.Controls.Add(this.btAceptar);
            this.tabMovimiento.Controls.Add(this.txtCantidadMovimiento);
            this.tabMovimiento.Controls.Add(this.lblCantidad);
            this.tabMovimiento.Controls.Add(this.lblDescripcionMovimiento);
            this.tabMovimiento.Controls.Add(this.lblCodigoMovimiento);
            this.tabMovimiento.Location = new System.Drawing.Point(4, 24);
            this.tabMovimiento.Name = "tabMovimiento";
            this.tabMovimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovimiento.Size = new System.Drawing.Size(734, 384);
            this.tabMovimiento.TabIndex = 1;
            this.tabMovimiento.Text = "Movimiento de productos";
            this.tabMovimiento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblStockMovimiento
            // 
            this.lblStockMovimiento.AutoSize = true;
            this.lblStockMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStockMovimiento.Location = new System.Drawing.Point(53, 131);
            this.lblStockMovimiento.Name = "lblStockMovimiento";
            this.lblStockMovimiento.Size = new System.Drawing.Size(57, 21);
            this.lblStockMovimiento.TabIndex = 5;
            this.lblStockMovimiento.Text = "label2";
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAceptar.Location = new System.Drawing.Point(476, 161);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(86, 37);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtCantidadMovimiento
            // 
            this.txtCantidadMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadMovimiento.Location = new System.Drawing.Point(205, 169);
            this.txtCantidadMovimiento.Name = "txtCantidadMovimiento";
            this.txtCantidadMovimiento.Size = new System.Drawing.Size(100, 29);
            this.txtCantidadMovimiento.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(53, 169);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 21);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripcionMovimiento
            // 
            this.lblDescripcionMovimiento.AutoSize = true;
            this.lblDescripcionMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcionMovimiento.Location = new System.Drawing.Point(53, 78);
            this.lblDescripcionMovimiento.Name = "lblDescripcionMovimiento";
            this.lblDescripcionMovimiento.Size = new System.Drawing.Size(57, 21);
            this.lblDescripcionMovimiento.TabIndex = 1;
            this.lblDescripcionMovimiento.Text = "label2";
            // 
            // lblCodigoMovimiento
            // 
            this.lblCodigoMovimiento.AutoSize = true;
            this.lblCodigoMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoMovimiento.Location = new System.Drawing.Point(53, 30);
            this.lblCodigoMovimiento.Name = "lblCodigoMovimiento";
            this.lblCodigoMovimiento.Size = new System.Drawing.Size(57, 21);
            this.lblCodigoMovimiento.TabIndex = 0;
            this.lblCodigoMovimiento.Text = "label1";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(579, 267);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbProductos);
            this.Name = "Productos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.tbProductos.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            this.tabMovimiento.ResumeLayout(false);
            this.tabMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btcargar;
        private Label lblcodigo;
        private Label lbldescripcion;
        private Label lblstock;
        private TextBox txtcodigo;
        private TextBox txtdescripcion;
        private TextBox txtstock;
        private DataGridView dgProductos;
        private TabControl tbProductos;
        private TabPage tabProductos;
        private TabPage tabMovimiento;
        private Button btAceptar;
        private TextBox txtCantidadMovimiento;
        private Label lblCantidad;
        private Label lblDescripcionMovimiento;
        private Label lblCodigoMovimiento;
        private Label lblStockMovimiento;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private Button btSalir;
    }
}