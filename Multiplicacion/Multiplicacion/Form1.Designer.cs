namespace Multiplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.txtOperador1 = new System.Windows.Forms.TextBox();
            this.txtOperador2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperador2 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicar.Location = new System.Drawing.Point(216, 256);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(124, 36);
            this.btMultiplicar.TabIndex = 0;
            this.btMultiplicar.Text = "Multiplicar";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // txtOperador1
            // 
            this.txtOperador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador1.Location = new System.Drawing.Point(378, 135);
            this.txtOperador1.Name = "txtOperador1";
            this.txtOperador1.Size = new System.Drawing.Size(142, 29);
            this.txtOperador1.TabIndex = 1;
            // 
            // txtOperador2
            // 
            this.txtOperador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador2.Location = new System.Drawing.Point(378, 198);
            this.txtOperador2.Name = "txtOperador2";
            this.txtOperador2.Size = new System.Drawing.Size(142, 29);
            this.txtOperador2.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(538, 256);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 29);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // lblOperador2
            // 
            this.lblOperador2.AutoSize = true;
            this.lblOperador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador2.Location = new System.Drawing.Point(212, 135);
            this.lblOperador2.Name = "lblOperador2";
            this.lblOperador2.Size = new System.Drawing.Size(112, 24);
            this.lblOperador2.TabIndex = 4;
            this.lblOperador2.Text = "operador 1";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(212, 205);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(112, 24);
            this.lblOperador.TabIndex = 5;
            this.lblOperador.Text = "operador 2";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(258, 381);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(124, 36);
            this.btLimpiar.TabIndex = 6;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(460, 381);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(124, 36);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblOperador2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtOperador2);
            this.Controls.Add(this.txtOperador1);
            this.Controls.Add(this.btMultiplicar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.TextBox txtOperador1;
        private System.Windows.Forms.TextBox txtOperador2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperador2;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
    }
}

