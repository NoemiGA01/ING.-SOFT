namespace Interfaces
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNoControl = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(63, 185);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(184, 22);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Text = "Nombre Completo";
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNoControl
            // 
            this.textBoxNoControl.Location = new System.Drawing.Point(63, 230);
            this.textBoxNoControl.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNoControl.Name = "textBoxNoControl";
            this.textBoxNoControl.Size = new System.Drawing.Size(184, 22);
            this.textBoxNoControl.TabIndex = 2;
            this.textBoxNoControl.Text = "No. de Control";
            this.textBoxNoControl.TextChanged += new System.EventHandler(this.textBoxNoControl_TextChanged);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(63, 281);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(184, 22);
            this.textBoxCorreo.TabIndex = 3;
            this.textBoxCorreo.Text = "Correo ";
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(63, 337);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(184, 22);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.Text = "Contraseña";
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Location = new System.Drawing.Point(99, 394);
            this.btnRegistrate.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrate.TabIndex = 5;
            this.btnRegistrate.Text = "Regístrate";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrate);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNoControl);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Registrarse";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNoControl;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}