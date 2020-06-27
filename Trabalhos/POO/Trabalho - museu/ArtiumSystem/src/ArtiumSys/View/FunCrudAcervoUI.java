package ArtiumSys.View;

import java.awt.BorderLayout;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.AbstractButton;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.JTabbedPane;
import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JTextArea;
import javax.swing.JComboBox;
import java.awt.Font;
import javax.swing.SwingConstants;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.ArrayList;

import ArtiumSys.Model.Acervo;
import ArtiumSys.Control.CrudAcervoCtrl;
import javax.swing.table.DefaultTableModel;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;

public class FunCrudAcervoUI extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTable tbAcervo;
	private JTextField txtTituloEfetuar;
	private JTextField txtReservaEfetuar;
	private JTextField txtMaximoEfetuar;
	private JTextField txtResponsavelEfetuar;
	private JTextField txtTelefoneEfetuar;
	private JTextField txtCepEfetuar;
	private JTextField txtCidadeEfetuar;
	private JTextField txtInicioEfetuar;
	private JTextField txtFinalEfetuar;
	private JTextField txtTituloAlterar;
	private JTextField txtCepAlterar;
	private JTextField txtCidadeAlterar;
	private JTextField txtInicioAlterar;
	private JTextField txtDataFinalAlterar;
	private JTextField txtMaximoAlterar;
	private JTextField txtLimiteAlterar;
	private JTextField txtResponsavelAlterar;
	private JTextField txtTelefoneAlterar;
	Acervo acervo = new Acervo();
	CrudAcervoCtrl contaCtrl = new CrudAcervoCtrl();
	ArrayList<Acervo> arrayAcervo = contaCtrl.obterAcervo();
	private JTextField txtEstadoEfetuar;
	

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FunCrudAcervoUI frame = new FunCrudAcervoUI();
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
	JTextArea txtDescricaoAlterar = new JTextArea();
	JTextArea txtEnderecoAlterar = new JTextArea();
	JTextArea txtEnderecoEfetuar = new JTextArea();
	JTextArea txtDescricaoEfetuar = new JTextArea();
	public void limparCampos(){
		txtCepAlterar.setText(null);
		txtDescricaoAlterar.setText(null);
 		txtInicioAlterar.setText(null);
 		txtDataFinalAlterar.setText(null);
 		txtCidadeAlterar.setText(null);
		txtEnderecoAlterar.setText(null);
 		txtCepAlterar.setText(null);
 		txtResponsavelAlterar.setText(null);
 		txtLimiteAlterar.setText(null);
 		txtMaximoAlterar.setText(null);
 		txtTelefoneAlterar.setText(null);
 		txtTituloAlterar.setText(null);
 		//-------------------- adicionar ---------
 		txtCepEfetuar.setText(null);
 		txtDescricaoEfetuar.setText(null);
 		txtInicioEfetuar.setText(null);
 		txtFinalEfetuar.setText(null);
 		txtCidadeEfetuar.setText(null);
		txtEnderecoEfetuar.setText(null);
 		txtCepEfetuar.setText(null);
 		txtResponsavelAlterar.setText(null);
 		txtReservaEfetuar.setText(null);
 		txtMaximoEfetuar.setText(null);
 		txtTelefoneEfetuar.setText(null);
 		txtTituloEfetuar.setText(null);
 		txtResponsavelEfetuar.setText(null);
 		txtEstadoEfetuar.setText(null);
 	
		
	}
	
	JComboBox<Acervo> cbxTituloAlterar = new JComboBox<Acervo>();
	
	public FunCrudAcervoUI() {
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowOpened(WindowEvent e) {
				CrudAcervoCtrl lsAcervo = new CrudAcervoCtrl();
				ArrayList<Acervo> arrayAcervo = lsAcervo.obterAcervo();

 			for (Acervo acervo : arrayAcervo){cbxTituloAlterar.addItem(acervo);}
			}
			
			
		});
		setTitle("Acervo");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 826, 592);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.add(cbxTituloAlterar);
		
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		
		
		
		JPanel panel = new JPanel();
		tabbedPane.addTab("Exibi\u00E7\u00E3o", null, panel, null);
		panel.setLayout(null);
		
		tbAcervo = new JTable();
		tbAcervo.setBounds(30, 23, 618, 362);
		tbAcervo.setModel(new DefaultTableModel(
			new Object[][] {
				{null, null, null, null, null},
			},
			new String[] {
				"idAcervo","titulo", "descricao", "periodo","dataInicio","dataFinal","cidade","endereco","estado","cep","responsavel","Telefone","LimiteREserva",
				"maxVisitante","enviarConvites"
			}
		));
		panel.add(tbAcervo);
		
		JButton btnAtualizar = new JButton("Atualizar");
		btnAtualizar.setBounds(601, 403, 89, 23);
		panel.add(btnAtualizar);
		
		JPanel panel_1 = new JPanel();
		tabbedPane.addTab("Adicionar", null, panel_1, null);
		
		JLabel lblTitullo = new JLabel("titullo ");
		lblTitullo.setBounds(90, 70, 179, 14);
		
		JLabel lblDescrio = new JLabel("descri\u00E7\u00E3o ");
		lblDescrio.setBounds(90, 128, 179, 14);
		
		JLabel lblCep = new JLabel("CEP");
		lblCep.setBounds(279, 64, 193, 14);
		
		JLabel lblEstado = new JLabel("Estado");
		lblEstado.setBounds(490, 69, 92, 14);
		
		JLabel lblCidade = new JLabel("Cidade");
		lblCidade.setBounds(279, 212, 193, 14);
		
		JLabel lblEndereo = new JLabel("Endere\u00E7o");
		lblEndereo.setBounds(279, 128, 400, 14);
		
		JLabel lblPeriodo = new JLabel("Periodo");
		lblPeriodo.setBounds(500, 209, 179, 14);
		
		JLabel lblInicio = new JLabel("Inicio");
		lblInicio.setBounds(295, 282, 38, 14);
		
		JLabel lblFinal = new JLabel("final");
		lblFinal.setBounds(295, 320, 20, 14);
		
		JLabel lblLimiteDeReserva = new JLabel("Limite de reserva");
		lblLimiteDeReserva.setBounds(482, 282, 100, 14);
		
		JLabel lblMximoEVisitante = new JLabel("M\u00E1ximo e visitante");
		lblMximoEVisitante.setBounds(482, 320, 107, 14);
		
		JLabel lblResponsavel = new JLabel("responsavel");
		lblResponsavel.setBounds(90, 265, 179, 14);
		
		JLabel lblTelefone = new JLabel("telefone");
		lblTelefone.setBounds(90, 320, 179, 14);
		
		txtTituloEfetuar = new JTextField();
		txtTituloEfetuar.setBounds(90, 90, 179, 20);
		txtTituloEfetuar.setColumns(10);
		
	
		txtDescricaoEfetuar.setBounds(90, 148, 179, 106);
		
		JComboBox<String> cbxPeriodoEfetuar = new JComboBox<String>();
		cbxPeriodoEfetuar.setBounds(500, 234, 179, 20);
		cbxPeriodoEfetuar.addItem("temporario");
		cbxPeriodoEfetuar.addItem("permanente");
		
		txtReservaEfetuar = new JTextField();
		txtReservaEfetuar.setBounds(593, 279, 86, 20);
		txtReservaEfetuar.setColumns(10);
		
		txtMaximoEfetuar = new JTextField();
		txtMaximoEfetuar.setBounds(593, 317, 86, 20);
		txtMaximoEfetuar.setColumns(10);
		
		txtResponsavelEfetuar = new JTextField();
		txtResponsavelEfetuar.setBounds(90, 285, 179, 20);
		txtResponsavelEfetuar.setColumns(10);
		
		txtTelefoneEfetuar = new JTextField();
		txtTelefoneEfetuar.setBounds(90, 343, 179, 20);
		txtTelefoneEfetuar.setColumns(10);
		
		txtCepEfetuar = new JTextField();
		txtCepEfetuar.setBounds(279, 89, 193, 20);
		txtCepEfetuar.setColumns(10);
		
		txtCidadeEfetuar = new JTextField();
		txtCidadeEfetuar.setBounds(279, 234, 193, 20);
		txtCidadeEfetuar.setColumns(10);
		
		
		txtEnderecoEfetuar.setBounds(279, 148, 400, 55);
		
		txtInicioEfetuar = new JTextField();
		txtInicioEfetuar.setBounds(362, 279, 110, 20);
		txtInicioEfetuar.setColumns(10);
		
		txtFinalEfetuar = new JTextField();
		txtFinalEfetuar.setBounds(362, 317, 110, 20);
		txtFinalEfetuar.setColumns(10);
		
		JLabel lblRegistar = new JLabel("Efetuar novo cadastro");
		lblRegistar.setBounds(256, 17, 267, 41);
		lblRegistar.setHorizontalAlignment(SwingConstants.CENTER);
		lblRegistar.setFont(new Font("Tahoma", Font.PLAIN, 22));
		
		JButton btnLimparEfetuar = new JButton("Limpar");
		btnLimparEfetuar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				limparCampos();
			}
		});
		btnLimparEfetuar.setBounds(199, 419, 145, 46);
		
		JButton btnRegistrar = new JButton("Registrar");
		btnRegistrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				
				acervo.setTitulo(txtTituloEfetuar.getText());
				acervo.setDescricao(txtDescricaoEfetuar.getText());
				if(cbxPeriodoEfetuar.equals("temporario")){
					acervo.setPeriodo("temporario");
				}else{
					acervo.setPeriodo("permanente");
				}
				
				acervo.setDataInicio(txtInicioEfetuar.getText());
				acervo.setDataFinal(txtFinalEfetuar.getText());
				acervo.setCidade(txtCidadeEfetuar.getText());;
				acervo.setEndereco(txtEnderecoEfetuar.getText());
				acervo.setEstado(txtEstadoEfetuar.getText());
				acervo.setCep(txtCepEfetuar.getText());
				acervo.setResponsavel(txtResponsavelEfetuar.getText());
				acervo.setTelResponvel(txtTelefoneEfetuar.getText());
				acervo.setLimiteReserva(Integer.parseInt(txtReservaEfetuar.getText()));
				acervo.setMaxVisitante(Integer.parseInt(txtMaximoEfetuar.getText()));
				acervo.setEnviarConvites(true);
				
				String msg = contaCtrl.AdicionarAcervo(acervo);
				JOptionPane.showMessageDialog(null, msg);
				
			
			}
		});
		btnRegistrar.setBounds(397, 419, 145, 46);
		panel_1.setLayout(null);
		panel_1.add(lblRegistar);
		panel_1.add(lblTitullo);
		panel_1.add(lblCep);
		panel_1.add(lblEstado);
		panel_1.add(txtTituloEfetuar);
		panel_1.add(txtCepEfetuar);
		panel_1.add(lblDescrio);
		panel_1.add(lblEndereo);
		panel_1.add(txtDescricaoEfetuar);
		panel_1.add(txtEnderecoEfetuar);
		panel_1.add(lblCidade);
		panel_1.add(lblPeriodo);
		panel_1.add(txtCidadeEfetuar);
		panel_1.add(cbxPeriodoEfetuar);
		panel_1.add(lblResponsavel);
		panel_1.add(txtResponsavelEfetuar);
		panel_1.add(lblInicio);
		panel_1.add(txtInicioEfetuar);
		panel_1.add(lblLimiteDeReserva);
		panel_1.add(txtReservaEfetuar);
		panel_1.add(lblTelefone);
		panel_1.add(lblFinal);
		panel_1.add(txtFinalEfetuar);
		panel_1.add(lblMximoEVisitante);
		panel_1.add(txtMaximoEfetuar);
		panel_1.add(txtTelefoneEfetuar);
		panel_1.add(btnLimparEfetuar);
		panel_1.add(btnRegistrar);
		
		
		txtEstadoEfetuar = new JTextField();
		txtEstadoEfetuar.setColumns(10);
		txtEstadoEfetuar.setBounds(486, 90, 50, 20);
		panel_1.add(txtEstadoEfetuar);
		
		JPanel panel_2 = new JPanel();
		tabbedPane.addTab("Alterar", null, panel_2, null);
		
		
		
		JLabel lblSelecioneOTtulo = new JLabel("Selecione o T\u00EDtulo");
		
		txtTituloAlterar = new JTextField();
		txtTituloAlterar.setColumns(10);
		
		JLabel label = new JLabel("titullo ");
		
		txtCepAlterar = new JTextField();
		txtCepAlterar.setColumns(10);
		
		JLabel label_1 = new JLabel("CEP");
		
		JLabel lblAlterarCadastro = new JLabel("Alterar cadastro");
		lblAlterarCadastro.setHorizontalAlignment(SwingConstants.CENTER);
		lblAlterarCadastro.setFont(new Font("Tahoma", Font.PLAIN, 22));
		
		JComboBox<String> cbxEstadoAlterar = new JComboBox<String>();
		cbxEstadoAlterar.addItem("SP");
		
		JLabel label_3 = new JLabel("Estado");
		
		
		
		JLabel label_4 = new JLabel("Endere\u00E7o");
		
		JLabel label_5 = new JLabel("descri\u00E7\u00E3o ");
		
		
		
		txtCidadeAlterar = new JTextField();
		txtCidadeAlterar.setColumns(10);
		
		JLabel label_6 = new JLabel("Cidade");
		
		JComboBox<String> cbxPeriodoAlterar = new JComboBox<String>();
		cbxPeriodoAlterar.addItem("temporario");
		cbxPeriodoAlterar.addItem("permanente");
		
		JLabel label_7 = new JLabel("Periodo");
		
		txtInicioAlterar = new JTextField();
		txtInicioAlterar.setColumns(10);
		
		JLabel label_8 = new JLabel("Inicio");
		
		JLabel label_9 = new JLabel("final");
		
		txtDataFinalAlterar = new JTextField();
		txtDataFinalAlterar.setColumns(10);
		
		JLabel label_10 = new JLabel("M\u00E1ximo e visitante");
		
		JLabel label_11 = new JLabel("Limite de reserva");
		
		txtMaximoAlterar = new JTextField();
		txtMaximoAlterar.setColumns(10);
		
		txtLimiteAlterar = new JTextField();
		txtLimiteAlterar.setColumns(10);
		
		txtResponsavelAlterar = new JTextField();
		txtResponsavelAlterar.setColumns(10);
		
		JLabel label_12 = new JLabel("responsavel");
		
		JLabel label_13 = new JLabel("telefone");
		
		txtTelefoneAlterar = new JTextField();
		txtTelefoneAlterar.setColumns(10);
		
		JButton btnEditarAlterar = new JButton("Editar");
		btnEditarAlterar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
			}
		});
		
		JButton bntLimparAlterar = new JButton("Limpar");
		bntLimparAlterar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				limparCampos();
			}
		});
		
		JButton btnListar = new JButton("Listar");
		btnListar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			CrudAcervoCtrl lista = new CrudAcervoCtrl();
			int  tituloSelecionado = cbxTituloAlterar.getSelectedIndex();
			System.out.println(tituloSelecionado);
		 	lista.editar(tituloSelecionado);
		 	
		 	
		 		txtCepAlterar.setText(acervo.getCep());
		 		txtDescricaoAlterar.setText(acervo.getDescricao());
		 		txtInicioAlterar.setText(acervo.getDataInicio());
		 		txtDataFinalAlterar.setText(acervo.getDataFinal());
		 		txtCidadeAlterar.setText(acervo.getCidade());
		 		txtEnderecoAlterar.setText(acervo.getEndereco());
		 		txtCepAlterar.setText(acervo.getCep());
		 		txtResponsavelAlterar.setText(acervo.getResponsavel());
		 		txtLimiteAlterar.setText(Integer.toString(acervo.getLimiteReserva()));
		 		txtMaximoAlterar.setText(Integer.toString(acervo.getMaxVisitante()));
		 		txtTelefoneAlterar.setText(acervo.getTelResponvel());
		 	
		 
			}
			
		});
		GroupLayout gl_panel_2 = new GroupLayout(panel_2);
		gl_panel_2.setHorizontalGroup(
			gl_panel_2.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_panel_2.createSequentialGroup()
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(label)
							.addGap(160)
							.addComponent(label_1)
							.addGap(192)
							.addComponent(label_3))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(txtTituloAlterar, GroupLayout.PREFERRED_SIZE, 179, GroupLayout.PREFERRED_SIZE)
							.addGap(10)
							.addComponent(txtCepAlterar, GroupLayout.PREFERRED_SIZE, 193, GroupLayout.PREFERRED_SIZE)
							.addGap(18)
							.addComponent(cbxEstadoAlterar, GroupLayout.PREFERRED_SIZE, 52, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(label_5)
							.addGap(141)
							.addComponent(label_4))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(txtDescricaoAlterar, GroupLayout.PREFERRED_SIZE, 179, GroupLayout.PREFERRED_SIZE)
							.addGap(10)
							.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
								.addComponent(txtEnderecoAlterar, GroupLayout.PREFERRED_SIZE, 400, GroupLayout.PREFERRED_SIZE)
								.addGroup(gl_panel_2.createSequentialGroup()
									.addComponent(label_6)
									.addGap(188)
									.addComponent(label_7))
								.addGroup(gl_panel_2.createSequentialGroup()
									.addComponent(txtCidadeAlterar, GroupLayout.PREFERRED_SIZE, 193, GroupLayout.PREFERRED_SIZE)
									.addGap(28)
									.addComponent(cbxPeriodoAlterar, GroupLayout.PREFERRED_SIZE, 179, GroupLayout.PREFERRED_SIZE))))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(label_12))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(txtResponsavelAlterar, GroupLayout.PREFERRED_SIZE, 179, GroupLayout.PREFERRED_SIZE)
							.addGap(26)
							.addComponent(label_8, GroupLayout.PREFERRED_SIZE, 38, GroupLayout.PREFERRED_SIZE)
							.addGap(29)
							.addComponent(txtInicioAlterar, GroupLayout.PREFERRED_SIZE, 110, GroupLayout.PREFERRED_SIZE)
							.addGap(28)
							.addComponent(label_11)
							.addGap(11)
							.addComponent(txtLimiteAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(label_13)
							.addGap(165)
							.addComponent(label_9)
							.addGap(47)
							.addComponent(txtDataFinalAlterar, GroupLayout.PREFERRED_SIZE, 110, GroupLayout.PREFERRED_SIZE)
							.addGap(28)
							.addComponent(label_10)
							.addGap(4)
							.addComponent(txtMaximoAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(78)
							.addComponent(txtTelefoneAlterar, GroupLayout.PREFERRED_SIZE, 179, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(197)
							.addComponent(bntLimparAlterar, GroupLayout.PREFERRED_SIZE, 145, GroupLayout.PREFERRED_SIZE)
							.addGap(43)
							.addComponent(btnEditarAlterar, GroupLayout.PREFERRED_SIZE, 145, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(79)
							.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_panel_2.createSequentialGroup()
									.addComponent(cbxTituloAlterar, GroupLayout.PREFERRED_SIZE, 190, GroupLayout.PREFERRED_SIZE)
									.addGap(26)
									.addComponent(btnListar, GroupLayout.PREFERRED_SIZE, 101, GroupLayout.PREFERRED_SIZE))
								.addComponent(lblSelecioneOTtulo, GroupLayout.PREFERRED_SIZE, 131, GroupLayout.PREFERRED_SIZE)))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(308)
							.addComponent(lblAlterarCadastro, GroupLayout.PREFERRED_SIZE, 267, GroupLayout.PREFERRED_SIZE)))
					.addContainerGap(241, Short.MAX_VALUE))
		);
		gl_panel_2.setVerticalGroup(
			gl_panel_2.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_panel_2.createSequentialGroup()
					.addComponent(lblAlterarCadastro, GroupLayout.PREFERRED_SIZE, 41, GroupLayout.PREFERRED_SIZE)
					.addGap(13)
					.addComponent(lblSelecioneOTtulo)
					.addGap(11)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.BASELINE)
						.addComponent(btnListar)
						.addComponent(cbxTituloAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addGap(11)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(6)
							.addComponent(label))
						.addComponent(label_1)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(5)
							.addComponent(label_3)))
					.addGap(5)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(1)
							.addComponent(txtTituloAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(txtCepAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addComponent(cbxEstadoAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addGap(18)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addComponent(label_5)
						.addComponent(label_4))
					.addGap(6)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addComponent(txtDescricaoAlterar, GroupLayout.PREFERRED_SIZE, 106, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addComponent(txtEnderecoAlterar, GroupLayout.PREFERRED_SIZE, 55, GroupLayout.PREFERRED_SIZE)
							.addGap(6)
							.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_panel_2.createSequentialGroup()
									.addGap(3)
									.addComponent(label_6))
								.addComponent(label_7))
							.addGap(8)
							.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
								.addComponent(txtCidadeAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
								.addComponent(cbxPeriodoAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))))
					.addGap(11)
					.addComponent(label_12)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(6)
							.addComponent(txtResponsavelAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(3)
							.addComponent(label_8))
						.addComponent(txtInicioAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(3)
							.addComponent(label_11))
						.addComponent(txtLimiteAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addGap(12)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(3)
							.addComponent(label_13))
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(3)
							.addComponent(label_9))
						.addComponent(txtDataFinalAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_panel_2.createSequentialGroup()
							.addGap(3)
							.addComponent(label_10))
						.addComponent(txtMaximoAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addGap(6)
					.addComponent(txtTelefoneAlterar, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(11)
					.addGroup(gl_panel_2.createParallelGroup(Alignment.LEADING)
						.addComponent(bntLimparAlterar, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE)
						.addComponent(btnEditarAlterar, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE)))
		);
		panel_2.setLayout(gl_panel_2);
		
		
		
		JPanel panel_3 = new JPanel();
		tabbedPane.addTab("Remover", null, panel_3, null);
		
		JComboBox<Acervo> cbxTituloRemover = new JComboBox<Acervo>();
		
		JLabel label_2 = new JLabel("Selecione o T\u00EDtulo");
		
		JLabel lblRemovercadastro = new JLabel("Remover cadastro");
		lblRemovercadastro.setHorizontalAlignment(SwingConstants.CENTER);
		lblRemovercadastro.setFont(new Font("Tahoma", Font.PLAIN, 22));
		
		JButton btnRemover = new JButton("Remover");
		
		JButton bntCancelarRemover = new JButton("Cancelar");
		
		
		
		JButton bntListarRemover = new JButton("Listar");
		bntListarRemover.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				CrudAcervoCtrl lsAcervo = new CrudAcervoCtrl();
				ArrayList<Acervo> arrayAcervo = lsAcervo.obterAcervo();
 			for (Acervo acervo : arrayAcervo){cbxTituloRemover.addItem(acervo);}
			}
		});
		GroupLayout gl_panel_3 = new GroupLayout(panel_3);
		gl_panel_3.setHorizontalGroup(
			gl_panel_3.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_panel_3.createSequentialGroup()
					.addGroup(gl_panel_3.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_panel_3.createSequentialGroup()
							.addGap(230)
							.addComponent(lblRemovercadastro, GroupLayout.PREFERRED_SIZE, 267, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_3.createSequentialGroup()
							.addGap(172)
							.addComponent(label_2, GroupLayout.PREFERRED_SIZE, 131, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_3.createSequentialGroup()
							.addGap(172)
							.addComponent(cbxTituloRemover, GroupLayout.PREFERRED_SIZE, 333, GroupLayout.PREFERRED_SIZE)
							.addGap(18)
							.addComponent(bntListarRemover, GroupLayout.PREFERRED_SIZE, 109, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel_3.createSequentialGroup()
							.addGap(172)
							.addComponent(bntCancelarRemover, GroupLayout.PREFERRED_SIZE, 145, GroupLayout.PREFERRED_SIZE)
							.addGap(43)
							.addComponent(btnRemover, GroupLayout.PREFERRED_SIZE, 145, GroupLayout.PREFERRED_SIZE)))
					.addContainerGap(143, Short.MAX_VALUE))
		);
		gl_panel_3.setVerticalGroup(
			gl_panel_3.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_panel_3.createSequentialGroup()
					.addGap(40)
					.addComponent(lblRemovercadastro, GroupLayout.PREFERRED_SIZE, 41, GroupLayout.PREFERRED_SIZE)
					.addGap(28)
					.addComponent(label_2)
					.addGap(5)
					.addGroup(gl_panel_3.createParallelGroup(Alignment.BASELINE)
						.addComponent(cbxTituloRemover, GroupLayout.PREFERRED_SIZE, 27, GroupLayout.PREFERRED_SIZE)
						.addComponent(bntListarRemover))
					.addGap(64)
					.addGroup(gl_panel_3.createParallelGroup(Alignment.LEADING)
						.addComponent(bntCancelarRemover, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE)
						.addComponent(btnRemover, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE)))
		);
		panel_3.setLayout(gl_panel_3);
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addComponent(tabbedPane, GroupLayout.DEFAULT_SIZE, 776, Short.MAX_VALUE)
					.addContainerGap())
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addComponent(tabbedPane, GroupLayout.DEFAULT_SIZE, 473, Short.MAX_VALUE)
					.addContainerGap())
		);
		contentPane.setLayout(gl_contentPane);
	}
}
