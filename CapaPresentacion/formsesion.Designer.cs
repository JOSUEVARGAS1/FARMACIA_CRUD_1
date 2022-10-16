
namespace CapaPresentacion
{
    partial class frsesion
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbtitulo2 = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.lbcontraseña = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btacceder = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbtitulo.Location = new System.Drawing.Point(238, 50);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(427, 47);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "FARMACIA SAN JUAN";
            this.lbtitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbtitulo2
            // 
            this.lbtitulo2.AutoSize = true;
            this.lbtitulo2.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbtitulo2.Location = new System.Drawing.Point(240, 123);
            this.lbtitulo2.Name = "lbtitulo2";
            this.lbtitulo2.Size = new System.Drawing.Size(425, 47);
            this.lbtitulo2.TabIndex = 1;
            this.lbtitulo2.Text = "DR. MARCELO TORCA";
            this.lbtitulo2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbusuario.Location = new System.Drawing.Point(87, 272);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(161, 35);
            this.lbusuario.TabIndex = 2;
            this.lbusuario.Text = "USUARIO :";
            // 
            // lbcontraseña
            // 
            this.lbcontraseña.AutoSize = true;
            this.lbcontraseña.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbcontraseña.Location = new System.Drawing.Point(26, 341);
            this.lbcontraseña.Name = "lbcontraseña";
            this.lbcontraseña.Size = new System.Drawing.Size(222, 35);
            this.lbcontraseña.TabIndex = 3;
            this.lbcontraseña.Text = "CONTRASEÑA :";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(291, 273);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(344, 34);
            this.txtusuario.TabIndex = 4;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(291, 341);
            this.txtcontraseña.Multiline = true;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(344, 35);
            this.txtcontraseña.TabIndex = 5;
            // 
            // btacceder
            // 
            this.btacceder.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btacceder.Location = new System.Drawing.Point(291, 407);
            this.btacceder.Name = "btacceder";
            this.btacceder.Size = new System.Drawing.Size(343, 40);
            this.btacceder.TabIndex = 6;
            this.btacceder.Text = "ACCEDER";
            this.btacceder.UseVisualStyleBackColor = true;
            this.btacceder.Click += new System.EventHandler(this.btacceder_Click);
            // 
            // btsalir
            // 
            this.btsalir.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btsalir.Location = new System.Drawing.Point(712, 482);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(96, 31);
            this.btsalir.TabIndex = 7;
            this.btsalir.Text = "salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // frsesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 570);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btacceder);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lbcontraseña);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.lbtitulo2);
            this.Controls.Add(this.lbtitulo);
            this.Name = "frsesion";
            this.Text = "FARMACIA SAN JUAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbtitulo2;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Label lbcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btacceder;
        private System.Windows.Forms.Button btsalir;
    }
}

