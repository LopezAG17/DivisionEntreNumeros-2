using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionEntreNumeros
{
    public class HMenu
    {
        public static string nCia = "ITLA";
        public static string pc = "  )   PC - " + System.Environment.MachineName;
        public static string cia = " ITLA - Programación I   (  ";
        public static string SerialNumber = "No Tiene";
        public static string pathPicture = @"\Imagenes\nutriciosa.jpg";
    }

    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
