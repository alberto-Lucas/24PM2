using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLogin
{
    //Classe normal, ou seja será instanciada
    //Onde iremos definir o nosso "PAR" 
    //de componentes
    //Ou seja iremos vincular um Entry a uma Label
    public class ValidationComponent
    {
        //São as propriedades da classe
        public Entry EntryCampo { get; set; }
        public Label LabelValidation { get; set; }

        //Criar o construtor da classe
        //e realizar o vinculo com as propriedades
        public ValidationComponent(
            Entry txtCampo, Label lblValidation)
        {
            EntryCampo = txtCampo;
            LabelValidation = lblValidation;
        }

        //Método para validar campo vazio
        public bool IsVazio()
        {
            return string.
                IsNullOrEmpty(EntryCampo.Text);
        }

        //Método para retorna a informação
        //digitada pelo usuario no campo Entry
        public string GetText()
        {
            return EntryCampo.Text;
        }

        //Método para ocultar a label de notificação
        public void OcultarValicadtion()
        {
            LabelValidation.IsVisible = false;
        }

        //Método para definir e exibir a notificação
        public void SetValidation(string MsgValidation)
        {
            LabelValidation.Text = MsgValidation;
            LabelValidation.IsVisible = true;
        }

        //Método de sobrecarga o SetValidation
        //Adicionando a animção de Tremor
        public void SetValidation(
            string MsgValidation, bool IsTremer)
        {
            if (IsTremer)
                Animation.Tremer(EntryCampo);

            SetValidation(MsgValidation);
        }
    }
}
