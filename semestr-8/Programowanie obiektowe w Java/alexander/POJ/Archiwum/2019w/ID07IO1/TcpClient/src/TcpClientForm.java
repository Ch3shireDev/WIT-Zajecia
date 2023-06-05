
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.HashSet;
import java.util.logging.Level;
import java.util.logging.Logger;

public class TcpClientForm extends javax.swing.JFrame {

    private static final int defPort=8888;
    private static final int pingStep=100;
    private static final int pingDie=1000;
    private ServerSocket server;
    private Socket socket;
    private DataInputStream sin;
    private DataOutputStream sout;
    private Thread th;
    private boolean active;
    private final HashSet<Socket> clients=new HashSet<>();
            
    public TcpClientForm() 
    {
        initComponents();
        EdPort.setText(Integer.toString(defPort));
        getRootPane().setDefaultButton(BtnConnect);
        //getRootPane().set
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        EdHost = new javax.swing.JTextField();
        EdPort = new javax.swing.JTextField();
        BtnConnect = new javax.swing.JButton();
        EdLogScroll = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();
        EdMessage = new javax.swing.JTextField();
        BtnSend = new javax.swing.JButton();
        BtnHost = new javax.swing.JCheckBox();
        jPanel2 = new javax.swing.JPanel();

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
        });

        EdHost.setText("localhost");

        EdPort.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        EdPort.setText("8888");

        BtnConnect.setText("Connect");
        BtnConnect.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnConnectActionPerformed(evt);
            }
        });

        EdLog.setColumns(20);
        EdLog.setRows(5);
        EdLogScroll.setViewportView(EdLog);

        BtnSend.setText("Send");
        BtnSend.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnSendActionPerformed(evt);
            }
        });

        BtnHost.setText("Host");
        BtnHost.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnHostActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 8, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(EdMessage)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnSend))
                    .addComponent(EdLogScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnHost)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 108, Short.MAX_VALUE)
                        .addComponent(EdHost, javax.swing.GroupLayout.PREFERRED_SIZE, 322, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdPort, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnConnect)))
                .addContainerGap())
            .addComponent(jPanel2, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(EdHost, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(EdPort, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnConnect)
                    .addComponent(BtnHost))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 357, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnSend)
                    .addComponent(EdMessage, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void ClientRead()
    {
        active=true;
        int inpcnt=0,outcnt=0;
        while(active)
        {
            try 
            {
                if(sin.available()>0)
                {
                    final String msg=sin.readUTF();
                    if(msg.length()>0) EdLog.append(msg+System.lineSeparator());
                    inpcnt=0;
                }
                else
                {
                    Thread.sleep(10);
                    if(++inpcnt>=pingDie) break;
                    if(++outcnt>=pingStep)
                    {
                        outcnt=0;
                        sout.writeUTF("");
                    }                    
                }
            } catch (InterruptedException|IOException ex) { active=false; }
        }   
        try { socket.close(); } catch (IOException ex) {}
        socket=null;
        sin=null;
        sout=null;
        th=null;
        AdjustBtn();
    }
    
    private void ClientTransmit(Socket socket)
    {
        try
        {
            DataInputStream sin=new DataInputStream(socket.getInputStream());
            DataOutputStream sout=new DataOutputStream(socket.getOutputStream());
            clients.add(socket);
            socket.setKeepAlive(true);
            EdLog.append(socket.getRemoteSocketAddress()+": connected"+System.lineSeparator());
            int inpcnt=0,outcnt=0;
            while(active)
            {
                try 
                {
                    if(sin.available()>0)
                    {
                        final String msg=sin.readUTF();
                        if(msg.length()>0)
                        {
                            EdLog.append(socket.getRemoteSocketAddress()+" - send: "+msg+System.lineSeparator());
                            final String tosend=socket.getRemoteSocketAddress()+": "+msg;
                            for(Socket s:clients)
                            {
                                DataOutputStream csout=new DataOutputStream(s.getOutputStream());
                                csout.writeUTF(tosend);
                            }
                        }
                        inpcnt=0;
                    }
                    else
                    {
                        Thread.sleep(10);
                        if(++inpcnt>=pingDie) break;
                        if(++outcnt>=pingStep)
                        {
                            outcnt=0;
                            sout.writeUTF("");
                        }
                    }
                } catch (InterruptedException|IOException ex) { break; }
            }        
        }
        catch (IOException ex) {}
        EdLog.append(socket.getRemoteSocketAddress()+": disconnected"+System.lineSeparator());
        clients.remove(socket);        
    }
    
    private void ServerListen()
    {
        active=true;
        while(active)
        {
            try 
            {
                Socket socket=server.accept();
                th=new Thread(() -> ClientTransmit(socket));
                th.start();
            } 
            catch (IOException ex) 
            { 
                EdLog.append(ex.getMessage()+System.lineSeparator());
                active=false; 
            }
        }
        server=null;
        sin=null;
        sout=null;
        th=null;
    }
    
    private int getPort()
    {
        try
        {
            return Integer.parseInt(EdPort.getText());
        }
        catch(NumberFormatException e) 
        {
            EdPort.setText(Integer.toString(defPort));
            return defPort;
        }
    }
    
    private void ClientStart()
    {
        try             
        {
            socket=new Socket(EdHost.getText(),getPort());
            socket.setKeepAlive(true);
            sin=new DataInputStream(socket.getInputStream());
            sout=new DataOutputStream(socket.getOutputStream());
            th=new Thread(this::ClientRead);
            th.start();
        } 
        catch (IOException ex) 
        {
            if(socket==null) EdLog.append("Can't connect"+System.lineSeparator());
            else
            {
                try { socket.close(); } catch (IOException exx) 
                {
                    EdLog.append(exx.getMessage()+System.lineSeparator());
                }
            }
            socket=null;
            sin=null;
            sout=null;
            th=null;
        }        
        AdjustBtn();
    }
    
    private void ServerStart()
    {
        try             
        {
            server=new ServerSocket(getPort());
            th=new Thread(this::ServerListen);
            th.start();
        } 
        catch (IOException ex) 
        {
            try { socket.close(); } catch (IOException exx) {}
            server=null;
            sin=null;
            sout=null;
            th=null;
        }        
        AdjustBtn();
    }
    
    private void ThreadStop()
    {
        if(server!=null) try { server.close(); } catch (IOException ex) {}
        active=false;
        if(th!=null)
        {
            try { th.join(); } catch (InterruptedException ex) {}
        }
        AdjustBtn();
    }
    
    private void AdjustBtn()
    {
        if(th==null)
        {
            BtnConnect.setText("Connect");
            EdHost.setEnabled(true);
            EdPort.setEnabled(true);
            BtnHost.setEnabled(true);
            getRootPane().setDefaultButton(BtnConnect);
        }
        else
        {
            BtnConnect.setText("Disconnect");
            EdHost.setEnabled(false);
            EdPort.setEnabled(false);
            BtnHost.setEnabled(false);
            getRootPane().setDefaultButton(BtnSend);
        }
    }
    
    private void BtnConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnConnectActionPerformed
        if(th==null)
        {
            if(BtnHost.isSelected()) ServerStart();
            else ClientStart();
        }
        else
        {
            ThreadStop();
        }
    }//GEN-LAST:event_BtnConnectActionPerformed

    private void BtnHostActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnHostActionPerformed
        boolean en=!BtnHost.isSelected();
        EdHost.setVisible(en);
        EdMessage.setVisible(en);
        BtnSend.setVisible(en);
    }//GEN-LAST:event_BtnHostActionPerformed

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing
        ThreadStop();
    }//GEN-LAST:event_formWindowClosing

    private void BtnSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSendActionPerformed
        try 
        {
            final String msg=EdMessage.getText();
            if(msg.length()>0) sout.writeUTF(msg); 
        }
        catch(IOException ex) {}
    }//GEN-LAST:event_BtnSendActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(() -> new TcpClientForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnConnect;
    private javax.swing.JCheckBox BtnHost;
    private javax.swing.JButton BtnSend;
    private javax.swing.JTextField EdHost;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JScrollPane EdLogScroll;
    private javax.swing.JTextField EdMessage;
    private javax.swing.JTextField EdPort;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    // End of variables declaration//GEN-END:variables
}
