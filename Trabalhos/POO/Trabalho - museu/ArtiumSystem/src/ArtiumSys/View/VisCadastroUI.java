package ArtiumSys.View;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JTextField;
import javax.swing.JRadioButton;
import javax.swing.SwingConstants;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Login;
import ArtiumSys.Control.ContaCtrl;

public class VisCadastroUI extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField txtNome;
	private JTextField txtTelefone;
	private JTextField txtNascimento;
	private JTextField txtSenha;
	private JTextField txtConfirSenha;
	private JTextField txtEmail;
	private ButtonGroup bg = new ButtonGroup();
	private JTextField txtCodCartao;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VisCadastroUI frame = new VisCadastroUI();
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
	public VisCadastroUI() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 619, 588);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		
		
		JLabel lblNomeCompleto = new JLabel("Nome Completo");
		lblNomeCompleto.setHorizontalAlignment(SwingConstants.CENTER);
		lblNomeCompleto.setBounds(127, 30, 309, 14);
		contentPane.add(lblNomeCompleto);
		
		JLabel lblTelefone = new JLabel("Telefone");
		lblTelefone.setHorizontalAlignment(SwingConstants.CENTER);
		lblTelefone.setBounds(127, 80, 309, 14);
		contentPane.add(lblTelefone);
		
		JLabel lblDataDeNacimento = new JLabel("Data de Nacimento");
		lblDataDeNacimento.setHorizontalAlignment(SwingConstants.CENTER);
		lblDataDeNacimento.setBounds(127, 127, 309, 14);
		contentPane.add(lblDataDeNacimento);
		
		JLabel lblSexo = new JLabel("Sexo");
		lblSexo.setHorizontalAlignment(SwingConstants.CENTER);
		lblSexo.setBounds(127, 177, 309, 14);
		contentPane.add(lblSexo);
		
		JLabel lblEmail = new JLabel("Email");
		lblEmail.setHorizontalAlignment(SwingConstants.CENTER);
		lblEmail.setBounds(127, 327, 309, 14);
		contentPane.add(lblEmail);
		
		JLabel lblSenha = new JLabel("Senha");
		lblSenha.setHorizontalAlignment(SwingConstants.CENTER);
		lblSenha.setBounds(127, 215, 309, 14);
		contentPane.add(lblSenha);
		
		JLabel lblConfirmarSenha = new JLabel("Confirmar Senha");
		lblConfirmarSenha.setHorizontalAlignment(SwingConstants.CENTER);
		lblConfirmarSenha.setBounds(127, 271, 309, 14);
		contentPane.add(lblConfirmarSenha);
		
		
		
		JCheckBox ckbReceberConvite = new JCheckBox("Desejo receber convite para futuros apresenta\u00E7\u00F5es de eventos");
		ckbReceberConvite.setBounds(115, 423, 386, 23);
		contentPane.add(ckbReceberConvite);
		
		txtNome = new JTextField();
		txtNome.setBounds(127, 55, 309, 20);
		contentPane.add(txtNome);
		txtNome.setColumns(10);
		
		txtTelefone = new JTextField();
		txtTelefone.setColumns(10);
		txtTelefone.setBounds(127, 102, 309, 20);
		contentPane.add(txtTelefone);
		
		
		txtNascimento = new JTextField();
		txtNascimento.setColumns(10);
		txtNascimento.setBounds(127, 146, 309, 20);
		contentPane.add(txtNascimento);
		
		JRadioButton rdbtnMasculino = new JRadioButton("Masculino");
		rdbtnMasculino.setHorizontalAlignment(SwingConstants.CENTER);
		rdbtnMasculino.setBounds(127, 195, 156, 23);
		contentPane.add(rdbtnMasculino);
		bg.add(rdbtnMasculino);
		
		
		JRadioButton rdbtnFeminino = new JRadioButton("Feminino");
		rdbtnFeminino.setHorizontalAlignment(SwingConstants.CENTER);
		rdbtnFeminino.setBounds(292, 195, 144, 23);
		contentPane.add(rdbtnFeminino);
		bg.add(rdbtnFeminino);
		
		txtSenha = new JTextField();
		txtSenha.setColumns(10);
		txtSenha.setBounds(127, 240, 309, 20);
		contentPane.add(txtSenha);
		
		txtConfirSenha = new JTextField();
		txtConfirSenha.setColumns(10);
		txtConfirSenha.setBounds(127, 296, 309, 20);
		contentPane.add(txtConfirSenha);
		
		txtEmail = new JTextField();
		txtEmail.setColumns(10);
		txtEmail.setBounds(127, 350, 309, 20);
		contentPane.add(txtEmail);
		
		JButton bntLimpar = new JButton("Limpar");
		bntLimpar.setBounds(127, 462, 144, 50);
		contentPane.add(bntLimpar);
		
		JButton btnEfetuarCadastro = new JButton("Efetuar Cadastro");
		btnEfetuarCadastro.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
					Login lg = new Login();
					Usuario usu = new Usuario();
					ContaCtrl cc = new ContaCtrl();
					lg.setNome(txtNome.getText());
					lg.setCodCartao(txtCodCartao.getText());
					lg.setSenha(txtSenha.getText());
					lg.setTipoAcesso("visitante");
					usu.setTelefone(txtTelefone.getText());
					usu.setEmail(txtEmail.getText());
				
						if(rdbtnMasculino.isSelected()){
							usu.setSexo("M");
						}
						else
						{
							usu.setSexo("F");
						}
				
						if(ckbReceberConvite.isSelected()){
							usu.setReceberConvite(true);
						}	
						else
						{
							usu.setReceberConvite(true);
						}
				
						usu.setDataNascimento(txtNascimento.getText());
			
			String msg = cc.CadastrarVistante(usu, lg);
			JOptionPane.showMessageDialog(null, msg);
		}});
		btnEfetuarCadastro.setBounds(292, 462, 144, 50);
		contentPane.add(btnEfetuarCadastro);
		
		txtCodCartao = new JTextField();
		txtCodCartao.setColumns(10);
		txtCodCartao.setBounds(127, 396, 309, 20);
		contentPane.add(txtCodCartao);
		
		JLabel lblCodigoCartao = new JLabel("C\u00F3digo Cart\u00E3o");
		lblCodigoCartao.setHorizontalAlignment(SwingConstants.CENTER);
		lblCodigoCartao.setBounds(127, 381, 309, 14);
		contentPane.add(lblCodigoCartao);
		
		
	}
}
