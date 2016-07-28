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
using Prototipo1.WSOrdenesTrabajos;
using WS_Produccion;
using WS_ProduccionUtilitario;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Web.Script.Serialization;
using System.ServiceModel;
using WS_Produccion.Excepciones;
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
                txtOt.Enabled = false;
            }
        }

        public void SISCO_Mantenimiento_Grabar()
        {
            try
            {
                if (PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Modify || PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Add)
                {
                    if (ValidarGuardar())
                    {
                        MessageBox.Show(MensajeValidacion, Funciones.Insfor_NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    lblError.Text = string.Empty;

                    Movimiento ordenMovimiento = new Movimiento();
                    ordenMovimiento.Fecha = DateTime.Parse(dtpFecha.Text);
                    ordenMovimiento.IdAlmacen = int.Parse(cboAlmacen.SelectedValue.ToString());
                    ordenMovimiento.IdOrdenTrabajo = int.Parse(txtOt.Text); ;

                    if (TipoMovimiento == eTipoMovimiento.IngresoProductoTerminado)
                    {
                        ordenMovimiento.TipoMovimiento = "I";
                    }
                    else
                    {
                        ordenMovimiento.TipoMovimiento = "S";
                    }

                    if (ordenMovimiento.ListaMovimientoDetalles == null) ordenMovimiento.ListaMovimientoDetalles = new List<MovimientoDetalle>();
                    foreach (DataRowView row in dvDetalle)
                    {
                        MovimientoDetalle MovimientoDetalle = new MovimientoDetalle();
                        MovimientoDetalle.IdArticulo = Int32.Parse(row["IdArticulo"].ToString());
                        MovimientoDetalle.Cantidad = decimal.Parse(row["Cantidad"].ToString());

                        ordenMovimiento.ListaMovimientoDetalles.Add(MovimientoDetalle);
                    }

                    Movimiento movimientoCreado = null;

                    string url = Funciones.GetRutaServicioMovimientoAlmacenes;
                    WebClient client = new WebClient();
                    client.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    string recurso = "Movimiento";

                    //var json = JObject.FromObject(ordenMovimiento);

                    if (PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Add)
                    {
                        ordenMovimiento.FechaRegistro = DateTime.Now;

                        var json = new JavaScriptSerializer().Serialize(ordenMovimiento);
                        var bytes = Encoding.Default.GetBytes(json);
                        client.Headers.Add("Content-Type", "application/json");
                        var response = client.UploadData(url + recurso, "POST", bytes);
                        JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(response));
                        movimientoCreado = token.ToObject<Movimiento>();
                    }
                    else
                    {
                        ordenMovimiento.FechaModificacion = DateTime.Now;
                        ordenMovimiento.Id = IdMovimiento;

                        var json = new JavaScriptSerializer().Serialize(ordenMovimiento);
                        var bytes = Encoding.Default.GetBytes(json);
                        client.Headers.Add("Content-Type", "application/json");
                        var response = client.UploadData(url + recurso, "PUT", bytes);

                        JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(response));
                        movimientoCreado = token.ToObject<Movimiento>();
                    }

                    if (movimientoCreado != null)
                    {
                        lblError.Text = Funciones.RegistroGrabadoExito;
                        PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Insert;
                        CargarDatos(movimientoCreado);
                    }
                    else
                    {
                        lblError.Text = Funciones.ErrorGrabarRegistro;
                        return;
                    }

                    EstadoBotones(false);
                }
            }
            catch (Exception error)
            {
                //FaultException<OrdenAprobadaValidacion>
                // var error = ()ex;
                MessageBox.Show(error.Message, Funciones.Insfor_NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SISCO_Mantenimiento_Modificar()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Modify && PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Add)
            {
                if (IdMovimiento == 0)
                {
                    lblError.Text = Funciones.NoExisteRegistroMoficar;
                    return;
                }
                else
                {
                    PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Modify;
                    TabControlMantenimiento.SelectedIndex = 1;
                    EstadoBotones(true);
                    txtNumero.Enabled = false;
                    txtOt.Enabled = false;
                }
            }
        }

        public void SISCO_Mantenimiento_Cancelar()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Modify || PropertyEvento.Sisco_Property_Mantenimiento == PropertyEvent.Sisco_Mantenimiento.Add)
            {
                PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Cancel;
                if (IdMovimiento != 0)
                {
                    var ordenTrabajo = ObtenerMovimiento(IdMovimiento);
                    CargarDatos(ordenTrabajo);
                }
                else
                {
                    TabControlMantenimiento.SelectedIndex = 0;
                    ListarDatos();
                }
                EstadoBotones(false);
            }
        }

        public void SISCO_Mantenimiento_Eliminar()
        {
            if (PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Modify && PropertyEvento.Sisco_Property_Mantenimiento != PropertyEvent.Sisco_Mantenimiento.Add)
            {
                if (MessageBox.Show("Estás seguro de eliminar el registro?", Funciones.Insfor_NombreEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    PropertyEvento.Sisco_Property_Mantenimiento = PropertyEvent.Sisco_Mantenimiento.Delete;

                    string url = Funciones.GetRutaServicioMovimientoAlmacenes + "Movimiento/" + IdMovimiento;
                    WebClient client = new WebClient();
                    client.Credentials = System.Net.CredentialCache.DefaultCredentials;

                    string eliminado = client.UploadString(url, "DELETE", "");

                    lblError.Text = Funciones.RegistroEliminadoExito;
                    SISCO_Mantenimiento_Listado();
                }
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
            JToken token = JArray.Parse(System.Text.Encoding.UTF8.GetString(responseData));
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
            if (string.IsNullOrEmpty(txtOt.Text))
            {
                MensajeValidacion = "Debe ingresar número de orden de trabajo.";
                return true;
            }

            if (dvDetalle.Count == 0)
            {
                MensajeValidacion = "Debe ingresar detalle.";
                return true;
            }

            return Retorno;
        }
        #endregion

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            SISCO_Mantenimiento_Listado();
        }

        private void lklAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuscarOrdenesTrabajo result = new BuscarOrdenesTrabajo();
            result.lblTitulo.Text = "Búsqueda: Ordenes de Trabajo";
            if (TipoMovimiento == eTipoMovimiento.IngresoProductoTerminado)
            {
                result.idsEstadoOrdenTrabajo = EEstadoOrdenTrabajo.EnProcesoProduccion.GetHashCode().ToString();
            }
            else
            {
                result.idsEstadoOrdenTrabajo = EEstadoOrdenTrabajo.Aprobado.GetHashCode().ToString();
            }

            result.ShowDialog();
            if (result.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (result.dvResultado.Count > 0)
                {
                    if (dvDetalle.Table == null)
                    {
                        dvDetalle = Funciones.convertToDataTable<MovimientoDetalle>(new List<MovimientoDetalle>()).AsDataView();
                    }

                    foreach (DataRowView DataRow in result.dvResultado)
                    {
                        WSOrdenesTrabajos.OrdenTrabajosClient proxyOrdenTrabajo = new OrdenTrabajosClient();
                        List<MovimientoDetalle> movimientoList = new List<MovimientoDetalle>();

                        int idOrdenTrabajo = Int32.Parse(DataRow["Id"].ToString());

                        if (TipoMovimiento == eTipoMovimiento.IngresoProductoTerminado)
                        {
                            movimientoList = proxyOrdenTrabajo.ListarLineaProduccion(idOrdenTrabajo).ToList();
                        }
                        else
                        {
                            movimientoList = proxyOrdenTrabajo.ListarMaterialesOrdenTrabajo(idOrdenTrabajo).ToList();
                        }

                        movimientoList.ForEach(articulo =>
                        {
                            DataRowView vRow;
                            dvDetalle.AllowNew = true;
                            vRow = dvDetalle.AddNew();
                            vRow.BeginEdit();
                            vRow["Id"] = 0;
                            vRow["IdArticulo"] = articulo.IdArticulo;
                            vRow["Articulo"] = articulo.Articulo;
                            vRow["Cantidad"] = articulo.Cantidad;
                            vRow["StockActual"] = articulo.StockActual;
                            vRow.EndEdit();
                            dvDetalle.AllowNew = false;
                        });

                        txtOt.Text = idOrdenTrabajo.ToString().PadLeft(6, '0');
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
