using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexion;

namespace ProyectoBiblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }
        public static bool status;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select*FROM usuarios WHERE cuenta='{0}' AND contraseña='{1}'", textUsuario.Text.Trim(), textPassword.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);
                string nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                string cuenta = ds.Tables[0].Rows[0]["cuenta"].ToString();
                string password = ds.Tables[0].Rows[0]["contraseña"].ToString();
                 status = Convert.ToBoolean(ds.Tables[0].Rows[0]["status_admin"]);
                if (cuenta == textUsuario.Text.Trim() && password == textPassword.Text.Trim())
                {
                    MessageBox.Show("Bienvenido " + nombre, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    VentanaAdmin admi = new VentanaAdmin();
                    this.Hide();
                    admi.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cuenta o contraseña incorrecta ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?","Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Usuario")
            {
                textUsuario.Text ="";
                textUsuario.ForeColor = Color.Black;
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Contraseña")
            {
                textPassword.Text = "";
                textUsuario.ForeColor = Color.Black;
                textPassword.UseSystemPasswordChar = true;

            }

        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text =="")
            {
                textUsuario.Text = "Usuario";
                textUsuario.ForeColor = Color.Black;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Contraseña";
                textUsuario.ForeColor = Color.Black ;


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
