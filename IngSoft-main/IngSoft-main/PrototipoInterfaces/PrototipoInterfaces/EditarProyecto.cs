using MetroFramework.Forms;
using MetroFramework.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrototipoInterfaces
{
    public partial class EditarProyecto : MetroForm // Cambiamos "Form" a "MetroForm"
    {
        public EditarProyecto()
        {
            InitializeComponent();

            // Configuramos el estilo del formulario
            this.Style = MetroFramework.MetroColorStyle.Teal; // Puedes cambiar el estilo según tus preferencias

            // Cambiamos el color de fondo del formulario
            this.BackColor = Color.FromArgb(22, 22, 22); // Establecemos un color personalizado

        }

        private void EditarProyecto_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier lógica adicional que necesites cuando se cargue el formulario
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
