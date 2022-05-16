using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.DarkBlue;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.DarkBlue;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text=="" || TextBox_password.Text=="")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz","Eksik Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedIndex > -1)
                {
                    if (comboBox_role.SelectedItem.ToString() == "YÖNETİCİ")
                    {
                        if (TextBox_username.Text == "admin" && TextBox_password.Text=="12345")
                        {
                            ProductForm product = new ProductForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Eğer yönetici iseniz, doğru kullanıcı adı ve şifre giriniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT *FROM Seller WHERE SellerName='" + TextBox_username.Text + "' AND SellerPass='" + TextBox_password.Text + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            SellingForm selling = new SellingForm();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı türü seçiniz", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void comboBox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
