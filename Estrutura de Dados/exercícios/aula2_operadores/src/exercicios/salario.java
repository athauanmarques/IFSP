package exercicios;

import javax.swing.JOptionPane;

public class salario {

	public static void main(String[] args) {
		/*
		 * O programa deve calcular o salario do funcionário
		 * Se a idade for maior do que 40 anos então
		 * o funcionário receberá um bônus de 20%, senão,
		 * receberá apenas 10%
		 * Exiba na tela: nome, idade e salário;
		 * 
		 */
		
		float salario = Float.parseFloat(JOptionPane.showInputDialog("informe o salario: "));
		int idade = Integer.parseInt(JOptionPane.showInputDialog("informe o bagulho da idade mano: "));
		
		System.out.println("idade: " + idade);
		JOptionPane.showMessageDialog(null, idade > 40 ? "\nVocê receber 20%: " + salario * 1.2 : "\nVocê receber 10%: " +  salario * 1.1);
		// jop (Ctrl + espaço) para aparece o JOptionPane
		
	}

}
