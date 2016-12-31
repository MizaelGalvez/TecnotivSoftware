namespace InterfaceTIV.Vista
{
    partial class GuardarRuta
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarRuta = new System.Windows.Forms.Button();
            this.btnIniciarRuta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(262, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Importante !!!: \r\nIniciar en modo\r\nManual.";
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
            this.btnGuardarRuta.Location = new System.Drawing.Point(374, 149);
            this.btnGuardarRuta.Name = "btnGuardarRuta";
            this.btnGuardarRuta.Size = new System.Drawing.Size(194, 100);
            this.btnGuardarRuta.TabIndex = 7;
            this.btnGuardarRuta.Text = "Terminar y Guardar Ruta";
            this.btnGuardarRuta.UseVisualStyleBackColor = true;
            this.btnGuardarRuta.Click += new System.EventHandler(this.btnGuardarRuta_Click);
            this.btnGuardarRuta.MouseLeave += new System.EventHandler(this.btnGuardarRuta_MouseLeave);
            this.btnGuardarRuta.MouseHover += new System.EventHandler(this.btnGuardarRuta_MouseHover);
            // 
            // btnIniciarRuta
            // 
            this.btnIniciarRuta.BackgroundImage = global::InterfaceTIV.Properties.Resources.btnIniciarRuta;
            this.btnIniciarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarRuta.FlatAppearance.BorderSize = 0;
            this.btnIniciarRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarRuta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciarRuta.Location = new System.Drawing.Point(39, 149);
            this.btnIniciarRuta.Name = "btnIniciarRuta";
            this.btnIniciarRuta.Size = new System.Drawing.Size(194, 100);
            this.btnIniciarRuta.TabIndex = 1;
            this.btnIniciarRuta.Text = "Iniciar Ruta";
            this.btnIniciarRuta.UseVisualStyleBackColor = true;
            this.btnIniciarRuta.Click += new System.EventHandler(this.btnIniciarRuta_Click);
            this.btnIniciarRuta.MouseLeave += new System.EventHandler(this.btnIniciarRuta_MouseLeave);
            this.btnIniciarRuta.MouseHover += new System.EventHandler(this.btnIniciarRuta_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::InterfaceTIV.Properties.Resources.barra_superior;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 38);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::InterfaceTIV.Properties.Resources.btnCerrar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(574, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(-1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 311);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(599, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 312);
            this.panel3.TabIndex = 3;
            // 
            // GuardarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(609, 302);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardarRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarRuta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuardarRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuardarRuta";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIniciarRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarRuta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}