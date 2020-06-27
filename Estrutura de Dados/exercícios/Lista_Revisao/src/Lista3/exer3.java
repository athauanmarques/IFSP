package Lista3;



import java.text.DecimalFormat;
import javax.swing.JOptionPane;


public class exer3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		 DecimalFormat df = new DecimalFormat("0.##");
		Double base = Double.parseDouble(JOptionPane.showInputDialog("Informe lado do cubo: "));
		Double volume = base*base*base;
		
		JOptionPane.showMessageDialog(null, "Resultado: " + df.format(volume));
	
		
		
	}

}
