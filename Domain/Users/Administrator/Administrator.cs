namespace Domain
{
    public class Administrator:User
    {
        public Administrator()
        {

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