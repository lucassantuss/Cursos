import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget { // Aplicativo principal
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
        primaryColor: Colors.blue
      ),
      home: HomePage(), // Chama o widget stateless criado abaixo
    );
  }
}

class HomePage extends StatelessWidget { // Widget
  @override
  Widget build(BuildContext context) {
    return Scaffold( // Permite utilizar outros widgets no MaterialApp dele
      appBar: AppBar( // AppBar (Tela azul em cima do App)
        title: Text("Hello Flutter"),
        centerTitle: true, // Alinha o titulo
      ),
      body: Container( // Corpo do App
        color: Colors.white,
      ),
      drawer: Container( // Navegação de itens ao lado esquerdo,
        color: Colors.yellow,
      ),
      floatingActionButton: FloatingActionButton(onPressed: (){}
      ), // Botão de ação em baixo no canto direito
    );
  }
}