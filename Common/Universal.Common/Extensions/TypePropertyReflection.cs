using System;
using System.Reflection;

namespace WSQ.CSharp.Extensions
{
    public static class TypePropertyReflection
    {

	/// <summary>
	/// get the T`s propertyName property`s ComareTo Method.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="genericInstance"></param>
	/// <param name="propertyName">the property path.</param>
	/// <returns></returns>
        public static MethodInfo ComareToMethod<T>(this T genericInstance, string propertyName) where T : class,new()
        {
            Type type = genericInstance.TypeOfProperty(propertyName);
            return type.GetMethod("CompareTo", new Type[] { type });
        }

	/// <summary>
	/// get the type of property of T.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="instance"></param>
	/// <param name="propertyName"></param>
	/// <returns></returns>
        public static Type TypeOfProperty<T>(this T instance, string propertyName) where T : class ,new()
        {
            return instance.GetType().GetProperty(propertyName).GetValue(instance, null).GetType();
        }

	/// <summary>
	/// get the compare method using the specified propety path.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="instance"></param>
	/// <param name="propertyName"></param>
	/// <param name="isReverse"></param>
	/// <returns></returns>
        public static Comparison<T> ComparerFromProperty<T>(this T instance, string propertyName, bool isReverse = false) where T : class,new()
        {
            return new Comparison<T>(delegate(T x, T y)
            {
                // the property`s default compareTo Method.
                MethodInfo compareToMethod = instance.ComareToMethod(propertyName);

                // Getting current object value.
                object xValue = x.GetType().GetProperty(propertyName).GetValue(x, null);

                // Getting the next value.
                object yValue = y.GetType().GetProperty(propertyName).GetValue(y, null);

                // Comparing the current and next object value of collection.
                object result = compareToMethod.Invoke(xValue, new object[] { yValue });

                return (isReverse ? -1 : 1) * Convert.ToInt32(result);
            });
        }
    }
}