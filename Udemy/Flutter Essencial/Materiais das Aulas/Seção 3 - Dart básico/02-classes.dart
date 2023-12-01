void main() {
  
  Pessoa p = Pessoa("Ricardo");
  
  int c = Calculadora.soma(1, 2);
  
  print("Soma: $c");
  print("Nome: ${p.nome}");
}

class Pessoa {
  String nome;
  
  Pessoa(this.nome);
}

class Calculadora {
  static soma( a, b) {
    return a + b;
  }
}