package Lista3;

import javax.swing.JOptionPane;
import java.util.Random;

public class exer1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Random dado = new Random();
		
		for (int i = 0; i <= 10; i++)
		{
			JOptionPane.showMessageDialog(null, " Seu reultado: " + dado.nextInt(6));
		}
		
		

	}

}
