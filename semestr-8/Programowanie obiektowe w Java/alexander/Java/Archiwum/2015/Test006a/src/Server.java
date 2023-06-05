import java.io.*;
import java.net.*;
import static java.lang.Thread.sleep;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Server extends javax.swing.JFrame {

    private ServerSocket srv;
    private ServerMainThread thr;
            
    public Server() {
        initComponents();
        Box.setEditable(false);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        Port = new javax.swing.JTextField();
        BtnConnect = new javax.swing.JButton();
        BoxScroller = new javax.swing.JScrollPane();
        Box = new javax.swing.JTextPane();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Server ...");

        Port.setText("3000");

        BtnConnect.setText("Connect");
        BtnConnect.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnConnectActionPerformed(evt);
            }
        });

        BoxScroller.setViewportView(Box);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(BoxScroller)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(0, 260, Short.MAX_VALUE)
                        .addComponent(Port, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnConnect)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnConnect)
                    .addComponent(Port, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(BoxScroller, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public void append(String txt)
    {
        Box.setText(Box.getText()+txt+"\n");
    }
    
    private void BtnConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnConnectActionPerformed
        if(thr == null)
        {
            try {
                int port = Integer.parseInt(Port.getText());
                srv = new ServerSocket(port);
                String name = srv.getInetAddress().getHostAddress()+":"+srv.getLocalPort();
                thr = new ServerMainThread(this,srv,name);
                thr.start();
                Port.setEnabled(false);
                BtnConnect.setText("Disconnect");
            } catch (IOException ex) {
                Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        else{
            try {
                thr.close();
            } catch (IOException ex) {
                Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
            } catch (InterruptedException ex) {
                Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
            }
            Port.setEnabled(true);
            BtnConnect.setText("Connect");            
            thr = null;
        }
    }//GEN-LAST:event_BtnConnectActionPerformed

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
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Server.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Server().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextPane Box;
    private javax.swing.JScrollPane BoxScroller;
    private javax.swing.JButton BtnConnect;
    private javax.swing.JTextField Port;
    // End of variables declaration//GEN-END:variables
}

class ServerMainThread extends Thread {
    
    private Server frame;
    private ServerSocket socket;
    private List<ClientThread> cln;
    
    public ServerMainThread(Server frame,ServerSocket srv,String name) {
        super(name);
        this.frame = frame;
        this.socket = srv;
        cln = new ArrayList<>();
    }
    
    public void connect(ClientThread thr) {
        cln.add(thr);
    }
    
    public void disconnect(ClientThread thr) {
        cln.remove(thr);
    }
    
    public void close() throws IOException, InterruptedException {
        List<ClientThread> tmp = new ArrayList<>(cln);
        for(ClientThread ct:tmp) ct.close();
        socket.close();
        interrupt();
        join();        
    }
    
    public void frameAppend(String txt) {
        frame.append(txt);
    }
    
    public void sendToAll(String txt) {
        frameAppend(txt);
        for(ClientThread ct:cln) ct.send(txt);
    }
    
    @Override
    public void run() {
        try {
            while(!socket.isClosed()) {
                try {
                    Socket conn=socket.accept();
                    String name = conn.getInetAddress().getHostAddress()+":"+conn.getLocalPort();
                    ClientThread thr = new ClientThread(this,conn,name);
                    thr.start();
                } catch(SocketException ex) {
                    break;
                }
            }
        } catch (IOException ex) {
            Logger.getLogger(ServerMainThread.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}

class ClientThread extends Thread {
    private Socket socket;
    private ServerMainThread frame;
    private String name;
    private BufferedReader in;
    private PrintStream out;
    
    public ClientThread(ServerMainThread frame,Socket socket,String name) throws IOException {
        super(name);
        this.frame = frame;
        this.socket = socket;
        this.name = name;
        in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
        out = new PrintStream(socket.getOutputStream());
    }
        
    public void close() throws IOException, InterruptedException {
        socket.close();
        interrupt();
        join();        
    }
    
    public void send(String txt) {
        out.print(txt+"\n");
	out.flush();        
    }
    
    @Override
    public void run() {
        frame.connect(this);
        frame.frameAppend("connected: "+name);
        while(socket.isConnected()) {
            String str;
            try {
                str = in.readLine();
                if(str == null) break;
                frame.sendToAll(name+": "+str);
            } catch (SocketException ex) {
                break;
            } catch (IOException ex) {
                Logger.getLogger(ClientThread.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        frame.frameAppend("disconnected: "+name);
        frame.disconnect(this);
    }
}
