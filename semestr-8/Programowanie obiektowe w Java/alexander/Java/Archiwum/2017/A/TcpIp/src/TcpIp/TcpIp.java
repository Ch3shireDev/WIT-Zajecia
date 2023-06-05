package TcpIp;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class TcpIp extends javax.swing.JFrame implements ThreadParent
{
   private ServerThread server;
   private SocketThread client;
   private boolean stop;   
   public TcpIp()
   {
      initComponents();
      stop=false;
   }
   @Override public void appendMessage(String msg) { BoxText.append(msg+"\n"); }   
   @Override public boolean stoped() { return stop; }
   @Override public void finished(SocketThread th) 
   {
      client=null; 
   }
   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdHost = new javax.swing.JTextField();
      LbHost = new javax.swing.JLabel();
      LbSemicolon = new javax.swing.JLabel();
      EdClnPort = new javax.swing.JTextField();
      BtnClnConn = new javax.swing.JButton();
      LbPort = new javax.swing.JLabel();
      EdSrvPort = new javax.swing.JTextField();
      BtnSrvConn = new javax.swing.JButton();
      BoxScroll = new javax.swing.JScrollPane();
      BoxText = new javax.swing.JTextArea();
      EdMessage = new javax.swing.JTextField();
      BtnSend = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      addWindowListener(new java.awt.event.WindowAdapter() {
         public void windowClosed(java.awt.event.WindowEvent evt) {
            formWindowClosed(evt);
         }
      });

      EdHost.setText("localhost");

      LbHost.setText("host:");

      LbSemicolon.setText(":");

      EdClnPort.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdClnPort.setText("3000");

      BtnClnConn.setText("Connect");
      BtnClnConn.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnClnConnActionPerformed(evt);
         }
      });

      LbPort.setText("port:");

      EdSrvPort.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdSrvPort.setText("3000");

      BtnSrvConn.setText("Connect");
      BtnSrvConn.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnSrvConnActionPerformed(evt);
         }
      });

      BoxText.setEditable(false);
      BoxText.setColumns(20);
      BoxText.setRows(5);
      BoxScroll.setViewportView(BoxText);

      EdMessage.setEditable(false);
      EdMessage.setText("Hello");
      EdMessage.addKeyListener(new java.awt.event.KeyAdapter() {
         public void keyPressed(java.awt.event.KeyEvent evt) {
            EdMessageKeyPressed(evt);
         }
      });

      BtnSend.setText("Send");
      BtnSend.setEnabled(false);
      BtnSend.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnSendActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(BoxScroll, javax.swing.GroupLayout.Alignment.TRAILING)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(LbHost)
                     .addComponent(LbPort))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(EdSrvPort, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnSrvConn))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(EdHost, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(LbSemicolon)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdClnPort, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnClnConn)))
                  .addGap(0, 153, Short.MAX_VALUE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdMessage)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnSend)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(LbHost)
               .addComponent(EdHost, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(LbSemicolon)
               .addComponent(EdClnPort, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnClnConn))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(LbPort)
               .addComponent(EdSrvPort, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnSrvConn))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(BoxScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 251, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdMessage, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnSend))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

    private void BtnSrvConnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSrvConnActionPerformed
      try
      {
         if(server==null)
         {
            appendMessage("Server started");
            ServerSocket srv=new ServerSocket(Integer.parseInt(EdSrvPort.getText()));         
            server=new ServerThread(this, srv);
            server.start();
            BtnSrvConn.setText("Disconnect");
         }
         else
         {
            appendMessage("Server terminating");            
            server.terminate();
            server=null;
            BtnSrvConn.setText("Connect");
         }
      } 
      catch (IOException ex) 
      {
         appendMessage(ex.getMessage());
      }
    }//GEN-LAST:event_BtnSrvConnActionPerformed

    private void BtnClnConnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnClnConnActionPerformed
      try 
      {
         if(client==null)
         {
            Socket sock=new Socket(EdHost.getText(),Integer.parseInt(EdClnPort.getText()));
            client=new SocketThread(this, sock);
            appendMessage("connected "+sock.getLocalSocketAddress().toString());
            client.start();
            BtnSend.setEnabled(true);
            EdMessage.setEditable(true);
            EdMessage.selectAll();
            EdMessage.requestFocus();
            BtnClnConn.setText("Disconnect");
         }
         else
         {
            client.terminate();
            client=null;
            BtnSend.setEnabled(false);
            EdMessage.setEditable(false);
            BtnClnConn.setText("Connect");
         }
      } 
      catch (IOException ex) 
      {
         appendMessage(ex.getMessage());
      }
    }//GEN-LAST:event_BtnClnConnActionPerformed

    private void BtnSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSendActionPerformed
       client.outMessage(EdMessage.getText());
       EdMessage.selectAll();
       EdMessage.requestFocus();
    }//GEN-LAST:event_BtnSendActionPerformed

   private void formWindowClosed(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosed
      stop=true;
   }//GEN-LAST:event_formWindowClosed

   private void EdMessageKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_EdMessageKeyPressed
      if(evt.getKeyChar()=='\n') BtnSend.doClick();
   }//GEN-LAST:event_EdMessageKeyPressed
    
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
            java.util.logging.Logger.getLogger(TcpIp.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(TcpIp.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(TcpIp.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(TcpIp.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new TcpIp().setVisible(true);
            }
        });
    }
   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JScrollPane BoxScroll;
   private javax.swing.JTextArea BoxText;
   private javax.swing.JButton BtnClnConn;
   private javax.swing.JButton BtnSend;
   private javax.swing.JButton BtnSrvConn;
   private javax.swing.JTextField EdClnPort;
   private javax.swing.JTextField EdHost;
   private javax.swing.JTextField EdMessage;
   private javax.swing.JTextField EdSrvPort;
   private javax.swing.JLabel LbHost;
   private javax.swing.JLabel LbPort;
   private javax.swing.JLabel LbSemicolon;
   // End of variables declaration//GEN-END:variables
}
