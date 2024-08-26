using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLogin
{
    //Classe Static ela armazena valores
    //é preciso sempre passar valores
    //via parametro
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

        static public void ExibirValidation(
            Label lblValidation, string MsgValidation)
        {
            lblValidation.Text = MsgValidation;
            lblValidation.IsVisible = true;
        }
        //Aqui criamos um método de sobrecarga(overloaded)
        //possui 2 metodos com o mesmo nome
        //diferenciando pelos parametros

        //Método para ocultar a label de notificiação
        static public void OcultarValidation(Label lblValidation)
        {
            lblValidation.IsVisible = false;
        }
    }
}
