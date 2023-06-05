
import java.awt.image.BufferedImage;
import java.nio.Buffer;
import java.util.ArrayList;
import java.util.List;
import javax.swing.DefaultListModel;

public class BridgeForm extends javax.swing.JFrame
{
   private DefaultListModel<String> shapeModel=new DefaultListModel<>();
   private ArrayList<Shape> shapeList=new ArrayList<>();
   private ShapeListToImageBridge slbImage=new ShapeListToImageBridge();
   private BufferedImage image=null;

   public BridgeForm()
   {
      initComponents();
      cbShapeKind.removeAllItems();
      for(String kind:Shape.keyList()) cbShapeKind.addItem(kind);
      cbShapeKind.setSelectedIndex(0);
      lbShapeList.setModel(shapeModel);
      resize();
   }

   private void resize()
   {
      image=new BufferedImage(ibShapesViewer.getWidth(),ibShapesViewer.getHeight(),BufferedImage.TYPE_INT_ARGB);
      ((ImageBox)ibShapesViewer).setImage(image);
      slbImage.setImage(image);
      repaint();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      spVertical = new javax.swing.JSplitPane();
      spHorizontal = new javax.swing.JSplitPane();
      pnControls = new javax.swing.JPanel();
      cbShapeKind = new javax.swing.JComboBox<>();
      tfParameters = new javax.swing.JTextField();
      btnAdd = new javax.swing.JButton();
      jScrollPane2 = new javax.swing.JScrollPane();
      lbShapeList = new javax.swing.JList<>();
      ibShapesViewer = new ImageBox();
      jScrollPane1 = new javax.swing.JScrollPane();
      taXml = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      spVertical.setDividerLocation(400);
      spVertical.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);

      spHorizontal.setDividerLocation(250);

      cbShapeKind.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "kinds" }));

      tfParameters.setText("110,110; 100");

      btnAdd.setText("Dodaj");
      btnAdd.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnAddActionPerformed(evt);
         }
      });

      lbShapeList.setModel(new javax.swing.AbstractListModel<String>()
      {
         String[] strings = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
         public int getSize() { return strings.length; }
         public String getElementAt(int i) { return strings[i]; }
      });
      jScrollPane2.setViewportView(lbShapeList);

      javax.swing.GroupLayout pnControlsLayout = new javax.swing.GroupLayout(pnControls);
      pnControls.setLayout(pnControlsLayout);
      pnControlsLayout.setHorizontalGroup(
         pnControlsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnControlsLayout.createSequentialGroup()
            .addContainerGap()
            .addGroup(pnControlsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
               .addComponent(jScrollPane2)
               .addComponent(tfParameters, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 229, Short.MAX_VALUE)
               .addGroup(javax.swing.GroupLayout.Alignment.LEADING, pnControlsLayout.createSequentialGroup()
                  .addGroup(pnControlsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(cbShapeKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnAdd))
                  .addGap(0, 0, Short.MAX_VALUE)))
            .addContainerGap())
      );
      pnControlsLayout.setVerticalGroup(
         pnControlsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(pnControlsLayout.createSequentialGroup()
            .addContainerGap()
            .addComponent(cbShapeKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(tfParameters, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(btnAdd)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 294, Short.MAX_VALUE)
            .addContainerGap())
      );

      spHorizontal.setLeftComponent(pnControls);

      ibShapesViewer.addComponentListener(new java.awt.event.ComponentAdapter()
      {
         public void componentResized(java.awt.event.ComponentEvent evt)
         {
            ibShapesViewerComponentResized(evt);
         }
      });

      javax.swing.GroupLayout ibShapesViewerLayout = new javax.swing.GroupLayout(ibShapesViewer);
      ibShapesViewer.setLayout(ibShapesViewerLayout);
      ibShapesViewerLayout.setHorizontalGroup(
         ibShapesViewerLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 543, Short.MAX_VALUE)
      );
      ibShapesViewerLayout.setVerticalGroup(
         ibShapesViewerLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 397, Short.MAX_VALUE)
      );

      spHorizontal.setRightComponent(ibShapesViewer);

      spVertical.setTopComponent(spHorizontal);

      taXml.setColumns(20);
      taXml.setRows(5);
      jScrollPane1.setViewportView(taXml);

      spVertical.setRightComponent(jScrollPane1);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(spVertical)
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(spVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 634, Short.MAX_VALUE)
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnAddActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnAddActionPerformed
   {//GEN-HEADEREND:event_btnAddActionPerformed
      try
      {
         Shape shape=Shape.make(cbShapeKind.getSelectedItem().toString(),tfParameters.getText());
         shapeList.add(shape);
         slbImage.proceed(shapeList);
         repaint();
      }
      catch(Exception ex) {}
   }//GEN-LAST:event_btnAddActionPerformed

   private void ibShapesViewerComponentResized(java.awt.event.ComponentEvent evt)//GEN-FIRST:event_ibShapesViewerComponentResized
   {//GEN-HEADEREND:event_ibShapesViewerComponentResized
      resize();
   }//GEN-LAST:event_ibShapesViewerComponentResized

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new BridgeForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnAdd;
   private javax.swing.JComboBox<String> cbShapeKind;
   private javax.swing.JPanel ibShapesViewer;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   private javax.swing.JList<String> lbShapeList;
   private javax.swing.JPanel pnControls;
   private javax.swing.JSplitPane spHorizontal;
   private javax.swing.JSplitPane spVertical;
   private javax.swing.JTextArea taXml;
   private javax.swing.JTextField tfParameters;
   // End of variables declaration//GEN-END:variables
}
