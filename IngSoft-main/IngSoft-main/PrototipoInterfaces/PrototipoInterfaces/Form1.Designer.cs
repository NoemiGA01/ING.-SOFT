namespace Interfaces
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCorreoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxIniciarGoogle = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicie Sesión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCorreoUsuario
            // 
            this.textBoxCorreoUsuario.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoUsuario.Location = new System.Drawing.Point(100, 291);
            this.textBoxCorreoUsuario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxCorreoUsuario.Name = "textBoxCorreoUsuario";
            this.textBoxCorreoUsuario.Size = new System.Drawing.Size(247, 38);
            this.textBoxCorreoUsuario.TabIndex = 1;
            this.textBoxCorreoUsuario.Text = "Correo o No. de Control";
            this.textBoxCorreoUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(100, 359);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(247, 38);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.Text = "Contraseña";
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxIniciarGoogle
            // 
            this.textBoxIniciarGoogle.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxIniciarGoogle.Location = new System.Drawing.Point(113, 556);
            this.textBoxIniciarGoogle.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxIniciarGoogle.Name = "textBoxIniciarGoogle";
            this.textBoxIniciarGoogle.Size = new System.Drawing.Size(247, 38);
            this.textBoxIniciarGoogle.TabIndex = 3;
            this.textBoxIniciarGoogle.Text = "Iniciar Sesión con Google";
            this.textBoxIniciarGoogle.TextChanged += new System.EventHandler(this.textBoxIniciarGoogle_TextChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnContinuar.Location = new System.Drawing.Point(137, 442);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(161, 56);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 534);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 621);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.textBoxIniciarGoogle);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxCorreoUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(37, 138, 37, 47);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCorreoUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxIniciarGoogle;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

