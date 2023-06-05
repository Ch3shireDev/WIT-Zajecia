
import java.util.ArrayList;
import java.util.List;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class BridgeMainForm extends javax.swing.JFrame
{
    private final List<ShapeBase> shapes=new ArrayList<>();
    private final DefaultComboBoxModel<String> modelShapeKinds=new DefaultComboBoxModel<>();
    private final DefaultListModel<String> modelShapeList=new DefaultListModel<>();
    private final BridgeShapeList xmlBridge,listBridge,imageBridge;
    public BridgeMainForm()
    {
        initComponents();
        for(String key:ShapeFactory.keys) modelShapeKinds.addElement(key);
        CbShapeKinds.setModel(modelShapeKinds);
        CbShapeKinds.setSelectedIndex(0);
        LbShapeList.setModel(modelShapeList);
        xmlBridge=new BridgeShapeListToXml(TaXml);
        listBridge=new BridgeShapeListToList(LbShapeList);
        imageBridge=new BridgeShapeListToImage((JImagePanel)PnImagePanel);
    }
    
    private void adjust(boolean preserve)
    {
        int index=LbShapeList.getSelectedIndex();
        xmlBridge.proceed(shapes);
        listBridge.proceed(shapes);
        imageBridge.proceed(shapes);
        if(preserve) LbShapeList.setSelectedIndex(index);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        SpVertical = new javax.swing.JSplitPane();
        PnLeft = new javax.swing.JPanel();
        CbShapeKinds = new javax.swing.JComboBox<>();
        TfParameters = new javax.swing.JTextField();
        BtnAdd = new javax.swing.JButton();
        LbShapeListScroll = new javax.swing.JScrollPane();
        LbShapeList = new javax.swing.JList<>();
        PnRight = new javax.swing.JPanel();
        SpRight = new javax.swing.JSplitPane();
        TaXmlScroll = new javax.swing.JScrollPane();
        TaXml = new javax.swing.JTextArea();
        PnImagePanel = new JImagePanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Bridge pattern");

        SpVertical.setDividerLocation(300);
        SpVertical.setDividerSize(12);

        CbShapeKinds.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "ShapeKinds" }));

        TfParameters.setFont(new java.awt.Font("Lucida Console", 0, 10)); // NOI18N
        TfParameters.setText("100 100 90");

        BtnAdd.setText("Add");
        BtnAdd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddActionPerformed(evt);
            }
        });

        LbShapeList.setFont(new java.awt.Font("Lucida Console", 0, 10)); // NOI18N
        LbShapeList.setModel(new javax.swing.AbstractListModel<String>() {
            String[] strings = { "ShapeList" };
            public int getSize() { return strings.length; }
            public String getElementAt(int i) { return strings[i]; }
        });
        LbShapeListScroll.setViewportView(LbShapeList);

        javax.swing.GroupLayout PnLeftLayout = new javax.swing.GroupLayout(PnLeft);
        PnLeft.setLayout(PnLeftLayout);
        PnLeftLayout.setHorizontalGroup(
            PnLeftLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(PnLeftLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(PnLeftLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(LbShapeListScroll)
                    .addComponent(CbShapeKinds, 0, 289, Short.MAX_VALUE)
                    .addComponent(TfParameters)
                    .addComponent(BtnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
        );
        PnLeftLayout.setVerticalGroup(
            PnLeftLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(PnLeftLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(CbShapeKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TfParameters, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(BtnAdd)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(LbShapeListScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 380, Short.MAX_VALUE)
                .addContainerGap())
        );

        SpVertical.setLeftComponent(PnLeft);

        SpRight.setDividerLocation(300);
        SpRight.setDividerSize(12);
        SpRight.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);

        TaXml.setColumns(20);
        TaXml.setFont(new java.awt.Font("Lucida Console", 0, 10)); // NOI18N
        TaXml.setRows(5);
        TaXmlScroll.setViewportView(TaXml);

        SpRight.setRightComponent(TaXmlScroll);

        PnImagePanel.addComponentListener(new java.awt.event.ComponentAdapter() {
            public void componentResized(java.awt.event.ComponentEvent evt) {
                PnImagePanelComponentResized(evt);
            }
        });

        javax.swing.GroupLayout PnImagePanelLayout = new javax.swing.GroupLayout(PnImagePanel);
        PnImagePanel.setLayout(PnImagePanelLayout);
        PnImagePanelLayout.setHorizontalGroup(
            PnImagePanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 441, Short.MAX_VALUE)
        );
        PnImagePanelLayout.setVerticalGroup(
            PnImagePanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 299, Short.MAX_VALUE)
        );

        SpRight.setLeftComponent(PnImagePanel);

        javax.swing.GroupLayout PnRightLayout = new javax.swing.GroupLayout(PnRight);
        PnRight.setLayout(PnRightLayout);
        PnRightLayout.setHorizontalGroup(
            PnRightLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 453, Short.MAX_VALUE)
            .addGroup(PnRightLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(PnRightLayout.createSequentialGroup()
                    .addComponent(SpRight)
                    .addContainerGap()))
        );
        PnRightLayout.setVerticalGroup(
            PnRightLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 480, Short.MAX_VALUE)
            .addGroup(PnRightLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(PnRightLayout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(SpRight, javax.swing.GroupLayout.DEFAULT_SIZE, 458, Short.MAX_VALUE)
                    .addContainerGap()))
        );

        SpVertical.setRightComponent(PnRight);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(SpVertical)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(SpVertical)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
        String key=CbShapeKinds.getSelectedItem().toString();
        String text=TfParameters.getText().trim();
        ShapeBase shape=null;
        try
        {
            shapes.add(ShapeFactory.make(key, text));
            adjust(false);
        }
        catch(Exception ex) {}
    }//GEN-LAST:event_BtnAddActionPerformed

    private void PnImagePanelComponentResized(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_PnImagePanelComponentResized
        // TODO add your handling code here:
    }//GEN-LAST:event_PnImagePanelComponentResized

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new BridgeMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAdd;
    private javax.swing.JComboBox<String> CbShapeKinds;
    private javax.swing.JList<String> LbShapeList;
    private javax.swing.JScrollPane LbShapeListScroll;
    private javax.swing.JPanel PnImagePanel;
    private javax.swing.JPanel PnLeft;
    private javax.swing.JPanel PnRight;
    private javax.swing.JSplitPane SpRight;
    private javax.swing.JSplitPane SpVertical;
    private javax.swing.JTextArea TaXml;
    private javax.swing.JScrollPane TaXmlScroll;
    private javax.swing.JTextField TfParameters;
    // End of variables declaration//GEN-END:variables
}
