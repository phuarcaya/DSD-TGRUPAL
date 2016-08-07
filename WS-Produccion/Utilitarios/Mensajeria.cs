using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using WS_Produccion.Persistencia;
using WS_ProduccionUtilitario;

namespace WS_Produccion
{
    public class Mensajeria
    {
        public void EscribirMensaje(OrdenTrabajo ordenTrabajo)
        {
            string rutaCola = @".\private$\OrdenTrabajo";
            if (!MessageQueue.Exists(rutaCola))
            {
                MessageQueue.Create(rutaCola);
            }

            MessageQueue cola = new MessageQueue(rutaCola);
            Message mensaje = new Message();
            mensaje.Label = "Error de registro de orden de trabajo";
            mensaje.Body = new OrdenTrabajo()
            {
                Id = ordenTrabajo.Id,
                Fecha = DateTime.Now,
                FechaRegistro = ordenTrabajo.FechaRegistro,
                Activo = true
            };
            cola.Send(mensaje);
        }

        public void AnularOrdenTrabajo()
        {
            string rutaCola = @".\private$\OrdenTrabajo";

            if (!MessageQueue.Exists(rutaCola)) { MessageQueue.Create(rutaCola); }

            MessageQueue queue = new MessageQueue(rutaCola);
            Message[] msgs = queue.GetAllMessages();

            foreach (Message msg in msgs)
            {
                msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(OrdenTrabajo) });
                queue.Receive();
                OrdenTrabajo ordenTrabajo = (OrdenTrabajo)msg.Body;
                ordenTrabajo.IdEstado = EEstadoOrdenTrabajo.Anulado.GetHashCode();
                new OrdenesDao().Crear(ordenTrabajo);
            }

        }
    }
}