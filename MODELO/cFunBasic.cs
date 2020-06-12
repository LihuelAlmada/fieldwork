using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CONTROLADORA
{
    public class cFunBasic
    {

        public static bool validar_mail(string mail) 
        {
            string expresion;
            expresion = @"\A(\w+.?\w*@\w+.)(com)\Z";
            System.Text.RegularExpressions.Regex automata = new Regex(expresion);
            return automata.IsMatch(mail);
        }


    }
}
