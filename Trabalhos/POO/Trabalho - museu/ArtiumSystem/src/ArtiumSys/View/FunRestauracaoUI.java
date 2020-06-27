package ArtiumSys.View;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.SwingConstants;

public class FunRestauracaoUI extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTable table_1;
	private JTable table_2;
	private JTable table_3;
	private JTextField textField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FunRestauracaoUI frame = new FunRestauracaoUI();
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
	public FunRestauracaoUI() {
		setTitle("Restaura\u00E7\u00F5es");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 864, 463);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		tabbedPane.setBounds(10, 11, 828, 402);
		contentPane.add(tabbedPane);
		
		JPanel panel = new JPanel();
		tabbedPane.addTab("Exibi\u00E7\u00E3o", null, panel, null);
		panel.setLayout(null);
		
		table = new JTable();
		table.setBounds(26, 69, 345, 128);
		panel.add(table);
		
		table_1 = new JTable();
		table_1.setBounds(414, 69, 345, 128);
		panel.add(table_1);
		
		table_2 = new JTable();
		table_2.setBounds(26, 235, 345, 128);
		panel.add(table_2);
		
		table_3 = new JTable();
		table_3.setBounds(414, 235, 345, 128);
		panel.add(table_3);
		
		JLabel lblEmAnalise = new JLabel("Em Analise");
		lblEmAnalise.setBounds(26, 44, 345, 14);
		panel.add(lblEmAnalise);
		
		JLabel lblConcludos = new JLabel("Conclu\u00EDdos");
		lblConcludos.setBounds(414, 44, 345, 14);
		panel.add(lblConcludos);
		
		JLabel lblEmAndamento = new JLabel("Em andamento");
		lblEmAndamento.setBounds(26, 210, 345, 14);
		panel.add(lblEmAndamento);
		
		JLabel lblCancelados = new JLabel("Cancelados");
		lblCancelados.setBounds(414, 210, 345, 14);
		panel.add(lblCancelados);
		
		JPanel panel_1 = new JPanel();
		tabbedPane.addTab("Solicitar", null, panel_1, null);
		panel_1.setLayout(null);
		
		JComboBox comboBox = new JComboBox();
		comboBox.setBounds(233, 204, 141, 20);
		panel_1.add(comboBox);
		
		JLabel lblSelecioneAcervo = new JLabel("Selecione Acervo");
		lblSelecioneAcervo.setHorizontalAlignment(SwingConstants.CENTER);
		lblSelecioneAcervo.setBounds(233, 179, 141, 14);
		panel_1.add(lblSelecioneAcervo);
		
		JLabel lblPrazoDeConcluso = new JLabel("Prazo de conclus\u00E3o");
		lblPrazoDeConcluso.setHorizontalAlignment(SwingConstants.CENTER);
		lblPrazoDeConcluso.setBounds(389, 179, 174, 14);
		panel_1.add(lblPrazoDeConcluso);
		
		textField = new JTextField();
		textField.setBounds(389, 204, 174, 20);
		panel_1.add(textField);
		textField.setColumns(10);
		
		JButton btnSolicitarRestaurao = new JButton("Solicitar Restaura\u00E7\u00E3o");
		btnSolicitarRestaurao.setBounds(233, 281, 330, 47);
		panel_1.add(btnSolicitarRestaurao);
		
		JButton btnLimpar = new JButton("Limpar");
		btnLimpar.setBounds(233, 235, 330, 35);
		panel_1.add(btnLimpar);
		
		JPanel panel_2 = new JPanel();
		tabbedPane.addTab("Processos", null, panel_2, null);
		panel_2.setLayout(null);
		
		JButton btnAlterarStatus = new JButton("Alterar Status");
		btnAlterarStatus.setBounds(245, 263, 330, 47);
		panel_2.add(btnAlterarStatus);
		
		JButton button_1 = new JButton("Limpar");
		button_1.setBounds(245, 217, 330, 35);
		panel_2.add(button_1);
		
		JLabel label_1 = new JLabel("Selecione Acervo");
		label_1.setHorizontalAlignment(SwingConstants.CENTER);
		label_1.setBounds(245, 161, 330, 14);
		panel_2.add(label_1);
		
		JComboBox comboBox_1 = new JComboBox();
		comboBox_1.setBounds(245, 186, 330, 20);
		panel_2.add(comboBox_1);
	}

}
