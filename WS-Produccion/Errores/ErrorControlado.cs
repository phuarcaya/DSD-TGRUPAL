using System.Runtime.Serialization;
namespace WS_Produccion.Errores
{
    /// <summary>
    /// <Proposito>Clase que gestiona los errores controlados</Proposito>
    /// <Detalle>Ejemplo: Devolver mensaje de codigo repetido, stock insuficiente, etc</Detalle>
    /// </summary>
    [DataContract]
    public class ErrorControlado
    {
        [DataMember]
        public string Codigo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}