import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class MainForm extends javax.swing.JFrame
{
   private long count=1000000000L;

   public MainForm()
   {
      initComponents();
      EdCount.selectAll();
      EdCount.requestFocus();
      getRootPane().setDefaultButton(BtnCalc);
      /*
      ActionListener onclick=new ActionListener()
      {
         @Override public void actionPerformed(ActionEvent evt)
         {
            BtnCalcActionPerformed(evt);
         }
      };
      */

      //BtnCalc.addActionListener(onclick);
      BtnCalc.addActionListener(evt -> BtnCalcActionPerformedAlt());
      BtnCalc.addActionListener(this::BtnCalcActionPerformed);
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { proceed(e); }
         @Override public void removeUpdate(DocumentEvent e) { proceed(e); }
         @Override public void changedUpdate(DocumentEvent e) { proceed(e); }
         public void proceed(DocumentEvent e)
         {
            try
            {
               count=Long.parseLong(EdCount.getText());
               BtnCalc.setEnabled(true);
            }
            catch(Exception ex)
            {
               BtnCalc.setEnabled(false);
            }
         }
      };
      EdCount.getDocument().addDocumentListener(listener);
      EdCount.setText(""+count);
   }

   private void BtnCalcActionPerformedAlt()
   {
      EdCount.selectAll();
      EdCount.requestFocus();
   }

   private double calculate(long count)
   {
      double sum=0;
      for(long i=1;i<=count;++i) sum+=1D/i;
      return sum;
   }

   private void run(long count)
   {
      EdResults.append(String.format("%d -> %.13f",count,calculate(count))+System.lineSeparator());
   }

   private void BtnCalcActionPerformed(ActionEvent evt)
   {
      new Thread(() -> run(count)).start();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      EdCount = new javax.swing.JTextField();
      BtnCalc = new javax.swing.JButton();
      EdResultsScroll = new javax.swing.JScrollPane();
      EdResults = new javax.swing.JTextArea();
      BtnThread = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdCount.setText("1000000000");

      BtnCalc.setText("Licz");

      EdResults.setEditable(false);
      EdResults.setColumns(20);
      EdResults.setRows(5);
      EdResultsScroll.setViewportView(EdResults);

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
               .addComponent(EdResultsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 466, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnCalc, javax.swing.GroupLayout.PREFERRED_SIZE, 61, javax.swing.GroupLayout.PREFERRED_SIZE)
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
            .addGap(11, 11, 11)
            .addComponent(EdResultsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 253, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void ThreadRun(int x,String str)
   {
      for(int i=1;i<10;++i)
      {
         EdResults.append(String.format("Wiersz %d",i)+System.lineSeparator());
         try { Thread.sleep(1000); }
         catch(InterruptedException ex) {}
      }
   }

   private void simple()
   {

   }

   private void BtnThreadActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnThreadActionPerformed
   {//GEN-HEADEREND:event_BtnThreadActionPerformed
      new Thread(this::simple).start();
      new Thread(() -> ThreadRun(1,"abc")).start();
   }//GEN-LAST:event_BtnThreadActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new MainForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCalc;
   private javax.swing.JButton BtnThread;
   private javax.swing.JTextField EdCount;
   private javax.swing.JTextArea EdResults;
   private javax.swing.JScrollPane EdResultsScroll;
   // End of variables declaration//GEN-END:variables
}
