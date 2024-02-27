namespace aula01
{
    public class Aluno
        
    {
        private DateTime _dataNascimento;
        private DateTime dataLimite = DateTime.Parse("31/12/1930");
        public string Prontuario { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento 
        {
            set 
            {
                if(value >= dataLimite)
                {
                    _dataNascimento = value;
                }
            }
            get 
            {
                return _dataNascimento;
            } 
        }

        public Aluno(string prontuario)
        {
            Prontuario = prontuario;
        }
        public Aluno(string nome, string prontuario, DateTime dataNascimento)
        {
            Nome = nome;
            Prontuario=prontuario;
            DataNascimento = dataNascimento;
        }

        public void ImprimirAluno()
        {
            Console.WriteLine("Nome do Aluno: " + Nome);
            Console.WriteLine("Prontuario: " + Prontuario);
            Console.WriteLine("Data de Nascimento: " + _dataNascimento);
        }
    }
}
