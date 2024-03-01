namespace rm99738.Models
{
    public class Aluno : Usuario
    {
        public int Id { get; set; }
        public int Rm { get; set; }

        public Aluno(string nome,string email, int rm=0) : base(nome, email)
        {
            if(rm == 0)
            {
                Random random = new Random();
                rm = random.Next(1, 10000);
            }
            else
            {
                Rm = rm;
            }
        }

        public Aluno() { }

        public string RetornaCodigo()
        {
            return $"O RM do aluno é RM{Rm}";
        }

    }
}
