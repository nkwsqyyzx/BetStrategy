
namespace WSQ.CSharp.Serialization
{
    public class SerializationFactory : ISerializationFactory
    {
        public IFileSerializer GetInstance()
        {
            return new JsonSerializer();
        }
    }
}
