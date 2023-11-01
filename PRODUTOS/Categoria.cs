
namespace PRODUTOS
{
    internal class Categoria
    {
        public string Nome { get; set; }
        public int Codigo { get;  set; }
        public List<Produto> Produtos { get; set; }

        
        public Categoria(string nome, int codigo) 
        {
            Nome = nome;
            Codigo = codigo;
            Produtos = new List<Produto>();
        }

        public override string ToString()
        {
            return "Nome: " + Nome + '\n' +
                   "Código: " + Codigo;
        }







    }
}
