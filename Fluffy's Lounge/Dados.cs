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

        private void Dados_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }
        private void CarregarDadosBanco()
        {
            string conexao = "server=localhost;database=cadastro;uid=root;pwd=";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_cliente", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCliente.DataSource = dt;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=cadastro;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update tb_cliente set nome_cliente='" + txtNomeCliente.Text + "', email_cliente='" + txtEmailCliente.Text + "' where id_cliente=" + txtIdCliente.Text, conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            txtNomeCliente.Text = "";
            txtEmailCliente.Text = "";
            txtIdCliente.Text = "";
            pnlAlterar.Visible = false;
            CarregarDadosBanco();
        }

        private void dgvCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdCliente.Text = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCliente.Text = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmailCliente.Text = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            pnlAlterar.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "" || txtNomeCliente.Text == "" || txtEmailCliente.Text == "")
            {

                MessageBox.Show("Por favor complete todos os campos");
            }
            else
            {
                MySqlConnection mySql = new MySqlConnection("server=localhost;database=cadastro;uid=root;pwd=etec");
                mySql.Open();
                MySqlCommand comando = new MySqlCommand("Insert into tb_cliente (id_cliente, nome_cliente, email_cliente) values ('" + txtIdCliente.Text + "','" + txtNomeCliente.Text + "','" + txtEmailCliente.Text + "');", mySql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente registrado com sucesso!");
                txtNomeCliente.Text = "";
                txtIdCliente.Text = "";
                txtEmailCliente.Text = "";
                CarregarDadosBanco();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult caixaMensagem = MessageBox.Show("Deseja realmente excluir esse aluno?", "Etec Taboão da Serra", MessageBoxButtons.YesNo);

            if (caixaMensagem == DialogResult.Yes)
            {
                string conexao = "server=localhost;database=cadastro;uid=root;pwd=etec";
                MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("delete from tb_cliente where id_cliente= " + txtIdCliente.Text + ";", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dado excluído com sucesso!");
                txtNomeCliente.Text = "";
                txtEmailCliente.Text = "";
                txtIdCliente.Text = "";
                pnlAlterar.Visible = false;
                CarregarDadosBanco();
            }
        }
    }
}