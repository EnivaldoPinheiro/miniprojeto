//Crie um programa em C# que calcule o resto da divisão inteira entre dois números por meio de sucessivas subtrações.
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o dividendo: ");
    int dividendo = int.Parse( Console.ReadLine() );
    Console.WriteLine("Digite o divisor: ");
    int divisor = int.Parse( Console.ReadLine() );
    Console.WriteLine("\n O resto da divisão é : "+ recursivo(divisor, dividendo));
  }

  public static int recursivo(int divisor, int dividendo){
    if(dividendo < divisor){
      Console.Write( "Resultado: "+dividendo );
      return dividendo;
    }
    else{
      Console.Write( String.Format("{0} - {1} = {2} | ", dividendo, divisor, (dividendo-divisor) ) );
      return recursivo(divisor, dividendo-divisor);
    }
      
  }
}