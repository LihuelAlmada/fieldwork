using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.SEGURIDAD
{
    public class AUDITORIA
    {
        public int IDAuditoria { get; set; }
        public DateTime FechayHora { get; set; }
        public string Movimiento { get; set; }
        public string Username { get; set; }
        public string Descripcion { get; set; }
        public string Permiso { get; set; }
    }
}
