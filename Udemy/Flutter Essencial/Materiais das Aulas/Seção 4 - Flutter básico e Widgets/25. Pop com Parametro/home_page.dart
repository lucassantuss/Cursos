import 'package:flutter/material.dart';
import 'package:flutter_hello/pages/hello_page1.dart';
import 'package:flutter_hello/pages/hello_page2.dart';
import 'package:flutter_hello/pages/hello_page3.dart';

class HomePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Hello Flutter"),
      ),
      body: _body(context),
    );
  }

  _body(context) {
    return Container(
      color: Colors.white,
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          _text(),
          _pageView(),
          _buttons(context)
        ],
      ),
    );
  }

  _pageView() {
    return Container(
      margin: EdgeInsets.only(top:20, bottom: 20),
      height: 300,
      child: PageView(
        children: <Widget>[
          _img("assets/images/dog1.png"),
          _img("assets/images/dog2.png"),
          _img("assets/images/dog3.png"),
          _img("assets/images/dog4.png"),
          _img("assets/images/dog5.png")
        ],
      ),
    );
  }

  _buttons(context) {
    return Column(
      children: <Widget>[
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: <Widget>[
            _button(context,"ListView", () => _onClickNavigator(context, HelloPage1())),
            _button(context,"Page 2", () => _onClickNavigator(context, HelloPage2())),
            _button(context,"Page 3", () => _onClickNavigator(context, HelloPage3())),
          ],
        ),
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: <Widget>[
            _button(context,"Snack", _onClickSnack),
            _button(context,"Dialog", _onClickDialog),
            _button(context,"Toast", _onClickToast)
          ],
        )
      ],
    );
  }

  void _onClickNavigator(BuildContext context, Widget page) async {
    String s = await Navigator.push(context, MaterialPageRoute(builder: (BuildContext context) {
      return page;
    }));

    print(">> $s");
  }

  _onClickSnack() {
  }

  _onClickDialog() {
  }

  _onClickToast() {
  }

  _button(BuildContext context,String text, Function onPressed) {
    return RaisedButton(
        color: Colors.blue,
        child: Text(
          text,
          style: TextStyle(
            color: Colors.white,
            fontSize: 20,
          ),
        ),
        onPressed: onPressed
    );
  }

  _img(String img) {
    return Image.asset(
      img,
      fit: BoxFit.cover,
    );
  }

  _text() {
    return Text(
      "Hello World",
      style: TextStyle(
          color: Colors.blue,
          fontSize: 30,
          fontWeight: FontWeight.bold,
          fontStyle: FontStyle.italic,
          decoration: TextDecoration.underline,
          decorationColor: Colors.red,
          decorationStyle: TextDecorationStyle.wavy),
    );
  }
}
