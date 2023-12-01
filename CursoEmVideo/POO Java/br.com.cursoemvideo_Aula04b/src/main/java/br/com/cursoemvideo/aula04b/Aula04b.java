package br.com.cursoemvideo.aula04b;

public class Aula04b {
    public static void main(String[] args) {
        // Caneta c1 = new Caneta();
        Caneta c1 = new Caneta("NIC", "Amarelo", 0.4f);
        c1.status();
        
        Caneta c2 = new Caneta("KKK", "Laranja", 1.5f);
        c2.status();
        
        // Primeira parte da Aula - Get and Set
        // c1.modelo = "BIC";
        // c1.setModelo("BIC");
        
        // c1.ponta = 0.5f;
        // c1.setPonta(0.5f);
        
        //c1.status();
        // System.out.println("Tenho uma caneta " + c1.getModelo() + 
        //        " de ponta " + c1.getPonta());
    }
}