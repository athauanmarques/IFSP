package exer;

import javax.swing.JOptionPane;

public class comandos_swhits {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/*
		 * O programa recebe um valor entre 1 e 12 representado os meses do ano,
		 * o programa exibe os num�ros de dias e o nome do m�s correspondente
		 */
		
		int mes = Integer.parseInt(JOptionPane.showInputDialog("informe o mes: "));
		
		if(mes < 1 || mes > 12)
		{
			JOptionPane.showInputDialog(null, "mes inv�lido!"); 
			return; // vai interromper a execu��o do m�todo
		}
		
		int dias;
		
		switch (mes)
		{
		
		case 1: dias=31; break;
		case 2: dias=28; break;
		case 3: dias=31; break;
		case 4: dias=30; break;
		case 5: dias=31; break;
		case 6: dias=30; break;
		case 7: dias=31; break;
		case 8: dias=31; break;
		case 9: dias=30; break;
		case 10: dias=31; break;
		case 11: dias=30; break;
		default: dias = 31; break;
		
		}
		
		JOptionPane.showInputDialog("os n�meros de dias s�o: " + dias);
		

	}

}
