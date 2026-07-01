using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
using SistemaDeGestion2026.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestion2026
{
    public partial class FRMUsuario_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aususis usuario = new aususis();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codUsuMod = "";
        public bool actualizar = false;
        #endregion

        #region Constructor
        public FRMUsuario_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos

        private bool VerificarIntegridad()
        {
            bool respuesta = true;            

            if (TXTNombreLogin.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el LOGIN del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombreLogin.Focus();
                respuesta = false;
            }
            
            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTCI.Text = "";
            TXTNombres.Text = "Nombre Completo";
            TXTNombreLogin.Text = "";
            TXTNombreLogin.Focus();
        }
        private void JalarDatos()
        {
            usuario.pauscodusu = this.codUsuMod;
            usuario.ObtenerDatos();
            SWBEstado.Value = usuario.causestusu;
            TXTCI.Text = "";            
            TXTNombres.Text = "";
            TXTNombreLogin.Text = usuario.causnomlog;
        }

        #endregion

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMUsuario_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }            
        }

        private void TXTCI_Enter(object sender, EventArgs e)
        {
            TextBoxX a = (TextBoxX)sender;
            a.SelectAll();
        }

        private void FRMUsuario_Registrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar Usuario";
                GPPanelPrincipal.Text = "Modificar Usuario";
                TXTCI.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar Usuario";
                GPPanelPrincipal.Text = "Registrar Usuario";
                TXTCI.Focus();
            }
        }

        private void TXTNombreLogin_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            else if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
