namespace PrototipoInterfaces
{
    partial class Proyectos
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
            this.txtBuscarP = new System.Windows.Forms.TextBox();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(21, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 71);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(21, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 71);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(21, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 71);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(21, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 71);
            this.panel1.TabIndex = 10;
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarP.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscarP.Location = new System.Drawing.Point(85, 27);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(249, 28);
            this.txtBuscarP.TabIndex = 8;
            this.txtBuscarP.Text = "Buscar proyectos";
            this.txtBuscarP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbUser
            // 
            this.ptbUser.Image = global::PrototipoInterfaces.Properties.Resources.USER;
            this.ptbUser.Location = new System.Drawing.Point(361, 12);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(71, 70);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUser.TabIndex = 9;
            this.ptbUser.TabStop = false;
            // 
            // Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.txtBuscarP);
            this.Name = "Proyectos";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Proyectos";
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
        private System.Windows.Forms.TextBox txtBuscarP;
    }
}