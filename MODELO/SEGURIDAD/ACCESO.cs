using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.SEGURIDAD
{
    public class ACCESO
    {
     
        public int IDAcceso { get; set; }
        public string Username { get; set; }
        public string Login { get; set; }
        public DateTime FechayHoraEntrada { get; set; }
        public string Logout { get; set; }
        public DateTime FechayHoraSalida { get; set; }
        
        
       
       
    }
}


