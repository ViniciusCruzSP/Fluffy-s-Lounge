using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_s_Lounge
{
    public partial class Tela_Cadastro : Form
    {
        public Tela_Cadastro()
        {
            InitializeComponent();
        }

        private void txt_cadastro_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Rafael" && txt_email.Text == "rdm@gmail.com" && txt_nameUser.Text == "Rafa" && txt_senha.Text == "12345")
            {


                Tela_Login Tela_Cadastro = new Tela_Login();
                Tela_Cadastro.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
            }
        }
    }

}