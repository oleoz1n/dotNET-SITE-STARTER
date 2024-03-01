namespace rm99738.Models
{
    public class Usuario
    {
        private string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        protected int Codigo { get; set; }
        public DateTime DataNascimento { get; set; }



        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public Usuario (){}
        
        public void SetNome(string nome)
        {
            if (nome == "")
            {
                throw new ArgumentNullException("O nome esta vazio");
            }
            Nome = nome;
        }

        public string GetNome()
        {
            return $"O nome do aluno é {Nome}";
        }


    }
}
