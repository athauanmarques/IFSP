import java.util.ArrayList;

public interface ClienteDAO {
	public void gravaCliente (Cliente cliente);
	public ArrayList<Cliente> obterCliente();
	public Cliente obterCliente (int idCliente);

}
