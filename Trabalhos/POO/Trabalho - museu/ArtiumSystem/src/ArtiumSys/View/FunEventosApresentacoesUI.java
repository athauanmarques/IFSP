package ArtiumSys.View;

import java.awt.EventQueue;
import javax.swing.table.DefaultTableModel;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JLabel;

import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.ArrayList;

import ArtiumSys.Model.Acervo;
import ArtiumSys.Control.CrudAcervoCtrl;
import javax.swing.JScrollPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class FunEventosApresentacoesUI extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTable table_1;
	Acervo acervo = new Acervo();
	CrudAcervoCtrl listaEnviar = new CrudAcervoCtrl();
	private JTable tbEventoExibicao;
	DefaultTableModel modelo = new DefaultTableModel();

	
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FunEventosApresentacoesUI frame = new FunEventosApresentacoesUI();
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
	public FunEventosApresentacoesUI() {
		DefaultTableModel modelo = new DefaultTableModel();
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowOpened(WindowEvent e) {
				
					carregarTabela();
				
			}

							
		});
		setTitle("Eventos & Apresenta\u00E7oes");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 964, 606);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addComponent(tabbedPane, GroupLayout.DEFAULT_SIZE, 709, Short.MAX_VALUE)
					.addContainerGap())
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addComponent(tabbedPane, GroupLayout.DEFAULT_SIZE, 390, Short.MAX_VALUE)
					.addContainerGap())
		);
		
		
		JPanel panel = new JPanel();
		tabbedPane.addTab("Em Exibi\u00E7\u00E3o", null, panel, null);
		
		
		JLabel lblEventosEApresentaes = new JLabel("Eventos e Apresenta\u00E7\u00F5es");
		
		JScrollPane scrollPane = new JScrollPane();
		
		tbEventoExibicao = new JTable(modelo);
		scrollPane.setViewportView(tbEventoExibicao);
		
		JButton btnAtualizar = new JButton("Atualizar");
		btnAtualizar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				carregarTabela();
			}
		});
		GroupLayout gl_panel = new GroupLayout(panel);
		gl_panel.setHorizontalGroup(
			gl_panel.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_panel.createSequentialGroup()
					.addGroup(gl_panel.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_panel.createSequentialGroup()
							.addGap(58)
							.addComponent(lblEventosEApresentaes, GroupLayout.PREFERRED_SIZE, 598, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel.createSequentialGroup()
							.addGap(57)
							.addComponent(scrollPane, GroupLayout.PREFERRED_SIZE, 777, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_panel.createSequentialGroup()
							.addGap(379)
							.addComponent(btnAtualizar)))
					.addContainerGap(79, Short.MAX_VALUE))
		);
		gl_panel.setVerticalGroup(
			gl_panel.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_panel.createSequentialGroup()
					.addGap(26)
					.addComponent(lblEventosEApresentaes)
					.addGap(11)
					.addComponent(scrollPane, GroupLayout.PREFERRED_SIZE, 370, GroupLayout.PREFERRED_SIZE)
					.addGap(18)
					.addComponent(btnAtualizar)
					.addGap(45))
		);
		panel.setLayout(gl_panel);
		modelo.addColumn("Codigo");
		modelo.addColumn("Titulo");
		modelo.addColumn("Descricao");
		modelo.addColumn("Periodo");
		modelo.addColumn("Data Inicio");
		modelo.addColumn("Data Final");
		modelo.addColumn("Cidade");
		modelo.addColumn("Endereco");
		modelo.addColumn("Cep");
		modelo.addColumn("Responsavel");
		modelo.addColumn("Telefone do Responvel");
		modelo.addColumn("Limite para Reserva");
		modelo.addColumn("Maximo Visitante");
		modelo.addColumn("Convites enviado");

		
		
		JPanel panel_1 = new JPanel();
		tabbedPane.addTab("Realizado", null, panel_1, null);
		panel_1.setLayout(null);
		
		table_1 = new JTable(modelo);
		table_1.setBounds(45, 52, 598, 279);
		panel_1.add(table_1);
		
		JLabel label = new JLabel("Eventos e Apresenta\u00E7\u00F5es");
		label.setBounds(45, 27, 598, 14);
		panel_1.add(label);
		contentPane.setLayout(gl_contentPane);
		
		
	}
	
	public void carregarTabela(){
		ArrayList<Acervo> list = listaEnviar.listarTabela();
		for(Acervo a :  list){
			modelo.addRow(new Object[]{a.getIdAcevo(),a.getTitulo(),a.getDescricao(),a.getPeriodo(),a.getDataInicio(),
						  a.getDataFinal(),a.getCidade(),a.getEndereco(),a.getCep(),a.getResponsavel(),a.getTelResponvel(),
						  a.getLimiteReserva(),a.getMaxVisitante(),a.isEnviarConvites()});
		}
	
	
		}
}
