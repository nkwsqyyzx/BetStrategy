
namespace WSQ.CSharp.Serialization
{
    public class SerializationFactory : ISerializationFactory
    {
        public FileStreamSerializer<T> GetInstance<T>()
        {
            return new JsonSerializer<T>(); 
        }
    }
}
