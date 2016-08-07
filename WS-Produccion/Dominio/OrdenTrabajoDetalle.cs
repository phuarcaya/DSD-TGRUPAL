using System.Runtime.Serialization;

namespace WS_Produccion
{
    [DataContract]
    public class OrdenTrabajoDetalle
    {
        [DataMember]
        public int IdOrdenTrabajo { get; set; }

        [DataMember]
        public decimal Cantidad { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int IdArticulo { get; set; }

        #region Campos externas
        [DataMember]
        public string Articulo { get; set; }
        #endregion
    }
}