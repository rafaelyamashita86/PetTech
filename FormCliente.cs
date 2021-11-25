using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetTech
{
    public partial class FormCliente : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\PetTech\\DbPetTech.mdf;Integrated Security=True");

        public FormCliente()
        {
            InitializeComponent();
        }
        public void CarregaDgv()
        {
            String sql = "SELECT * FROM Cliente";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable teste = new DataTable();
            da.Fill(teste);
            dgvCliente.DataSource = teste;
            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CarregaDgv();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InserirCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@endereco", SqlDbType.NChar).Value = txtEndereco.Text;
                cmd.Parameters.AddWithValue("@cidade", SqlDbType.NChar).Value = txtCidade.Text;
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text;
                cmd.Parameters.AddWithValue("@email", SqlDbType.NChar).Value = txtEmail.Text;
                cmd.Parameters.AddWithValue("@datanascimento", SqlDbType.DateTime).Value = Convert.ToDateTime(txtDatanascimentoCli.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente inserido com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtDatanascimentoCli.Text = "";

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AtualizarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@endereco", SqlDbType.NChar).Value = txtEndereco.Text;
                cmd.Parameters.AddWithValue("@cidade", SqlDbType.NChar).Value = txtCidade.Text;
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text;
                cmd.Parameters.AddWithValue("@email", SqlDbType.NChar).Value = txtEmail.Text;
                cmd.Parameters.AddWithValue("@datanascimento", SqlDbType.DateTime).Value = Convert.ToDateTime(txtDatanascimentoCli.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtID.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtDatanascimentoCli.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ApagarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente apagado com sucesso!", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtID.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtDatanascimentoCli.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LocalizarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtEndereco.Text = dr["endereco"].ToString();
                    txtCidade.Text = dr["cidade"].ToString();
                    txtCelular.Text = dr["celular"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtDatanascimentoCli.Text = dr["datanascimento"].ToString();
                    dr.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum Cliente localizado com este ID?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
