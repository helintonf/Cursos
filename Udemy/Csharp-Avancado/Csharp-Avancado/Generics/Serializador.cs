using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Generics
{
    public class Serializador
    {
        /// <summary>
        /// Serializa um objeto generico
        /// </summary>
        /// <param name="obj">objeto Generico</param>
        public static void Serializar(object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\home\arquivos\" + obj.GetType().Name + ".txt");

            string objSr = JsonConvert.SerializeObject(obj);

            sw.Write(objSr);

            sw.Close();
        }

        /// <summary>
        /// Classe como generica
        /// </summary>
        /// <returns></returns>
        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader($@"C:\home\arquivos\{typeof(T).Name}.txt");

            string conteudo = sr.ReadToEnd();

            //return JsonConvert.DeserializeObject<T>(conteudo);
            return (T)JsonConvert.DeserializeObject(conteudo, typeof(T));

        }
    }
}
