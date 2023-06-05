
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import java.net.ServerSocket;
import java.net.Socket;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

public class TcpIpChatForm extends javax.swing.JFrame
{
   private int port=3334;
   private boolean active;
   private ServerSocket srv;
   private Socket cln;
   private DataOutputStream dout;
   private ArrayList<Socket> clients=new ArrayList<>();
   public TcpIpChatForm()
   {
      initComponents();
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { adjustPort(); }
         @Override public void removeUpdate(DocumentEvent e) { adjustPort(); }
         @Override public void changedUpdate(DocumentEvent e) { adjustPort(); }
      };
      tfPort.getDocument().addDocumentListener(listener);
      tfPort.setText(Integer.toString(port));
   }

   private void adjustPort()
   {
      try
      {
         port=Integer.parseInt(tfPort.getText());
         btnConnect.setEnabled(true);
      }
      catch(Exception ex)
      {
         btnConnect.setEnabled(false);
      }
   }

   private void ServerClientLoop(Socket cln)
   {
      try
      {
         clients.add(cln);
         DataInputStream din=new DataInputStream(cln.getInputStream());
         String who=cln.getRemoteSocketAddress().toString();

         while(active)
         {
            if(din.available()>0)
            {
               String message=who+": "+din.readUTF();
               for(Socket sock:clients)
               {
                  DataOutputStream dout=new DataOutputStream(sock.getOutputStream());
                  dout.writeUTF(message);
               }
            }
         }
      }
      catch(Exception ex)
      {
      }
      active=false;
      clients.remove(cln);
   }

   private void ClientMainLoop()
   {
      try
      {
         cln=new Socket(tfHost.getText(),port);
         DataInputStream din=new DataInputStream(cln.getInputStream());
         dout=new DataOutputStream(cln.getOutputStream());
         active=true;
         while(active)
         {
            if(din.available()>0)
            {
               String message=din.readUTF();
               taLog.append(message+System.lineSeparator());
            }
         }
      }
      catch(Exception ex)
      {
      }
      active=false;
   }

   private void ServerMainLoop()
   {
      try
      {
         srv=new ServerSocket(port);
         active=true;
         while(active)
         {
            Socket cln=srv.accept();
            new Thread(() -> ServerClientLoop(cln)).start();
         }
      }
      catch(Exception ex)
      {
      }
      active=false;
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
      jScrollPane1 = new javax.swing.JScrollPane();
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
      jScrollPane1.setViewportView(taLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(cbIsClient, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(tfHost, javax.swing.GroupLayout.PREFERRED_SIZE, 153, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(tfPort, javax.swing.GroupLayout.PREFERRED_SIZE, 52, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 334, Short.MAX_VALUE)
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
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 314, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnSend)
               .addComponent(tfMessage, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnConnectActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnConnectActionPerformed
   {//GEN-HEADEREND:event_btnConnectActionPerformed
      if(cbIsClient.getSelectedIndex()>0) // Client
      {
         new Thread(this::ClientMainLoop).start();
      }
      else // Server
      {
         new Thread(this::ServerMainLoop).start();
      }
   }//GEN-LAST:event_btnConnectActionPerformed

   private void formWindowClosing(java.awt.event.WindowEvent evt)//GEN-FIRST:event_formWindowClosing
   {//GEN-HEADEREND:event_formWindowClosing
      if(srv!=null)
      {
         try
         {
            srv.close();
         }
         catch(Exception ex){}
      }
      active=false;
   }//GEN-LAST:event_formWindowClosing

   private void btnSendActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnSendActionPerformed
   {//GEN-HEADEREND:event_btnSendActionPerformed
      String message=tfMessage.getText().trim();
      try
      {
         dout.writeUTF(message);
      }
      catch(IOException ex)
      {
         taLog.append("Nie udało się wysłać komunikatu"+System.lineSeparator());
      }
   }//GEN-LAST:event_btnSendActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new TcpIpChatForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnConnect;
   private javax.swing.JButton btnSend;
   private javax.swing.JComboBox<String> cbIsClient;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JTextArea taLog;
   private javax.swing.JTextField tfHost;
   private javax.swing.JTextField tfMessage;
   private javax.swing.JTextField tfPort;
   // End of variables declaration//GEN-END:variables
}
