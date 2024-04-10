namespace PrototipoInterfaces
{
    partial class Tarea
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarT = new System.Windows.Forms.TextBox();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(28, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 71);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(28, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 71);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(28, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 71);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(28, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 71);
            this.panel1.TabIndex = 10;
            // 
            // txtBuscarT
            // 
            this.txtBuscarT.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscarT.Location = new System.Drawing.Point(92, 27);
            this.txtBuscarT.Name = "txtBuscarT";
            this.txtBuscarT.Size = new System.Drawing.Size(249, 28);
            this.txtBuscarT.TabIndex = 8;
            this.txtBuscarT.Text = "Buscar tareas";
            this.txtBuscarT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbUser
            // 
            this.ptbUser.Image = global::PrototipoInterfaces.Properties.Resources.USER;
            this.ptbUser.Location = new System.Drawing.Point(368, 12);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(71, 70);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUser.TabIndex = 9;
            this.ptbUser.TabStop = false;
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.txtBuscarT);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "Tarea";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Tarea";
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbUser;
        private System.Windows.Forms.TextBox txtBuscarT;
    }
}