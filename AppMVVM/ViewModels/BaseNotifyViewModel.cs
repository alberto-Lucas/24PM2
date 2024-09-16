using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMVVM.ViewModels
{
    //é precisso importat a biblioteca ComponentModel
    //using System.ComponentModel;

    //classe abstrata é uma classe que não pode ser instanciada diretamente,
    //ou seja, não é possível criar objetos a partir dela

    //Nossa classe irá herdar da Interface INotifyPropertyChanged
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        //Evento publico herdado da classe
        public event PropertyChangedEventHandler? PropertyChanged;

        //CallerMemberName usado para identificar automaticamente
        //o nome da propriedade alterada
        //Para usso do CallerMemberName é preciso impostar a biblioteca Runtime.CompilerServices
        //using System.Runtime.CompilerServices;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //Se a propridade for alterada irá disparar o evento de notificação
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
