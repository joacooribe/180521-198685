using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    [Table("Colaborators")]
    public class Colaborator:User
    {
        [Key]
        public int OIDColaborator { get; set; }
        public Colaborator()
        {

        }

        public override bool Equals(object obj)
        {
            bool equal = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Colaborator colaborator = (Colaborator)obj;
                if (this.mail.Equals(colaborator.mail))
                {
                    equal = true;
                }

            }
            return equal;
        }

    }
}