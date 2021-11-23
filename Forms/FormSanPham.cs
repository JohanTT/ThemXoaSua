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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
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
            SanPhamGV.DataSource = table;
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = RGBColors.color3;
                }
            }
        }
    }
}
