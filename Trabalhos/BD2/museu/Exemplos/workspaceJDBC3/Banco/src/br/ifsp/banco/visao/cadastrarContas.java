package br.ifsp.banco.visao;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import br.ifsp.banco.controle.CadastrarContaCtrl;
import br.ifsp.modelo.Cliente;
import br.ifsp.modelo.Conta;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;


public class cadastrarContas {
		public cadastrarContas () {
		JFrame frameCadContas = new JFrame("Cadastro de Contas");
		frameCadContas.setSize(400, 240);
		frameCadContas.setVisible(true);
		frameCadContas.setLocationRelativeTo(null);
		
		JPanel panel = new JPanel();
		JLabel rotuloNumero = new JLabel();
		
		rotuloNumero.setText("Numero: ");
		panel.add(rotuloNumero);
		
		JTextField textFieldNumero = new JTextField(20);
		panel.add(textFieldNumero);
		
		JLabel rotuloSaldo = new JLabel();
		rotuloSaldo.setText("Saldo: ");
		panel.add(rotuloSaldo);
		
		JTextField textFieldSaldo = new JTextField(15);
		panel.add(textFieldSaldo);
		
		CadastrarContaCtrl ccc = new CadastrarContaCtrl();
		ArrayList<Cliente> arrayClientes = ccc.obterClientes();
		
		JComboBox<Cliente> comboBoxClientes = new JComboBox<Cliente>();
		
		for (Cliente cliente : arrayClientes) {comboBoxClientes.addItem(cliente);}
		
		panel.add(comboBoxClientes);
		
		JButton buttonSalvar = new JButton (" Salvar ");
		buttonSalvar.addActionListener(new ActionListener() {

				@Override
				public void actionPerformed(ActionEvent e) {
					Conta conta = new Conta();
					conta.setNumero(textFieldNumero.getText());
					conta.setSaldo(Double.parseDouble(textFieldSaldo.getText()));
					
					Cliente cliente = (Cliente) comboBoxClientes.getSelectedItem();
					conta.setCliente(cliente);
					
					CadastrarContaCtrl ccc = new CadastrarContaCtrl();
					ccc.gravarConta(conta);
					
				}
	});
		
		panel.add(buttonSalvar);
		
		JButton buttonCancelar = new JButton(" Cancelar ");
		buttonCancelar.addActionListener(new ActionListener () {
			
			public void actionPerformed(ActionEvent e) {
				frameCadContas.dispose();
			}
		});
		
		panel.add(buttonCancelar);
		
		frameCadContas.setContentPane(panel);
	
	
		
	}
		
}
		
		
		