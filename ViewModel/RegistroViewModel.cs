using CommunityToolkit.Mvvm.ComponentModel;
using Login.Model;
using Login.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Login.ViewModel
{
    public partial class RegistroViewModel : ObservableObject
    {
        private readonly IUserRepository _userRepository;

        public RegistroViewModel(IUserRepository userRepository)
        { 
          _userRepository = userRepository;
        }

        [ObservableProperty]
        private UserLogin userLogin;
        public void Login("ArRamirez", 123)
        {
            var success = _userRepository.Login(UserLoginView.UserName, UserLoginView.Password);
            if (success)
            {
                MessageBox.Show("Usuario Valido");
            }else
            {
                MessageBox.Show("Fallido");
            }
        }

        private void AgregarUsuario()
        {
            var newUsuario = new User("aron@aron", "Aron", "ArRamirez", "123");
            var listaUsuarios = new List<User>();
            {
                newUsuario,
                newUsuario,
                newUsuario,
                newUsuario,
            };
            _userRepository.AgregarUsuario(listaUsuarios);
        }
    }
}
