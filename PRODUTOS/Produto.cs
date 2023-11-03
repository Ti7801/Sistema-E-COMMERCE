
namespace PRODUTOS
{
    internal class Produto : Entidade
    {

        public string Nome { get; set; }    
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Dimensões Dimensoes { get; set; }
        public Categoria Categoria { get; set; }    


        public Produto(string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro,               int quantidadeEstoque, Dimensões dimensoes, Categoria categoria) 
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            QuantidadeEstoque = quantidadeEstoque;
            Dimensoes = dimensoes;
            Categoria = categoria;
        }

        public void Ativar()
        {
            Ativo = true;
        }

        public void Desativar()
        {
            Ativo = false;   
        }

        public void AlterarCategoria(Categoria novaCategoria)
        {
            Categoria = novaCategoria;
        }

        public void AlterarDescricao(string novaDescricao)
        {
            Descricao = novaDescricao;   
        }

        public void DebitarEstoque(int quantidade)
        {
            QuantidadeEstoque = QuantidadeEstoque - quantidade; 
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque = QuantidadeEstoque + quantidade;
        }
        public bool PossuiEstoque(int quantidade)
        {
            if (QuantidadeEstoque == quantidade)
            {
                return true;    
            }
            return false;
        }
    }
}
