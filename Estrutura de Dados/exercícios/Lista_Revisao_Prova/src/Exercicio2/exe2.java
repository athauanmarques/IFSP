package Exercicio2;

import javax.swing.JOptionPane;

public class exe2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Double Qts1 = Double.parseDouble(JOptionPane.showInputDialog("Digite a quantidade 1: "));
		Double Qts2 = Double.parseDouble(JOptionPane.showInputDialog("Informe a quantidade 2: "));
		Double Qts3 = Double.parseDouble(JOptionPane.showInputDialog("Digite a quantidade 3: "));
		Double Vlr1 = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor 1: "));
		Double Vlr2 = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor 2: "));
		Double Vlr3 = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor 3: "));
		
		Double Resultado = Qts1*Vlr1 + Qts2*Vlr2 + Qts3*Vlr3;
		
	JOptionPane.showMessageDialog(null, "o resultado final é: " + Resultado);
	
		
		

	}

}
