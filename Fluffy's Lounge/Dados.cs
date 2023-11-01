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
    public partial class Dados : Form
    {
        public Dados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dados_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }
        private void CarregarDadosBanco()
        {
            string conexao = "server=localhost;database=cadastro;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_cliente", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCliente.DataSource = dt;

        }
    }
}
