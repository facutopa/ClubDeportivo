
namespace CapaUsuario
{
    partial class GestionProfesor
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
            this.gestProfesor_botonCerrar = new System.Windows.Forms.Button();
            this.gestProfesor_botonEliminar = new System.Windows.Forms.Button();
            this.gestProfesor_botonModif = new System.Windows.Forms.Button();
            this.gestProfesor_botonCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Profesor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gestProfesor_botonCerrar
            // 
            this.gestProfesor_botonCerrar.Location = new System.Drawing.Point(136, 448);
            this.gestProfesor_botonCerrar.Name = "gestProfesor_botonCerrar";
            this.gestProfesor_botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonCerrar.TabIndex = 17;
            this.gestProfesor_botonCerrar.Text = "Cerrar";
            this.gestProfesor_botonCerrar.UseVisualStyleBackColor = true;
            this.gestProfesor_botonCerrar.Click += new System.EventHandler(this.gestProfesor_botonCerrar_Click);
            // 
            // gestProfesor_botonEliminar
            // 
            this.gestProfesor_botonEliminar.Location = new System.Drawing.Point(272, 400);
            this.gestProfesor_botonEliminar.Name = "gestProfesor_botonEliminar";
            this.gestProfesor_botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonEliminar.TabIndex = 16;
            this.gestProfesor_botonEliminar.Text = "Eliminar";
            this.gestProfesor_botonEliminar.UseVisualStyleBackColor = true;
            this.gestProfesor_botonEliminar.Click += new System.EventHandler(this.gestProfesor_botonEliminar_Click);
            // 
            // gestProfesor_botonModif
            // 
            this.gestProfesor_botonModif.Location = new System.Drawing.Point(136, 400);
            this.gestProfesor_botonModif.Name = "gestProfesor_botonModif";
            this.gestProfesor_botonModif.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonModif.TabIndex = 15;
            this.gestProfesor_botonModif.Text = "Modificar";
            this.gestProfesor_botonModif.UseVisualStyleBackColor = true;
            this.gestProfesor_botonModif.Click += new System.EventHandler(this.gestProfesor_botonModif_Click);
            // 
            // gestProfesor_botonCrear
            // 
            this.gestProfesor_botonCrear.Location = new System.Drawing.Point(8, 400);
            this.gestProfesor_botonCrear.Name = "gestProfesor_botonCrear";
            this.gestProfesor_botonCrear.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonCrear.TabIndex = 14;
            this.gestProfesor_botonCrear.Text = "Crear";
            this.gestProfesor_botonCrear.UseVisualStyleBackColor = true;
            this.gestProfesor_botonCrear.Click += new System.EventHandler(this.gestProfesor_botonCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione el Profesor que desea Modificar o Eliminar. \r\nSi desea crear un nuevo " +
    "Profesor, use Crear.";
            // 
            // listBox1_Profesor
            // 
            this.listBox1_Profesor.FormattingEnabled = true;
            this.listBox1_Profesor.ItemHeight = 15;
            this.listBox1_Profesor.Location = new System.Drawing.Point(8, 48);
            this.listBox1_Profesor.Name = "listBox1_Profesor";
            this.listBox1_Profesor.Size = new System.Drawing.Size(336, 319);
            this.listBox1_Profesor.TabIndex = 12;
            // 
            // GestionProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 478);
            this.Controls.Add(this.gestProfesor_botonCerrar);
            this.Controls.Add(this.gestProfesor_botonEliminar);
            this.Controls.Add(this.gestProfesor_botonModif);
            this.Controls.Add(this.gestProfesor_botonCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_Profesor);
            this.Name = "GestionProfesor";
            this.Text = "GestionProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Button gestProfesor_botonCerrar;
        private System.Windows.Forms.Button gestProfesor_botonEliminar;
        private System.Windows.Forms.Button gestProfesor_botonModif;
        private System.Windows.Forms.Button gestProfesor_botonCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Profesor;
        #endregion
    }
}