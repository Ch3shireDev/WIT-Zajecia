
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
    private boolean working;
    private ArrayList<Socket> clients = new ArrayList<>();
    private DataOutputStream sout;
    public TcpChatForm()
    {
        initComponents();
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
        jScrollPane1 = new javax.swing.JScrollPane();
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
        jScrollPane1.setViewportView(EdLog);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1)
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
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 214, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(EdMessge, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnSend))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private int getPort()
    {
        try
        {
            return Integer.parseInt(EdPort.getText());            
        }
        catch(Exception e)
        {
            int port=6686;
            EdPort.setText(""+port);
            return port;
        }
    }
    
    private void clinetTalk(Socket cln)
    {
        String who=null;
        try 
        {
            who=cln.getRemoteSocketAddress().toString();
            EdLog.append("Connected"+who+System.lineSeparator());
            clients.add(cln);
            DataInputStream sin=new DataInputStream(cln.getInputStream());
            //DataOutputStream sout=new DataOutputStream(cln.getOutputStream());
            while(working)
            {
                if(sin.available()>0)
                {
                    String message=sin.readUTF();
                    if(message.length()>0)
                    {
                        String answer=who+": "+message+System.lineSeparator();
                        EdLog.append(answer);
                        for(Socket sock : clients)
                        {
                            DataOutputStream sout=new DataOutputStream(sock.getOutputStream());
                            sout.writeUTF(answer);
                        }                        
                    }
                }
            }
        }
        catch (IOException ex)
        {
            EdLog.append(ex.getMessage()+System.lineSeparator());
        }     
        clients.remove(cln);
        EdLog.append("Disconnected"+who+System.lineSeparator());
    }
    
    private void serverThread(ServerSocket srv)
    {
        EdLog.append("Server started"+System.lineSeparator());
        working=true;
        while(working)
        {
            try 
            {
                Socket cln=srv.accept();
                new Thread(() -> clinetTalk(cln)).start();
            }
            catch (IOException ex) 
            {
                EdLog.append(ex.getMessage()+System.lineSeparator());
                break;
            }
        }
        EdLog.append("Server stoped"+System.lineSeparator());
    }
    
    private void clientThread(Socket cln)
    {
        try 
        {
            DataInputStream sin=new DataInputStream(cln.getInputStream());
            sout=new DataOutputStream(cln.getOutputStream());
            working=true;
            while(working)
            {
                if(sin.available()>0)
                {
                    String message=sin.readUTF();
                    if(message.length()>0)
                    {
                        EdLog.append(message);                                                
                    }
                }
            }
        }
        catch (Exception ex) 
        {
            EdLog.append(ex.getMessage()+System.lineSeparator());
        }
    }
    
    private void BtnConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnConnectActionPerformed
        if(CbServer.isSelected())
        {
            try 
            {
                ServerSocket srv=new ServerSocket(getPort());
                new Thread(() -> serverThread(srv)).start();
            }
            catch (Exception ex) 
            {
                EdLog.append(ex.getMessage()+System.lineSeparator());
            }
        }
        else
        {
            try 
            {
                Socket cln=new Socket(EdHost.getText(),getPort());
                new Thread(() -> clientThread(cln)).start();
            } 
            catch (Exception ex)
            {
                EdLog.append(ex.getMessage()+System.lineSeparator());
            }            
        }
    }//GEN-LAST:event_BtnConnectActionPerformed

    private void BtnSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSendActionPerformed
        try 
        {
            sout.writeUTF(EdMessge.getText());
        }
        catch (Exception ex) 
        {
            EdLog.append(ex.getMessage()+System.lineSeparator());
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
    private javax.swing.JTextField EdMessge;
    private javax.swing.JTextField EdPort;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}
