﻿using MetroFramework.Forms;
using MetroFramework.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrototipoInterfaces
{
    public partial class EditarNota : MetroForm // Cambiamos "Form" a "MetroForm"
    {
        public EditarNota()
        {
            InitializeComponent();

            // Configuramos el estilo del formulario
            this.Style = MetroFramework.MetroColorStyle.Teal; // Puedes cambiar el estilo según tus preferencias

            // Cambiamos el color de fondo del formulario
            this.BackColor = Color.FromArgb(22, 22, 22); // Establecemos un color personalizado

          
        }

        private void EditarNota_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier lógica adicional que necesites cuando se cargue el formulario
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}