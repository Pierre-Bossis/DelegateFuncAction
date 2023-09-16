using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingFuncAction
{
    public class Recepteur
    {
        public void ReceptAction(string s)
        {
            //receptionne le message de EmetteurAction par le biais de l'event MyAction
            Console.WriteLine(s);
        }

        public int ReceptFunc(int numb1, int numb2)
        {
            //receptionne le numb1 et numb2 de EmetteurFunc par le biais de l'event MyFunc
            return numb1 * numb2;
        }
    }
}
