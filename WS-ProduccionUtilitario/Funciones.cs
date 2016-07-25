using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.IO;

namespace Prototipo1.View
{
    public static class Funciones
    {
        public const string GetRutaServicioMovimientoAlmacenes = "http://localhost:30813/Servicios/MovimientoAlmacenes.svc/";

        public static string Insfor_NombreEmpresa = "Grupo Urano";
        public static string Insfor_Titulo = "Registro: ";

        public static string RegistroGrabadoExito = Insfor_NombreEmpresa + ": " + "Registro Grabado con Exito.";
        public static string ErrorGrabarRegistro = Insfor_NombreEmpresa + ": " + "Ha Ocurrido error al grabar el registro, verifique...!!!";
        public static string RegistroEliminadoExito = Insfor_NombreEmpresa + ": " + "Registro Eliminado con Exito.";
        public static string NoExisteRegistroMoficar = Insfor_NombreEmpresa + ": " + "No existe Registro seleccionado para modificar, Seleccione un registro.!!!";
        public static string ConfirmacionEliminacionRegistro = "Está seguro de eliminar el registro ???";
        public static string CodigoBuscadoNoExiste = Insfor_NombreEmpresa + ": " + "Codigo Buscado no existe...!!!";
        public static string RegistroCalculadoExito = Insfor_NombreEmpresa + ": " + "El Cálculo se realizó correctamente...!!!";
        public static string RegistroCalculadoError = Insfor_NombreEmpresa + ": " + "El Cálculo se realizó con errorres, verifique...!!!";

        /// <summary>
        /// Metodo que permite definir columnas del grid
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="HeaderText"></param>
        /// <param name="StateColumn"></param>
        /// <param name="WidthColumn"></param>
        public static void CreateColumnGrid(DataGridView dgv, string HeaderText, string DataPropertyName, bool StateColumn, int WidthColumn, bool ColumnTypeCheck)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid

            if (ColumnTypeCheck)
            {
                DataGridViewCell cell = new DataGridViewCheckBoxCell();
                newCol.CellTemplate = cell;
            }
            else
            {
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                newCol.CellTemplate = cell;
            }

            newCol.HeaderText = HeaderText;
            newCol.Name = HeaderText;
            newCol.DataPropertyName = DataPropertyName;
            newCol.Visible = StateColumn;
            newCol.Width = WidthColumn;
            dgv.Columns.Add(newCol);
        }

        /// <summary>
        /// Metodo que permite convertir lista en datatable
        /// <CreadoPor>Ponciano Huarcaya C.</CreadoPor>
        /// <FechaCrea>31-12-2012</FechaCrea>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable convertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        /// <summary>
        /// Extrae cadena a partir de la izquierda
        /// </summary>
        /// <param name="strCadena"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string ExtractLeft(string strCadena, int length)
        {
            return strCadena.Substring(0, length);
        }

        /// <summary>
        /// Extrae Cadena a partir de la derecha
        /// </summary>
        /// <param name="strCadena"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string ExtractRigth(string strCadena, int length)
        {
            int valor = strCadena.Length - length;
            return strCadena.Substring(valor, length);
        }

        public static string ExtractMid(string strCadena, int StarIndex, int length)
        {
            return strCadena.Substring(StarIndex, length);
        }

        public static string ExtractMid(string strCadena, int StarIndex)
        {
            return strCadena.Substring(StarIndex);
        }

        /// <summary>
        /// Retorna Url de la ubicacion de reportes
        /// <CreadoPor>Ponciano Huarcaya C.</CreadoPor>
        /// </summary>
        /// <returns></returns>
        public static string RutaReportes
        {
            get
            {
                return Path.GetDirectoryName(Directory.GetCurrentDirectory());
            }
        }

        public static void Bind<T>(ComboBox Combo, IList<T> data, string value, string text, bool insertItemTodos)
        {
            Combo.DataSource = data;
            Combo.ValueMember = value;
            Combo.DisplayMember = text;
        }

        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #region Metodos de Validacion
        public static bool NoNumerico(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool NoDecimal(TextBox CajaTexto, KeyPressEventArgs e)
        {
            bool Retorno = false;
            if (CajaTexto.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    Retorno = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                {
                    Retorno = true;
                }
            }

            return Retorno;
        }
        #endregion
    }

    /// <summary>
    /// Clase que getiona los eventos de mantenimiento
    /// Insert, Edit, Etc.
    /// </summary>
    public class PropertyEvent
    {
        #region Enumerador Mantenimientos
        public Sisco_Mantenimiento Sisco_Property_Mantenimiento { get; set; }
        public enum Sisco_Mantenimiento
        {
            Add = 1,
            Insert = 2,
            Modify = 3,
            Cancel = 4,
            Delete = 5,
            List = 6
        };
        #endregion
    }
}