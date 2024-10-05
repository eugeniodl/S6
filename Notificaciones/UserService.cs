using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificaciones
{
    // Servicio de usuario (SRP - Maneja solo la lógica de usuarios)
    internal class UserService
    {
        public void AddUser(string username)
        {
            // Aquí podría estar la lógica de agregar un usuario a una base de datos
            MessageBox.Show("Usuario agregado: " + username);
        }
    }
}
