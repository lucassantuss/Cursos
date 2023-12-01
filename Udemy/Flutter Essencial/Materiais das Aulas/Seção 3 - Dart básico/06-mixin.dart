void main() {
  Carro c1 = Carro("Fusca");
  c1.acelerar(100);
  c1.abastecer(50);
  print(c1);
}

class Carro extends Automovel with Combustivel {
  String nome;
  Carro(this.nome);
  
  void acelerar(int velocidade) {
    print("Acelerando com $velocidade km/h");
  }
  
  String toString() => nome;
}

abstract class Automovel {
  void acelerar(int velocidade);
}

class Combustivel {
  abastecer(int qtde) {
    print("Abastecendo $qtde L");
  }
}