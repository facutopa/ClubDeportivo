
namespace CapaUsuario
{
    partial class GestionSocio
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
            this.gestSocio_botonCerrar = new System.Windows.Forms.Button();
            this.gestSocio_botonEliminar = new System.Windows.Forms.Button();
            this.gestSocio_botonModif = new System.Windows.Forms.Button();
            this.gestSocio_botonCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Socios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gestSocio_botonCerrar
            // 
            this.gestSocio_botonCerrar.Location = new System.Drawing.Point(136, 448);
            this.gestSocio_botonCerrar.Name = "gestSocio_botonCerrar";
            this.gestSocio_botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonCerrar.TabIndex = 11;
            this.gestSocio_botonCerrar.Text = "Cerrar";
            this.gestSocio_botonCerrar.UseVisualStyleBackColor = true;
            this.gestSocio_botonCerrar.Click += new System.EventHandler(this.gestSocio_botonCerrar_Click);
            // 
            // gestSocio_botonEliminar
            // 
            this.gestSocio_botonEliminar.Location = new System.Drawing.Point(272, 400);
            this.gestSocio_botonEliminar.Name = "gestSocio_botonEliminar";
            this.gestSocio_botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonEliminar.TabIndex = 10;
            this.gestSocio_botonEliminar.Text = "Eliminar";
            this.gestSocio_botonEliminar.UseVisualStyleBackColor = true;
            this.gestSocio_botonEliminar.Click += new System.EventHandler(this.gestSocio_botonEliminar_Click);
            // 
            // gestSocio_botonModif
            // 
            this.gestSocio_botonModif.Location = new System.Drawing.Point(136, 400);
            this.gestSocio_botonModif.Name = "gestSocio_botonModif";
            this.gestSocio_botonModif.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonModif.TabIndex = 9;
            this.gestSocio_botonModif.Text = "Modificar";
            this.gestSocio_botonModif.UseVisualStyleBackColor = true;
            this.gestSocio_botonModif.Click += new System.EventHandler(this.gestSocio_botonModif_Click);
            // 
            // gestSocio_botonCrear
            // 
            this.gestSocio_botonCrear.Location = new System.Drawing.Point(8, 400);
            this.gestSocio_botonCrear.Name = "gestSocio_botonCrear";
            this.gestSocio_botonCrear.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonCrear.TabIndex = 8;
            this.gestSocio_botonCrear.Text = "Crear";
            this.gestSocio_botonCrear.UseVisualStyleBackColor = true;
            this.gestSocio_botonCrear.Click += new System.EventHandler(this.gestSocio_botonCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el Socio que desea Modificar o Eliminar. \r\nSi desea crear un nuevo Soc" +
    "io, use Crear.";
            // 
            // listBox1_Socios
            // 
            this.listBox1_Socios.FormattingEnabled = true;
            this.listBox1_Socios.ItemHeight = 15;
            this.listBox1_Socios.Location = new System.Drawing.Point(8, 48);
            this.listBox1_Socios.Name = "listBox1_Socios";
            this.listBox1_Socios.Size = new System.Drawing.Size(336, 319);
            this.listBox1_Socios.TabIndex = 6;
            // 
            // GestionSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 485);
            this.Controls.Add(this.gestSocio_botonCerrar);
            this.Controls.Add(this.gestSocio_botonEliminar);
            this.Controls.Add(this.gestSocio_botonModif);
            this.Controls.Add(this.gestSocio_botonCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_Socios);
            this.Name = "GestionSocio";
            this.Text = "GestionSocio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gestSocio_botonCerrar;
        private System.Windows.Forms.Button gestSocio_botonEliminar;
        private System.Windows.Forms.Button gestSocio_botonModif;
        private System.Windows.Forms.Button gestSocio_botonCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Socios;
    }
}