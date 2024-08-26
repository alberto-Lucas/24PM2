using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLogin
{
    //Classe statica onde não é preciso realizar
    //a instancia para ser utilizada
    //dessa forma é sempre preciso passar
    //os valores via parametros
    public static class Validation
    {
        //Método generico para validar campo Entry vazio
        static public bool ValidarCampoVazio(Entry txtCampo)
        {
            return string.IsNullOrEmpty(txtCampo.Text);
        }

        //Método generico, para exibir uma mensagem
        //personalazida na Label de notificação
        static public void ExibirValidation(Entry txtCampo,
            Label lblValidation, string MsgValidation)
        {
            Animation.Tremer(txtCampo);
            ExibirValidation(lblValidation, MsgValidation);
        }

        //Aqui criamos um metodo de sobrecarga(overload)
        //possui 2 metodos com o mesmo nome, porém com parametro diferentes
        static public void ExibirValidation(Label lblValidation, string MsgValidation)
        {
            lblValidation.Text = MsgValidation;
            lblValidation.IsVisible = true;
        }


        //Método para ocultar a label de notificiação
        static public void OcultarValidation(Label lblValidation)
        {
            lblValidation.IsVisible = false;
        }
    }
}