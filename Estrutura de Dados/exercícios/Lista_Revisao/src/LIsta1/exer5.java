package LIsta1;

import javax.swing.JOptionPane;

public class exer5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Double comprimento = Double.parseDouble(JOptionPane.showInputDialog("Informa o compirmento; "));
		Double largura = Double.parseDouble(JOptionPane.showInputDialog("Informa o largura: "));
		Double profundidade = Double.parseDouble(JOptionPane.showInputDialog("Informe a profundidade: "));
		
		Double resultado = (comprimento * largura * profundidade) * 45;
		JOptionPane.showMessageDialog(null, "O resultado é: " + resultado);
		
		System.out.println(resultado);
	}

}
