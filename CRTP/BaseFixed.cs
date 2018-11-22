namespace CRTP
{
    // This addresses the problem of having to downcast every time a copy is created
    public abstract class BaseFixed<TDerived> where TDerived : BaseFixed<TDerived>
    {
        public abstract TDerived Copy();
    }
}