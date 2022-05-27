using System;
using System.Runtime.CompilerServices;

namespace Biblioteca
{
    public static class StringExtendido
    {
        //Hola mundo-feliz
        
        public static int ContarPalabras(this String s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentNullException();
            }
            return s.Split(new char [] {' ','-' }).Length;
        }
    }
}
