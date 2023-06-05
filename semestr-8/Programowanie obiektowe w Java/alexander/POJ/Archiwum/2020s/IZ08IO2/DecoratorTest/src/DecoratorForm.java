
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.ArrayList;
import javax.swing.BoxLayout;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JCheckBox;

public class DecoratorForm extends javax.swing.JFrame 
{
    private final DefaultComboBoxModel<String> kinds=new DefaultComboBoxModel<>();
    private final ArrayList<JCheckBox> decors=new ArrayList<>();
    public DecoratorForm()
    {
        initComponents();
        CbKinds.setModel(kinds);
        for(String kind:CarFabric.names()) kinds.addElement(kind);
        PnDecorators.setLayout(new BoxLayout(PnDecorators,BoxLayout.Y_AXIS));
        for(String kind:CarDecoratorFabric.names()) decors.add(new JCheckBox(kind));
        for(JCheckBox cb:decors) cb.setFocusable(true);
        for(JCheckBox cb:decors) PnDecorators.add(cb);
        getRootPane().setDefaultButton(BtnShow);
        final KeyListener antitab=new KeyListener()
        {
            @Override public void keyTyped(KeyEvent e) {}
            @Override public void keyReleased(KeyEvent e) {}
            @Override public void keyPressed(KeyEvent e)
            {
                if(e.getKeyCode()!=KeyEvent.VK_TAB) return;
                e.consume();
                transferFocusBackward();
            }
        };      
        EdLog.addKeyListener(antitab);
    }
    

    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        CbKinds = new javax.swing.JComboBox<>();
        BtnShow = new javax.swing.JButton();
        PnDecorators = new javax.swing.JPanel();
        EdLogScroll = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        BtnShow.setText("Show");
        BtnShow.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnShowActionPerformed(evt);
            }
        });

        PnDecorators.setFocusable(false);

        javax.swing.GroupLayout PnDecoratorsLayout = new javax.swing.GroupLayout(PnDecorators);
        PnDecorators.setLayout(PnDecoratorsLayout);
        PnDecoratorsLayout.setHorizontalGroup(
            PnDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        PnDecoratorsLayout.setVerticalGroup(
            PnDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 326, Short.MAX_VALUE)
        );

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
                    .addComponent(CbKinds, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(BtnShow, javax.swing.GroupLayout.DEFAULT_SIZE, 138, Short.MAX_VALUE)
                    .addComponent(PnDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 470, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(EdLogScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(PnDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnShow)))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnShowActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnShowActionPerformed
    {
        Car car=CarFabric.make(CbKinds.getSelectedItem().toString());
        for(JCheckBox cb:decors)
        {
            if(cb.isSelected()) car=CarDecoratorFabric.make(cb.getText(),car);
        }
        EdLog.append(car+System.lineSeparator());
    }//GEN-LAST:event_BtnShowActionPerformed

    public static void main(String args[]) 
    {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new DecoratorForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnShow;
    private javax.swing.JComboBox<String> CbKinds;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JScrollPane EdLogScroll;
    private javax.swing.JPanel PnDecorators;
    // End of variables declaration//GEN-END:variables
}
