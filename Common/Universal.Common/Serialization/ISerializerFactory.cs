
namespace WSQ.CSharp.Serialization
{
    public interface ISerializationFactory
    {
        IFileSerializer GetInstance();
    }
}
