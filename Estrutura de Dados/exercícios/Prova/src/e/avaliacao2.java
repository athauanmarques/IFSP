package e;

import javax.swing.JOptionPane;

public class avaliacao2 {

	public static void main(String[] args) {
		int funcao = Integer.parseInt(JOptionPane.showInputDialog("informe a sua função:\n 1 - Analista Jr \n 2 - Analista Sr \n3- Analista Pleno"));
		int idade = Integer.parseInt(JOptionPane.showInputDialog("Informe a tua idade: "));
	    double salario;
		
		
		switch (funcao)
		{
		 case 1:
			 if (idade >45)
			 {
			  salario = 3.500 * 1.1;
			  JOptionPane.showMessageDialog(null, "Seu salário é: " + salario);
			 }
			 else
			 {
			  salario = 3.500;
			  JOptionPane.showMessageDialog(null, "Seu salário é: " + salario);
			 }
			  break;
		 case 2:
			 if (idade >45)
			 {
			  salario = 5.500 * 1.1;
			  JOptionPane.showMessageDialog(null, "Seu salário é: " + salario);
			 }
			 else
			 {
			  salario = 5.500;
			  JOptionPane.showMessageDialog(null, "Seu salário é: " + salario);
			 }
			  break;
		 case 3:
			 if (idade >45)
			 {
			  salario = 8.500 * 1.1;
			  JOptionPane.showMessageDialog(null, "Seu salário é: " + salario);
			 }
			 else
			 {
			  salario = 8.500;
			  JOptionPane.showMessageDialog(null, "Seu salário é: " + salario);
			 }
			  break;
		default:
			JOptionPane.showMessageDialog(null, "número infalido");
			break;

		}
		
		
	
	}

}
