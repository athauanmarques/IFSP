package exercicios;

import javax.swing.JOptionPane;

public class areaRetangulo {

	public static void main(String[] args) {
		/*
		 * Calcular a area do retangulo e verificar
		 * se � um quadrado ou de fato ou ret�ngulo.
		 * 
		 * <declara��o>
		 * <if> ou um tern�rio
		 * <exibindo>
		 * 
		 */
		
		int n1 = Integer.parseInt(JOptionPane.showInputDialog("informe a altura: "));
		int n2 = Integer.parseInt(JOptionPane.showInputDialog("informe a base: "));
		System.out.println("Total da �rea �: " + (n1*n2));
		System.out.println(n1 == n2 ? "� quadrado" : "n�o � quadrado");
	}

}
