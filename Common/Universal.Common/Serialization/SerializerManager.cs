
namespace WSQ.CSharp.Serialization
{
    public class SerializationManager
    {
        private static ISerializationFactory _factory;

        public static ISerializationFactory Instance
        {
            get
            {
                return _factory ?? (_factory = new SerializationFactory());
            }
        }
    }
}
