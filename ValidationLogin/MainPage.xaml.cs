namespace ValidationLogin;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
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
            Animation.Tremer(txtCampo);
            lblValidation.IsVisible = true;
        }
        else
            lblValidation.IsVisible = false;
    }




    private bool ValidarEmail(
        Entry txtCampo, Label lblValidation)
    {
        bool resultado = false;

        if (Validation.ValidarCampoVazio(txtCampo))
            Validation.ExibirValidation(txtCampo,
                lblValidation, "* Informe o Email.");
        else if(!txtCampo.Text.Contains("@"))
            Validation.ExibirValidation(txtCampo,
                lblValidation, "Email inválido.");
        else if(txtCampo.Text != "admin@admin")
            Validation.ExibirValidation(txtCampo,
                lblValidation, "Email não encontrado.");
        else
        {
            resultado = true;
            Validation.OcultarValidation(lblValidation);
        }

        return resultado;
    }

    private bool ValidarSenha(
        ValidationComponent Senha)
    {
        bool resultado = false;

        if (Senha.IsVazio())
            Senha.SetValidation("* Informe a Senha.", true);
        else if (Senha.GetText().Length < 5)
            Senha.SetValidation(
                "Informe a senha com no minimo 5 caracteres", true);
        else if (Senha.GetText() != "admin")
            Senha.SetValidation("Senha incorreta!", true);
        else
        {
            Senha.OcultarValicadtion();
            resultado = true;
        }

        return resultado;
    }

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {
        //Cria o vinculo entre o Entry e Label
        //Instancia a classe de validação
        ValidationComponent senha =
            new ValidationComponent(txtSenha, lblValidationSenha);

        ValidarEmail(txtEmail, lblValidationEmail);
        ValidarSenha(senha);
    }
}

