
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

public class TcpChatForm extends javax.swing.JFrame
{
    private ArrayList<Socket> clients=new ArrayList<>();
    DataOutputStream out;
    
    public TcpChatForm()
    {
        initComponents();
    }
    
    private int getPort()
    {
        try
        {
            return Integer.parseInt(EdPort.getText());
        }
        catch(Exception ex)
        {
            int port=6686;
            EdPort.setText(""+port);
            return port;
        }
    }
    private void ShowLog(String message)
    {
        EdLog.append(message+System.lineSeparator());
    }

    private void clientTalk(Socket cln)
    {
        String who=cln.getRemoteSocketAddress().toString();
        try 
        {
            ShowLog("Client connected: "+who);
            clients.add(cln);
            DataInputStream inp=new DataInputStream((cln.getInputStream()));
            while(true)
            {
                if(inp.available()>0)
                {
                    String message=who+": "+inp.readUTF();
                    ShowLog(message);
                    for(Socket s : clients)
                    {
                        DataOutputStream out=new DataOutputStream((s.getOutputStream()));
                        out.writeUTF(message);
                    }
                }                
            }
        }
        catch (Exception ex) 
        {
            ShowLog(ex.getMessage());
        }
        clients.remove(cln);
        ShowLog("Client disconnected: "+who);
    }

    private void clientRun(Socket cln)
    {
        try 
        {
            ShowLog("Connected to server");
            DataInputStream inp=new DataInputStream((cln.getInputStream()));
            out = new DataOutputStream((cln.getOutputStream()));
            while(true)
            {
                if(inp.available()>0)
                {
                    ShowLog(inp.readUTF());
                }                
            }
        }
        catch (Exception ex) 
        {
            ShowLog(ex.getMessage());
        }
        ShowLog("isconnected to server");
    }

    private void serverRun(ServerSocket srv)
    {
        try 
        {
            ShowLog("Server started");
            while(true)
            {
                Socket cln=srv.accept();
                new Thread(() -> clientTalk(cln)).start();
            }
        }
        catch (Exception ex) 
        {
            ShowLog(ex.getMessage());
        }
        ShowLog("Server stopped");
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        EdHost = new javax.swing.JTextField();
        EdPort = new javax.swing.JTextField();
        BtnConnect = new javax.swing.JButton();
        CbServer = new javax.swing.JCheckBox();
        EdMessge = new javax.swing.JTextField();
        BtnSend = new javax.swing.JButton();
        EdLogScroll = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        EdHost.setText("localhost");

        EdPort.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        EdPort.setText("6686");

        BtnConnect.setText("Connect");
        BtnConnect.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnConnectActionPerformed(evt);
            }
        });

        CbServer.setText("Server");

        BtnSend.setText("Send");
        BtnSend.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnSendActionPerformed(evt);
            }
        });

        EdLog.setColumns(20);
        EdLog.setRows(5);
        EdLogScroll.setViewportView(EdLog);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(EdLogScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(EdMessge)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnSend))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(EdHost, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdPort, javax.swing.GroupLayout.PREFERRED_SIZE, 47, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbServer)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 221, Short.MAX_VALUE)
                        .addComponent(BtnConnect)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(EdHost, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(EdPort, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnConnect)
                    .addComponent(CbServer))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 214, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(EdMessge, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnSend))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnConnectActionPerformed
        if(CbServer.isSelected()) // server
        {
            try 
            {
                ServerSocket srv=new ServerSocket(getPort());
                new Thread(() -> serverRun(srv)).start();
            } 
            catch (Exception ex) 
            {
                ShowLog(ex.getMessage());
            }
        }
        else // client
        {
            try 
            {
                Socket cln=new Socket(EdHost.getText(),getPort());
                new Thread(() -> clientRun(cln)).start();
            } 
            catch (Exception ex) 
            {
                ShowLog(ex.getMessage());
            }
        }
    }//GEN-LAST:event_BtnConnectActionPerformed

    private void BtnSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSendActionPerformed
        try 
        {
            out.writeUTF(EdMessge.getText());
        } 
        catch (IOException ex)
        {
            ShowLog(ex.getMessage());
        }
    }//GEN-LAST:event_BtnSendActionPerformed

    public static void main(String args[]) 
    {
        java.awt.EventQueue.invokeLater(() -> new TcpChatForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnConnect;
    private javax.swing.JButton BtnSend;
    private javax.swing.JCheckBox CbServer;
    private javax.swing.JTextField EdHost;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JScrollPane EdLogScroll;
    private javax.swing.JTextField EdMessge;
    private javax.swing.JTextField EdPort;
    // End of variables declaration//GEN-END:variables

}
