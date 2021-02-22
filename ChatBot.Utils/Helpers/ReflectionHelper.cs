using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ChatBot.Utils.Helpers
{
    /// <summary>
    /// Хэлпер рефлексии
    /// </summary>
    public static class ReflectionHelper
    {
        /// <summary>
        /// Получить список классов-наследников, не являющихся абстрактными классами или интерфейсами
        /// </summary>
        /// <param name="type">Тип, наследников которого необходимо получить</param>
        /// <returns>Список наследников типа</returns>
        public static IEnumerable<Type> GetImplimentationTypes(Type type)
        {
            return Assembly.GetAssembly(type)
                .GetTypes()
                .Where(i => type.IsAssignableFrom(i) && i != type && !i.IsAbstract && !i.IsInterface)
                .ToList();
        }

        /// <summary>
        /// Получить список классов-наследников, не являющихся абстрактными классами или интерфейсами
        /// </summary>
        /// <typeparam name="T">Тип, наследников которого необходимо получить</typeparam>
        /// <returns>Список наследников типа</returns>
        public static IEnumerable<Type> GetImplimentationTypes<T>()
        {
            var type = typeof(T);
            return GetImplimentationTypes(type);
        }
    }
}
