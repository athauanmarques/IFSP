package br.ifsp.banco.visao;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.border.BevelBorder;

public class PrincipalGUI {

	public static void main(String[] args) {
	 
		JFrame frame = new JFrame("Banco");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize(800, 400);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		JMenuBar menuBar = new JMenuBar();
		menuBar.setBorder(new BevelBorder( BevelBorder.RAISED));
		
		JMenu menuCadastro = new JMenu("Cadastro");
		JMenu menuRelatorio = new JMenu("Relatorios");
		
		JMenuItem menuItemClientes = new JMenuItem("Clientes");
		menuItemClientes.addActionListener(new ActionListener() {
			
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "cadastro não existe");
			}
			
		});
		menuCadastro.add(menuItemClientes);
		
		JMenuItem menuItemContas = new JMenuItem("Contas");
		menuItemContas.addActionListener(new ActionListener() {
			
			public void actionPerformed(ActionEvent e) {
				new cadastrarContas();
			}
			
		});
		
		menuCadastro.add(menuItemContas);
		
		JMenuItem menuItemListaCliente = new JMenuItem("Lista Clientes");
		menuItemListaCliente.addActionListener(new ActionListener() {
			
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "relatório não existe");
			}
			
		});
		
		menuRelatorio.add(menuItemListaCliente);
		
		menuCadastro.addSeparator();
		
		JMenuItem menuItemSair = new JMenuItem("Sair");
		menuItemSair.addActionListener(new ActionListener() {
			
			public void actionPerformed(ActionEvent e) {
				frame.dispose();
			}
			
		});
		menuCadastro.add(menuItemSair);
		
		menuBar.add(menuCadastro);
		menuBar.add(menuRelatorio);
		
		frame.setJMenuBar(menuBar);
		

	}

}
