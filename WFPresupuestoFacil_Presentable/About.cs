using LoginSistem.Forms;
using WFPresupuestoFacil_Presentable.Clases;

namespace WFPresupuestoFacil_Presentable
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPresupuesto menuPrincipal = new PanelPresupuesto();
            menuPrincipal.lblUser.Text = Global.GlobalVarNombre;
            menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
            menuPrincipal.ShowDialog();
        }
    }
}
