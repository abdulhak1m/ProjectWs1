using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ProjectWS1
{
    public partial class Form1 : Form
    {
        void SwirchForm2()
        {
            ActiveForm.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }
        public Form1()
        {
            InitializeComponent();
            int move = 0, moveY = 0, moveX = 0;
            pnl_Top.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            pnl_Top.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            pnl_Top.MouseUp += (s, e) => { move = 0; };

            btn_close.Click += (s, e) => { Close(); };

            txt_password.TextChanged += (s, e) => { txt_password.UseSystemPasswordChar = true; };
            btn_show.MouseDown += (s, e) => { txt_password.UseSystemPasswordChar = false; };
            btn_show.MouseUp += (s, e) => { txt_password.UseSystemPasswordChar = true; };

            linkLabel1.Click += (s, e) => { SwirchForm2(); };
            
        }

        static string MyConn = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;

        void BtnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text))
                {
                    using (SqlConnection sql = new SqlConnection(MyConn))
                    {
                        sql.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Ws1 where Username ='" + txt_username.Text.Trim() + "' and Password = '" + txt_password.Text.Trim() + "'", sql);
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        if (data.Rows.Count == 1)
                        {
                            ActiveForm.Hide();
                            using (Form3 form3 = new Form3())
                            {
                                form3.ShowDialog();
                            }
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль!", "Авторизация не прошла!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля!", "Пустые поля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source); }
        }
    }
}
