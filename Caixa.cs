class Caixa{
  private double lado;//campo
  
  public Caixa(){//metodo construtor
    lado = 10;//inicializa as variaveis
  }
  public Caixa(double qualquerlado){//criação de construtor sobrecarregado
    lado = qualquerlado;
  }
  
   public double Volume(){//metodo volume 
    return lado * lado * lado;
  }
   
}
