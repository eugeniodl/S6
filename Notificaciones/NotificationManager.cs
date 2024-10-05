using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificaciones
{
    // Gestor de notificaciones para manejar el envío (DIP)
    internal class NotificationManager
    {
        private readonly INotificationService _notificationService;

        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Notify(string message)
        {
            _notificationService.Send(message);
        }
    }
}
