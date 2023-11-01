using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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
            string conexao = "server=localhost;database=cadastro;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update cliente set nome='" + txt_nome.Text + "', dsEndereco='" + txtEndereco.Text + "' where idAluno=" + txtCodigoAluno.Text, conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            txtNomeAluno.Text = "";
            txtEndereco.Text = "";
            txtCodigoAluno.Text = "";
            pnlAlterar.Visible = false;
            CarregarDadosBanco();
        }
    }

}