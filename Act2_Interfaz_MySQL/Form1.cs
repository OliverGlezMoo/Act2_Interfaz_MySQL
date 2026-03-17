using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
// Declaracion de las clases necesarias para la ejecución 

namespace Act2_Interfaz_MySQL
{
    public partial class Act2_Interfaz_MySQL : Form
    {
        public Act2_Interfaz_MySQL()
        {
            InitializeComponent();
            // Inicializacion de los componentes.
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
        // Función para imitar el funcionamiento de la propiedad de PlaceHolder, con el fin de que sea más limpio y no
        // afecte a futuras actualizaciones al momento de emplear bases de datos.

        private void BtnConectar_Click_1(object sender, EventArgs e)
        {
            string host = TxtHost.Text;
            string user = TxtUsuario.Text;
            string password = TxtContraseña.Text;
            string puerto = TxtPuerto.Text;
            string database = TxtBD.Text;
            // Conversion de los datos ingresados a tipo String para futuras referencias

            string connectionString = BuildConnectionString(host, user, password, puerto, database);
            // Sentencia para establecer conexion con la BD, pasando los atributos necesarios para la misma

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM CatPersonal", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DgvDatos.DataSource = dt;
                    // Senbtencia para lograr la visualizacion de las filas de la tabla CatPersonal
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);

                }
                // Mensaje de error, en caso de no poder establecer conexion y mostrar los datos en el grid.
            }
        }

        private string BuildConnectionString(string host, string user, string password, string puerto, string database)
        {
            return $"SERVER={host};PORT={puerto};DATABASE={database};USER ID={user};PASSWORD={password};";
        }
        // Sentencia que establece la conexion con la base de datos, usando como parametros los datos ingresados por el usuario

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            TxtContraseña.PasswordChar = '*';
        }
        // Creación de una sentencia para volver cada caracter de las contraseñas en *
    }
}
