namespace aula01
{
    public class Livro
    {
        public int _AnoPublicacao;
        private int dataLimite = DateTime.Now.Year;
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao
        {
            set
            {
                if(value < dataLimite)
                {
                    _AnoPublicacao = value;
                }
            }
            get
            {
                return _AnoPublicacao;
            }
        }

        private bool locado;

        public Livro(string _ISBN)
        {
            ISBN = _ISBN;
        }
        public Livro(string _ISBN, string _Titulo, int _AnoPublicacao) 
        { 
            ISBN= _ISBN;
            Titulo= _Titulo;
            AnoPublicacao= _AnoPublicacao;
        }

        public void Devolver()
        {
            if (locado == true)
            {
                locado = false;
                Console.WriteLine("Devolvido com sucesso");  
            }
            else
            {
                Console.WriteLine("O livro não esta locado!");
            }
        }
        public void Retirar()
        {
            if (locado == false)
            {
                locado = true;
                Console.WriteLine("Locado com sucesso");
            }
            else
            {
                Console.WriteLine("O Livro já esta Locado!");
            }
        }

        public void ImprimirLivro()
        {
            Console.WriteLine("ISBN do livro: " + ISBN);
            Console.WriteLine("Titulo: " +  Titulo);
            Console.WriteLine("Ano de publicação: " + AnoPublicacao);
        }

    }
}
