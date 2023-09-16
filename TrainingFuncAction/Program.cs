using TrainingFuncAction;

//Action ne renvoie rien
//Func renvoie quelque chose

Recepteur recepteur = new();
Emetteur emetteur = new();

//----------Action----------

//on rajoute ReceptAction comme étant abonné à l'event MyAction
emetteur.MyAction += recepteur.ReceptAction;

//on execute la méthode qui va déclencher l'event MyAction
emetteur.EmetteurAction();

//----------func----------

//on rajoute ReceptFunc comme étant abonné à l'event MyFunc
emetteur.MyFunc += recepteur.ReceptFunc;

//on execute la méthode qui va déclencher l'event MyFunc
emetteur.EmetteurFunc();

