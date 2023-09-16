using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingFuncAction
{
    public class Emetteur
    {
        public event Action<string> MyAction = null;

        public event Func<int, int, int> MyFunc = null;

        public void EmetteurAction()
        {
            if (MyAction != null)
            {
                //déclencheur de l'event MyAction qui passe le message en paramètre à l'abonné, ReceptAction ici
                MyAction.Invoke("mon message envoyé en paramètre");
            }
        }

        public void EmetteurFunc()
        {
            if (MyFunc != null)
            {
                //déclencheur de l'event MyFunc qui passe 4 et 5 en paramètre à l'abonné, ReceptFunc ici
                Console.WriteLine(MyFunc.Invoke(4, 5));
            }
        }
    }
}
