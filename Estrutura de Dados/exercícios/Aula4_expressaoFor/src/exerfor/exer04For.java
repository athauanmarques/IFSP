package exerfor;

import javax.swing.JOptionPane;

public class exer04For {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/*
		 * O programa deve gerar um senha alfanumerica de 8 dígitos aleatórios e armazená-los em string.
		 * No final, mostrar a senha na tela.
		 */

		String senha = ""; // sempre inicializar
		for(int i = 0; i < 4; i++)
		{
			senha += (int)(Math.random()*10);
			senha += (char)(int)(97 + Math.random()*26); // 97 representa letra "a" da tabela scii
			
		}
		
		JOptionPane.showMessageDialog(null, "Sua senha é: "+ senha);
	}

}
