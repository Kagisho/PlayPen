namespace CRTP
{
    public class DerivedProblematic : BaseProblematic
    {
        public string DerivedClassProperty
        {
            get { return "Property of derived";  }
           
        }

        public override BaseProblematic Copy()
        {
            return this;
        }
    }

}