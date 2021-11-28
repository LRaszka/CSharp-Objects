using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Basics
{
    /// <summary>
    /// Třída reprezentuje zdravič, který slouží ke zdravení uživatelů
    /// </summary>
    class Zdravic
    {
        /// <summary>
        /// Text pozdravu
        /// </summary>
        public string text;
        public void Pozdrav(string jmeno)
        {
            Console.WriteLine("{0} {1}", text, jmeno);
        }

        /// <summary>
        /// Pozdraví uživatele textem pozdravu a jeho jménem
        /// </summary>
        /// <param name="jmeno">Jméno uživatele</param>
        /// <returns>Text s pozdravem</returns>
        public string Pozdrav2(string jmeno)
        {
            return String.Format("{0} {1}", text, jmeno);
        }
    }
}
