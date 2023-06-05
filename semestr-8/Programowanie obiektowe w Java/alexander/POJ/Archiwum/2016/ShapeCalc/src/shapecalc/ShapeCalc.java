package shapecalc;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.event.ListDataListener;

public class ShapeCalc extends javax.swing.JFrame {

    private final javax.swing.JLabel[] labels;
    private final javax.swing.JTextField[] values;
    private IntfShapeCalc calc=null;
    private ShapeCalcMaker maker=new ShapeCalcMaker();
    private int[] priority=new int[] { 2,1,0 };
    private boolean changeInvokes=false;
    
    public ShapeCalc() 
    {
        initComponents();
        labels=new javax.swing.JLabel[] { Label0,Label1,Label2 };
        values=new javax.swing.JTextField[] { Value0,Value1,Value2 };        
        for(int i=0;i<values.length;++i)
        {
            javax.swing.JTextField fld=values[i];
            DocumentListener dl; 
            dl = new FieldListener(i)
            {
                @Override public void insertUpdate(DocumentEvent e) { callChange(getIndex()); }
                @Override public void removeUpdate(DocumentEvent e) { callChange(getIndex()); }
                @Override public void changedUpdate(DocumentEvent e) { callChange(getIndex()); }
            };
            fld.getDocument().addDocumentListener(dl);
        }
        ItemListener il=new ItemListener()
        {
            @Override public void itemStateChanged(ItemEvent e) 
            {
                kindChange((String)e.getItem());
            }
                     
        };
        DefaultComboBoxModel model=new DefaultComboBoxModel();
        String[] names=maker.names();
        for(String name:names) model.addElement(name);
        KindChoice.setModel(model);
        KindChoice.addItemListener(il);
        kindChange(names[0]);
    }
    
    private void kindChange(String name)
    {
        calc=maker.makeCalc(name);
        for(int i=0;i<labels.length;++i) labels[i].setText(calc.getName(i)+":");
    }
    
    private void callChange(int index)
    {
        if(!changeInvokes)
        {
            changeInvokes=true;
            try
            {
                calc.setValue(index,Integer.parseInt(values[index].getText()));
// przenosimy priority                
                int p=priority[0];
                values[p].setText(""+calc.calcValue(p));
            }
            catch(Exception e)
            {
            }
            changeInvokes=false;
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        KindChoice = new javax.swing.JComboBox();
        Label0 = new javax.swing.JLabel();
        Value0 = new javax.swing.JTextField();
        Label1 = new javax.swing.JLabel();
        Value1 = new javax.swing.JTextField();
        Label2 = new javax.swing.JLabel();
        Value2 = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        KindChoice.setPreferredSize(new java.awt.Dimension(100, 20));

        Label0.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        Label0.setText(":");
        Label0.setPreferredSize(new java.awt.Dimension(90, 14));

        Value0.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        Value0.setText("0");
        Value0.setPreferredSize(new java.awt.Dimension(80, 20));

        Label1.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        Label1.setText(":");
        Label1.setPreferredSize(new java.awt.Dimension(90, 14));

        Value1.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        Value1.setText("0");
        Value1.setPreferredSize(new java.awt.Dimension(80, 20));

        Label2.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        Label2.setText(":");
        Label2.setPreferredSize(new java.awt.Dimension(90, 14));

        Value2.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        Value2.setText("0");
        Value2.setPreferredSize(new java.awt.Dimension(80, 20));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(KindChoice, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(Label0, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(Value0, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(Label1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(Value1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(Label2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(Value2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(Label0, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(Value0, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(Label1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(Value1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(Label2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(Value2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addComponent(KindChoice, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(ShapeCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ShapeCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ShapeCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ShapeCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ShapeCalc().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox KindChoice;
    private javax.swing.JLabel Label0;
    private javax.swing.JLabel Label1;
    private javax.swing.JLabel Label2;
    private javax.swing.JTextField Value0;
    private javax.swing.JTextField Value1;
    private javax.swing.JTextField Value2;
    // End of variables declaration//GEN-END:variables
}
