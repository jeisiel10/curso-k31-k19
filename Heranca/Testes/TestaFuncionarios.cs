using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca.Modelos;

namespace Heranca.Testes

{
    class TestaFuncionarios
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Jeisiel Morais";
            g.Salario = 2000;
            g.Usuario = "jeisiel.morais";
            g.Senha = "123";

            Telefonista t = new Telefonista();
            t.Nome = "Carolina Melo";
            t.Salario = 2000;
            t.EstacaoDeTrabalho = 13;

            Secretaria s = new Secretaria();
            s.Nome = "Tatiane Andrade";
            s.Salario = 1500;
            s.Ramal = 198;

            System.Console.WriteLine(" GERENTE ");
            System.Console.WriteLine(" Nome : " + g.Nome);
            System.Console.WriteLine(" Salário : " + g.Salario);
            System.Console.WriteLine(" Usuário : " + g.Usuario);
            System.Console.WriteLine(" Senha : " + g.Senha);
            System.Console.WriteLine(" Bonificação : " + g.CalculaBonificacao());

             System.Console.WriteLine(" TELEFONISTA ");
             System.Console.WriteLine(" Nome : " + t. Nome );
             System.Console.WriteLine(" Salário : " + t. Salario );
             System.Console.WriteLine(" Estacao de trabalho : " + t. EstacaoDeTrabalho );
             System.Console.WriteLine(" Bonificação : " + t.CalculaBonificacao());

             System.Console.WriteLine(" SECRETARIA ");
             System.Console.WriteLine(" Nome : " + s. Nome );
             System.Console.WriteLine(" Salário : " + s. Salario );
             System.Console.WriteLine(" Ramal : " + s. Ramal );
             System.Console.WriteLine(" Bonificação : " + s.CalculaBonificacao());


        }
    }
}
