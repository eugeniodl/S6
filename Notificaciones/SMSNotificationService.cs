using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificaciones
{
    // Implementación para SMS (SRP)
    internal class SMSNotificationService : INotificationService
    {
        public void Send(string message)
        {
            // Aquí iría la lógica real de envío de SMS
            MessageBox.Show("Enviando SMS: " + message);
        }
    }
}
