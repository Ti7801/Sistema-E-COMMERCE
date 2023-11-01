
namespace PRODUTOS
{
    internal abstract class Entidade 
    {
        public Guid Id { get; set; }

        protected Entidade(Guid id)
        {
            Id = Guid.NewGuid();
        }
    }
}
