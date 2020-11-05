using TestsCandidates.Domain.Interfaces.BaseTypes;

namespace TestsCandidates.Domain.Interfaces.Test1
{
    public interface ITest1
        : IBaseTests
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="payload">contain a serialized list of person with two properties Age and Name</param>
        /// <returns></returns>
        public new IBaseRequest Handle(IBasePayload payload);
    }
}
