using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMVVM.ViewModels
{
    //Importar bibliotecas:
    //ComponentModel
    //Runtime.CompilerService

    //Classes abistrata é uma classe
    //que não pode ser instanciada
    //É carregada em memoria, ao inicar o app

    //Ou seja iniciou o app, ja carrega em memoria
    
    //Herdar da classe de notificação
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        //Evento do observador
        //Ou um evento publico herdado,
        //q monitora a alteração da propriedade
        public event 
            PropertyChangedEventHandler 
                PropertyChanged;

        //Criamos é metodo de observação

        //CallerMemberName é usado para identificar
        //o nome da propriedade (Email, Senha, CPF...)
        //de maneira automatica
        public void OnPropertyChanged(
           [CallerMemberName] string propertyName = "")
        {
            //Se a propriedade foi alterada
            //disparamos a notificação

            //Ou seja se recebmos o CPF via parametro
            //Iremos validar se o CPF foi alterado
            //se sim, iremos disparar o evento
            //de notificação para o CPF
            PropertyChanged?.Invoke(
                this, 
                new PropertyChangedEventArgs(
                    propertyName));
        }
    }
}
