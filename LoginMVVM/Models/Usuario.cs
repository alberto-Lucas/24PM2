using SQLite;

namespace LoginMVVM.Models
{
    public class Usuario
    {
        //Cada [] antes da propriedade, eh a config da propriedade
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
