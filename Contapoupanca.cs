class Contapoupanca : Conta {
private float tx_movimentacao;

public Contapoupanca(string t, string n, float tx)
:base (t,n)
{
tx_movimentacao = tx;
}
  public bool Sacar(float vlr_saque){
    float aux = vlr_saque + tx_movimentacao;
    return base.Sacar(aux);
  }
}