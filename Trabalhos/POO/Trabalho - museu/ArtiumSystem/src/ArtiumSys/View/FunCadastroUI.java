package ArtiumSys.View;


import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.SwingConstants;
import javax.swing.JTextField;
import javax.swing.JRadioButton;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.ButtonGroup;
import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Login;
import ArtiumSys.Control.ContaCtrl;

public class FunCadastroUI extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField txtNome;
	private JTextField txtFone;
	private JTextField txtDataNasc;
	private JTextField txtCargo;
	private JTextField txtRA;
	private JTextField txtEmail;
	private JTextField txtSenha;
	private JTextField txtCodCartao;
	private JTextField txtConfirmarSenha;
	ButtonGroup gb = new ButtonGroup();
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FunCadastroUI frame = new FunCadastroUI();
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
	public FunCadastroUI() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 869, 592);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel label = new JLabel("Nome Completo");
		label.setHorizontalAlignment(SwingConstants.CENTER);
		label.setBounds(81, 110, 309, 14);
		contentPane.add(label);
		
		txtNome = new JTextField();
		txtNome.setColumns(10);
		txtNome.setBounds(81, 135, 309, 20);
		contentPane.add(txtNome);
		
		JLabel label_1 = new JLabel("Telefone");
		label_1.setHorizontalAlignment(SwingConstants.CENTER);
		label_1.setBounds(81, 160, 309, 14);
		contentPane.add(label_1);
		
		txtFone = new JTextField();
		txtFone.setColumns(10);
		txtFone.setBounds(81, 182, 309, 20);
		contentPane.add(txtFone);
		
		JLabel label_2 = new JLabel("Data de Nacimento");
		label_2.setHorizontalAlignment(SwingConstants.CENTER);
		label_2.setBounds(81, 207, 309, 14);
		contentPane.add(label_2);
		
		txtDataNasc = new JTextField();
		txtDataNasc.setColumns(10);
		txtDataNasc.setBounds(81, 226, 309, 20);
		contentPane.add(txtDataNasc);
		
		JLabel label_3 = new JLabel("Sexo");
		label_3.setHorizontalAlignment(SwingConstants.CENTER);
		label_3.setBounds(241, 253, 309, 14);
		contentPane.add(label_3);
		
		
		JRadioButton rbtMasculino = new JRadioButton("Masculino");
		rbtMasculino.setHorizontalAlignment(SwingConstants.CENTER);
		rbtMasculino.setBounds(241, 271, 156, 23);
		rbtMasculino.isSelected();
		contentPane.add(rbtMasculino);
		rbtMasculino.isSelected();
		gb.add(rbtMasculino);
		
		JLabel lblCargo = new JLabel("Cargo");
		lblCargo.setHorizontalAlignment(SwingConstants.CENTER);
		lblCargo.setBounds(400, 110, 309, 14);
		contentPane.add(lblCargo);
		
		JRadioButton rbtFeminino = new JRadioButton("Feminino");
		rbtFeminino.setHorizontalAlignment(SwingConstants.CENTER);
		rbtFeminino.setBounds(406, 271, 144, 23);
		contentPane.add(rbtFeminino);
		gb.add(rbtFeminino);
		
		txtCargo = new JTextField();
		txtCargo.setColumns(10);
		txtCargo.setBounds(400, 135, 309, 20);
		contentPane.add(txtCargo);
		
		JLabel lblNumeroRa = new JLabel("Numero RA");
		lblNumeroRa.setHorizontalAlignment(SwingConstants.CENTER);
		lblNumeroRa.setBounds(400, 160, 309, 14);
		contentPane.add(lblNumeroRa);
		
		txtRA = new JTextField();
		txtRA.setColumns(10);
		txtRA.setBounds(400, 182, 309, 20);
		contentPane.add(txtRA);
		
		JLabel label_6 = new JLabel("Email");
		label_6.setHorizontalAlignment(SwingConstants.CENTER);
		label_6.setBounds(400, 207, 309, 14);
		contentPane.add(label_6);
		
		txtEmail = new JTextField();
		txtEmail.setColumns(10);
		txtEmail.setBounds(400, 226, 309, 20);
		contentPane.add(txtEmail);
		
		JLabel lblSenha_1 = new JLabel("Senha");
		lblSenha_1.setHorizontalAlignment(SwingConstants.CENTER);
		lblSenha_1.setBounds(251, 301, 309, 14);
		contentPane.add(lblSenha_1);
		
		txtSenha = new JTextField();
		txtSenha.setColumns(10);
		txtSenha.setBounds(251, 316, 309, 20);
		contentPane.add(txtSenha);
		
		JButton bntLimpar = new JButton("Limpar");
		bntLimpar.setBounds(248, 477, 144, 50);
		contentPane.add(bntLimpar);
		
		JButton txtEfetuarCadastro = new JButton("Efetuar Cadastro");
		txtEfetuarCadastro.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ContaCtrl contaCtrl = new ContaCtrl();
				Usuario usuario= new Usuario();
				Login login = new Login();
				login.setNome(txtNome.getText());
				login.setTipoAcesso("funcionario");
				login.setSenha(txtSenha.getText());
				login.setCodCartao(txtCodCartao.getText());
				usuario.setCargo(txtCargo.getText());
				usuario.setDataNascimento(txtDataNasc.getText());
				usuario.setEmail(txtEmail.getText());
				usuario.setNumeroRA(txtRA.getText());
				usuario.setTelefone(txtFone.getText());
				if(rbtMasculino.isSelected()){
					usuario.setSexo("m");
				}else{
					usuario.setSexo("f");
				}
				
				String msg = contaCtrl.CadastrarFuncionario(usuario, login);
				
				JOptionPane.showMessageDialog(null, msg);
			}
		});
		txtEfetuarCadastro.setBounds(413, 477, 144, 50);
		contentPane.add(txtEfetuarCadastro);
		
		txtCodCartao = new JTextField();
		txtCodCartao.setColumns(10);
		txtCodCartao.setBounds(251, 420, 309, 20);
		contentPane.add(txtCodCartao);
		
		JLabel lblCdigoCarto = new JLabel("C\u00F3digo Cart\u00E3o");
		lblCdigoCarto.setHorizontalAlignment(SwingConstants.CENTER);
		lblCdigoCarto.setBounds(251, 397, 309, 14);
		contentPane.add(lblCdigoCarto);
		
		txtConfirmarSenha = new JTextField();
		txtConfirmarSenha.setColumns(10);
		txtConfirmarSenha.setBounds(251, 372, 309, 20);
		contentPane.add(txtConfirmarSenha);
		
		JLabel lblSenha = new JLabel("Confirmar senha");
		lblSenha.setHorizontalAlignment(SwingConstants.CENTER);
		lblSenha.setBounds(251, 347, 309, 14);
		contentPane.add(lblSenha);
	}

}
