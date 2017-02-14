namespace InterfaceTIV.Vista
{
    partial class ReconocimeintoVoz
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
            this.lblVerificacion = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerificacion
            // 
            this.lblVerificacion.AutoSize = true;
            this.lblVerificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblVerificacion.Location = new System.Drawing.Point(35, 11);
            this.lblVerificacion.Name = "lblVerificacion";
            this.lblVerificacion.Size = new System.Drawing.Size(62, 13);
            this.lblVerificacion.TabIndex = 0;
            this.lblVerificacion.Text = "Verificacion";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(36, 157);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(55, 20);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Frase";
            this.lblTexto.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::InterfaceTIV.Properties.Resources.AUDIO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 165);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ReconocimeintoVoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.BackgroundImage = global::InterfaceTIV.Properties.Resources.Transparente;
            this.ClientSize = new System.Drawing.Size(27, 186);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblVerificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReconocimeintoVoz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReconocimeintoVoz";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerificacion;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}