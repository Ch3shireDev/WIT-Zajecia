
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import javax.swing.BoxLayout;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JCheckBox;

public class DecoratorForm extends javax.swing.JFrame 
{
    private final DefaultComboBoxModel<String> models=new DefaultComboBoxModel<>();
    private final ArrayList<JCheckBox> decors=new ArrayList<>();
    public DecoratorForm()
    {
        initComponents();
        CbModels.setModel(models);
        for(String model:CarFabric.models()) models.addElement(model);
        
        CbDecorators.setLayout(new BoxLayout(CbDecorators,BoxLayout.Y_AXIS));
        for(String decor:CarDecoratorFabric.models())
        {
            JCheckBox cb=new JCheckBox(decor);
            CbDecorators.add(cb);
            decors.add(cb);
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        CbModels = new javax.swing.JComboBox<>();
        CbDecorators = new javax.swing.JPanel();
        BtnShow = new javax.swing.JButton();
        EdLogScroll = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        javax.swing.GroupLayout CbDecoratorsLayout = new javax.swing.GroupLayout(CbDecorators);
        CbDecorators.setLayout(CbDecoratorsLayout);
        CbDecoratorsLayout.setHorizontalGroup(
            CbDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        CbDecoratorsLayout.setVerticalGroup(
            CbDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        BtnShow.setText("Show");
        BtnShow.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnShowActionPerformed(evt);
            }
        });

        EdLog.setEditable(false);
        EdLog.setColumns(20);
        EdLog.setRows(5);
        EdLogScroll.setViewportView(EdLog);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addComponent(CbModels, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(BtnShow, javax.swing.GroupLayout.DEFAULT_SIZE, 176, Short.MAX_VALUE)
                    .addComponent(CbDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 501, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbModels, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnShow))
                    .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 221, Short.MAX_VALUE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnShowActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnShowActionPerformed
        Car car=CarFabric.make(CbModels.getSelectedItem().toString());
        for(JCheckBox cb:decors)
        {
            if(cb.isSelected()) car=CarDecoratorFabric.make(cb.getText(),car);
        }
        EdLog.append(car+System.lineSeparator());
    }//GEN-LAST:event_BtnShowActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new DecoratorForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnShow;
    private javax.swing.JPanel CbDecorators;
    private javax.swing.JComboBox<String> CbModels;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JScrollPane EdLogScroll;
    // End of variables declaration//GEN-END:variables
}
