using System;
using WSQ.CSharp.Configuration;

namespace WSQ.CSharp.Configuration
{
    public static class EnumKeyForConfiguration
    {
        public static T Get<T>(this Enum key, IConfig config = null)
        {
            if (config != null)
            {
                return config.Get<T>(key);
            }
            else
            {
                return ConfigurationManager.GetInstance().Get<T>(key);
            }
        }

        public static T Get<T>(this Enum key, IConfig config = null, T nkv = default(T))
        {
            if (config != null)
            {
                return config.Get<T>(key, nkv);
            }
            else
            {
                return ConfigurationManager.GetInstance().Get<T>(key, nkv);
            }
        }

        public static void Set(this Enum key, object value, IConfig config = null)
        {
            if (config != null)
            {
                config.Set(key, value);
            }
            else
            {
                ConfigurationManager.GetInstance().Set(key, value);
            }
        }
    }
}
