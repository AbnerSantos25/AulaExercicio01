namespace aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno("Abner", "22222", DateTime.Parse("25/09/2001"));

            var livro1 = new Livro("55sbn", "Cao covarde", 2023);

            livro1.Retirar();
            //livro1 .Retirar();
            //teste
            //livro1.ImprimirLivro();
        }

    }
}
