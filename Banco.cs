class Banco{
  private string nome;
  private int ccorrente;
  private double saldo;

  public Banco(){
    
  }
  public Banco(string nome,int ccorrente,double saldo){

  }
  
  public void setNome(string nome){
    this.nome = nome;
    
  }
  public string getNome(){
    return this.nome;
  }
  public void setCCorrente(int ccorrente){
    this.ccorrente = ccorrente;
  }
  public int getCCorrente(){
    return this.ccorrente;
  }
  public void setSaldo(double saldo){
    this.saldo = saldo;
  }
  public double getSaldo(){
    return this.saldo;
  }
  
  
}
