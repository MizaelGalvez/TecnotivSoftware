namespace InterfaceTIV.Vista
{
    partial class WebNavegador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresarNavegador = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::InterfaceTIV.Properties.Resources.barra_superior;
            this.panel1.Controls.Add(this.btnRegresarNavegador);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 68);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresarNavegador
            // 
            this.btnRegresarNavegador.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresarNavegador.BackgroundImage = global::InterfaceTIV.Properties.Resources.btnRegresar;
            this.btnRegresarNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresarNavegador.FlatAppearance.BorderSize = 0;
            this.btnRegresarNavegador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegresarNavegador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegresarNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarNavegador.Location = new System.Drawing.Point(14, 8);
            this.btnRegresarNavegador.Name = "btnRegresarNavegador";
            this.btnRegresarNavegador.Size = new System.Drawing.Size(52, 53);
            this.btnRegresarNavegador.TabIndex = 0;
            this.btnRegresarNavegador.UseVisualStyleBackColor = false;
            this.btnRegresarNavegador.Click += new System.EventHandler(this.btnRegresarNavegador_Click);
            this.btnRegresarNavegador.MouseLeave += new System.EventHandler(this.btnRegresarNavegador_MouseLeave);
            this.btnRegresarNavegador.MouseHover += new System.EventHandler(this.btnRegresarNavegador_MouseHover);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(22, 115);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(100, 20);
            this.txtEnviar.TabIndex = 1;
            this.txtEnviar.TextChanged += new System.EventHandler(this.txtEnviar_TextChanged);
            // 
            // WebNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1024, 65);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WebNavegador";
            this.Text = "WebNavegador";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresarNavegador;
        private System.Windows.Forms.TextBox txtEnviar;
    }
}