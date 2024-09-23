using LoginMVVM.Models;
using LoginMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginMVVM.ViewModels
{
    public class PrincipalViewModel : UsuarioViewModel
    {
        #region properts

        //Propriedade do componente RefreshView para exibir icone de carregamento
        bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        #endregion


        public PrincipalViewModel()
        {
            CarregarUsuarios();
        }

    }
}
