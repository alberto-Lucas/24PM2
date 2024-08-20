namespace ValidationLogin;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    //Criamos um método generico que
    //ira receber um componente do tipo Entry
    //como parametros, e iremos aplicar 
    //uma animção de tremor
    //Podemos aplicar esta animação em qualquer
    //componente do tipo Entry(txt)
    private async void TremerEntry(Entry txtCampo)
    {
        uint tempo = 50;

        await txtCampo.TranslateTo(-15, 0, tempo);
        await txtCampo.TranslateTo(15, 0, tempo);
        await txtCampo.TranslateTo(-10, 0, tempo);
        await txtCampo.TranslateTo(10, 0, tempo);
        await txtCampo.TranslateTo(-5, 0, tempo);
        await txtCampo.TranslateTo(5, 0, tempo);
        txtCampo.TranslationX = 0;
    }
    //Criamos um método generico
    //parar validar campos do tipoe Entry
    //E exibit a Label de notificação 
    //vinculada ao campo
    private void ValidarCamposComValidation(
        Entry txtCampo, Label lblValidation)
    {
        if(string.IsNullOrEmpty(txtCampo.Text))
        {
            TremerEntry(txtCampo);
            lblValidation.IsVisible = true;
        }
        else
            lblValidation.IsVisible = false;
    }

    //Método generico, para exibir uma mensagem
    //personalazida na Label de notificação
    private void ExibirValidation(Entry txtCampo,
        Label lblValidation, string MsgValidation)
    {
        TremerEntry(txtCampo);
        lblValidation.Text = MsgValidation;
        lblValidation.IsVisible = true;
    }

    //Método para ocultar a label de notificiação
    private void OcultarValidation(Label lblValidation)
    { 
        lblValidation.IsVisible = false; 
    }

    //Método generico para validar campo Entry vazio
    private bool ValidarCampoVazio(Entry txtCampo)
    {
        return string.IsNullOrEmpty(txtCampo.Text);
    }

    private bool ValidarEmail(
        Entry txtCampo, Label lblValidation)
    {
        bool resultado = false;

        if (ValidarCampoVazio(txtCampo))
            ExibirValidation(txtCampo,
                lblValidation, "* Informe o Email.");
        else if(!txtCampo.Text.Contains("@"))
            ExibirValidation(txtCampo,
                lblValidation, "Email inválido.");
        else if(txtCampo.Text != "admin@admin")
            ExibirValidation(txtCampo,
                lblValidation, "Email não encontrado.");
        else
        {
            resultado = true;
            OcultarValidation(lblValidation);
        }

        return resultado;
    }

    private bool ValidarSenha(
        Entry txtCampo, Label lblValidation)
    {
        bool resultado = false;

        if (ValidarCampoVazio(txtCampo))
            ExibirValidation(txtCampo,
                lblValidation, "* Informe a Senha.");
        else if (txtCampo.Text.Length < 5)
            ExibirValidation(txtCampo,
                lblValidation, 
                "Informe a senha com no minimo 5 caracteres");
        else if(txtCampo.Text != "admin")
            ExibirValidation(txtCampo,
                lblValidation, "Senha incorreta.");
        else
        {
            resultado = true;
            OcultarValidation(lblValidation);
        }

        return resultado;
    }

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {
        ValidarEmail(txtEmail, lblValidationEmail);
        ValidarSenha(txtSenha, lblValidationSenha);
        //ValidarCamposComValidation(txtSenha, lblValidationSenha);
    }
}

