using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EjemploBBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //al pulsar el botón de login, queremos que se cree un nuevo objeto ConexionBBDD que
            //tiene la configuración de la conexión a la BBDD
            MySqlConnection conexion = new conexionBBDD().conecta();
            //hacemos una query básica a la BBDD para obtener la lista de usuarios que sean iguales
            //al que hemos puesto en la caja Usuario, con la contraseña que hemos puesto en la caja pass
            MySqlCommand comando = new MySqlCommand("SELECT * FROM usuarios WHERE "
                + " usuario = '" + textBox2.Text
                + "' and pass = '" + textBox1.Text
                + "' ;", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            if (resultado.Read())
            {
                MessageBox.Show("Acceso Correcto", "USUARIO OK");
                this.Visible = false;//hacenmos invisibnle esto y ponemos visible la otra
                VentanaPrincipal v = new VentanaPrincipal();
                v.Visible=true;
            }
            else
            {
                MessageBox.Show("Usuario Y/O Contraseña Incorrecto(s)", "ERROR");
            }
            //Cerramos la conexion
            conexion.Close();
        }
    }
}
