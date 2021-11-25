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
    public partial class FormAnimais : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\PetTech\\DbPetTech.mdf;Integrated Security=True");

        public FormAnimais()
        {
            InitializeComponent();
        }
        public void CarregaDgv()
        {
            String sql = "SELECT * FROM Animais";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable teste = new DataTable();
            da.Fill(teste);
            dgvAnimais.DataSource = teste;
            con.Close();
        }

        private void FormAnimais_Load(object sender, EventArgs e)
        {
            CarregaDgv();
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
                SqlCommand cmd = new SqlCommand("Inseriranimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@datanascimento", SqlDbType.Date).Value = Convert.ToDateTime(txtDatanascimento.Text.Trim());
                cmd.Parameters.AddWithValue("@especie", SqlDbType.NChar).Value = cbxEspecie.Text;
                cmd.Parameters.AddWithValue("@pelagem", SqlDbType.NChar).Value = cbxPelagem.Text;
                cmd.Parameters.AddWithValue("@peso", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPeso.Text.Trim());
                cmd.Parameters.AddWithValue("@porte", SqlDbType.NChar).Value = cbxPorte.Text;
                cmd.Parameters.AddWithValue("@sexo", SqlDbType.NChar).Value = cbxSexo.Text;
                cmd.Parameters.AddWithValue("@raca", SqlDbType.NChar).Value = txtRaca.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal inserido com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtNome.Text = "";
                txtDatanascimento.Text = "";
                cbxEspecie.Text = "";
                cbxPelagem.Text = "";
                txtPeso.Text = "";
                cbxPorte.Text = "";
                cbxSexo.Text = "";
                txtRaca.Text = "";
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
                SqlCommand cmd = new SqlCommand("AtualizarAnimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@datanascimento", SqlDbType.Date).Value = Convert.ToDateTime(txtDatanascimento.Text.Trim());
                cmd.Parameters.AddWithValue("@especie", SqlDbType.NChar).Value = cbxEspecie.Text;
                cmd.Parameters.AddWithValue("@pelagem", SqlDbType.NChar).Value = cbxPelagem.Text;
                cmd.Parameters.AddWithValue("@peso", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPeso.Text.Trim());
                cmd.Parameters.AddWithValue("@porte", SqlDbType.NChar).Value = cbxPorte.Text;
                cmd.Parameters.AddWithValue("@sexo", SqlDbType.NChar).Value = cbxSexo.Text;
                cmd.Parameters.AddWithValue("@raca", SqlDbType.NChar).Value = txtRaca.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtID.Text = "";
                txtNome.Text = "";
                txtDatanascimento.Text = "";
                cbxEspecie.Text = "";
                cbxPelagem.Text = "";
                txtPeso.Text = "";
                cbxPorte.Text = "";
                cbxSexo.Text = "";
                txtRaca.Text = "";
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
                SqlCommand cmd = new SqlCommand("ApagarAnimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal apagado com sucesso!", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtID.Text = "";
                txtNome.Text = "";
                txtDatanascimento.Text = "";
                cbxEspecie.Text = "";
                cbxPelagem.Text = "";
                txtPeso.Text = "";
                cbxPorte.Text = "";
                cbxSexo.Text = "";
                txtRaca.Text = "";
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
                SqlCommand cmd = new SqlCommand("LocalizarAnimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtDatanascimento.Text = dr["datanascimento"].ToString();
                    cbxEspecie.Text = dr["especie"].ToString();
                    cbxPelagem.Text = dr["pelagem"].ToString();
                    txtPeso.Text = dr["peso"].ToString();
                    cbxPorte.Text = dr["porte"].ToString();
                    cbxSexo.Text = dr["sexo"].ToString();
                    txtRaca.Text = "";
                    dr.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum Animal localizado com este ID?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
