import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget { // stateless = estado estático, imutavel
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false, // Desmarca a marca d'agua do DebugMode no emulador
      theme: ThemeData(
        primaryColor: Colors.blue // Cor do tema
      ),
      home: Container(
        color: Colors.white, // Cor do fundo Container
      ),
    );
  }
}