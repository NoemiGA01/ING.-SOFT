using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoInterfaces
{
    public partial class formInicio : MetroForm // Cambiamos "Form" a "MetroForm"
    {
        public formInicio()
        {
            InitializeComponent();

            // Configuramos el estilo del formulario
            this.Style = MetroFramework.MetroColorStyle.Teal; // Puedes cambiar el estilo según tus preferencias
                                                              // Cambiamos el renderizador del MenuStrip
                                                              // Establecemos los colores de los elementos de menú
            menuStrip1.ForeColor = Color.White; // Color del texto de los elementos de menú
            menuStrip1.BackColor = Color.FromArgb(22, 22, 22); // Color de fondo de los elementos de menú
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
