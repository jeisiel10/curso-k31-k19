using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        
        virtual public double CalculaBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
