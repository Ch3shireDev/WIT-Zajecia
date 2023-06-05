
import java.awt.Dimension;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import javax.swing.JPanel;

public class ListenerTestForm extends javax.swing.JFrame {

    public ListenerTestForm() 
    {
        initComponents();
        SignalSourceTimer Source=new SignalSourceTimer(100,1000);
        SignalSourcePanel APanel=new SignalSourcePanel(PanelA);
        SignalSourcePanel BPanel=new SignalSourcePanel(PanelB);
        SignalSourcePanel CPanel=new SignalSourcePanel(PanelC);
        SignalSourcePanel DPanel=new SignalSourcePanel(PanelD);
        Source.AddListener(APanel);
        APanel.AddListener(BPanel);
        BPanel.AddListener(CPanel);
        CPanel.AddListener(DPanel);
        ComponentAdapter onresize=new ComponentAdapter() 
        {
            @Override public void componentResized(ComponentEvent componentEvent) 
            {
                doresize(); 
            }
        };
        addComponentListener(onresize);
        doresize();
    }
    
    private void doresize()
    {
        final int MarginSize=20;
        final JPanel[] tb={PanelD,PanelC,PanelB,PanelA};
        int Curr=MarginSize,Step=(getWidth()-MarginSize-1)/tb.length,Width=Step-MarginSize;
        for(int i=0;i<tb.length;++i)
        {
            int Y=tb[i].getLocation().y,Height=tb[i].getSize().height;
            tb[i].setBounds(Curr,Y,Width,Height);
            Curr+=Step;
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        PanelC = new javax.swing.JPanel();
        PanelA = new javax.swing.JPanel();
        PanelB = new javax.swing.JPanel();
        PanelD = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        PanelC.setPreferredSize(new java.awt.Dimension(120, 100));

        javax.swing.GroupLayout PanelCLayout = new javax.swing.GroupLayout(PanelC);
        PanelC.setLayout(PanelCLayout);
        PanelCLayout.setHorizontalGroup(
            PanelCLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 120, Short.MAX_VALUE)
        );
        PanelCLayout.setVerticalGroup(
            PanelCLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        PanelA.setPreferredSize(new java.awt.Dimension(120, 100));

        javax.swing.GroupLayout PanelALayout = new javax.swing.GroupLayout(PanelA);
        PanelA.setLayout(PanelALayout);
        PanelALayout.setHorizontalGroup(
            PanelALayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 120, Short.MAX_VALUE)
        );
        PanelALayout.setVerticalGroup(
            PanelALayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 342, Short.MAX_VALUE)
        );

        PanelB.setPreferredSize(new java.awt.Dimension(120, 100));

        javax.swing.GroupLayout PanelBLayout = new javax.swing.GroupLayout(PanelB);
        PanelB.setLayout(PanelBLayout);
        PanelBLayout.setHorizontalGroup(
            PanelBLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 120, Short.MAX_VALUE)
        );
        PanelBLayout.setVerticalGroup(
            PanelBLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 342, Short.MAX_VALUE)
        );

        PanelD.setPreferredSize(new java.awt.Dimension(120, 100));

        javax.swing.GroupLayout PanelDLayout = new javax.swing.GroupLayout(PanelD);
        PanelD.setLayout(PanelDLayout);
        PanelDLayout.setHorizontalGroup(
            PanelDLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 120, Short.MAX_VALUE)
        );
        PanelDLayout.setVerticalGroup(
            PanelDLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(18, 18, 18)
                .addComponent(PanelD, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(PanelC, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(PanelB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(PanelA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(154, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(PanelC, javax.swing.GroupLayout.DEFAULT_SIZE, 342, Short.MAX_VALUE)
                    .addComponent(PanelD, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 342, Short.MAX_VALUE)
                    .addComponent(PanelA, javax.swing.GroupLayout.DEFAULT_SIZE, 342, Short.MAX_VALUE)
                    .addComponent(PanelB, javax.swing.GroupLayout.DEFAULT_SIZE, 342, Short.MAX_VALUE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public static void main(String args[]) 
    {
        java.awt.EventQueue.invokeLater(() -> new ListenerTestForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel PanelA;
    private javax.swing.JPanel PanelB;
    private javax.swing.JPanel PanelC;
    private javax.swing.JPanel PanelD;
    // End of variables declaration//GEN-END:variables
}
