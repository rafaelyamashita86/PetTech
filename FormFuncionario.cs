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
    public partial class FormFuncionario : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\PetTech\\DbPetTech.mdf;Integrated Security=True");

        public FormFuncionario()
        {
            InitializeComponent();
        }
        public void CarregaDgv()
        {
            String sql = "SELECT * FROM Funcionarios";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable teste = new DataTable();
            da.Fill(teste);
            dgvFuncionarios.DataSource = teste;
            con.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InserirFunc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = txtLogin.Text;
                cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = txtSenha.Text;
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text;
                cmd.Parameters.AddWithValue("@dataadmissao", SqlDbType.NChar).Value = txtDataadmissao.Text;
                cmd.Parameters.AddWithValue("@genero", SqlDbType.NChar).Value = cbxGenero.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario inserido com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtCelular.Text = "";
                txtDataadmissao.Text = "";
                cbxGenero.Text = "";
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
                SqlCommand cmd = new SqlCommand("AtualizarFunc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = txtLogin.Text;
                cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = txtSenha.Text;
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text;
                cmd.Parameters.AddWithValue("@dataadmissao", SqlDbType.DateTime).Value = Convert.ToDateTime(txtDataadmissao.Text.Trim());
                cmd.Parameters.AddWithValue("@genero", SqlDbType.NChar).Value = Convert.ToString(cbxGenero.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtID.Text = "";
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtCelular.Text = "";
                txtDataadmissao.Text = "";
                cbxGenero.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnApgar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ApagarFunc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario apagado com sucesso!", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtID.Text = "";
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtCelular.Text = "";
                txtDataadmissao.Text = "";
                cbxGenero.Text = "";
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
                SqlCommand cmd = new SqlCommand("LocalizarFunc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                string data = Convert.ToString(txtDataadmissao);
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtLogin.Text = dr["login"].ToString();
                    txtSenha.Text = dr["senha"].ToString();
                    txtCelular.Text = dr["celular"].ToString();
                    txtDataadmissao.Text = dr["dataadmissao"].ToString();
                    cbxGenero.SelectedItem = dr["genero"].ToString();
                    dr.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum funcionario localizado com este ID?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            CarregaDgv();
        }
    }
   
}
