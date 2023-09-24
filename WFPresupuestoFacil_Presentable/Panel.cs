using LoginSistem.Clases;
using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using System.Data;
using WFPresupuestoFacil_Presentable;

namespace LoginSistem.Forms
{
    public partial class PanelPresupuesto : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        public PanelPresupuesto()
        {
            InitializeComponent();
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Limpiamos los datos en las variables globales
            Global.GlobalVarId = 0;
            Global.GlobalVarNombre = "";
            Global.GlobalVarClave = "";
            Global.GlobalVarIdPerfil = 0;
            Global.GlobalVarEdad = 0;
            Global.GlobalVarPerfil = "";
            Global.GlobalVarCorreo = "";
            Global.GlobalVarTelefono = "";
            Global.GlobalVarPosicion = "";

            //volvemos al formulario de login
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void PanelPresupuesto_Load(object sender, EventArgs e)
        {
            string date = DateTime.UtcNow.ToString("D");
            lblFecha.Text = date;


            LlenarComboBox(cbEstatusGasto, "Select * From Estatus", "Estatus_Id", "Estatus");
            //cbEstatusGasto.Text = Global.GlobalVarPerfil;
        }

        private void picModifyUser_Click(object sender, EventArgs e)
        {
            mdlEditarUsuario mdlEditarUsuario = new mdlEditarUsuario();
            mdlEditarUsuario.txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            mdlEditarUsuario.txtEditUsuarioClave.Text = Global.GlobalVarClave;
            mdlEditarUsuario.txtCorreoEdit.Text = Global.GlobalVarCorreo;
            mdlEditarUsuario.txtEdadEdit.Text = Global.GlobalVarEdad.ToString();
            mdlEditarUsuario.txtTelefonoEdit.Text = Global.GlobalVarTelefono;
            mdlEditarUsuario.txtPosicionEdit.Text = Global.GlobalVarPosicion;
            mdlEditarUsuario.ShowDialog();

        }
        public void LlenarComboBox(ComboBox combo, string strSql, string id, string desc)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion.Conexion);
            da.Fill(tabla);
            combo.ValueMember = id;
            combo.DisplayMember = desc;
            combo.DataSource = tabla;
        }

        private void picSetup_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
