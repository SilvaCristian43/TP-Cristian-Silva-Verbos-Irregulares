using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Info
    {
        public string MostrarPlurales()
        {
            string Plurales = "A la gran mayoria de los sustantivos ingleses SE LOS CONSIDERA REGULARES y simplemente se les agrega(S) para hacerlos plurales"

             +"\r\n"+ "cat / cats"+
             "\r\n"+"toy / toys"+
             "\r\n" + "car / cars" +
             "\r\n" + "telephone / telephones" +
             "\r\n" + "chair / chairs ";
            return Plurales;
      
        }
        public string MostrarSustantivos()
        {
            string Sustantivos = "Son llamados asi ya que no hay norma o regla que debamos seguir para pluralizar"

     + "\r\n" + "Sustantivos singulares / Sustantivos plurales"+
     "\r\n" + "person /  people" +
             "\r\n" + "child / children" +
              "\r\n" + "woman / women" +
              "\r\n" + "mouse / mice" +
             "\r\n" + "moose / moose" +
              "\r\n" + "deer / deer" +
              "\r\n" + "sheep / sheep" +
              "\r\n" + "foot / feet" +
              "\r\n" + "tooth / teeth ";
            return Sustantivos;
        }
    }
}
