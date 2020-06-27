package ArtiumSys.View;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JMenuItem;
import javax.swing.SwingConstants;
import javax.swing.BoxLayout;
import javax.swing.JMenuBar;
import javax.swing.JButton;
import java.awt.FlowLayout;
import javax.swing.JToggleButton;
import javax.swing.JMenu;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextArea;
import javax.swing.JDesktopPane;
import javax.swing.JTabbedPane;
import java.awt.GridBagLayout;
import java.awt.GridBagConstraints;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import java.awt.CardLayout;
import javax.swing.JRadioButton;
import java.awt.Color;

public class MainFuncionarioUI extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainFuncionarioUI frame = new MainFuncionarioUI();
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
	public MainFuncionarioUI() {
		setBackground(new Color(0, 0, 0));
		setTitle("Artium System");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 687, 438);
		
		JMenuBar menuBar = new JMenuBar();
		setJMenuBar(menuBar);
		
		JMenu mnGerenciar = new JMenu("Gerenciar");
		menuBar.add(mnGerenciar);
		
		JMenuItem mntmAcervos = new JMenuItem("Acervos");
		mntmAcervos.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		mnGerenciar.add(mntmAcervos);
		
		JMenuItem mntmExposicaoEventos = new JMenuItem("Exposi\u00E7\u00E3o & Eventos");
		mntmExposicaoEventos.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		mnGerenciar.add(mntmExposicaoEventos);
		
		JMenuItem mntmRestauracoes = new JMenuItem("Restaura\u00E7\u00F5es");
		mntmRestauracoes.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		mnGerenciar.add(mntmRestauracoes);
		
		JMenuItem mntmSouvenir = new JMenuItem("Souvenir ");
		mntmSouvenir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		mnGerenciar.add(mntmSouvenir);
		
		JMenu mnSair = new JMenu("Sair");
		menuBar.add(mnSair);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGap(0, 661, Short.MAX_VALUE)
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGap(0, 368, Short.MAX_VALUE)
		);
		contentPane.setLayout(gl_contentPane);
	}
}
