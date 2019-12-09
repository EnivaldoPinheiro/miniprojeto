using System;

class MainClass {
   static void Main (string[] args) {
    Caixa cx = new Caixa(6);//cria a instancia da class caixa,new chama o metodo contrtor caixa que vai atribuir 10 ao campo lado,'e ele é invocado no ponto new caixa'.
    double volumecaixa;//se cria a variavel volumecaixa do tipo double
    volumecaixa = cx.Volume();//volumecaixa recebe o metodo Volume da classe caixa cx que pega o valor lado e eleva ao cubo
    Console.WriteLine (volumecaixa.ToString());
  }
  

 
}