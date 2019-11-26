using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Hubs
{
    public class Intercambio: Hub
    { 
        public async Task MensajeEnviado(string user, string mensaje)
        {
            Console.WriteLine("mensaje enviado con" + mensaje);
            await Clients.Others.SendAsync("EnviandoMensaje", user, mensaje);
        }
    }
}
