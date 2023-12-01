void main() {
  Carro c1 = Carro("Fusca");
  Carro c2 = Carro("Brasilia");
  Carro c3 = Carro("Chevete");
  
  final carros = { "1":c1, "2":c2 };
  carros["3"] = c3;
  
  print("Lista: $carros, length: ${carros.length}");
  
  for(String id in carros.keys) {
    
    final c = carros[id];
    
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
