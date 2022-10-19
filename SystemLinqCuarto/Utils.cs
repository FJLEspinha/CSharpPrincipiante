using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    public static class Utils
    {
        public static void AddRangeDictionary<K,V>(Dictionary<K,V> dictionary, List<KeyValuePair<K,V>> elements)
        {
            foreach(var keyValue in elements)
            {
                dictionary.Add(keyValue.Key, keyValue.Value); 
            }
        }


        // Vamos a hacer lo anterior con metodos de extensión.

        public static void AddRange<K,V>(this Dictionary<K,V> dictionary, List<KeyValuePair<K, V>> elements)
        {
            // El código interno es identico al anterior
            // La diferencia es el this
            // Ver en program el cambio
            foreach (var keyValue in elements)
            {
                dictionary.Add(keyValue.Key, keyValue.Value);
            }
        }
    }
}
