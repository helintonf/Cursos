using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    /// <summary>
    /// Classe de Extensão
    /// </summary>
    public static class StringExtension
    {
        public static string FirstToUpper(this String str)
        {
            string first = str.Substring(0, 1);

            return first.ToUpper() + str.Substring(1);
        }
    }
}
