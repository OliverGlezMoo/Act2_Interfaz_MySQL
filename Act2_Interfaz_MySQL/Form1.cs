using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Act2_Interfaz_MySQL
{
    public partial class Act2_Interfaz_MySQL : Form
    {
        public Act2_Interfaz_MySQL()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SendMessage(TxtHost.Handle, EM_SETCUEBANNER, 1, "Escribe el Host");
            SendMessage(TxtUsuario.Handle, EM_SETCUEBANNER, 1, "Escribe tu Usuario");
            SendMessage(TxtContraseña.Handle, EM_SETCUEBANNER, 1, "Escribe tu Contraseña");
            SendMessage(TxtPuerto.Handle, EM_SETCUEBANNER, 1, "Puerto de la BD");
            SendMessage(TxtBD.Handle, EM_SETCUEBANNER, 1, "Nombre de la BD");
        }

        private void BtnConectar_Click_1(object sender, EventArgs e)
        {
            string host = TxtHost.Text;
            string user = TxtUsuario.Text;
            string password = TxtContraseña.Text;
            string puerto = TxtPuerto.Text;
            string database = TxtBD.Text;

            string connectionString = BuildConnectionString(host, user, password, puerto, database);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM CatPersonal", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);

                }
            }
        }

        private string BuildConnectionString(string host, string user, string password, string puerto, string database)
        {
            return $"SERVER={host};PORT={puerto};DATABASE={database};USER ID={user};PASSWORD={password};";
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            TxtContraseña.PasswordChar = '*';
        }
    }
}
