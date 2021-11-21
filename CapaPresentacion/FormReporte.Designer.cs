
namespace CapaPresentacion
{
    partial class FormReporte
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
            this.pnlFrmReporte = new System.Windows.Forms.Panel();
            this.BtnEstrCartera = new System.Windows.Forms.Button();
            this.BtnRegValores = new System.Windows.Forms.Button();
            this.BtnMovMN = new System.Windows.Forms.Button();
            this.BtnMovME = new System.Windows.Forms.Button();
            this.pnlFrmReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrmReporte
            // 
            this.pnlFrmReporte.Controls.Add(this.BtnMovME);
            this.pnlFrmReporte.Controls.Add(this.BtnMovMN);
            this.pnlFrmReporte.Controls.Add(this.BtnRegValores);
            this.pnlFrmReporte.Controls.Add(this.BtnEstrCartera);
            this.pnlFrmReporte.Location = new System.Drawing.Point(0, 0);
            this.pnlFrmReporte.Name = "pnlFrmReporte";
            this.pnlFrmReporte.Size = new System.Drawing.Size(1072, 643);
            this.pnlFrmReporte.TabIndex = 0;
            // 
            // BtnEstrCartera
            // 
            this.BtnEstrCartera.BackColor = System.Drawing.Color.Black;
            this.BtnEstrCartera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstrCartera.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstrCartera.ForeColor = System.Drawing.Color.White;
            this.BtnEstrCartera.Location = new System.Drawing.Point(250, 178);
            this.BtnEstrCartera.Name = "BtnEstrCartera";
            this.BtnEstrCartera.Size = new System.Drawing.Size(163, 90);
            this.BtnEstrCartera.TabIndex = 0;
            this.BtnEstrCartera.Text = "Estructura de Cartera";
            this.BtnEstrCartera.UseVisualStyleBackColor = false;
            this.BtnEstrCartera.Click += new System.EventHandler(this.BtnEstrCartera_Click);
            // 
            // BtnRegValores
            // 
            this.BtnRegValores.BackColor = System.Drawing.Color.Black;
            this.BtnRegValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegValores.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegValores.ForeColor = System.Drawing.Color.White;
            this.BtnRegValores.Location = new System.Drawing.Point(250, 369);
            this.BtnRegValores.Name = "BtnRegValores";
            this.BtnRegValores.Size = new System.Drawing.Size(163, 90);
            this.BtnRegValores.TabIndex = 1;
            this.BtnRegValores.Text = "Registro de Valores";
            this.BtnRegValores.UseVisualStyleBackColor = false;
            this.BtnRegValores.Click += new System.EventHandler(this.BtnRegValores_Click);
            // 
            // BtnMovMN
            // 
            this.BtnMovMN.BackColor = System.Drawing.Color.Black;
            this.BtnMovMN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovMN.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovMN.ForeColor = System.Drawing.Color.White;
            this.BtnMovMN.Location = new System.Drawing.Point(627, 178);
            this.BtnMovMN.Name = "BtnMovMN";
            this.BtnMovMN.Size = new System.Drawing.Size(163, 90);
            this.BtnMovMN.TabIndex = 2;
            this.BtnMovMN.Text = "Movimiento Moneda Nacional";
            this.BtnMovMN.UseVisualStyleBackColor = false;
            // 
            // BtnMovME
            // 
            this.BtnMovME.BackColor = System.Drawing.Color.Black;
            this.BtnMovME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovME.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovME.ForeColor = System.Drawing.Color.White;
            this.BtnMovME.Location = new System.Drawing.Point(627, 369);
            this.BtnMovME.Name = "BtnMovME";
            this.BtnMovME.Size = new System.Drawing.Size(163, 90);
            this.BtnMovME.TabIndex = 3;
            this.BtnMovME.Text = "Movimientos Moneda Extranjera";
            this.BtnMovME.UseVisualStyleBackColor = false;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 643);
            this.Controls.Add(this.pnlFrmReporte);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte";
            this.pnlFrmReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrmReporte;
        private System.Windows.Forms.Button BtnMovME;
        private System.Windows.Forms.Button BtnMovMN;
        private System.Windows.Forms.Button BtnRegValores;
        private System.Windows.Forms.Button BtnEstrCartera;
    }
}