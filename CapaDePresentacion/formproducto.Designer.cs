
namespace CapaDePresentacion
{
    partial class formlistaproducto
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
            this.lblistadeproducto = new System.Windows.Forms.Label();
            this.lbbuscarproducto = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btvolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblistadeproducto
            // 
            this.lblistadeproducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblistadeproducto.AutoSize = true;
            this.lblistadeproducto.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblistadeproducto.Location = new System.Drawing.Point(165, 27);
            this.lblistadeproducto.Name = "lblistadeproducto";
            this.lblistadeproducto.Size = new System.Drawing.Size(348, 39);
            this.lblistadeproducto.TabIndex = 0;
            this.lblistadeproducto.Text = "LISTA DE PRODUCTOS";
            // 
            // lbbuscarproducto
            // 
            this.lbbuscarproducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbbuscarproducto.AutoSize = true;
            this.lbbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscarproducto.Location = new System.Drawing.Point(224, 134);
            this.lbbuscarproducto.Name = "lbbuscarproducto";
            this.lbbuscarproducto.Size = new System.Drawing.Size(131, 29);
            this.lbbuscarproducto.TabIndex = 1;
            this.lbbuscarproducto.Text = "BUSCAR :";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(416, 134);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(240, 29);
            this.txtbuscar.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 276);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 359);
            this.dataGridView1.TabIndex = 3;
            // 
            // btvolver
            // 
            this.btvolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolver.Location = new System.Drawing.Point(372, 661);
            this.btvolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btvolver.Name = "btvolver";
            this.btvolver.Size = new System.Drawing.Size(141, 41);
            this.btvolver.TabIndex = 4;
            this.btvolver.Text = "VOLVER";
            this.btvolver.UseVisualStyleBackColor = true;
            this.btvolver.Click += new System.EventHandler(this.btvolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESULTADO:";
            // 
            // formlistaproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btvolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lbbuscarproducto);
            this.Controls.Add(this.lblistadeproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(871, 759);
            this.Name = "formlistaproducto";
            this.Text = "generarventa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblistadeproducto;
        private System.Windows.Forms.Label lbbuscarproducto;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btvolver;
        private System.Windows.Forms.Label label1;
    }
}