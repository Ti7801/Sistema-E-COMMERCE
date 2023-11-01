
namespace PRODUTOS
{
    internal class Categoria
    {
        public string Nome { get; set; }
        public int Codigo { get; private set; }
        public List<Produto> produtos { get; private set; }

        public Categoria(string nome, int codigo) 
        {
            Nome = nome;
            Codigo = codigo;
            produtos = new List<Produto>();
        }

        public override string ToString()
        {
            return "Nome: " + Nome + '\n' +
                   "Código: " + Codigo;
        }







    }
}
