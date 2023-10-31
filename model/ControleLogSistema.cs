using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Projeto_Venda_2023.model
{
    internal class ControleLogSistema
    {
        public int Codcontrole {  get; set; }

        public Logins Logins { get; set; }

        public DateTime Datas { get; set; }

        public Timer Hora {  get; set; }
        
        public ControleLogSistema () { }
    }
}
