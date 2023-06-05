package TcpIp;

import java.awt.List;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.ArrayList;

public class TcpIp extends javax.swing.JFrame implements WorkerOwner
{
   private boolean work;
   private SocketThread sock;
   public TcpIp()
   {
      initComponents();
      work=true;
   }
   @Override public boolean getWork() { return work; }
   @Override public void appendMessage(String Text)
   {
      BoxText.append(Text+"\n"); 
   }
   @Override public void terminated(SocketThread sth) { sock=null; }
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

      BoxText.setColumns(20);
      BoxText.setRows(5);
      BoxScroll.setViewportView(BoxText);

      EdMessage.setText("Hello");

      BtnSend.setText("Send");
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
         ServerSocket server=new ServerSocket(Integer.parseInt(EdSrvPort.getText()));
         new ServerThread(this,server).start();
         appendMessage("listen");
      }
      catch (IOException ex)
      {
         appendMessage(ex.getMessage());
      }
    }//GEN-LAST:event_BtnSrvConnActionPerformed

    private void BtnClnConnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnClnConnActionPerformed
      try {
         Socket client=new Socket(EdHost.getText(),Integer.parseInt(EdClnPort.getText()));
         sock=new SocketThread(this, client, "Connected to");
         sock.start();
      } catch (IOException ex) {
         appendMessage(ex.getMessage());
      }
    }//GEN-LAST:event_BtnClnConnActionPerformed

    private void BtnSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSendActionPerformed
       if(sock!=null) sock.outMessage(EdMessage.getText());
       else appendMessage("Not connected");
       EdMessage.selectAll();
       EdMessage.requestFocus();
    }//GEN-LAST:event_BtnSendActionPerformed

   private void formWindowClosed(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosed
      work=false;
   }//GEN-LAST:event_formWindowClosed
    
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

class SocketThread extends Thread
{
   private final WorkerOwner form;
   private final Socket socket;
   private final String who;
   private BufferedReader in;
   private PrintStream out;
   public SocketThread(WorkerOwner form,Socket socket,String msg)
   {
      who=socket.getRemoteSocketAddress().toString();
      this.form=form;
      this.socket=socket;
      in=null;
      out=null;      
      form.appendMessage(msg+" "+who);
   }
   public void outMessage(String msg) 
   {
      out.println(msg); 
      out.flush();
   }
   @Override public void run()
   {
      try
      {
         in=new BufferedReader(new InputStreamReader(socket.getInputStream()));
         out=new PrintStream(socket.getOutputStream());
         while(form.getWork())
         {
            String msg=in.readLine();
            if(msg==null) break;
            form.appendMessage(who+": "+msg);
         }
      } 
      catch(UnknownHostException ex) 
      {
         form.appendMessage(ex.getMessage());
      }
      catch (IOException ex) 
      {
         form.appendMessage(ex.getMessage());
      }
      form.terminated(this);
   }
}

class ServerThread extends Thread implements WorkerOwner {
   private final WorkerOwner form; 
   private final ServerSocket server; 
   private final ArrayList<SocketThread> lst;
   public ServerThread(WorkerOwner form,ServerSocket server)
   {
      this.form=form;
      this.server=server;  
      lst=new ArrayList<SocketThread>();
   }
   @Override public boolean getWork() { return form.getWork(); }
   @Override public void terminated(SocketThread sth) { lst.remove(sth); }
   @Override public void appendMessage(String msg)
   {
      form.appendMessage(msg);
      for(SocketThread sock : lst) sock.outMessage(msg);
   }
   @Override public void run()
   {
      try      
      {
         while(form.getWork())
         {
            Socket socket=server.accept();
            if(socket==null) break;
            SocketThread cln=new SocketThread(this, socket, "Connected from ");
            lst.add(cln);
            cln.start();
         }
      }
      catch(UnknownHostException ex) 
      {
         form.appendMessage(ex.getMessage());
      }
      catch (IOException ex) 
      {
         form.appendMessage(ex.getMessage());
      }
      //form.terminated(this);
   }
}

interface WorkerOwner
{
   public boolean getWork();
   public void appendMessage(String msg);
   public void terminated(SocketThread sth);
}