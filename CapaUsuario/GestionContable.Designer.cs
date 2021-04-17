
namespace CapaUsuario
{
    partial class GestionContable
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Socios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gestionContable_datePickerFechaPago = new System.Windows.Forms.DateTimePicker();
            this.gestionContable_botonPagar = new System.Windows.Forms.Button();
            this.listBox2_ListaFacturas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Socio y luego complete los datos para el Pago";
            // 
            // listBox1_Socios
            // 
            this.listBox1_Socios.FormattingEnabled = true;
            this.listBox1_Socios.ItemHeight = 15;
            this.listBox1_Socios.Location = new System.Drawing.Point(16, 40);
            this.listBox1_Socios.Name = "listBox1_Socios";
            this.listBox1_Socios.Size = new System.Drawing.Size(328, 94);
            this.listBox1_Socios.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Pago";
            // 
            // gestionContable_datePickerFechaPago
            // 
            this.gestionContable_datePickerFechaPago.Location = new System.Drawing.Point(112, 144);
            this.gestionContable_datePickerFechaPago.Name = "gestionContable_datePickerFechaPago";
            this.gestionContable_datePickerFechaPago.Size = new System.Drawing.Size(232, 23);
            this.gestionContable_datePickerFechaPago.TabIndex = 3;
            // 
            // gestionContable_botonPagar
            // 
            this.gestionContable_botonPagar.Location = new System.Drawing.Point(16, 176);
            this.gestionContable_botonPagar.Name = "gestionContable_botonPagar";
            this.gestionContable_botonPagar.Size = new System.Drawing.Size(75, 23);
            this.gestionContable_botonPagar.TabIndex = 4;
            this.gestionContable_botonPagar.Text = "Pagar";
            this.gestionContable_botonPagar.UseVisualStyleBackColor = true;
            this.gestionContable_botonPagar.Click += new System.EventHandler(this.gestionContable_botonPagar_Click);
            // 
            // listBox2_ListaFacturas
            // 
            this.listBox2_ListaFacturas.FormattingEnabled = true;
            this.listBox2_ListaFacturas.ItemHeight = 15;
            this.listBox2_ListaFacturas.Location = new System.Drawing.Point(16, 248);
            this.listBox2_ListaFacturas.Name = "listBox2_ListaFacturas";
            this.listBox2_ListaFacturas.Size = new System.Drawing.Size(328, 94);
            this.listBox2_ListaFacturas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de Pagos";
            // 
            // GestionContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2_ListaFacturas);
            this.Controls.Add(this.gestionContable_botonPagar);
            this.Controls.Add(this.gestionContable_datePickerFechaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1_Socios);
            this.Controls.Add(this.label1);
            this.Name = "GestionContable";
            this.Text = "GestionContable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Socios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker gestionContable_datePickerFechaPago;
        private System.Windows.Forms.Button gestionContable_botonPagar;
        private System.Windows.Forms.ListBox listBox2_ListaFacturas;
        private System.Windows.Forms.Label label3;
    }
}