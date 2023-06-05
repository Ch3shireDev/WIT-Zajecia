import com.sun.java.swing.plaf.motif.MotifBorders;
import java.awt.Color;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.sql.Time;
import java.util.ArrayList;
import javax.swing.BoxLayout;
import javax.swing.JPanel;
import javax.swing.Timer;
import javax.swing.border.Border;

public class ObserverMainForm extends javax.swing.JFrame
{
    private final ArrayList<ObservablePanel> panels=new ArrayList<>();
    private final BoxLayout layout;
    
    public ObserverMainForm() {
        initComponents();
        layout=new BoxLayout(PnClient, BoxLayout.X_AXIS);
        PnClient.setLayout(layout);
        SpDigitsStateChanged(null);
        new Timer(1000,this::timer).start();
    }
    
    private void timer(ActionEvent e)
    {
        panels.get(panels.size()-1).sygnal(null);
        changes(null);
    }

    private void changes(ActionEvent e)
    {
        int code=0;
        for(ObservablePanel pn:panels) code=code*ObservablePanel.base+pn.getValue();
        TfCode.setText(Integer.toString(code));
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        PnClient = new javax.swing.JPanel();
        TfCode = new javax.swing.JTextField();
        SpDigits = new javax.swing.JSpinner();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setMinimumSize(new java.awt.Dimension(90, 90));

        PnClient.setAutoscrolls(true);

        javax.swing.GroupLayout PnClientLayout = new javax.swing.GroupLayout(PnClient);
        PnClient.setLayout(PnClientLayout);
        PnClientLayout.setHorizontalGroup(
            PnClientLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        PnClientLayout.setVerticalGroup(
            PnClientLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 335, Short.MAX_VALUE)
        );

        TfCode.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        SpDigits.setModel(new javax.swing.SpinnerNumberModel(3, 3, 9, 1));
        SpDigits.addChangeListener(new javax.swing.event.ChangeListener() {
            public void stateChanged(javax.swing.event.ChangeEvent evt) {
                SpDigitsStateChanged(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(PnClient, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(TfCode)
            .addGroup(layout.createSequentialGroup()
                .addComponent(SpDigits, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 407, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(SpDigits, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(PnClient, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TfCode, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void SpDigitsStateChanged(javax.swing.event.ChangeEvent evt) {//GEN-FIRST:event_SpDigitsStateChanged
        int count=(Integer)SpDigits.getValue();
        for(ObservablePanel pn:panels) pn.clearObservers();
        while(panels.size()>count)
        {
            ObservablePanel pn=panels.remove(panels.size()-1);
            PnClient.remove(pn);
        }
        while(panels.size()<count)
        {
            ObservablePanel pn=new ObservablePanel();
            panels.add(pn);
            pn.setBorder(new MotifBorders.ToggleButtonBorder(Color.yellow, Color.lightGray, Color.darkGray, Color.blue));
            PnClient.add(pn);
        }
        ObservablePanel prev=null;
        for(ObservablePanel pn:panels)
        {
            if(prev!=null) pn.addObserver(prev);
            prev=pn;
            pn.addObserver((observer)->changes(null));
        }
        int w=getWidth();
        setSize(w+1, getHeight());
        setSize(w+0, getHeight());
    }//GEN-LAST:event_SpDigitsStateChanged

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new ObserverMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel PnClient;
    private javax.swing.JSpinner SpDigits;
    private javax.swing.JTextField TfCode;
    // End of variables declaration//GEN-END:variables
}
