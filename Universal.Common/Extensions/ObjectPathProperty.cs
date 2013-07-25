using System;
using System.Collections.Generic;
using System.Linq;
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

	/// <summary>
	/// strong type value of property path.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="o"></param>
	/// <param name="PropertyPath"></param>
	/// <returns></returns>
        public static T Property<T>(this object o, string PropertyPath)
        {
            T result = default(T);
            try
            {
                result = (T)o.Property(PropertyPath);
            }
            catch (Exception ex)
            {
                System.Console.Out.WriteLine("Property<T> raise exception:" + ex.Message);
            }
            return result;
        }

        /// <summary>
        /// the properties with specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<string> Properties<T>(this Type type)
        {
            var ps = type.GetProperties();
            foreach (var p in ps)
            {
                if (p.PropertyType == typeof(T))
                {
                    yield return p.Name;
                }
            }
        }

	/// <summary>
	/// all properties.
	/// </summary>
	/// <param name="type"></param>
	/// <returns></returns>
        public static IEnumerable<string> Properties(this Type type)
        {
            var ps = type.GetProperties();
            foreach (var p in ps)
            {
                yield return p.Name;
            }
        }

	/// <summary>
	/// set property name.
	/// </summary>
	/// <param name="o"></param>
	/// <param name="PropertyPath"></param>
	/// <param name="value"></param>
        public static void SetProperty(this object o, string PropertyPath,object value)
        {
            if (string.IsNullOrEmpty(PropertyPath))
            {
                throw new System.ArgumentException("PropertyPath is invalid", "PropertyPath");
            }
            object result = null;
            var ps = PropertyPath.Split('.');
	    object c = o;
            Type type = o.GetType();
            PropertyInfo info = null;
            if (ps.Length == 1)
            {
                info = type.GetProperty(ps[0]);
		c = o;
            }
            else
            {
                result = o;
                foreach (var pro in ps)
                {
                    info = type.GetProperty(pro);
                    c = result;
                    result = info.GetValue(result, null);
                    type = result.GetType();
                }
            }
            info.SetValue(c,value,null);
        }
    }
}
