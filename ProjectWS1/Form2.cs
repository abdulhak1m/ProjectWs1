using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWS1
{
    public partial class Form2 : Form
    {
        void SwitchForm1()
        {
            ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }
        public Form2()
        {
            InitializeComponent();
            lblError.Visible = false;
            lblErrorRow.Visible = false;
            int move = 0, moveX = 0, moveY = 0;
            pnl_Top.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            pnl_Top.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            pnl_Top.MouseUp += (s, e) => { move = 0; };
            btn_close.Click += (s, e) => { Close(); };
            linkRegin.Click += (s, e) => { panelreg.BringToFront(); };
            linkAuto.Click += (s, e) => { SwitchForm1(); };
            linkAutho.Click += (s, e) => { SwitchForm1(); };

            cmbgender.SelectedIndex = 0;

            //btn_done.Click += (s, e) => { panelReginDone.BringToFront(); };
            btn_back.Click += (s, e) => { SwitchForm1(); };

            txtpassword.TextChanged += (s, e) => { txtpassword.UseSystemPasswordChar = true; Prov(); };
            txt_confirmpassword.TextChanged += (s, e) => { txt_confirmpassword.UseSystemPasswordChar = true; Prov(); };
            btn_show1.MouseDown += (s, e) => { txtpassword.UseSystemPasswordChar = false; };
            btn_show2.MouseDown += (s, e) => { txt_confirmpassword.UseSystemPasswordChar = false; };

            btn_show1.MouseUp += (s, e) => { txtpassword.UseSystemPasswordChar = true; };
            btn_show2.MouseUp += (s, e) => { txt_confirmpassword.UseSystemPasswordChar = true; };
        }

        readonly static string MyConn = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;

        void Panel(Panel panel)
        {
            panel.BringToFront();
        }

        public bool Insert()
        {
            bool IsSuccess = false;
            try
            {
                using(SqlConnection sql = new SqlConnection(MyConn))
                {
                    sql.Open();
                    string query = $"INSERT INTO tbl_Ws1 ([Name], [Surname], [Gender], [Phone], [UserName], [Password])" +
                        $"values ('{txt_name.Text}','{txt_surname.Text}', '{cmbgender.Text}', '{txt_phone.Text}', '{txtusername.Text}', '{txtpassword.Text}')";
                    SqlCommand command = new SqlCommand(query, sql);
                    int row = command.ExecuteNonQuery();
                    IsSuccess = row > 0 ? true : false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return IsSuccess;
        }

        private void Btn_done_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_name.Text) &&
                 !string.IsNullOrEmpty(txt_surname.Text) &&
                 !string.IsNullOrEmpty(cmbgender.Text) &&
                 !string.IsNullOrEmpty(txt_phone.Text) &&
                 !string.IsNullOrEmpty(txtusername.Text) &&
                 !string.IsNullOrEmpty(txt_confirmpassword.Text))
            {
                Prov();
                bool success = Insert();
                Panel(success ? panelReginDone : panelError);
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните поля, отмеченные (*)", "Заполните поля!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        void Prov()
        {
            if (txtpassword.Text != txt_confirmpassword.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Внимание, пароль не совпадает";
                btn_done.Enabled = false;
            }
            else
            {
                lblError.Visible = false;
                btn_done.Enabled = true;
            }
        }
    }
}
