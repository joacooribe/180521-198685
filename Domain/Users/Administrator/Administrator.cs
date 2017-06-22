using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    [Table("Administrators")]
    public class Administrator:User
    { 
        public Administrator()
        {
            active = true;
        }
        
        
        public override bool Equals(object obj)
        {
            bool equal = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Administrator administrator = (Administrator)obj;
                if (this.mail.Equals(administrator.mail))
                {
                    equal = true;
                }
            }
            return equal;
        }
    }
}