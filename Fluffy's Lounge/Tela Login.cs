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
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_Cadastro Tela_Login = new Tela_Cadastro();
            Tela_Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados Dados = new Dados();
            Dados.Show();
        }

        private void Tela_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
