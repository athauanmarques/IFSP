package Exercicios3;

import javax.swing.JOptionPane;


public class exer3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Double largura = Double.parseDouble(JOptionPane.showInputDialog("informe a largura: "));
		Double comprimento = Double.parseDouble(JOptionPane.showInputDialog("Informe o comprimento: "));
		Double resultado = largura*comprimento;
		
		JOptionPane.showMessageDialog(null, "Área Total é: " + resultado);
		
		
		

	}

}
