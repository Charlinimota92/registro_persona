using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_guardar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_eliminar.Enabled = false;

            txt_Nombre.Enabled = true;
            txt_Edad.Enabled = true;

            txt_Nombre.Focus();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_Editar.Enabled = true;
            btn_eliminar.Enabled = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_guardar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_eliminar.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Nombre.Enabled = false;
            txt_Edad.Enabled = false;
        }
    }
}
