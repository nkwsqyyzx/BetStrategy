using System;
using System.Reflection;

namespace WSQ.CSharp.Extensions
{
    public static class ObjectPathProperty
    {
        /// <summary>
        /// return the property with property path.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="path"></param>
        /// <returns>proprety value</returns>
        /// <exception cref="System.ArgumentException">PropertyPath is invalid.</exception>
        /// <exception cref="System.NullReferenceException">the property path has null value.</exception> 
        public static object Property(this object o, string PropertyPath)
        {
            if (string.IsNullOrEmpty(PropertyPath))
            {
                throw new System.ArgumentException("PropertyPath is invalid", "PropertyPath");
            }
            object result = null;
            var ps = PropertyPath.Split('.');
            Type type = o.GetType();
            PropertyInfo info = null;
            if (ps.Length == 1)
            {
                info = type.GetProperty(ps[0]);
                result = info.GetValue(o, null);
            }
            else
            {
                result = o;
                foreach (var pro in ps)
                {
                    info = type.GetProperty(pro);
                    result = info.GetValue(result, null);
                    type = result.GetType();
                }
            }
            return result;
        }
    }
}
