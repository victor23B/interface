public class Pessoa
{
    // Atributos privados
    private string _nome;
    private int _idade;
    private string _telefone;
    private string _endereco;
    private string _email;

    // Propriedade Nome
    public string Nome
    {
        get { return _nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            _nome = value;
        }
    }

    // Propriedade Idade
    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser negativa.");
            }
            _idade = value;
        }
    }

    // Propriedade Telefone
    public string Telefone
    {
        get { return _telefone; }
        set { _telefone = value; }
    }

    // Propriedade Endereco
    public string Endereco
    {
        get { return _endereco; }
        set { _endereco = value; }
    }

    // Propriedade Email
    public string Email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O e-mail não pode ser vazio.");
            }
            _email = value;
        }
    }
}


class Program
{
    static void Main()
    {
        try
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = "Jose victor martins",
                Idade = 22,
                Telefone = "9876-5432",
                Endereco = "Avenida Brasil, 100",
                Email = "Vitor@example.com"
            };

            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}