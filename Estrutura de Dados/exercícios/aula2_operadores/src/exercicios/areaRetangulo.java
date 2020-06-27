package exercicios;

import javax.swing.JOptionPane;

public class areaRetangulo {

	public static void main(String[] args) {
		/*
		 * Calcular a area do retangulo e verificar
		 * se é um quadrado ou de fato ou retângulo.
		 * 
		 * <declaração>
		 * <if> ou um ternário
		 * <exibindo>
		 * 
		 */
		
		int n1 = Integer.parseInt(JOptionPane.showInputDialog("informe a altura: "));
		int n2 = Integer.parseInt(JOptionPane.showInputDialog("informe a base: "));
		System.out.println("Total da área é: " + (n1*n2));
		System.out.println(n1 == n2 ? "é quadrado" : "não é quadrado");
	}

}
