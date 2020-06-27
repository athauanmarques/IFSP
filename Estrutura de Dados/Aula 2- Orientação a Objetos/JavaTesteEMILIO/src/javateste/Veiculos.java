package javateste;

import br.edu.ifsp.bra.connectionfactory.ConnectionFactory;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.JOptionPane;

public class Veiculos {

    private Connection conexao = new ConnectionFactory().getConnection();
    private PreparedStatement ps;
    private ResultSet rs;

    public Veiculos() {

        int opcao = 0;
        String conteudo;

        while (opcao != 6) {

            conteudo = "Carros\n\n1. Listar todos\n2. Buscar";
            conteudo += "\n3. Inserir\n4. Editar\n5. Remover";
            conteudo += "\n6. Sair\n\nDigite a opção desejada:";

            opcao = Integer.parseInt(JOptionPane.showInputDialog(null, conteudo));

            switch (opcao) {
                case 1:
                    listarTodos();
                    break;
                case 2:
                    buscar();
                    break;
                case 3:
                    inserir();
                    break;
                case 4:
                    editar();
                    break;
                case 5:
                    remover();
                    break;
                case 6:
                    JOptionPane.showMessageDialog(null, "Até mais!");
                    break;
                default:
                    JOptionPane.showMessageDialog(null, "Opção inválida. Tente outra vez.");
                    break;
            }

        }
    }
    
    // cria a listagem de veiculos
    private String criarListagem(ResultSet rs) {
        String table = "";
        int contador = 0;
        try {
            
            if (rs.next()) {

                rs.absolute(0); // volta cursor a posicao inicial

                table += "ID    Modelo  Fabricante\n\n";

                while ( rs.next() ) {

                    contador++;

                    table += rs.getInt("id") + "    ";
                    table += rs.getString("modelo") + " ";
                    table += rs.getString("fabricante") + "\n";

                }

                table += "\nTotal de registros: " + contador;
                
                return table;
                
            } else {
                
                return null;
                
            }

        } catch (Exception e) {

            JOptionPane.showMessageDialog(null, e.getMessage());
            
        }
        
        return null;
            
    }
    
    // listar registros (ResultSet)
    private void listarRs(ResultSet rs) {
        try {

            // gera listagem dos registros
            String table = criarListagem(rs);
            
            if (table == null) {
                throw new Exception("Nenhum registro encontrado.");
            } else {
                JOptionPane.showMessageDialog(null, table);
            }

        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Erro: " + e.getMessage());
        }
        
    }
    
    // lista todos os registros
    public void listarTodos() {

        try {

            ps = conexao.prepareStatement("SELECT * FROM carros");
            rs = ps.executeQuery();
            listarRs(rs);

        } catch (Exception e) {

            JOptionPane.showMessageDialog(null, "Erro: " + e.getMessage());

        }

    }
    
    // metodo buscar
    private void buscar() {
        String buscado = JOptionPane.showInputDialog(null, "Digite algo para buscar:");
        try {

            ps = conexao.prepareStatement("SELECT * FROM carros WHERE modelo LIKE ? OR fabricante LIKE ?");
            ps.setString(1, "%" + buscado + "%");
            ps.setString(2, "%" + buscado + "%");
            rs = ps.executeQuery();
            listarRs(rs);

        } catch (Exception e) {

            JOptionPane.showMessageDialog(null, "Erro: " + e.getMessage());

        }
    }
    
    // inserir
    public void inserir() {
        
        String modelo = JOptionPane.showInputDialog(null, "Digite o modelo:");
        String fabricante = JOptionPane.showInputDialog(null, "Digite o Fabricante:");
        
        try {
            
            ps = conexao.prepareStatement("INSERT INTO carros (modelo, fabricante) VALUES (?, ?)");
            ps.setString(1, modelo);
            ps.setString(2, fabricante);
            ps.execute();
            JOptionPane.showMessageDialog(null, modelo + " inserido com sucesso!");
            
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Erro: " + e.getMessage());
        }
        
    }
    
    // metodo editar
    private void editar() {

        try {
            
            // lista os registros
            String table;
            ps = conexao.prepareStatement("SELECT * FROM carros");
            rs = ps.executeQuery();
            
            // se nao encontrou registros
            if (!rs.next()) { throw new Exception("Nenhum registro encontrado."); }
            
            // gera listagem dos registros
            table = criarListagem(rs);
            
            table += "\nDigite o ID do carro que será editado: ";
            int id = Integer.parseInt(JOptionPane.showInputDialog(null, table));
            
            // encontra o veiculo com o id especificado
            ps = conexao.prepareStatement("SELECT * FROM carros WHERE id = ?");
            ps.setInt(1, id);
            rs = ps.executeQuery();
            
            // se nao encontrou
            if (!rs.next()) { throw new Exception("Nenhum registro encontrado com o ID " + id); }
            
            // le do usuario
            String modelo = JOptionPane.showInputDialog(null, "Digite o modelo:", "Edição de registro", JOptionPane.QUESTION_MESSAGE, null, null, rs.getString("modelo")).toString();
            String fabricante = JOptionPane.showInputDialog(null, "Digite o fabricante:", "Edição de registro", JOptionPane.QUESTION_MESSAGE, null, null, rs.getString("fabricante")).toString();
            
            // salvar
            ps = conexao.prepareStatement("UPDATE carros SET modelo = ?, fabricante = ? WHERE id = ?");
            ps.setString(1, modelo);
            ps.setString(2, fabricante);
            ps.setInt(3, id);
            ps.execute();
            JOptionPane.showMessageDialog(null, modelo + " atualizado com sucesso!");
            
        } catch (Exception e) {
            
            JOptionPane.showMessageDialog(null, e.getMessage());
            
        }
        
    }
    
    // metodo editar
    private void remover() {

        try {
            
            // lista os registros
            String table;
            ps = conexao.prepareStatement("SELECT * FROM carros");
            rs = ps.executeQuery();
            
            // se nao encontrou registros
            if (!rs.next()) { throw new Exception("Nenhum registro encontrado."); }
            
            // gera listagem dos registros
            table = criarListagem(rs);
            
            table += "\nDigite o ID do carro que será removido: ";
            int id = Integer.parseInt(JOptionPane.showInputDialog(null, table));
            
            // encontra o veiculo com o id especificado
            ps = conexao.prepareStatement("SELECT * FROM carros WHERE id = ?");
            ps.setInt(1, id);
            rs = ps.executeQuery();
            
            // se nao encontrou
            if (!rs.next()) { throw new Exception("Nenhum registro encontrado com o ID " + id); }
            
            // remover
            ps = conexao.prepareStatement("DELETE FROM carros WHERE id = ?");
            ps.setInt(1, id);
            ps.execute();
            JOptionPane.showMessageDialog(null, rs.getString("modelo") + " removido com sucesso!");
            
        } catch (Exception e) {
            
            JOptionPane.showMessageDialog(null, e.getMessage());
            
        }
        
    }

}
