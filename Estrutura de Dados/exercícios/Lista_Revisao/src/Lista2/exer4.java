package Lista2;

import javax.swing.JOptionPane;

public class exer4 {

	public static void main(String[] args) {
	
		float produto = Float.parseFloat(JOptionPane.showInputDialog("Informe o valor do produto: "));
		float total;
		
		
		
		for (int i = 0; i < 15; i++)
		{
			if (i % 2 != 0)
			{
				total = produto * i;	
				System.out.println("["+i+"] o resultado: " + total);
			}
			
		}
		

	}

}
