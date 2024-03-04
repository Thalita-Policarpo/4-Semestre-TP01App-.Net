namespace TP01App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Exemplo";
            pessoa.Idade = 25;
            pessoa.CPF = "123.456.789-00";

            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, CPF: {pessoa.CPF}");

            List<Pessoa> pessoas = new List<Pessoa>();

            while (true)
            {
                Console.WriteLine("1 - Adicionar Pessoa | 2 - Mostrar Pessoas");
                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Pessoa novaPessoa = new Pessoa();
                    Console.WriteLine("Digite o nome:");
                    novaPessoa.Nome = Console.ReadLine();
                    Console.WriteLine("Digite a idade:");
                    novaPessoa.Idade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o CPF:");
                    novaPessoa.CPF = Console.ReadLine();

                    pessoas.Add(novaPessoa);
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Pessoas na lista:");
                    foreach (var p in pessoas)
                    {
                        Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}, CPF: {p.CPF}");
                    }
                }
            }
        }
    }
}
