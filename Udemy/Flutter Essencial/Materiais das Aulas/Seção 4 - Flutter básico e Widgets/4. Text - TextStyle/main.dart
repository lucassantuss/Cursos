import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
        primaryColor: Colors.blue
      ),
      home: Scaffold(
        appBar: AppBar(
          title: Text("Hello Flutter"),
        ),
        body: Container(
          color: Colors.white,
          child: Center( // Filho do container
            child: Text( // Filho do center
              "Hello World",
              style: TextStyle(
                  color: Colors.blue, // Cor do texto
                  fontSize: 30, // Tamanho da fonte
                  fontWeight: FontWeight.bold, // Fonte em negrito
                  fontStyle: FontStyle.italic, // Fonte em itálico
                  decoration: TextDecoration.underline, // Underline no texto
                  decorationColor: Colors.red, // Cor do underline
                  decorationStyle: TextDecorationStyle.wavy), // Design do underline, ondulado = wavy
            ),
          ),
        ),
      ),
    );
  }
}