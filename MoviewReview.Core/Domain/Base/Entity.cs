
using Microsoft.VisualBasic;

namespace MovieReview.Core.Domain.Base
{
    public abstract class Entity
    {
        //reune informações comuns entre todas entidades do sistema. Para evitar duplicaçao de codigo
        public int Id { get; private set; }
        public DateTime CreationDate { get; private set; }

        public Entity()
        {
            CreationDate = DateAndTime.Now;
        }
    }
}
