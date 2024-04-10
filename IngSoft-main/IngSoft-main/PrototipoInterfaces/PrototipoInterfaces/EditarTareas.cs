using MetroFramework.Forms;
using MetroFramework.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrototipoInterfaces
{
    public partial class EditarTareas : MetroForm // Cambiamos "Form" a "MetroForm"
    {
        public EditarTareas()
        {
            InitializeComponent();

            // Configuramos el estilo del formulario
            this.Style = MetroFramework.MetroColorStyle.Teal; // Puedes cambiar el estilo según tus preferencias

            // Cambiamos el color de fondo del formulario
            this.BackColor = Color.FromArgb(22, 22, 22); // Establecemos un color personalizado

         //borde para el SplitContainer
        }

        private void EditarTareas_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier lógica adicional que necesites cuando se cargue el formulario
        }
    }
}

