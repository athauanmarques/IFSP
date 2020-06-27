package ArtiumSys.View;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTable;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JTextArea;
import javax.swing.JButton;

public class FunSouvenirUI extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTable table_1;
	private JLabel lblVendas;
	private JLabel lblProduto;
	private JTextField textField;
	private JTextArea textArea;
	private JLabel lblDescrio;
	private JTextField textField_2;
	private JLabel lblQuantidade;
	private JTextField textField_3;
	private JLabel lblPreo;
	private JTextField textField_4;
	private JLabel label_1;
	private JButton btnNewButton;
	private JButton btnAdicvionar;
	private JButton btnEditar;
	private JButton btnLimpar;
	private JButton btnRemover;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FunSouvenirUI frame = new FunSouvenirUI();
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
	public FunSouvenirUI() {
		setTitle("Gerenciar Souvenir");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 879, 584);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		table = new JTable();
		table.setBounds(31, 51, 457, 223);
		contentPane.add(table);
		
		JLabel lblEstoque = new JLabel("Estoque");
		lblEstoque.setBounds(31, 26, 46, 14);
		contentPane.add(lblEstoque);
		
		table_1 = new JTable();
		table_1.setBounds(31, 357, 457, 135);
		contentPane.add(table_1);
		
		lblVendas = new JLabel("Vendas");
		lblVendas.setBounds(31, 332, 46, 14);
		contentPane.add(lblVendas);
		
		lblProduto = new JLabel("Produto");
		lblProduto.setBounds(521, 51, 46, 14);
		contentPane.add(lblProduto);
		
		textField = new JTextField();
		textField.setBounds(521, 69, 321, 20);
		contentPane.add(textField);
		textField.setColumns(10);
		
		textArea = new JTextArea();
		textArea.setBounds(521, 223, 321, 51);
		contentPane.add(textArea);
		
		lblDescrio = new JLabel("Descri\u00E7\u00E3o");
		lblDescrio.setBounds(521, 198, 227, 14);
		contentPane.add(lblDescrio);
		
		textField_2 = new JTextField();
		textField_2.setColumns(10);
		textField_2.setBounds(685, 167, 157, 20);
		contentPane.add(textField_2);
		
		lblQuantidade = new JLabel("Quantidade");
		lblQuantidade.setBounds(685, 149, 150, 14);
		contentPane.add(lblQuantidade);
		
		textField_3 = new JTextField();
		textField_3.setColumns(10);
		textField_3.setBounds(521, 167, 157, 20);
		contentPane.add(textField_3);
		
		lblPreo = new JLabel("Pre\u00E7o");
		lblPreo.setBounds(521, 149, 46, 14);
		contentPane.add(lblPreo);
		
		textField_4 = new JTextField();
		textField_4.setColumns(10);
		textField_4.setBounds(521, 118, 321, 20);
		contentPane.add(textField_4);
		
		label_1 = new JLabel("Marca");
		label_1.setBounds(521, 100, 46, 14);
		contentPane.add(label_1);
		
		btnNewButton = new JButton("Gerar Relat\u00F3rio");
		btnNewButton.setBounds(579, 376, 214, 100);
		contentPane.add(btnNewButton);
		
		btnAdicvionar = new JButton("Adicionar");
		btnAdicvionar.setBounds(521, 294, 89, 23);
		contentPane.add(btnAdicvionar);
		
		btnEditar = new JButton("Editar");
		btnEditar.setBounds(641, 294, 89, 23);
		contentPane.add(btnEditar);
		
		btnLimpar = new JButton("Limpar");
		btnLimpar.setBounds(753, 294, 89, 23);
		contentPane.add(btnLimpar);
		
		btnRemover = new JButton("Remover");
		btnRemover.setBounds(31, 294, 89, 23);
		contentPane.add(btnRemover);
	}

}
