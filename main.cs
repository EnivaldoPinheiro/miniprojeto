using System;
using System.Collections.Generic;



class MainClass {
  public static void Main (string[] args) {

    Cartao meuCard = new Cartao(350);
    Maquina maquininha = new Maquina("CINEMA");
    
    if (maquininha.inserirCartao(45, meuCard)){
      Console.WriteLine("COMPRA REALIZADA");
    }
    else{
      Console.WriteLine("COMPRA NEGADA");
    }
  
    
   

  }
}