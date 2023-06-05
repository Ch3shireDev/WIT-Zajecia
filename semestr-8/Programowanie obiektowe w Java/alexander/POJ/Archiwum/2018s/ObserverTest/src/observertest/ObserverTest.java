
package observertest;

public class ObserverTest extends javax.swing.JFrame {

   public ObserverTest() {
      initComponents();
      Observable ob=new TimeSwitcher(LbTime);
      ob=new PanelObserver(PanelA,ob);
      ob=new PanelObserver(PanelB,ob);
      ob=new PanelObserver(PanelC,ob);
      ob=new PanelObserver(PanelD,ob);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      PanelB = new javax.swing.JPanel();
      PanelC = new javax.swing.JPanel();
      PanelA = new javax.swing.JPanel();
      LbTime = new javax.swing.JLabel();
      PanelD = new javax.swing.JPanel();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setMinimumSize(new java.awt.Dimension(688, 200));

      javax.swing.GroupLayout PanelBLayout = new javax.swing.GroupLayout(PanelB);
      PanelB.setLayout(PanelBLayout);
      PanelBLayout.setHorizontalGroup(
         PanelBLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 161, Short.MAX_VALUE)
      );
      PanelBLayout.setVerticalGroup(
         PanelBLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout PanelCLayout = new javax.swing.GroupLayout(PanelC);
      PanelC.setLayout(PanelCLayout);
      PanelCLayout.setHorizontalGroup(
         PanelCLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 157, Short.MAX_VALUE)
      );
      PanelCLayout.setVerticalGroup(
         PanelCLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 158, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout PanelALayout = new javax.swing.GroupLayout(PanelA);
      PanelA.setLayout(PanelALayout);
      PanelALayout.setHorizontalGroup(
         PanelALayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 161, Short.MAX_VALUE)
      );
      PanelALayout.setVerticalGroup(
         PanelALayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      LbTime.setText("*");

      javax.swing.GroupLayout PanelDLayout = new javax.swing.GroupLayout(PanelD);
      PanelD.setLayout(PanelDLayout);
      PanelDLayout.setHorizontalGroup(
         PanelDLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 157, Short.MAX_VALUE)
      );
      PanelDLayout.setVerticalGroup(
         PanelDLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(LbTime, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(PanelA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                  .addComponent(PanelB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                  .addComponent(PanelC, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(PanelD, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(0, 0, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(LbTime, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addGap(11, 11, 11)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
               .addComponent(PanelC, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(PanelB, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(PanelA, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(PanelD, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
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
         java.util.logging.Logger.getLogger(ObserverTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(ObserverTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(ObserverTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(ObserverTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      Runnable go=new Runnable()
      {
         @Override public void run() { new ObserverTest().setVisible(true); }
      };
      java.awt.EventQueue.invokeLater(go);
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JLabel LbTime;
   private javax.swing.JPanel PanelA;
   private javax.swing.JPanel PanelB;
   private javax.swing.JPanel PanelC;
   private javax.swing.JPanel PanelD;
   // End of variables declaration//GEN-END:variables
}
