package e;

import javax.swing.JOptionPane;

public class avaliacao3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		
		Double n1 = Double.parseDouble(JOptionPane.showInputDialog("Informe o 1º valor: "));
		Double n2 = Double.parseDouble(JOptionPane.showInputDialog("Informe o 2ª valor: "));
		int senha = Integer.parseInt(JOptionPane.showInputDialog("Informe a sua senha: "));
		int senha1 = Integer.parseInt(JOptionPane.showInputDialog("Confirma a sua senha: "));
		
		Double resultado;
		
		if (senha == senha1)
		{
	
			resultado =  n1/n2;
			JOptionPane.showMessageDialog(null, "Seu resultado é: " + resultado);
			
		}
		else
		{
			JOptionPane.showMessageDialog(null, "Senha incorreta");
		}
		
		
	}

}
