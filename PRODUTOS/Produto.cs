﻿
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


        public Produto(Guid id, string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro, int quantidadeEstoque, Dimensões dimensoes, Categoria categoria) : base(id)
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            QuantidadeEstoque = quantidadeEstoque;
            Dimensoes = dimensoes;
            Categoria = categoria;
            Id = id;

        }

        public void Ativar()
        {

        }

        public void Desativar()
        {

        }

        public void AlterarCategoria(Categoria novaCategoria)
        {

        }

        public void AlterarDescricao(string novaDescricao)
        {

        }

        public void DebitarEstoque(int quantidade)
        {

        }

        public void ReporEstoque(int quantidade)
        {

        }
        public bool PossuiEstoque(int quantidade)
        {
            return false;
        }
    }
}
