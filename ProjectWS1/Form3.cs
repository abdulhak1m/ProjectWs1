using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ProjectWS1
{
    public partial class Form3 : Form
    {
        DialogResult dialogResult;

        readonly static string MyConnection = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
        public Form3()
        {
            InitializeComponent();

            int move = 0, moveX = 0, moveY = 0;
            panelTop.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            panelTop.MouseDown += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            panelTop.MouseUp += (s, e) => { move = 0; };

            btn_close.Click += (s, e) => { Close();};
            Exit.Click += (s, e) =>
            {
                dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Уведомление системы.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    ActiveForm.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    Close();
                }
            };

            switch_add.Click += (s, e) => { panelAdd.BringToFront(); };
            switch_view.Click += (s, e) => { panelView.BringToFront(); };
        }

        void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_product.Text) && !string.IsNullOrEmpty(txt_manufacturer.Text) &&
                    !string.IsNullOrEmpty(txt_characteristics.Text) && !string.IsNullOrEmpty(txt_price.Text))
                {
                    string query = $"INSERT INTO tbl_Ws2 ([Product], [Manufacturer], [Characteristics], [Price], [UserId]) VALUES ('{txt_product.Text}', '{txt_manufacturer.Text}', '{txt_characteristics.Text}', '{txt_price.Text}', '{comboBox1.Text}')";
                    using (SqlConnection sql = new SqlConnection(MyConnection))
                    {
                        sql.Open();
                        SqlCommand command = new SqlCommand(query, sql);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Добавление прошло успешно!", "Уведомление системы.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля, обозначенные *.", "Уведомление системы.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        DataTable data = new DataTable();
        public new DataTable Select()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(MyConnection))
                {
                    sql.Open();
                    string query = "SELECT * FROM tbl_Ws2";
                    SqlCommand command = new SqlCommand(query, sql);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(data);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source); }
            return data;
        }

        void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbWSDataSet.tbl_Ws1". При необходимости она может быть перемещена или удалена.
            this.tbl_Ws1TableAdapter.Fill(this.dbWSDataSet.tbl_Ws1);
            Refresh();
        }

        private new void Refresh()
        {
            data = Select();
            dataGridView1.DataSource = data;
        }
    }
}
