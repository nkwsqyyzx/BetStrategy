using System;

namespace WSQ.CSharp.Configuration
{
    public interface IConfig
    {
        /// <summary>
        /// set config value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void Set(Enum key, object value);

        /// <summary>
        /// if the Enume key has unaccepted attribute,it raise exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        T Get<T>(Enum key);

	/// <summary>
	/// return the value of the key.if no key,return nkv
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="key">the key</param>
	/// <param name="nkv">if no key.return nkv</param>
	/// <returns></returns>
        T Get<T>(Enum key,T nkv);
    }
}
