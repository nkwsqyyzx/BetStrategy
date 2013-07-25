using System;

namespace WSQ.CSharp.Configuration
{
    public class ConfigAttribute : Attribute
    {
        public ConfigAttribute() { }

        public ConfigAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; set; }
    }
}
