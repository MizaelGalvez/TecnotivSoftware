namespace InterfaceTIV.Vista
{
    partial class Confirmacion
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardarRuta = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(513, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 384);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 383);
            this.panel2.TabIndex = 10;
            // 
            // btnGuardarRuta
            // 
            this.btnGuardarRuta.BackgroundImage = global::InterfaceTIV.Properties.Resources.btnGuardarRuta;
            this.btnGuardarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarRuta.FlatAppearance.BorderSize = 0;
            this.btnGuardarRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRuta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardarRuta.Location = new System.Drawing.Point(135, 132);
            this.btnGuardarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarRuta.Name = "btnGuardarRuta";
            this.btnGuardarRuta.Size = new System.Drawing.Size(259, 123);
            this.btnGuardarRuta.TabIndex = 14;
            this.btnGuardarRuta.Text = "Entendido";
            this.btnGuardarRuta.UseVisualStyleBackColor = true;
            this.btnGuardarRuta.Click += new System.EventHandler(this.btnGuardarRuta_Click);
            this.btnGuardarRuta.MouseLeave += new System.EventHandler(this.btnGuardarRuta_MouseLeave);
            this.btnGuardarRuta.MouseHover += new System.EventHandler(this.btnGuardarRuta_MouseHover);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 289);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(528, 20);
            this.progressBar1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::InterfaceTIV.Properties.Resources.barra_superior;
            this.panel1.Location = new System.Drawing.Point(4, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 47);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(127, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 53);
            this.label1.TabIndex = 15;
            this.label1.Text = "Solicitud Exitosa\r\n";
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(525, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardarRuta);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Confirmacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardarRuta;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}