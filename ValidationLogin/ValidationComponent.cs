namespace ValidationLogin
{
    public class ValidationComponent
    {
        //Definimos nossa propriedades referente
        //ao nosso "PAR" de componentes
        private Entry EntryCampo { get; set; }
        private Label LabelValidation { get; set; }

        //Criamos um construtor para fazer o vinculo
        public ValidationComponent(Entry txtCampo, Label lblValidation) 
        {
            EntryCampo = txtCampo;
            LabelValidation = lblValidation;
        }

        public string GetText()
        { 
            return EntryCampo.Text; 
        }

        public void SetValidation(string MsgValidation)
        {
            LabelValidation.Text = MsgValidation;
            LabelValidation.IsVisible = true;
        }

        public void SetValidation(string MsgValidation, bool IsTremer)
        {
            if (IsTremer)
                Animation.Tremer(EntryCampo);
            SetValidation(MsgValidation);
        }

        public void OcultarValidation()
        {
            LabelValidation.IsVisible = false;
        }

        public bool IsVazio()
        {
            return string.IsNullOrEmpty(EntryCampo.Text);
        }
    }
}
