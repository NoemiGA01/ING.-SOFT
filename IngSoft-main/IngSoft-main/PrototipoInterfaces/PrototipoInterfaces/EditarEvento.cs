using MetroFramework.Forms;
using MetroFramework.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrototipoInterfaces
{
    public partial class EditarEvento : MetroForm // Cambiamos "Form" a "MetroForm"
    {
        public EditarEvento()
        {
            InitializeComponent();

            // Configuramos el estilo del formulario
            this.Style = MetroFramework.MetroColorStyle.Pink; // Puedes cambiar el estilo según tus preferencias

            // Cambiamos el color de fondo del formulario
            this.BackColor = Color.FromArgb(22, 22, 22); // Establecemos un color personalizado

           
        }

        private void EditarEvento_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier lógica adicional que necesites cuando se cargue el formulario
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
