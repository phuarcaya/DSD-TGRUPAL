namespace WS_ProduccionUtilitario
{
    public enum EParametro
    {
        EstadoOrdenTrabajo = 1,
        AlmacenMateriales = 2,
        AlmacenProductoPerminado = 3,
        FormulaProduccion = 4
    }

    public enum EEstadoOrdenTrabajo
    {
        Pendiente = 1,
        Aprobado = 2,
        EnProcesoProduccion = 3,
        Cerrado = 4,
        Anulado = 57
    }
}
