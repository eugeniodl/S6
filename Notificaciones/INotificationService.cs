using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificaciones
{
    internal interface INotificationService
    {
        void Send(string message);
    }
}
