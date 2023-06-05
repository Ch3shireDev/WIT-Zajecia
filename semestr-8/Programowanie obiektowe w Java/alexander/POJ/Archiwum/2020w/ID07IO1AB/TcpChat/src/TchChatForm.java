
import java.io.IOException;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;

public class TchChatForm extends javax.swing.JFrame
{
   private Socket clnsocket;
   private Socket consocket;
   private DataInputStream clninput;
   private DataOutputStream clnoutput;
   private DataInputStream coninput;
   private DataOutputStream conoutput;
   private ServerSocket srvsocket;
   public TchChatForm()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      BtnServerStart = new javax.swing.JButton();
      BtnServerSend = new javax.swing.JButton();
      BtnClientConnect = new javax.swing.JButton();
      BtnClientSend = new javax.swing.JButton();
      EdLogAreaScroll = new javax.swing.JScrollPane();
      EdLogArea = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      BtnServerStart.setText("Server Start");
      BtnServerStart.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnServerStartActionPerformed(evt);
         }
      });

      BtnServerSend.setText("Server Send");

      BtnClientConnect.setText("Client Connect");
      BtnClientConnect.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnClientConnectActionPerformed(evt);
         }
      });

      BtnClientSend.setText("Client Send");

      EdLogArea.setColumns(20);
      EdLogArea.setRows(5);
      EdLogAreaScroll.setViewportView(EdLogArea);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdLogAreaScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnServerStart)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 182, Short.MAX_VALUE)
                  .addComponent(BtnClientConnect))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnServerSend)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(BtnClientSend)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGap(19, 19, 19)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnServerStart)
               .addComponent(BtnClientConnect))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnServerSend)
               .addComponent(BtnClientSend))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogAreaScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 212, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void AppendLog(String Text)
   {
      EdLogArea.append(Text+System.lineSeparator());
   }

   private void serverListen()
   {
      try
      {
         coninput=new DataInputStream(consocket.getInputStream());
         conoutput=new DataOutputStream(consocket.getOutputStream());
      }
      catch (Exception ex)
      {
         AppendLog("Stream error");
         return;
      }
      while(true)
      {
         try
         {
            String message=coninput.readUTF();
            AppendLog("From client: "+message);
            conoutput.writeUTF("Kota ma Ala");
         }
         catch (Exception ex)
         {
            AppendLog("From client: not string object received");
         }
      }
   }

   private void BtnServerStartActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnServerStartActionPerformed
      try
      {
         srvsocket=new ServerSocket(8888);
         AppendLog("Server: Started");
         consocket=srvsocket.accept();
         AppendLog("Server: Accept client");
         new Thread(this::serverListen).start();
      }
      catch (IOException ex)
      {
         AppendLog("Server: Can't start");
      }
   }//GEN-LAST:event_BtnServerStartActionPerformed

   private void BtnClientConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnClientConnectActionPerformed
      try
      {
         clnsocket=new Socket(InetAddress.getByName("localhost"),8888);
         AppendLog("Client: Connected");
         clninput=new DataInputStream(clnsocket.getInputStream());
         clnoutput=new DataOutputStream(clnsocket.getOutputStream());
         clnoutput.writeUTF("Ala ma kota");
         String message=clninput.readUTF();
         AppendLog("From client: "+message);
      }
      catch(Exception ex)
      {
         AppendLog("Client: Can't connect");
      }
   }//GEN-LAST:event_BtnClientConnectActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new TchChatForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnClientConnect;
   private javax.swing.JButton BtnClientSend;
   private javax.swing.JButton BtnServerSend;
   private javax.swing.JButton BtnServerStart;
   private javax.swing.JTextArea EdLogArea;
   private javax.swing.JScrollPane EdLogAreaScroll;
   // End of variables declaration//GEN-END:variables
}
