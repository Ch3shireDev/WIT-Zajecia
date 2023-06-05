
import java.awt.event.ActionEvent;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class HarmCalc extends javax.swing.JFrame //implements ActionListener //implements DocumentListener
{
   private long count=1000000000;
   public HarmCalc()
   {
      initComponents();
      /*
      ActionListener listener=new ActionListener()
      {
         @Override public void actionPerformed(ActionEvent e)
         {
            BtnCalcActionPerformed(e);
         }

      };
      BtnCalc.addActionListener(listener);
      */
      BtnCalc.addActionListener(e -> BtnCalcActionPerformed(e));
      //BtnCalc.addActionListener(this::BtnCalcActionPerformed);
      //BtnCalc.addActionListener(this);
      getRootPane().setDefaultButton(BtnCalc);
      final DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { EdCountOnChange(e); }
         @Override public void removeUpdate(DocumentEvent e) { EdCountOnChange(e); }
         @Override public void changedUpdate(DocumentEvent e) { EdCountOnChange(e); }
      };
      EdCount.getDocument().addDocumentListener(listener);
      //EdCount.getDocument().addDocumentListener(this);
      EdCount.setText(""+count);
   }

   //@Override public void actionPerformed(ActionEvent e) { BtnCalcActionPerformed(e); }
   //@Override public void insertUpdate(DocumentEvent e) { EdCountOnChange(e); }
   //@Override public void removeUpdate(DocumentEvent e) { EdCountOnChange(e); }
   //@Override public void changedUpdate(DocumentEvent e) { EdCountOnChange(e); }

   public void EdCountOnChange(DocumentEvent e)
   {
      try
      {
         count=Long.parseLong(EdCount.getText());
         BtnCalc.setEnabled(true);
      }
      catch(NumberFormatException ex)
      {
         BtnCalc.setEnabled(false);
      }
   }

   private double calculate(long count)
   {
      double sum=0;
      for(long i=1;i<=count;++i) sum+=1D/i;
      return sum;
   }

   private void append(String fmt,Object ... lst)
   {
      EdResult.append(String.format(fmt,lst)+System.lineSeparator());
   }

   private void execute(long count)
   {
      //EdResult.append(String.format("%s -> %.13f",count,calculate(count))+System.lineSeparator());
      append("%s -> %.13f",count,calculate(count));
   }

   private void BtnCalcActionPerformed(ActionEvent e)
   {
      EdCount.selectAll();
      EdCount.requestFocus();
      new Thread(() -> execute(count)).start();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      EdCount = new javax.swing.JTextField();
      BtnCalc = new javax.swing.JButton();
      EdResultScroll = new javax.swing.JScrollPane();
      EdResult = new javax.swing.JTextArea();
      BtnThread = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);

      BtnCalc.setText("Licz");

      EdResult.setEditable(false);
      EdResult.setColumns(20);
      EdResult.setRows(5);
      EdResultScroll.setViewportView(EdResult);

      BtnThread.setText("Wątek");
      BtnThread.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnThreadActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdResultScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 349, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 98, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnCalc)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(BtnThread)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnCalc)
               .addComponent(BtnThread))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdResultScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 276, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void runThread()
   {
      try
      {
         for(int i=1;i<10;++i)
         {
            EdResult.append(String.format("%d"+System.lineSeparator(),i));
            Thread.sleep(1000);
         }
      }
      catch(InterruptedException ex) {}
   }

   private void BtnThreadActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnThreadActionPerformed
   {//GEN-HEADEREND:event_BtnThreadActionPerformed
      new Thread(() -> runThread()).start();
   }//GEN-LAST:event_BtnThreadActionPerformed

   public static void main(String args[])
   {
      /*
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new HarmCalc().setVisible(true);
         }
      });
      */
      java.awt.EventQueue.invokeLater(() -> new HarmCalc().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCalc;
   private javax.swing.JButton BtnThread;
   private javax.swing.JTextField EdCount;
   private javax.swing.JTextArea EdResult;
   private javax.swing.JScrollPane EdResultScroll;
   // End of variables declaration//GEN-END:variables
}
