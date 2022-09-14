
namespace MoviewReview.Core.Domain.Base
{
    public abstract class Entity
    {
        //reune informações comuns entre todas entidades do sistema. Para evitar duplicaçao de codigo
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
