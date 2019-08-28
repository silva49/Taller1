namespace taller1
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
            this.lblbienvenido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.btnpresioname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbienvenido
            // 
            this.lblbienvenido.AutoSize = true;
            this.lblbienvenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbienvenido.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenido.Location = new System.Drawing.Point(285, 22);
            this.lblbienvenido.Name = "lblbienvenido";
            this.lblbienvenido.Size = new System.Drawing.Size(156, 33);
            this.lblbienvenido.TabIndex = 0;
            this.lblbienvenido.Text = "¡Bienvenido!";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblnombre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(21, 143);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(219, 31);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Ingrese su nombre.";
            // 
            // txtnombres
            // 
            this.txtnombres.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(259, 143);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(266, 31);
            this.txtnombres.TabIndex = 2;
            this.txtnombres.TextChanged += new System.EventHandler(this.txtnombres_TextChanged);
            // 
            // btnpresioname
            // 
            this.btnpresioname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpresioname.Location = new System.Drawing.Point(545, 144);
            this.btnpresioname.Name = "btnpresioname";
            this.btnpresioname.Size = new System.Drawing.Size(153, 30);
            this.btnpresioname.TabIndex = 3;
            this.btnpresioname.Text = "¡Presioname!";
            this.btnpresioname.UseVisualStyleBackColor = true;
            this.btnpresioname.Click += new System.EventHandler(this.btnpresioname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpresioname);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblbienvenido);
            this.Name = "Form1";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Button btnpresioname;
    }
}

