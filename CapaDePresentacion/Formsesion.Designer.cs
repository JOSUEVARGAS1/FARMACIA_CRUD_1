
namespace CapaDePresentacion
{
    partial class frsesion
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.lbcontraseña = new System.Windows.Forms.Label();
            this.btacceder = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Stencil", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(136, 69);
            this.lbtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(460, 51);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "FARMACIA SAN JUAN";
            this.lbtitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.Location = new System.Drawing.Point(139, 257);
            this.lbusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(151, 33);
            this.lbusuario.TabIndex = 2;
            this.lbusuario.Text = "USUARIO :";
            this.lbusuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbcontraseña
            // 
            this.lbcontraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcontraseña.AutoSize = true;
            this.lbcontraseña.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontraseña.Location = new System.Drawing.Point(139, 394);
            this.lbcontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcontraseña.Name = "lbcontraseña";
            this.lbcontraseña.Size = new System.Drawing.Size(206, 33);
            this.lbcontraseña.TabIndex = 3;
            this.lbcontraseña.Text = "CONTRASEÑA :";
            // 
            // btacceder
            // 
            this.btacceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btacceder.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btacceder.Location = new System.Drawing.Point(145, 546);
            this.btacceder.Margin = new System.Windows.Forms.Padding(4);
            this.btacceder.Name = "btacceder";
            this.btacceder.Size = new System.Drawing.Size(441, 57);
            this.btacceder.TabIndex = 4;
            this.btacceder.Text = "ACCEDER";
            this.btacceder.UseVisualStyleBackColor = true;
            this.btacceder.Click += new System.EventHandler(this.btacceder_Click);
            // 
            // btsalir
            // 
            this.btsalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsalir.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalir.Location = new System.Drawing.Point(211, 641);
            this.btsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(289, 59);
            this.btsalir.TabIndex = 5;
            this.btsalir.Text = "SALIR";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(145, 312);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(441, 48);
            this.txtusuario.TabIndex = 6;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(145, 457);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraseña.Multiline = true;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(441, 46);
            this.txtcontraseña.TabIndex = 7;
            // 
            // frsesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 760);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btacceder);
            this.Controls.Add(this.lbcontraseña);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.lbtitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frsesion";
            this.Text = "FARMACIA SAN JUAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Label lbcontraseña;
        private System.Windows.Forms.Button btacceder;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
    }
}

