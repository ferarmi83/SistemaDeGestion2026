using CapaRN;
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
    public partial class FRMVenta_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
            private avenpro venta = new avenpro();
            private aiteven item = new aiteven();
            private xnumcor correlativo = new xnumcor();

            public aususis usuario = new aususis();

            public bool actualizar = false;
            private aclient cliente=new aclient();
            private bool clienteok=false;
            private bool lectorCBHabilitado = false;
            public aproduc producto = new aproduc();
            private liteven itemModificar = new liteven();
            private bool modificarItem = false;
        private List<liteven> listaItems = new List<liteven>();
        #endregion

        #region Constructor
        public FRMVenta_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void TXTNITCliente_Leave(object sender, EventArgs e)
        {
            cliente.caclnitcli = TXTNITCliente.Text;
            if (cliente.ObtenerDatosNIT())
            {
                TXTNombreCliente.Text = cliente.caclrazcli;
                clienteok = true;
            }
            else
            { 
                TXTNombreCliente.Text = "Nombre del cliente";
                clienteok = false;
            }
        }

        private void BTNBuscarUsuario_Click(object sender, EventArgs e)
        {
            FRMCliente_Buscar a = new FRMCliente_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.cliente = a.cliente;
                this.clienteok = true;
                TXTNITCliente.Text = cliente.caclnitcli;
                TXTNombreCliente.Text = cliente.caclrazcli;
            }
            else
            {
                this.clienteok = false;
                TXTNITCliente.Text = "";
                TXTNombreCliente.Text = "Nombre del cliente";
            }
        }

        private void BTNCodigoDeBarras_Click(object sender, EventArgs e)
        {
            if (!lectorCBHabilitado)
            {
                lectorCBHabilitado = true;
                LBLCodigoDeBarras.Text = "LECTOR ACTIVO";
                LBLCodigoDeBarras.BackColor = Color.PaleGreen;
            }
            else
            {                
                producto.capdcodbar = LBLCodigoDeBarras.Text;
                if (producto.ObtenerDatosCodigo(false, producto.capdcodbar))
                { 
                    AgregarProductoALista(producto);
                    lectorCBHabilitado = true;
                    LBLCodigoDeBarras.Text = "LECTOR ACTIVO";
                    LBLCodigoDeBarras.BackColor = Color.PaleGreen;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    LBLCodigoDeBarras.Text = "LECTOR ACTIVO";
                    LBLCodigoDeBarras.BackColor = Color.PaleGreen;
                    BTNCodigoDeBarras.Focus();
                }
            }
        }

        private void BTNCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (LBLCodigoDeBarras.Text == "LECTOR ACTIVO")
            {
                LBLCodigoDeBarras.Text = "" + e.KeyChar;
            }
            else
            {
                LBLCodigoDeBarras.Text += e.KeyChar;
            }
        }

        #endregion

        #region Metodos

        private void ActualizarGridItems()
        {
            DTGLista.Rows.Clear();
            foreach (liteven item in listaItems)
            {
                DTGLista.Rows.Add();

                DTGLista[0, DTGLista.Rows.Count - 1].Value = item.faivcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = item.capdmodpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = item.capdcodbar;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = item.capdnompro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = item.capdtalpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = item.capddespro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = item.caivcanite;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = item.caivpreuni;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = item.caivsubtot;
            }
        }

        private void AgregarProductoALista(aproduc pro)
        {
            liteven item = new liteven();

            item=listaItems.Find(x => x.faivcodpro == pro.papdcodpro);

            if (item != null)
            {
                item.caivcanite += 1; // Incrementar la cantidad en 1
                item.caivsubtot = item.caivcanite * item.caivpreuni; // Actualizar el subtotal
            }
            else
            {
                item = new liteven();
                item.faivcodpro = pro.papdcodpro;
                item.capdmodpro = pro.capdmodpro;
                item.capdcodbar = pro.capdcodbar;
                item.capdnompro = pro.capdnompro;
                item.capdtalpro = pro.capdtalpro;
                item.capddespro = pro.capddespro;
                item.caivcanite = 1; // Cantidad por defecto
                item.caivpreuni = pro.capdpreven; // Precio por defecto
                item.capdstopro = pro.capdstopro; // Stock por defecto
                item.caivsubtot = item.caivcanite * item.caivpreuni;
                item.caivestite = true; // Estado activo            
                listaItems.Add(item);
            }
            ActualizarGridItems();
            
        }

        

        #endregion

        private void BTNCodigoDeBarras_Leave(object sender, EventArgs e)
        {
            lectorCBHabilitado = false;
            LBLCodigoDeBarras.Text = "LECTOR INACTIVO";
            LBLCodigoDeBarras.BackColor = Color.LightSalmon;            
        }

        private void FRMVenta_Registrar_Load(object sender, EventArgs e)
        {
            lectorCBHabilitado = false;
            LBLCodigoDeBarras.Text = "LECTOR INACTIVO";
            LBLCodigoDeBarras.BackColor = Color.LightSalmon;
            usuario.pauscodusu = "aususis-000000000006";
            usuario.ObtenerDatos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el item seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EliminarItem(DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString());
                }
            }
        }

        private void EliminarItem(string CodPro)
        {
            listaItems.RemoveAll(x => x.faivcodpro == CodPro);
            ActualizarGridItems();
        }        

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            itemModificar = listaItems.Find(x => x.faivcodpro == DTGLista[0, e.RowIndex].Value.ToString());
            modificarItem = true;
            if (itemModificar != null)
            {
                TXTDescripción.Text = itemModificar.capddespro;
                IINCantidad.Value = itemModificar.caivcanite;
                DINPrecio.Value = (Double)itemModificar.caivpreuni;
                producto.papdcodpro = itemModificar.faivcodpro;
                if (producto.ObtenerDatos())
                {
                    if (producto.capdfotpro == "")
                    {
                     
                        PCBFotografia.Image = Resources.NoImagen;
                    }
                    else
                    {                 
                        PCBFotografia.Image = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);
                    }
                }                
            }
        }

        private void BTNModificarProducto_Click(object sender, EventArgs e)
        {
            if (modificarItem)
            {                
                itemModificar.caivcanite = (int)IINCantidad.Value;
                itemModificar.caivpreuni = (Decimal)DINPrecio.Value;
                itemModificar.caivsubtot = itemModificar.caivcanite * itemModificar.caivpreuni;
                ActualizarGridItems();
                modificarItem = false;
                TXTDescripción.Text = "Descripción del producto";
                IINCantidad.Value = 0;
                DINPrecio.Value = 0;
                PCBFotografia.Image = Resources.NoImagen;
            }
        }

        private void LimpiarProducto_Click(object sender, EventArgs e)
        {
            modificarItem = false;
            TXTDescripción.Text = "Descripción del producto";
            IINCantidad.Value = 0;
            DINPrecio.Value = 0;
            PCBFotografia.Image = Resources.NoImagen;
        }

        private void BTNGrabar_Click(object sender, EventArgs e)
        {
            List<aproduc> listaProductos = new List<aproduc>();
            listaProductos = listaItems.Select(x => new aproduc
            {
                papdcodpro = x.faivcodpro,
                capdmodpro = x.capdmodpro,
                capdcodbar = x.capdcodbar,
                capdnompro = x.capdnompro,
                capdtalpro = x.capdtalpro,
                capddespro = x.capddespro,
                capdstopro = x.capdstopro-x.caivcanite,
                capdpreven = x.caivpreuni
            }).ToList();
            


            if (Verificar_Integridad())
            {
                venta=new avenpro();
                correlativo.pxnctipcor = "avenpro";
                if (correlativo.ObtenerSiguiente())
                {
                    venta.pavpcodven = correlativo.pxnctipcor + "-" +
                                       correlativo.cxncnumcor.ToString("D12");
                }
                venta.cavpestven = true;
                venta.cavpfeccre = DateTime.Now;
                venta.cavpfechor = DateTime.Now;
                venta.cavpfecmod = DateTime.Now;
                venta.cavpmontot = listaItems.Sum(x => x.caivsubtot);
                venta.cavpobsven = TXTObservaciones.Text;
                venta.favpcodcli = cliente.paclcodcli;
                venta.favpusucre = usuario.pauscodusu;
                venta.favpusumod = usuario.pauscodusu;
                
                //Grabado de los items de la venta
                correlativo.pxnctipcor = "aiteven";
                if (correlativo.ObtenerSiguiente(listaItems.Count))
                {
                    correlativo.cxncnumcor -= listaItems.Count-1;
                    foreach (liteven item in listaItems)
                    {

                        item.paivcodite = correlativo.pxnctipcor + "-" +
                                          correlativo.cxncnumcor.ToString("D12");
                        item.faivcodven = venta.pavpcodven;
                        correlativo.cxncnumcor++;
                    }
                    
                }

                if (venta.Grabar() && item.Grabar(listaItems) && producto.ActualizarStock(listaProductos))
                {
                    MessageBox.Show("Venta guardada correctamente!!",
                                    "Mensaje",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    //LimpiarCasillas();
                    this.actualizar = true;
                    //this.FormClosing -= FRMVenta_Registrar_FormClosing;                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Venta no se pudo guardar!!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private bool Verificar_Integridad()
        {
            return true;
        }
    }
}
