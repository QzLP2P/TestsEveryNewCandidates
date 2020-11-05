namespace TestsCandidates.Domain.Interfaces.BaseTypes
{
    public interface IBaseTests
    {
        public IBaseRequest Handle(IBasePayload payload);
    }
}
