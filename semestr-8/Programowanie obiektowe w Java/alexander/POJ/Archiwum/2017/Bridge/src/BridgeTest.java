
import core.*;
import java.util.HashMap;
import javafx.animation.KeyValue;
import screen.GUI.GuiScreen;
import screen.IFigureMake;
import screen.TUI.TuiScreen;

public class BridgeTest extends javax.swing.JFrame {

   private HashMap<String,IFigureMake> map = new HashMap<String,IFigureMake>()
   {
      {
         put("Triangle",() -> { return makeTriangle(); });
         put("Rectangle",() -> { return makeRectangle(); });
         put("Circle",() -> { return makeCircle(); });
      } 
   };
   private Figure fig=null;
   private GuiScreen gui;
   private TuiScreen tui;

   public BridgeTest() {
      initComponents();
      for(String item : map.keySet()) Kind.addItem(item);
      gui = new GuiScreen(Box.getGraphics());
      tui = new TuiScreen();
      ((PaintPanel)Box).setCall(() -> redraw() );
   }
   
   private void redraw()
   {
      if(fig!=null) fig.Draw(gui);
   }

   private Figure makeTriangle()
   {
      String[] tbs=Params.getText().split(",");
      int[] tb=new int[6];
      for(int i=0;i<tb.length;++i) tb[i]=Integer.parseInt(tbs[i]);
      return new Triangle(new Point(tb[0],tb[1]),new Point(tb[2],tb[3]),new Point(tb[4],tb[5]));
   }

   private Figure makeRectangle()
   {
      String[] tbs=Params.getText().split(",");
      int[] tb=new int[4];
      for(int i=0;i<tb.length;++i) tb[i]=Integer.parseInt(tbs[i]);
      return new Rectangle(new Point(tb[0],tb[1]),new Point(tb[2],tb[3]));
   }

   private Figure makeCircle()
   {
      String[] tbs=Params.getText().split(",");
      int[] tb=new int[3];
      for(int i=0;i<tb.length;++i) tb[i]=Integer.parseInt(tbs[i]);
      return new Circle(new Point(tb[0],tb[1]),tb[2]);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      Kind = new javax.swing.JComboBox<>();
      Params = new javax.swing.JTextField();
      Box = new PaintPanel();
      btnGenerate = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      Params.setText("50,50,10,10,10,50");
      Params.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            ParamsActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout BoxLayout = new javax.swing.GroupLayout(Box);
      Box.setLayout(BoxLayout);
      BoxLayout.setHorizontalGroup(
         BoxLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );
      BoxLayout.setVerticalGroup(
         BoxLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 249, Short.MAX_VALUE)
      );

      btnGenerate.setText("Generate");
      btnGenerate.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnGenerateActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(Box, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(Kind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(Params, javax.swing.GroupLayout.DEFAULT_SIZE, 384, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnGenerate)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(Kind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(Params, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnGenerate))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
            .addComponent(Box, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGap(6, 6, 6))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnGenerateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGenerateActionPerformed
      String kind=Kind.getSelectedItem().toString();
      fig=map.get(kind).make();
      fig.Draw(tui);
      fig.Draw(gui);
   }//GEN-LAST:event_btnGenerateActionPerformed

   private void ParamsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ParamsActionPerformed
      // TODO add your handling code here:
   }//GEN-LAST:event_ParamsActionPerformed

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
         java.util.logging.Logger.getLogger(BridgeTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(BridgeTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(BridgeTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(BridgeTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new BridgeTest().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JPanel Box;
   private javax.swing.JComboBox<String> Kind;
   private javax.swing.JTextField Params;
   private javax.swing.JButton btnGenerate;
   // End of variables declaration//GEN-END:variables
}
