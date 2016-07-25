using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS_Produccion;
using WS_ProduccionUtilitario;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Web.Script.Serialization;
namespace Prototipo1.View
{
    public partial class MovimientoAlmacen : frmMantenimiento, IMantenimiento
    {
        #region Variables generales
        private PropertyEvent PropertyEvento = new PropertyEvent();
        private DataView dvListado = new DataView();
        private DataView dvDetalle = new DataView();

        private string MensajeValidacion { get; set; }
        private string MensajeError { get; set; }
        private int IdMovimiento { get; set; }
        protected WSMovimientoAlmacenes.MovimientoAlmacenesClient Proxy = new WSMovimientoAlmacenes.MovimientoAlmacenesClient();
        #endregion

        public enum eTipoMovimiento
        {
            Ninguno = 0,
            IngresoProductoTerminado = 1,
            SalidaMateriales = 2
        }

        public eTipoMovimiento TipoMovimiento { get; set; }

        public MovimientoAlmacen()
        {
            InitializeComponent();
        }

        private void IngresoProducto_Load(object sender, EventArgs e)
        {

            //HttpWebRequest req2 = WebRequest.Create(url + "/Movimiento/1") as HttpWebRequest;
            //req2.Method = "GET";
            //HttpWebResponse res2 = req2.GetResponse() as HttpWebResponse;
            //StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            //string proveedorJson2 = reader2.ReadToEnd();
            //JavaScriptSerializer js2 = new JavaScriptSerializer();
            //Movimiento proveedorObtenido = js2.Deserialize<Movimiento>(proveedorJson2);


            WSConsultasGenerales.ParametroDetallesClient proxy = new WSConsultasGenerales.ParametroDetallesClient();
            cboAlmacen.DataSource = proxy.ListarParametroDetalle(TipoMovimiento == eTipoMovimiento.IngresoProductoTerminado ? EParametro.AlmacenProductoPerminado.GetHashCode() : EParametro.AlmacenMateriales.GetHashCode());
            cboAlmacen.DisplayMember = "Descripcion";
            cboAlmacen.ValueMember = "Id";
            EstadoBotones(false);
            ListarDatos();
        }

