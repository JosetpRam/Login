using Login.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Login.Repositorios
{
    public class UserRepository : IUserRepository
    {
        private readonly string _path;

        public UserRepository(string path)
        {
            _path = path;
        }
        public void AgregarUsuario(User user)
        {
            throw new NotImplementedException();
        }

        public void AgregarUsuario(List<User> users)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            var usuarios = ObtenerUsuarios();
            var user = usuarios.FirstOrDefault(a => a.UserName == username && a.Password == password);
            return user != null ? true : false;
        } 

                public List<User> ObtenerUsuarios()
                {
                    if (!File.Exists(_path))
                    {
                        return [];
                    }

                    using var fs = File.OpenRead(_path);
                    var items = JsonSerializer.Deserialize<List<User>>(fs);
                    return items ?? [];
                }

    }
}
