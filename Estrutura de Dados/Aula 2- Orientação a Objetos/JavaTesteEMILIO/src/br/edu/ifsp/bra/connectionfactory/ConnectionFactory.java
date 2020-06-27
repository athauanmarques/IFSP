package br.edu.ifsp.bra.connectionfactory;

import java.sql.Connection;
import java.sql.DriverManager;
import javax.swing.JOptionPane;

public class ConnectionFactory {
    
    String url = "jdbc:mysql://localhost:3306/braveiculos",
           user = "root",
           password = "";
    
    public Connection getConnection() {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            return DriverManager.getConnection(url, user, password);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage());
            System.exit(0);
            return null;
        }
    }
}