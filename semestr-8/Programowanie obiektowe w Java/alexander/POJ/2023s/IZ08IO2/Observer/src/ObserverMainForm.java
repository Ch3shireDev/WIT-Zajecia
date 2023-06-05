
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.Action;
import javax.swing.JPanel;
import javax.swing.Timer;

public class ObserverMainForm extends javax.swing.JFrame
{
    private static Color[] colors = new Color[] { Color.BLUE,Color.MAGENTA,Color.ORANGE };
    private JPanel[] panels;
            
    public ObserverMainForm()
    {
        initComponents();
        panels=new JPanel[] {PnA,PnB,PnC,PnD};
        for(JPanel pn:panels) pn.setBackground(colors[0]);
        Timer tm=new Timer(1000, this::firstpanel);
        tm.start();
    }
    
    private Color nextColor(Color current)
    {
        int found=-1;
        for(int i=0;(i<colors.length)&&(found<0);++i) if(colors[i].equals(current)) found=i;
        int next=(found+1)%colors.length;
        return colors[next];
    }
    
    private void firstpanel(ActionEvent e)
    {
        panels[0].setBackground(nextColor(panels[0].getBackground()));
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        PnB = new javax.swing.JPanel();
        PnD = new javax.swing.JPanel();
        PnA = new javax.swing.JPanel();
        PnC = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        PnB.setBackground(new java.awt.Color(102, 102, 255));

        javax.swing.GroupLayout PnBLayout = new javax.swing.GroupLayout(PnB);
        PnB.setLayout(PnBLayout);
        PnBLayout.setHorizontalGroup(
            PnBLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );
        PnBLayout.setVerticalGroup(
            PnBLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        PnD.setBackground(new java.awt.Color(102, 102, 255));

        javax.swing.GroupLayout PnDLayout = new javax.swing.GroupLayout(PnD);
        PnD.setLayout(PnDLayout);
        PnDLayout.setHorizontalGroup(
            PnDLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );
        PnDLayout.setVerticalGroup(
            PnDLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        PnA.setBackground(new java.awt.Color(102, 102, 255));

        javax.swing.GroupLayout PnALayout = new javax.swing.GroupLayout(PnA);
        PnA.setLayout(PnALayout);
        PnALayout.setHorizontalGroup(
            PnALayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );
        PnALayout.setVerticalGroup(
            PnALayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 303, Short.MAX_VALUE)
        );

        PnC.setBackground(new java.awt.Color(102, 102, 255));

        javax.swing.GroupLayout PnCLayout = new javax.swing.GroupLayout(PnC);
        PnC.setLayout(PnCLayout);
        PnCLayout.setHorizontalGroup(
            PnCLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 100, Short.MAX_VALUE)
        );
        PnCLayout.setVerticalGroup(
            PnCLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 303, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(PnA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(PnB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(PnC, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(PnD, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(PnB, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(PnA, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(PnD, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(PnC, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ObserverMainForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel PnA;
    private javax.swing.JPanel PnB;
    private javax.swing.JPanel PnC;
    private javax.swing.JPanel PnD;
    // End of variables declaration//GEN-END:variables
}
