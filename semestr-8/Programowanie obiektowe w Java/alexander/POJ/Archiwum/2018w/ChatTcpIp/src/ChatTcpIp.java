
import java.awt.Color;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class ChatTcpIp extends javax.swing.JFrame
{
   private WorkManager work=null;

   public ChatTcpIp()
   {
      initComponents();
      final DocumentListener doc=new DocumentListener()
      {
        public void changedUpdate(DocumentEvent e) { edPortTextChange(); }
        public void removeUpdate(DocumentEvent e) { edPortTextChange(); }
        public void insertUpdate(DocumentEvent e) { edPortTextChange(); }
      };
      edPort.getDocument().addDocumentListener(doc);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      cbMode = new javax.swing.JComboBox<>();
      lbMode = new javax.swing.JLabel();
      lbPort = new javax.swing.JLabel();
      edPort = new javax.swing.JTextField();
      btnConnect = new javax.swing.JButton();
      edLogScroll = new javax.swing.JScrollPane();
      edLog = new javax.swing.JTextArea();
      edMessage = new javax.swing.JTextField();
      btnSend = new javax.swing.JButton();
      lbName = new javax.swing.JLabel();
      edName = new javax.swing.JTextField();
      lbHost = new javax.swing.JLabel();
      edHost = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setMinimumSize(new java.awt.Dimension(600, 220));

      cbMode.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Klient", "Server" }));
      cbMode.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            cbModeActionPerformed(evt);
         }
      });

      lbMode.setText("Tryb:");

      lbPort.setText("     Port:");

      edPort.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      edPort.setText("5555");

      btnConnect.setText("Połącz");
      btnConnect.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnConnectActionPerformed(evt);
         }
      });

      edLog.setEditable(false);
      edLog.setColumns(20);
      edLog.setRows(5);
      edLogScroll.setViewportView(edLog);

      btnSend.setText("Wyślij");

      lbName.setText("     Imie:");

      edName.setText("Ja");

      lbHost.setText("    Server:");

      edHost.setHorizontalAlignment(javax.swing.JTextField.LEFT);
      edHost.setText("localhost");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(edMessage)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnSend))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(lbMode)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(cbMode, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(lbPort)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(edPort, javax.swing.GroupLayout.PREFERRED_SIZE, 43, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(lbHost)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(edHost, javax.swing.GroupLayout.DEFAULT_SIZE, 76, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(lbName)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(edName, javax.swing.GroupLayout.PREFERRED_SIZE, 53, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnConnect))
               .addComponent(edLogScroll))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(lbMode)
               .addComponent(cbMode, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(lbPort)
               .addComponent(edPort, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnConnect)
               .addComponent(lbName)
               .addComponent(edName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                  .addComponent(lbHost)
                  .addComponent(edHost, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(edLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 108, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(edMessage, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnSend))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private boolean isClientMode() { return (cbMode.getSelectedIndex()==0); }
   private String getHost() { return edHost.getText(); }
   private void appendLog(String msg) { edLog.append(msg+System.lineSeparator()); }
   private int getPort()
   {
      int port=0;
      try
      {
         port=Integer.parseUnsignedInt(edPort.getText());
      }
      catch(Exception e) {}
      return port;
   }
   private void receiveSrv(ConnectionManager conn,String msg)
   {
      try { work.send(msg); } catch(Exception ex) {}
   }
   private void receiveCln(ConnectionManager conn,String msg)
   {
      appendLog(msg);
   }
   private void cbModeActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_cbModeActionPerformed
   {//GEN-HEADEREND:event_cbModeActionPerformed
      boolean isClient=isClientMode();
      lbHost.setEnabled(isClient);
      edHost.setEnabled(isClient);
      lbName.setEnabled(isClient);
      edName.setEnabled(isClient);
   }//GEN-LAST:event_cbModeActionPerformed

   private void edPortTextChange()
   {
      if(getPort()<=0)
      {
         lbPort.setForeground(Color.red);
         btnConnect.setEnabled(false);
      }
      else
      {
         lbPort.setForeground(Color.black);
         btnConnect.setEnabled(true);
      }
   }

   private void btnConnectActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnConnectActionPerformed
   {//GEN-HEADEREND:event_btnConnectActionPerformed
      boolean isClient=isClientMode();
      if(work!=null)
      {
         work.terminate();
         work=null;
         btnConnect.setText("Połącz");
         cbMode.setEnabled(true);
         lbPort.setEnabled(true);
         edPort.setEnabled(true);
         cbModeActionPerformed(null);
      }
      else
      {
         btnConnect.setText("Rozłącz");
         cbMode.setEnabled(false);
         lbPort.setEnabled(false);
         edPort.setEnabled(false);
         lbHost.setEnabled(false);
         edHost.setEnabled(false);
         lbName.setEnabled(false);
         edName.setEnabled(false);
         try
         {
            if(isClient) work=new ClientManager(getPort(),getHost(),this::receiveCln);
            else work=new ServerMenager(getPort(),this::receiveSrv);
         }
         catch(Exception e) { appendLog(e.getMessage()); }
      }
   }//GEN-LAST:event_btnConnectActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new ChatTcpIp().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnConnect;
   private javax.swing.JButton btnSend;
   private javax.swing.JComboBox<String> cbMode;
   private javax.swing.JTextField edHost;
   private javax.swing.JTextArea edLog;
   private javax.swing.JScrollPane edLogScroll;
   private javax.swing.JTextField edMessage;
   private javax.swing.JTextField edName;
   private javax.swing.JTextField edPort;
   private javax.swing.JLabel lbHost;
   private javax.swing.JLabel lbMode;
   private javax.swing.JLabel lbName;
   private javax.swing.JLabel lbPort;
   // End of variables declaration//GEN-END:variables
}
