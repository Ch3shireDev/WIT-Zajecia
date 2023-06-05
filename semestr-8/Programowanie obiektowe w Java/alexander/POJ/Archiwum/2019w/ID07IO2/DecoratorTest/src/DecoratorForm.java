
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.ListSelectionModel;

public class DecoratorForm extends javax.swing.JFrame {

    private final DefaultListModel<CheckListItem> decmodel=new DefaultListModel<>();
    private final DefaultComboBoxModel<String> carmodel=new DefaultComboBoxModel<>();
    
    public DecoratorForm() 
    {
        initComponents();
        DecorationList.setModel(decmodel);
        CarCombobox.setModel(carmodel);
        for(String item:Car.decorKeys()) decmodel.addElement(new CheckListItem(item));
        for(String item:Car.carKeys()) carmodel.addElement(item);
        DecorationList.setCellRenderer(new CheckListRenderer());
        DecorationList.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        final MouseAdapter mouseadaptor=new MouseAdapter() 
        {
            @Override public void mouseClicked(MouseEvent event) 
            {
                int index=DecorationList.locationToIndex(event.getPoint()); // Get index of item
                CheckListItem item=decmodel.getElementAt(index);
                item.setSelected(!item.isSelected()); // Toggle selected state
                DecorationList.repaint(DecorationList.getCellBounds(index,index)); // Repaint cell
            }
        };
        DecorationList.addMouseListener(mouseadaptor);
        for(int i=0;i<decmodel.getSize();++i)
        {
            if(decmodel.getElementAt(i).isSelected())
            {
                
            }
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        DecorationListScroll = new javax.swing.JScrollPane();
        DecorationList = new javax.swing.JList<>();
        CarCombobox = new javax.swing.JComboBox<>();
        BtnAdd = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        DecorationListScroll.setViewportView(DecorationList);

        BtnAdd.setText("Add");
        BtnAdd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(CarCombobox, javax.swing.GroupLayout.PREFERRED_SIZE, 115, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnAdd))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 89, Short.MAX_VALUE)
                .addComponent(DecorationListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 176, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CarCombobox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(BtnAdd))
                    .addComponent(DecorationListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(159, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
        
    }//GEN-LAST:event_BtnAddActionPerformed

    public static void main(String args[]) 
    {
        java.awt.EventQueue.invokeLater(() -> new DecoratorForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAdd;
    private javax.swing.JComboBox<String> CarCombobox;
    private javax.swing.JList<CheckListItem> DecorationList;
    private javax.swing.JScrollPane DecorationListScroll;
    // End of variables declaration//GEN-END:variables
}
