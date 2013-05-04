using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WSQ.CSharp.Serialization;

namespace WSQ.CSharp.Configuration
{
    public class ConfigurationManager : IConfig
    {
        private SerializableDictionary<string, object> configs;
        private static string DEFAULT_CONFIGURATION_FILE = "configuration.json.txt";

        private FileStreamSerializer<SerializableDictionary<string, object>> serializer = new JsonSerializer<SerializableDictionary<string, object>>();

        private static Dictionary<string, IConfig> savedConfigurationManagers = new Dictionary<string, IConfig>();
        private string configurationFile;

        private ConfigurationManager(string configurationFile,Action<IConfig> initWhenNOFile)
        {
            this.configurationFile = configurationFile;
            Load(initWhenNOFile);
        }

        public static IConfig GetInstance(string configurationFile = null,Action<IConfig> initWhenNOFile = null)
        {
            if (configurationFile == null)
                configurationFile = DEFAULT_CONFIGURATION_FILE;
            IConfig config = null;
            if (savedConfigurationManagers.ContainsKey(configurationFile))
            {
                config = savedConfigurationManagers[configurationFile];
            }
            else
            {
                config = new ConfigurationManager(configurationFile,initWhenNOFile);
                savedConfigurationManagers[configurationFile] = config;
            }
            return config;
        }

        private void Load(Action<IConfig> initWhenNOFile)
        {
            configs = serializer.Deserialize(configurationFile);
            if (configs == null)
            {
                configs = new SerializableDictionary<string, object>();
                if (initWhenNOFile != null)
                {
                    initWhenNOFile(this);
                }
                Save();
            }
        }

        private void Save()
        {
            serializer.Serialize(configurationFile, configs);
        }

        private void CheckKeyAttribute(Enum key, Type mappingType)
        {
            MemberInfo[] mi = key.GetType().GetMember(key.ToString());
            if (mi == null || mi.Length == 0)
                throw new ArgumentException("You should config the Enum Attribute.");
            ConfigAttribute attr = Attribute.GetCustomAttribute(mi[0], typeof(ConfigAttribute)) as ConfigAttribute;
            if (attr == null)
                throw new ArgumentException(string.Format("Configuration has no type：{0}", key.ToString()));
            if (attr.Type != mappingType)
                throw new ArgumentException(string.Format("Configuration has wrong type Attribute：Declared Type:{0} Requeted Type:{1}", attr.Type.Name, mappingType.Name));
        }

        private string Key(Enum key)
        {
            return key.ToString();
        }

        public void Set(Enum key, object value)
        {
            CheckKeyAttribute(key, value.GetType());
            configs[Key(key)] = value;
            Save();
        }

        public T Get<T>(Enum key)
        {
            return Get<T>(key, default(T));
        }

        public T Get<T>(Enum key, T nkv)
        {
            CheckKeyAttribute(key, typeof(T));
            if (configs.ContainsKey(Key(key)))
            {
                var kv = configs[Key(key)];
                if (kv is T)
                {
                    return (T)configs[Key(key)];
                }
                else if (kv is JObject)
                {
                    return JsonConvert.DeserializeObject<T>(kv.ToString());
                }
                else
                {
                    throw new ArgumentException("Wrong Configuration Key Value Pair.");
                }
            }
            else if (nkv != null)
            {
                Set(key, nkv);
            }
            return nkv;
        }
    }
}
