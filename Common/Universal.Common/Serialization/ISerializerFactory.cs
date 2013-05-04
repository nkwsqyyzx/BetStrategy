
namespace WSQ.CSharp.Serialization
{
    public interface ISerializationFactory
    {
        FileStreamSerializer<T> GetInstance<T>();
    }
}
