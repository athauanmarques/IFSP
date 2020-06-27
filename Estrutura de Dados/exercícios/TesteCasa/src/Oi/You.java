package Oi;

import javax.swing.JOptionPane;

public class You {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Modifica yo = new Modifica();

		String nome = JOptionPane.showInputDialog("Informe o nome: ");
		
		yo.Mudar(nome);

		System.out.println(yo.Mudar(nome));
		

	}

}
