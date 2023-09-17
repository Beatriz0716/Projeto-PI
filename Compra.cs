using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Microsoft;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_PI_V3
{
    public partial class telaCompra : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection conexao
              = new MySql.Data.MySqlClient.MySqlConnection(
                "server=localhost; port=3306; user id = root; password=07161828; database=dbDeposito; ");
        private MySql.Data.MySqlClient.MySqlCommand stm;
        private MySql.Data.MySqlClient.MySqlDataReader dr;

        private telaCompra()
        {
            InitializeComponent();
        }
        //CARREGAR MATERIAIS
        private void telaCompra_Load_1(object sender, EventArgs e)
        {
            conexao.Open();
            stm = new MySqlCommand("SELECT * FROM materiais ORDER BY material ", conexao);
            dr = stm.ExecuteReader();
            listaMateriais.Items.Clear();
            while (dr.Read())
            {
                listaMateriais.Items.Add(dr.GetString("material"));
            }
            dr.Close();
            stm.Dispose();
            conexao.Close();
        }

        //mostrar material e preço nos campos
        private void selectMaterial(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                string materialSelec = listaMateriais.SelectedItem as string;
                string sql = "SELECT * FROM materiais WHERE material='" + materialSelec + "'";
                stm = new MySql.Data.MySqlClient.MySqlCommand(sql, conexao);
                dr = stm.ExecuteReader();
                while (dr.Read())
                {
                    txtMaterial.Text = dr.GetString(0);
                    string preco = dr.GetString(1);
                    txtValorPeso.Text = string.Format(@"{0:#,##R$ #0.00}", Decimal.Parse(preco));
                }

                dr.Close();
                stm.Dispose();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(null, erro.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                string materialSelec = listaMateriais.SelectedItem as string;
                string sql = "SELECT * FROM materiais WHERE material='" + materialSelec + "'";
                stm = new MySql.Data.MySqlClient.MySqlCommand(sql, conexao);
                dr = stm.ExecuteReader();
                while (dr.Read())
                {
                    txtMaterial.Text = dr.GetString(0);
                    string preco = dr.GetString(1);
                    double precoConv = Convert.ToDouble(preco);
                    double peso = Convert.ToSingle(txtPeso.Text);
                    double tara = Convert.ToSingle(txtTara.Text);
                    double pesoLiq = peso;
                    if (tara >= 0)
                    {
                        pesoLiq = peso - tara;
                    }
                    double valorPagar = precoConv * pesoLiq;
                    txtTara.Text = tara.ToString() + 0;
                    txtPesoLiq.Text = pesoLiq.ToString("N2");
                    txtValorPagar.Text = valorPagar.ToString("C");
                }
                dr.Close();
                stm.Dispose();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(null, erro.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMaterial.Text = " ";
            txtTara.Text = "0";
            txtPeso.Text = " ";
            txtValorPagar.Text = " ";
            txtValorPeso.Text = " ";
            txtPesoLiq.Text = " ";
        }

    }
}
