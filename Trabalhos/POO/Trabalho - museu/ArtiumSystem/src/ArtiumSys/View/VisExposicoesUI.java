package ArtiumSys.View;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.SwingConstants;

public class VisExposicoesUI extends JFrame {

	private JPanel contentPane;
	private JTable table;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VisExposicoesUI frame = new VisExposicoesUI();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public VisExposicoesUI() {
		setTitle("Exposi\u00E7\u00F5es e Eventos");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 845, 468);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		table = new JTable();
		table.setBounds(31, 54, 758, 227);
		contentPane.add(table);
		
		JComboBox comboBox = new JComboBox();
		comboBox.setBounds(55, 320, 205, 20);
		contentPane.add(comboBox);
		
		JLabel label = new JLabel("Selecionar Evento");
		label.setHorizontalAlignment(SwingConstants.CENTER);
		label.setBounds(55, 300, 205, 14);
		contentPane.add(label);
		
		JButton button = new JButton("Reservar");
		button.setBounds(55, 351, 205, 48);
		contentPane.add(button);
		
		JLabel label_1 = new JLabel("Eventos");
		label_1.setBounds(31, 36, 46, 14);
		contentPane.add(label_1);
		
		JComboBox comboBox_1 = new JComboBox();
		comboBox_1.setBounds(540, 320, 224, 20);
		contentPane.add(comboBox_1);
		
		JLabel lblConvitesRecebidos = new JLabel("Convites recebidos ");
		lblConvitesRecebidos.setHorizontalAlignment(SwingConstants.CENTER);
		lblConvitesRecebidos.setBounds(540, 300, 224, 14);
		contentPane.add(lblConvitesRecebidos);
		
		JButton btnAceitarConvite = new JButton("Aceitar");
		btnAceitarConvite.setBounds(540, 351, 107, 48);
		contentPane.add(btnAceitarConvite);
		
		JButton btnRecusar = new JButton("Recusar");
		btnRecusar.setBounds(657, 351, 107, 48);
		contentPane.add(btnRecusar);
	}
}
