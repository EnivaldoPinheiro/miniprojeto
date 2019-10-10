using System;

class MainClass {
  public static void Main (string[] args) {
    Banco esp = new Banco();
    esp.setNome ("Enivaldo");
    esp.setCCorrente(0001);
    esp.setSaldo(10000);

    Console.WriteLine("Entre com o nome do correntista "  + esp.getNome());
 
    Cliente nm1 = new Cliente("fisico","Pinheiro ","000.111.222.00");
    
  }
}