package ArtiumSys.View;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTable;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JComboBox;

public class VisLojaUI extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField textField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VisLojaUI frame = new VisLojaUI();
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
	public VisLojaUI() {
		setTitle("Loja");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 876, 487);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		table = new JTable();
		table.setBounds(36, 33, 802, 256);
		contentPane.add(table);
		
		JLabel lblQuantidade = new JLabel("Quantidade");
		lblQuantidade.setBounds(463, 311, 91, 14);
		contentPane.add(lblQuantidade);
		
		textField = new JTextField();
		textField.setBounds(463, 333, 156, 20);
		contentPane.add(textField);
		textField.setColumns(10);
		
		JButton btnCarrinho = new JButton("Sua compra");
		btnCarrinho.setBounds(463, 364, 156, 47);
		contentPane.add(btnCarrinho);
		
		JComboBox comboBox = new JComboBox();
		comboBox.setBounds(265, 333, 156, 20);
		contentPane.add(comboBox);
		
		JLabel lblSelecioneOSeu = new JLabel("Selecione o seu produto");
		lblSelecioneOSeu.setBounds(265, 311, 159, 14);
		contentPane.add(lblSelecioneOSeu);
		
		JButton btnCancelar = new JButton("Cancelar");
		btnCancelar.setBounds(265, 364, 175, 47);
		contentPane.add(btnCancelar);
	}

}
