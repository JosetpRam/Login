using Login.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Repositorios
{
    public interface IUserRepository
    {
        List<User> ObtenerUsuarios();

        bool Login(string username, string password);

        void AgregarUsuario(List<User> users);
        void Login(object userName, object password);
    }
}