        #region Metodos de Mantenimiento
        public void SISCO_Mantenimiento_Nuevo()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Modify && PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Add)
            {
                PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Add;
                Limpiar();

                TabControlMantenimiento.SelectedIndex = 1;
                EstadoBotones(true);
                txtNumero.Enabled = false;
            }
        }

        public void SISCO_Mantenimiento_Grabar()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Modify || PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Add)
            {
                if (ValidarGuardar())
                {
                    MessageBox.Show(MensajeValidacion, Funciones.Insfor_NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblError.Text = string.Empty;

                //OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
                //ordenTrabajo.Fecha = DateTime.Parse(dtpFecha.Text);
                //ordenTrabajo.IdEstado = int.Parse(cboEstado.SelectedValue.ToString());
                //ordenTrabajo.Activo = true;

                //if (ordenTrabajo.ListaDetalleOrdenTrabajo == null) ordenTrabajo.ListaDetalleOrdenTrabajo = new List<OrdenTrabajoDetalle>();
                //foreach (DataRowView row in dvDetalle)
                //{
                //    OrdenTrabajoDetalle ordenTrabajoDetalle = new OrdenTrabajoDetalle();
                //    ordenTrabajoDetalle.IdArticulo = Int32.Parse(row["IdArticulo"].ToString());
                //    ordenTrabajoDetalle.Cantidad = decimal.Parse(row["Cantidad"].ToString());

                //    ordenTrabajo.ListaDetalleOrdenTrabajo.Add(ordenTrabajoDetalle);
                //}

                //OrdenTrabajo ordenTrabajoCreado = null;

                //if (PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Add)
                //{
                //    ordenTrabajo.FechaRegistro = DateTime.Now;
                //    ordenTrabajoCreado = Proxy.crearOrd(ordenTrabajo);
                //}
                //else
                //{
                //    ordenTrabajo.FechaModificacion = DateTime.Now;
                //    ordenTrabajo.Id = IdOrdenTrabajo;
                //    ordenTrabajoCreado = Proxy.modificarOrd(ordenTrabajo);
                //}


                //if (ordenTrabajoCreado != null)
                //{
                //    lblError.Text = Funciones.RegistroGrabadoExito;
                //    PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Insert;
                //    CargarDatos(ordenTrabajoCreado);
                //}
                //else
                //{
                //    lblError.Text = Funciones.ErrorGrabarRegistro;
                //    return;
                //}

                //EstadoBotones(false);
            }
        }

        public void SISCO_Mantenimiento_Modificar()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Modify && PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Add)
            {
                //if (IdOrdenTrabajo == 0)
                //{
                //    lblError.Text = Funciones.NoExisteRegistroMoficar;
                //    return;
                //}
                //else
                //{
                //    PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Modify;
                //    TabControlMantenimiento.SelectedIndex = 1;
                //    EstadoBotones(true);
                //    txtNumero.Enabled = false;
                //    cboEstado.Enabled = false;
                //}
            }
        }

        public void SISCO_Mantenimiento_Cancelar()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Modify || PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Add)
            {
                //PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Cancel;
                //if (IdOrdenTrabajo != 0)
                //{
                //    var ordenTrabajo = Proxy.obtenerOrd(IdOrdenTrabajo);
                //    CargarDatos(ordenTrabajo);
                //}
                //else
                //{
                //    TabControlMantenimiento.SelectedIndex = 0;
                //    ListarDatos();
                //}
                //EstadoBotones(false);
            }
        }

        public void SISCO_Mantenimiento_Eliminar()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Modify && PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Add)
            {
                PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Delete;
            }
        }

        public void SISCO_Mantenimiento_Listado()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Modify && PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Add)
            {
                PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.List;
                ListarDatos();
                TabControlMantenimiento.SelectedIndex = 0;
            }
        }

        #endregion

        #region Metodos basicos
        private void EstadoTabRegistro(bool blnEstado)
        {
            foreach (Control tp in TabControlMantenimiento.TabPages)
            {
                if (tp.Name != "TabPageListado")
                {
                    foreach (Control ctl in tp.Controls)
                    {
                        if (ctl is TextBox || ctl is CheckBox || ctl is GroupBox || ctl is ComboBox)
                        {
                            ctl.Enabled = blnEstado;
                        }
                    }
                }
            }
        }

        private void EstadoBotones(bool blnEstado)
        {
            IMantenimiento currenForm = (IMantenimiento)this;
            if (currenForm != null)
            {
                this.btnNuevo.Enabled = !blnEstado;
                this.btnGrabar.Enabled = blnEstado;
                this.btnModificar.Enabled = !blnEstado;
                this.btnDeshacer.Enabled = blnEstado;
                this.btnEliminar.Enabled = !blnEstado;
                this.btnLista.Enabled = !blnEstado;
                this.lklAgregar.Enabled = blnEstado;
                BindingNavigatorListado.Enabled = !blnEstado;

                EstadoTabRegistro(blnEstado);
            }
        }
        private void Limpiar()
        {
            foreach (TabPage tp in TabControlMantenimiento.TabPages)
            {
                foreach (Control ctl in tp.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.Text = string.Empty;
                    }
                }
            }

            if (dvDetalle.Table != null)
                dvDetalle.Table.Clear();

            lblError.Text = "*";
            CargarDetalle();
        }

        private void ListarDatos()
        {
            BindingSource BindingSource = new System.Windows.Forms.BindingSource();

            string url = Funciones.GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;

            string recurso = string.Empty;

            if (TipoMovimiento == eTipoMovimiento.IngresoProductoTerminado)
            {
                recurso = "Movimiento?pTipoMovimiento=I";
            }
            else
            {
                recurso = "Movimiento?pTipoMovimiento=S";
            }

            byte[] responseData = client.DownloadData(url + recurso);
            JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(responseData));
            var result = token.ToObject<List<Movimiento>>();

            BindingSource.DataSource = result;
            BindingNavigatorListado.BindingSource = BindingSource;

            dgvListados.AutoGenerateColumns = false;
            dgvListados.DataSource = BindingNavigatorListado.BindingSource;
        }

        private Movimiento ObtenerMovimiento(int id)
        {
            string url = Funciones.GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;

            string recurso = "Movimiento/" + id;

            byte[] responseData = client.DownloadData(url + recurso);
            JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(responseData));
            var result = token.ToObject<Movimiento>();

            return result;
        }
        private void CargarDatos(Movimiento objMovimiento)
        {
            IdMovimiento = objMovimiento.Id;
            cboAlmacen.SelectedValue = objMovimiento.IdAlmacen;
            dtpFecha.Text = objMovimiento.Fecha.Value.ToShortDateString();
            txtNumero.Text = objMovimiento.Id.ToString().PadLeft(6, '0');
            txtOt.Text = objMovimiento.IdOrdenTrabajo.ToString().PadLeft(6, '0');

            dvDetalle = Funciones.convertToDataTable(objMovimiento.ListaMovimientoDetalles).DefaultView;

            dvDetalle.AllowNew = false;
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            dgvMovimientos.AutoGenerateColumns = false;
            dgvMovimientos.DataSource = dvDetalle;
        }
        private bool ValidarGuardar()
        {
            bool Retorno = false;
            if (dvDetalle.Count == 0)
            {
                MensajeValidacion = "Debe ingresar linea de producción.";
                return true;
            }

            return Retorno;
        }

        private bool ExisteEnLista(int IdClienteEmpresa)
        {
            bool Resultado = false;
            for (int row = 0; row <= dvDetalle.Count - 1; row++)
            {
                if (Int32.Parse(dvDetalle[row]["IdArticulo"].ToString()) == IdClienteEmpresa)
                {
                    Resultado = true;
                    break;
                }
            }

            return Resultado;
        }
        #endregion

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            SISCO_Mantenimiento_Listado();
        }

        private void lklAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuscarArticulos result = new BuscarArticulos();
            result.lblTitulo.Text = "Búsqueda: Linea producción";
            result.TipoExistencia = "T";
            result.ShowDialog();
            if (result.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (result.dvArticulos.Count > 0)
                {
                    if (dvDetalle.Table == null)
                    {
                        dvDetalle = Funciones.convertToDataTable<OrdenTrabajoDetalle>(new List<OrdenTrabajoDetalle>()).AsDataView();
                    }

                    foreach (DataRowView DataRow in result.dvArticulos)
                    {
                        if (!ExisteEnLista(Int32.Parse(DataRow["Id"].ToString())))
                        {
                            DataRowView vRow;
                            dvDetalle.AllowNew = true;
                            vRow = dvDetalle.AddNew();
                            vRow.BeginEdit();
                            vRow["Id"] = 0;
                            vRow["IdArticulo"] = DataRow["Id"];
                            vRow["Articulo"] = DataRow["Descripcion"];
                            vRow["Cantidad"] = 1;
                            vRow.EndEdit();
                            dvDetalle.AllowNew = false;
                        }
                    }

                    CargarDetalle();
                }
            }
        }

        private void dgvListados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    if (row.Cells["ID"].Value == null)
                        IdMovimiento = 0;
                    else
                        IdMovimiento = Int32.Parse(row.Cells["Id"].Value.ToString());

                    var movimiento = ObtenerMovimiento(IdMovimiento);
                    if (movimiento != null)
                    {
                        CargarDatos(movimiento);
                    }
                }
            }
        }

        private void dgvMovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (dgvMovimientos.Columns[e.ColumnIndex].Name.ToString() == "DEL")
            {
                dvDetalle.Delete(dgvMovimientos.CurrentRow.Index);
            }
        }
    }
}
