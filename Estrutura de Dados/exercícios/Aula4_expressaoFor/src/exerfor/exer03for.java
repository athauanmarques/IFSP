package exerfor;

import javax.swing.JOptionPane;

public class exer03for {

	public static void main(String[] args) {
		/*Este programa preccisa gerar uma senha númerica
		 * de 4 digitos aleatório e armazená-lo em uma variável do tipo String
		 * no final o programa exibe a senha na tela.
		 * 
		 */
		
		String senha = "";
		for (int i = 0;i < 4; i++)
		{
			
			senha += (int)(Math.random()*10);
			JOptionPane.showMessageDialog(null, "Senha: " + senha);
		}

		

	}

}
