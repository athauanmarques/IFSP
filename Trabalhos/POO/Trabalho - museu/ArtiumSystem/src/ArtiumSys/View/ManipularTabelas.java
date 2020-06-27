package ArtiumSys.View;

import javax.swing.event.TableModelListener;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;

import ArtiumSys.Control.CrudAcervoCtrl;
import ArtiumSys.Model.Acervo;



public class ManipularTabelas implements TableModel {
	DefaultTableModel modelo = new DefaultTableModel();
	
	public ManipularTabelas(Acervo acervo) {
		CrudAcervoCtrl listar = new CrudAcervoCtrl();
		
		for(Acervo a: listar.read()){
			
			modelo.addRow(new Object[]{a.getCep(),a.getDescricao(),a.getDataInicio(),
					a.getDataFinal(),a.getCidade(),a.getEndereco(),a.getCep(),
					a.getResponsavel(),a.getLimiteReserva(),a.getMaxVisitante(),
					a.getTelResponvel()
			 		
				});
			
		}
	}

	@Override
	public int getRowCount() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public int getColumnCount() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public String getColumnName(int columnIndex) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Class<?> getColumnClass(int columnIndex) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean isCellEditable(int rowIndex, int columnIndex) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public Object getValueAt(int rowIndex, int columnIndex) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public void setValueAt(Object aValue, int rowIndex, int columnIndex) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void addTableModelListener(TableModelListener l) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void removeTableModelListener(TableModelListener l) {
		// TODO Auto-generated method stub
		
	}


}
