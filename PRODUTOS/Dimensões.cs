
namespace PRODUTOS
{
    internal class Dimensões
    {
        public decimal Altura { get; set; } 
        public decimal Largura { get; set; }    
        public decimal Profundidade { get; set; }   


        public Dimensões(decimal altura, decimal largura, decimal profundidade) 
        {
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }

        public override string ToString()
        {
            return "Altura: " + Altura
                 + "Largura: " + Largura
                 + "Profundidade: " + Profundidade;
        }
    }
}
