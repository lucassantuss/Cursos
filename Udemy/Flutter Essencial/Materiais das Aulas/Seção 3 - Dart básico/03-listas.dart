void main() {
  Carro c1 = Carro("Fusca");
  Carro c2 = Carro("Brasilia");
  Carro c3 = Carro("Chevete");
  
  final carros = [c1, c2, c3];
//   carros.add(c1);
//   carros.add(c2);
//   carros.add(c3);
  
  print("Lista: $carros, length: ${carros.length}");
  
  for(Carro c in carros) {
    print(" >> ${c.nome}");
  }
}

class Carro {
  String nome;
  
  Carro(this.nome);
  
  String toString() {
    return nome;
  }
}
