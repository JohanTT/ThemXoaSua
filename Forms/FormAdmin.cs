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

namespace UITest.Forms
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadTheme();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=JOHAN\SQLEXPRESS;Initial Catalog=SHOES14;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.Aquamarine;
            public static Color colorHome = Color.FromArgb(89, 131, 252);
            public static Color colorBase = Color.FromArgb(41, 53, 86);
        }

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " Select * from Mat_Hang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        void retext()
        {
            tb_magiay.Text = "";
            tb_tengiay.Text = "";
            tb_soluong.Text = "";
            tb_mausac.Text = "";
            tb_size.Text = "";
            tb_dongia.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "insert into Mat_Hang values ('" + tb_magiay.Text + "','" + tb_tengiay.Text + "','" + double.Parse(tb_soluong.Text) + "','" + tb_mausac.Text + "','" + tb_size.Text + "','" + double.Parse(tb_dongia.Text) + "')";
            command.ExecuteNonQuery();
            loaddata();
            retext();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Mat_Hang where MaGiay= '" + tb_magiay.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            retext();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            //tb_magiay.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update Mat_Hang set TenGiay = '" + tb_tengiay.Text + "', SoLuong = '" + double.Parse(tb_soluong.Text) + "', MauSac = '" + tb_mausac.Text + "', Size = '" + tb_size.Text + "', DonGiaBan = '" + double.Parse(tb_dongia.Text) + "' where MaGiay = '" + tb_magiay.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            retext();
        }

        private void KhoiTao_Click(object sender, EventArgs e)
        {
            retext();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tb_magiay.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tb_tengiay.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tb_soluong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tb_mausac.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tb_size.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tb_dongia.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = RGBColors.color6;
                }
            }
        }
    }
}
