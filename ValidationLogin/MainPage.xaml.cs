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
        Entry txtCampo, Label lblValidation)
    {
        bool resultado = false;

        if (Validation.ValidarCampoVazio(txtCampo))
            Validation.ExibirValidation(txtCampo,
                lblValidation, "* Informe a Senha.");
        else if (txtCampo.Text.Length < 5)
            Validation.ExibirValidation(txtCampo,
                lblValidation, 
                "Informe a senha com no minimo 5 caracteres");
        else if(txtCampo.Text != "admin")
            Validation.ExibirValidation(txtCampo,
                lblValidation, "Senha incorreta.");
        else
        {
            resultado = true;
            Validation.OcultarValidation(lblValidation);
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

