package exer;

import javax.swing.JOptionPane;

public class For_exeSenha {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/*
		 * Este programa gera uma senha númerica
		 * de dígitos numérico aleatórios, e armazenado em uma string
		 * No final, mostra a senha na tela.
		 */
		
		String senha = "";
		for(int i = 0; i < 4; i++)
		{
			
			senha += (int)(Math.random()*10); // random convert o int
			senha += (char)(int)(97 + Math.random()*26); // 97 = a da tabela scii
			JOptionPane.showMessageDialog(null, "Senha " + senha);
			
		}

	}

}
