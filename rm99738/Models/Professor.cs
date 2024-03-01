namespace rm99738.Models
{
    public class Professor : Usuario
    {
        public int Id { get; set; }
        public string CPF { get; set; }

        public Professor() { }

        public Professor(string nome, string email, string cpf) : base(nome, email)
        {
            CPF = cpf;
        }
    }
}
