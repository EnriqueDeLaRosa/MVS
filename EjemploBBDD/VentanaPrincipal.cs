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
//https://scrumy.com/doff86ramble
namespace EjemploBBDD
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            rellenaComboAutores();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void rellenaComboAutores()
        {
            MySqlConnection conexion = new conexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM actors ORDER BY last_name"
                , conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                String id = resultado.GetString(0);
                String first_name = resultado.GetString("first_name");
                String last_name = resultado.GetString("last_name");
                String gender = resultado.GetString("gender");
                String film_count = resultado.GetString("film_count");
                desplegablePelis.Items.Add(id+" "+first_name+ " "+last_name+ " "+gender+ " "+ film_count);

            }
            conexion.Close();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
