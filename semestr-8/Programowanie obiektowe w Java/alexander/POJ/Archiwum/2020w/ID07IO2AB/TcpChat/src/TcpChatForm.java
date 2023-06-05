
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;

public class TcpChatForm extends javax.swing.JFrame
{
   private ServerSocket serverSocket;
   private Socket clientSocket;
   private Socket oneclient;
   public TcpChatForm()
   {
      initComponents();
   }
   private void appenddLog(String text)
   {
      edLogArea.append(text+System.lineSeparator());
   }
   private void listenClient(Socket client)
   {
      try
      {
         appenddLog("Client connected");
         DataInputStream input = new DataInputStream(client.getInputStream());
         while(true)
         {
            try
            {
               String message=input.readUTF();
               appenddLog("Client "+client.getInetAddress().getHostAddress()+": "+message);
            }
            catch (IOException ex)
            {
               appenddLog("Client listen error: "+ex.getMessage());
               break;
            }
         }
      }
      catch (Exception ex)
      {
         appenddLog("Client stream error: "+ex.getMessage());
      }
      finally
      {
         appenddLog("Client disconnected");
      }
   }
   private void talkWithClient(Socket client)
   {
      appenddLog("Client "+client.getInetAddress().getHostAddress()+" connected");
      oneclient=client;
      try
      {
         DataInputStream input = new DataInputStream(client.getInputStream());
         while(true)
         {
            try
            {
               String message=input.readUTF();
               appenddLog("Client "+client.getInetAddress().getHostAddress()+": "+message);
            }
            catch (IOException ex)
            {
               appenddLog("Server talking error: "+ex.getMessage());
               break;
            }
         }
      }
      catch (Exception ex)
      {
         appenddLog("Server stream error: "+ex.getMessage());
      }
      finally
      {
         appenddLog("Client "+client.getInetAddress().getHostAddress()+" disconnected");
      }
   }

   private void acceptCliens()
   {
      try
      {
         appenddLog("Server start");
         while(true)
         {
            Socket client=serverSocket.accept();
            new Thread(()->talkWithClient(client)).start();
         }
      }
      catch (Exception ex)
      {
         appenddLog("Server accept error: "+ex.getMessage());
      }
      finally
      {
         appenddLog("Server stop");
      }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      btnServerStart = new javax.swing.JButton();
      btnClientConnect = new javax.swing.JButton();
      btnServerSend = new javax.swing.JButton();
      btnClientSend = new javax.swing.JButton();
      jScrollPane1 = new javax.swing.JScrollPane();
      edLogArea = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      btnServerStart.setText("Server Start");
      btnServerStart.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnServerStartActionPerformed(evt);
         }
      });

      btnClientConnect.setText("Client Connect");
      btnClientConnect.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnClientConnectActionPerformed(evt);
         }
      });

      btnServerSend.setText("Server Send");
      btnServerSend.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnServerSendActionPerformed(evt);
         }
      });

      btnClientSend.setText("Client Send");
      btnClientSend.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnClientSendActionPerformed(evt);
         }
      });

      edLogArea.setColumns(20);
      edLogArea.setRows(5);
      jScrollPane1.setViewportView(edLogArea);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(btnServerStart)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 182, Short.MAX_VALUE)
                  .addComponent(btnClientConnect))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(btnServerSend)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnClientSend)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnServerStart)
               .addComponent(btnClientConnect))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnServerSend)
               .addComponent(btnClientSend))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 220, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnServerStartActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnServerStartActionPerformed
      try
      {
         serverSocket=new ServerSocket(8888);
         new Thread(this::acceptCliens).start();
      }
      catch (Exception ex)
      {
         appenddLog("Server start error: "+ex.getMessage());
      }
   }//GEN-LAST:event_btnServerStartActionPerformed

   private void btnClientConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnClientConnectActionPerformed
      try
      {
         clientSocket=new Socket(InetAddress.getByName("localhost"),8888);
         new Thread(()->listenClient(clientSocket)).start();
      }
      catch (Exception ex)
      {
         appenddLog("Client connect error: "+ex.getMessage());
      }
   }//GEN-LAST:event_btnClientConnectActionPerformed

   private void btnServerSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnServerSendActionPerformed
      try
      {
         DataOutputStream output=new DataOutputStream(oneclient.getOutputStream());
         output.writeUTF("Hello from server");
      }
      catch (Exception ex)
      {
         appenddLog("Server send error: "+ex.getMessage());
      }
   }//GEN-LAST:event_btnServerSendActionPerformed

   private void btnClientSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnClientSendActionPerformed
      try
      {
         DataOutputStream output=new DataOutputStream(clientSocket.getOutputStream());
         output.writeUTF("Hello from client");
      }
      catch (Exception ex)
      {
         appenddLog("Client send error: "+ex.getMessage());
      }
   }//GEN-LAST:event_btnClientSendActionPerformed

   public static void main(String args[]) {
      java.awt.EventQueue.invokeLater(() -> new TcpChatForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnClientConnect;
   private javax.swing.JButton btnClientSend;
   private javax.swing.JButton btnServerSend;
   private javax.swing.JButton btnServerStart;
   private javax.swing.JTextArea edLogArea;
   private javax.swing.JScrollPane jScrollPane1;
   // End of variables declaration//GEN-END:variables
}
