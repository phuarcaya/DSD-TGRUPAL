namespace WS_ProduccionUtilitario
{
    /// <summary>
    /// <Proposito>Da funciones al mantenimiento de botones del mdi</Proposito>
    /// <CreadoPor>Ponciano Huarcaya</CreadoPor>
    /// <Fecha>19-06-2013</Fecha>
    /// </summary>
    public interface IMantenimiento
    {
        void SISCO_Mantenimiento_Nuevo();
        void SISCO_Mantenimiento_Grabar();
        void SISCO_Mantenimiento_Modificar();
        void SISCO_Mantenimiento_Cancelar();
        void SISCO_Mantenimiento_Eliminar();
        void SISCO_Mantenimiento_Listado();
        void SISCO_Mantenimiento_encolado();
    }
}
