
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import java.net.ServerSocket;
import java.net.Socket;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.util.ArrayList;

public class TchIpChatForm extends javax.swing.JFrame
{
   private int port=3334;
   private boolean active;
   private ServerSocket srv;
   private Socket cln;
   private ArrayList<Socket> clients=new ArrayList<>();
   public TchIpChatForm()
   {
      initComponents();
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void removeUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void changedUpdate(DocumentEvent e) { adjustButtons(); }
      };
      tfPort.getDocument().addDocumentListener(listener);
      tfHost.getDocument().addDocumentListener(listener);
      tfMessage.getDocument().addDocumentListener(listener);
      tfPort.setText(Integer.toString(port));
   }

   private void adjustButtons()
   {
      boolean ok=false;
      try
      {
         port=Integer.parseInt(tfPort.getText());
         ok=(tfHost.getText().trim().length()>0);
      }
      catch(Exception ex) {}
      btnConnect.setEnabled(ok);
      btnSend.setEnabled(tfMessage.getText().trim().length()>0);
   }

   private void appendLog(String message)
   {
      taLog.append(message+System.lineSeparator());
   }

   private void toClients(String message)
   {
      for(Socket sock:clients)
      {
         try
         {
            DataOutputStream dout=new DataOutputStream(sock.getOutputStream());
            dout.writeUTF(message);
         }
         catch(Exception ex) {}
      }
   }

   private void serverClientLoop(Socket cln)
   {
      String who=cln.getRemoteSocketAddress().toString();
      clients.add(cln);
      final String conn=who+" Connected";
      appendLog(conn);
      toClients(conn);
      try
      {
         DataInputStream din=new DataInputStream(cln.getInputStream());
         while(active)
         {
            if(din.available()>0)
            {
               String message=who+": "+din.readUTF();
               appendLog(message);
               toClients(message);
            }
         }
      }
      catch(Exception ex)
      {
      }
      final String disconn=who+" Connected";
      appendLog(disconn);
      toClients(disconn);
      clients.remove(cln);
   }

   private void clientMainLoop()
   {
      try
      {
         cln=new Socket(tfHost.getText().trim(),port);
         DataInputStream din=new DataInputStream(cln.getInputStream());
         active=true;
         while(active)
         {
            if(din.available()>0)
            {
               String message=din.readUTF();
               appendLog(message);
            }
         }
      }
      catch(Exception ex)
      {
      }
   }

   private void serverMainLoop()
   {
      try
      {
         srv=new ServerSocket(port);
         active=true;
         while(active)
         {
            Socket cln=srv.accept();
            new Thread(() -> serverClientLoop(cln)).start();
         }
      }
      catch(Exception ex)
      {
      }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      cbIsClient = new javax.swing.JComboBox<>();
      tfHost = new javax.swing.JTextField();
      tfPort = new javax.swing.JTextField();
      btnConnect = new javax.swing.JButton();
      tfMessage = new javax.swing.JTextField();
      btnSend = new javax.swing.JButton();
      taLogScroll = new javax.swing.JScrollPane();
      taLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      addWindowListener(new java.awt.event.WindowAdapter()
      {
         public void windowClosing(java.awt.event.WindowEvent evt)
         {
            formWindowClosing(evt);
         }
      });

      cbIsClient.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Serwer", "Klient" }));
      cbIsClient.setSelectedItem("Klient");

      tfHost.setText("localhost");

      tfPort.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfPort.setText("0");

      btnConnect.setText("Połącz");
      btnConnect.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnConnectActionPerformed(evt);
         }
      });

      btnSend.setText("Wyślij");
      btnSend.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnSendActionPerformed(evt);
         }
      });

      taLog.setColumns(20);
      taLog.setRows(5);
      taLogScroll.setViewportView(taLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(taLogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(cbIsClient, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(tfHost, javax.swing.GroupLayout.PREFERRED_SIZE, 158, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(tfPort, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 324, Short.MAX_VALUE)
                  .addComponent(btnConnect))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(tfMessage)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnSend)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(cbIsClient, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(tfHost, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(tfPort, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnConnect))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(taLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 343, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(tfMessage, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnSend))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnConnectActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnConnectActionPerformed
   {//GEN-HEADEREND:event_btnConnectActionPerformed
      if(cbIsClient.getSelectedIndex()>0) // Client
      {
         new Thread(this::clientMainLoop).start();
      }
      else // Server
      {
         new Thread(this::serverMainLoop).start();
      }
   }//GEN-LAST:event_btnConnectActionPerformed

   private void formWindowClosing(java.awt.event.WindowEvent evt)//GEN-FIRST:event_formWindowClosing
   {//GEN-HEADEREND:event_formWindowClosing
      active=true;
   }//GEN-LAST:event_formWindowClosing

   private void btnSendActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnSendActionPerformed
   {//GEN-HEADEREND:event_btnSendActionPerformed
      if(cbIsClient.getSelectedIndex()>0) // Client
      {
         try
         {
            DataOutputStream dout=new DataOutputStream(cln.getOutputStream());
            dout.writeUTF(tfMessage.getText().trim());
         }
         catch(Exception ex){}
      }
      else // Server
      {
         new Thread(this::serverMainLoop).start();
      }

   }//GEN-LAST:event_btnSendActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new TchIpChatForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnConnect;
   private javax.swing.JButton btnSend;
   private javax.swing.JComboBox<String> cbIsClient;
   private javax.swing.JTextArea taLog;
   private javax.swing.JScrollPane taLogScroll;
   private javax.swing.JTextField tfHost;
   private javax.swing.JTextField tfMessage;
   private javax.swing.JTextField tfPort;
   // End of variables declaration//GEN-END:variables
}
