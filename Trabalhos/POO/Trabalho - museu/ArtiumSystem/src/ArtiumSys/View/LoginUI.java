package ArtiumSys.View;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.ButtonGroup;
import javax.swing.ImageIcon;
import javax.swing.SwingConstants;
import java.awt.Font;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import ArtiumSys.Model.Login;
import ArtiumSys.Control.VerificarLoginCtrl;
import javax.swing.JRadioButton;

public class LoginUI extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField txtCodAcesso;
	private JTextField txtSenha;
	private ButtonGroup bg = new ButtonGroup();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					LoginUI frame = new LoginUI();
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
	public LoginUI() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 702);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblLogo = new JLabel("");
		lblLogo.setHorizontalAlignment(SwingConstants.CENTER);
		lblLogo.setIcon(new ImageIcon("C:\\Users\\vir_k\\Documents\\workspace\\ArtiumSystem\\img\\logo.png"));
		lblLogo.setBounds(96, 108, 229, 259);
		contentPane.add(lblLogo);
		
		JLabel lblCodigoDeAcesso = new JLabel("Codigo de Acesso");
		lblCodigoDeAcesso.setHorizontalAlignment(SwingConstants.CENTER);
		lblCodigoDeAcesso.setBounds(129, 396, 176, 14);
		contentPane.add(lblCodigoDeAcesso);
		
		JLabel lblSenha = new JLabel("Senha");
		lblSenha.setHorizontalAlignment(SwingConstants.CENTER);
		lblSenha.setBounds(129, 452, 176, 14);
		contentPane.add(lblSenha);
		
		txtCodAcesso = new JTextField();
		txtCodAcesso.setBounds(129, 421, 176, 20);
		contentPane.add(txtCodAcesso);
		txtCodAcesso.setColumns(10);
		
		JLabel lblArtiumSystem = new JLabel("Artium System");
		lblArtiumSystem.setFont(new Font("Papyrus", Font.PLAIN, 35));
		lblArtiumSystem.setBounds(94, 35, 255, 72);
		contentPane.add(lblArtiumSystem);

		txtSenha = new JTextField();
		txtSenha.setBounds(129, 477, 176, 20);
		contentPane.add(txtSenha);
		txtSenha.setColumns(10);
		
		JRadioButton rdbtnVisitante = new JRadioButton("Visitante");
		rdbtnVisitante.setBounds(129, 368, 77, 23);
		contentPane.add(rdbtnVisitante);
		rdbtnVisitante.setSelected(true);
		bg.add(rdbtnVisitante);
		
		JRadioButton rdbtnFuncionario = new JRadioButton("Funcionario");
		rdbtnFuncionario.setBounds(224, 368, 81, 23);
		contentPane.add(rdbtnFuncionario);
		bg.add(rdbtnFuncionario);
		
		JButton btnSouNovoVisitante = new JButton("Sou novo visitante");
		btnSouNovoVisitante.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				VisCadastroUI novo = new VisCadastroUI();
				novo.setVisible(true);
			}
		});
		btnSouNovoVisitante.setBounds(10, 584, 196, 68);
		contentPane.add(btnSouNovoVisitante);
		
		JButton btnCadastroFuncionarios = new JButton("Cadastro para funcionarios");
		btnCadastroFuncionarios.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				FunCadastroUI fun = new FunCadastroUI();
				fun.setVisible(true);
			}
		});
		btnCadastroFuncionarios.setBounds(224, 584, 200, 68);
		contentPane.add(btnCadastroFuncionarios);
		
		JButton bntEntrar = new JButton("Entrar");
		bntEntrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			Login login = new Login();
			login.setCodCartao(txtCodAcesso.getText());
			login.setSenha(txtSenha.getText());
			if(rdbtnVisitante.isSelected()){
				login.setTipoAcesso("visitante");
			}
			else
			{
				login.setTipoAcesso("funcionario");
			}
			
			VerificarLoginCtrl vlc = new VerificarLoginCtrl();
			String msg = vlc.verificarLogin(login);
			
			if(msg.equals("funcionario")){
				MainFuncionarioUI fun = new MainFuncionarioUI();
				fun.setVisible(true);
				
			}else if(msg.equals("visitante")){
				MainVisitanteUI vis = new MainVisitanteUI();
				vis.setVisible(true);
			
			}else{

			JOptionPane.showMessageDialog(null, "Verifique o seu código de acesso e a sua senha.");
			}
				
			}
		});
		bntEntrar.setBounds(129, 510, 176, 44);
		contentPane.add(bntEntrar);
	}
}
