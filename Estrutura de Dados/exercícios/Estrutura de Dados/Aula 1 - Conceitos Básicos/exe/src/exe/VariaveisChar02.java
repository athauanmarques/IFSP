package exe;

import javax.swing.JOptionPane;

public class VariaveisChar02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		JOptionPane.showMessageDialog(null, "Exemplo " + "de Caracteres");
		// caixa de dialogo para mostra para o usários, aperte entre as " no - OptionPaneUI" Ctrl + espaço". para importa
		
		int ch1 = 25943;
		int ch2 = (char)ch1;
		
		System.out.println("ch2 = " + ch2);
		JOptionPane.showMessageDialog(null, "ch2 = " + ch2); //aperte entre Pane e o ponto ctrl + espaço
		//mostra dialog de confirmação
		
	}

}
