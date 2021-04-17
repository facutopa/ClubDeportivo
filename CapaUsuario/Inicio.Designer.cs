
namespace CapaUsuario
{
    partial class Inicio
    {
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminButton_Socios = new System.Windows.Forms.Button();
            this.adminButton_Profesor = new System.Windows.Forms.Button();
            this.adminButton_ActivDepo = new System.Windows.Forms.Button();
            this.adminButton_Factura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Inicio";
            // 
            // adminButton_Socios
            // 
            this.adminButton_Socios.Location = new System.Drawing.Point(8, 56);
            this.adminButton_Socios.Name = "adminButton_Socios";
            this.adminButton_Socios.Size = new System.Drawing.Size(280, 23);
            this.adminButton_Socios.TabIndex = 1;
            this.adminButton_Socios.Text = "Gestion Socios";
            this.adminButton_Socios.UseVisualStyleBackColor = true;
            this.adminButton_Socios.Click += new System.EventHandler(this.adminButton_Socios_Click_1);
            // 
            // adminButton_Profesor
            // 
            this.adminButton_Profesor.Location = new System.Drawing.Point(8, 88);
            this.adminButton_Profesor.Name = "adminButton_Profesor";
            this.adminButton_Profesor.Size = new System.Drawing.Size(280, 23);
            this.adminButton_Profesor.TabIndex = 2;
            this.adminButton_Profesor.Text = "Gestion Profesores";
            this.adminButton_Profesor.UseVisualStyleBackColor = true;
            this.adminButton_Profesor.Click += new System.EventHandler(this.adminButton_Profesor_Click_1);
            // 
            // adminButton_ActivDepo
            // 
            this.adminButton_ActivDepo.Location = new System.Drawing.Point(8, 120);
            this.adminButton_ActivDepo.Name = "adminButton_ActivDepo";
            this.adminButton_ActivDepo.Size = new System.Drawing.Size(280, 23);
            this.adminButton_ActivDepo.TabIndex = 3;
            this.adminButton_ActivDepo.Text = "Gestion Actividad Deportiva";
            this.adminButton_ActivDepo.UseVisualStyleBackColor = true;
            this.adminButton_ActivDepo.Click += new System.EventHandler(this.adminButton_ActivDepo_Click_1);
            // adminButton_Factura
            // 
            this.adminButton_Factura.Location = new System.Drawing.Point(8, 152);
            this.adminButton_Factura.Name = "adminButton_Factura";
            this.adminButton_Factura.Size = new System.Drawing.Size(281, 24);
            this.adminButton_Factura.TabIndex = 4;
            this.adminButton_Factura.Text = "Gestion Contable";
            this.adminButton_Factura.UseVisualStyleBackColor = true;
            this.adminButton_Factura.Click += new System.EventHandler(this.adminButton_Factura_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 198);
            this.Controls.Add(this.adminButton_Factura);
            this.Controls.Add(this.adminButton_ActivDepo);
            this.Controls.Add(this.adminButton_Profesor);
            this.Controls.Add(this.adminButton_Socios);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Administradora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminButton_Socios;
        private System.Windows.Forms.Button adminButton_Profesor;
        private System.Windows.Forms.Button adminButton_ActivDepo;
        private System.Windows.Forms.Button adminButton_Factura;
    }
}

