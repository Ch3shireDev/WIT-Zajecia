
import java.io.*;
import java.net.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Client extends javax.swing.JFrame {
    private ClientMainThread cln;
    
    public Client() {
        initComponents();
        Box.setEditable(false);
        Text.setEnabled(false);
        BtnSend.setEnabled(false);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        Host = new javax.swing.JTextField();
        Port = new javax.swing.JTextField();
        BtnConnect = new javax.swing.JButton();
        BoxScroller = new javax.swing.JScrollPane();
        Box = new javax.swing.JTextPane();
        Text = new javax.swing.JTextField();
        BtnSend = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Client ...");

        Host.setText("localhost");

        Port.setText("3000");

        BtnConnect.setText("Connect");
        BtnConnect.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnConnectActionPerformed(evt);
            }
        });

        BoxScroller.setViewportView(Box);

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
                    .addComponent(BoxScroller)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(Host, javax.swing.GroupLayout.DEFAULT_SIZE, 254, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(Port, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnConnect))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(Text)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnSend)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(Host, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(Port, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnConnect))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(BoxScroller, javax.swing.GroupLayout.DEFAULT_SIZE, 215, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(Text, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnSend))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public void append(String txt)
    {
        Box.setText(Box.getText()+txt+"\n");
    }
    
    private void BtnConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnConnectActionPerformed
        if(cln == null) {
            int port = Integer.parseInt(Port.getText());
            try {
                Socket socket = new Socket(Host.getText(),port);
                String name = socket.getInetAddress().getHostAddress()+":"+socket.getLocalPort();
                cln = new ClientMainThread(this, socket, name);
                cln.start();
                Host.setEnabled(false);
                Port.setEnabled(false);
                BtnConnect.setText("Disconnect");
                Text.setEnabled(true);
                BtnSend.setEnabled(true);
            } catch (UnknownHostException ex) {
                Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
            } catch (IOException ex) {
                Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        else {
            try {
                cln.close();
            } catch (IOException ex) {
                Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
            } catch (InterruptedException ex) {
                Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
            }
            Host.setEnabled(true);
            Port.setEnabled(true);
            BtnConnect.setText("Connect");            
            Text.setEnabled(false);
            BtnSend.setEnabled(false);
            cln = null;
        }
        
    }//GEN-LAST:event_BtnConnectActionPerformed

    private void BtnSendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSendActionPerformed
        cln.send(Text.getText());
    }//GEN-LAST:event_BtnSendActionPerformed

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
            java.util.logging.Logger.getLogger(Client.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Client.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Client.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Client.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Client().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextPane Box;
    private javax.swing.JScrollPane BoxScroller;
    private javax.swing.JButton BtnConnect;
    private javax.swing.JButton BtnSend;
    private javax.swing.JTextField Host;
    private javax.swing.JTextField Port;
    private javax.swing.JTextField Text;
    // End of variables declaration//GEN-END:variables
}

class ClientMainThread extends Thread {
    private Client frame;
    private Socket socket;
    private BufferedReader in;
    private PrintStream out;
    
    public ClientMainThread(Client frame,Socket socket,String name) throws IOException {
        super(name);
        this.frame = frame;
        this.socket = socket;
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
        while(socket.isConnected()) {               
            try {
                if(socket.getInputStream().read(null, 0, 0)<0) break;
            } catch (IOException ex) {
                break;
            }
            String str;
            try {
                str = in.readLine();
                if(str == null) break;
                frame.append(str);
            } catch (SocketException ex) {
                break;
            } catch (IOException ex) {
                Logger.getLogger(ClientMainThread.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
}
