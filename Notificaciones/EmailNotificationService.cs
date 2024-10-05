using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificaciones
{
    // Implementación para Email (SRP)
    internal class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            // Aquí iría la lógica real de envío de email
            MessageBox.Show("Enviando Email: " + message);
        }
    }
}
