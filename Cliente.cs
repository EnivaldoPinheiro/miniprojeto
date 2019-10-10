class Cliente{
  private string tipo;
  private string sobrenome;
  public string cpf;

  public Cliente(){

  }
  public Cliente(string tipo,string sobreNome,string cpf){

  }

  public void setTipo(string tipo){
    this.tipo = tipo;
  }
  public string getTipo(){
    return this.tipo;
  }
  public void setSobreNome(string sobreNome){
    this.sobrenome=sobreNome;
  }
  public string getSobreNome(){
    return this.sobrenome;
  }
  public void setCpf(string cpf){

  }
}