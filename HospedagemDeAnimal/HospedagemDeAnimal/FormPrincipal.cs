using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospedagemDeAnimal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void meusPetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPet form = new FormPet();
            form.Show();
        }

        private void meusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente form = new FormCadastroCliente();
            form.Show();
        }

        private void hospedarMeuPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHospedagemCliente form = new FormHospedagemCliente();
            form.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            var user = FormLogin.usuarioconectado;
        }
    }
}
