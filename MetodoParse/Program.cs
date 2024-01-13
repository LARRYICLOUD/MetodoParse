using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            //Parse
            string cadenaAConvertir;
            Console.WriteLine("Ingresa un color perteneciente a RGB:");
            cadenaAConvertir = Console.ReadLine();
            //Variable para almacenar la devolucion del metodo (un objeto de tipo enumeracion)
            object valorEnumDevuelto;

            valorEnumDevuelto = Enum.Parse(typeof(RGB),cadenaAConvertir);

            //Variable de tipo enum "RGB" donde se va a almacenar el valor de la string
            RGB cadenaConvertidaAEnum;
            //Asignamos el objeto de tipo enum a la variablr de tipo "RGB"
            cadenaConvertidaAEnum = (RGB)valorEnumDevuelto;

        }
    }
    enum RGB
    {
        Rojo,
        Verde,
        Azul
    }

}
