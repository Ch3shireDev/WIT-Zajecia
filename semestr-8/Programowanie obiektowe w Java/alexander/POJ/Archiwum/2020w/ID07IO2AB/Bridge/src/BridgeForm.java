
import java.awt.Color;
import java.awt.Graphics;

public class BridgeForm extends javax.swing.JFrame
{
   public BridgeForm()
   {
      initComponents();
   }

   private void onpaint(Graphics g)
   {
      g.setColor(Color.red);
      g.drawPolyline(new int[]{100,100,250,100}, new int[]{100,300,300,100}, 4);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      CbFigureKind = new javax.swing.JComboBox();
      EdCbFigureParameters = new javax.swing.JTextField();
      BtnCrreate = new javax.swing.JButton();
      PnDrawArea = new OwnerDrawPanel(this::onpaint);
      jScrollPane1 = new javax.swing.JScrollPane();
      EdLogArea = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      CbFigureKind.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

      EdCbFigureParameters.setText("100 100 400 100 400 500");

      BtnCrreate.setText("Create");

      javax.swing.GroupLayout PnDrawAreaLayout = new javax.swing.GroupLayout(PnDrawArea);
      PnDrawArea.setLayout(PnDrawAreaLayout);
      PnDrawAreaLayout.setHorizontalGroup(
         PnDrawAreaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );
      PnDrawAreaLayout.setVerticalGroup(
         PnDrawAreaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 459, Short.MAX_VALUE)
      );

      EdLogArea.setColumns(20);
      EdLogArea.setRows(5);
      jScrollPane1.setViewportView(EdLogArea);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(PnDrawArea, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addComponent(CbFigureKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdCbFigureParameters, javax.swing.GroupLayout.DEFAULT_SIZE, 479, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnCrreate))
               .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.TRAILING))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbFigureKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(EdCbFigureParameters, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnCrreate))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(PnDrawArea, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 77, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new BridgeForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCrreate;
   private javax.swing.JComboBox CbFigureKind;
   private javax.swing.JTextField EdCbFigureParameters;
   private javax.swing.JTextArea EdLogArea;
   private javax.swing.JPanel PnDrawArea;
   private javax.swing.JScrollPane jScrollPane1;
   // End of variables declaration//GEN-END:variables
}
