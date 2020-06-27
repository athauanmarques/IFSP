package br.ifsp.banco.controle;
import java.sql.DriverManager;
import java.util.Scanner;

import br.ifsp.banco.bd.ConnectionFactory;

import java.sql.PreparedStatement;

import java.sql.Connection;

public class InsereCliente {
	public static void main(String[] cachorro ) {
		Scanner entrada = new Scanner(System.in);
		/*
		String strConnection = "jdbc:mysql://localhost:3306/banco";
		String user = "root";
		String pass = "ifsp";*/
		try {
			System.out.println("Abrindo a conection");
			//Connection con = DriverManager.getConnection(strConnection,user,pass);
			Connection con = ConnectionFactory.createConnection();
			System.out.println("Digite o nome do usuário:");
			String nome= entrada.next();
			System.out.println("Digite seu cpf:");
			String cpf = entrada.next();
			//String sql = "insert into cliente(nome,cpf) values "+"('"+nome+"','"+cpf+"')";
			String sql = "insert into cliente(nome,cpf) values (?,?)";
			
			PreparedStatement comando = con.prepareStatement(sql);
			comando.setString(1, nome);
			comando.setString(2, cpf);
			System.out.println("Executando o comando...");
			comando.execute();
			System.out.println("Fechando a connection");
			comando.close();
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
	}
}
