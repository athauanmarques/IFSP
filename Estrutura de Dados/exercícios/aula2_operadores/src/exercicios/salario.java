package exercicios;

import javax.swing.JOptionPane;

public class salario {

	public static void main(String[] args) {
		/*
		 * O programa deve calcular o salario do funcion�rio
		 * Se a idade for maior do que 40 anos ent�o
		 * o funcion�rio receber� um b�nus de 20%, sen�o,
		 * receber� apenas 10%
		 * Exiba na tela: nome, idade e sal�rio;
		 * 
		 */
		
		float salario = Float.parseFloat(JOptionPane.showInputDialog("informe o salario: "));
		int idade = Integer.parseInt(JOptionPane.showInputDialog("informe o bagulho da idade mano: "));
		
		System.out.println("idade: " + idade);
		JOptionPane.showMessageDialog(null, idade > 40 ? "\nVoc� receber 20%: " + salario * 1.2 : "\nVoc� receber 10%: " +  salario * 1.1);
		// jop (Ctrl + espa�o) para aparece o JOptionPane
		
	}

}
