
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class MatrixMultiplyForm extends javax.swing.JFrame
{
   public MatrixMultiplyForm()
   {
      initComponents();
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { recalc(); }
         @Override public void removeUpdate(DocumentEvent e) { recalc(); }
         @Override public void changedUpdate(DocumentEvent e) { recalc(); }
      };
      MatrixA.getDocument().addDocumentListener(listener);
      MatrixB.getDocument().addDocumentListener(listener);
      recalc();
   }

   private void err(String src,Exception ex)
   {
      MatrixR.append(src+": "+ex.getMessage()+System.lineSeparator());
   }

   private void recalc()
   {
      MatrixR.setText("");
      try
      {
         Matrix A=null,B=null;
         try
         {
            A=new Matrix(MatrixA.getText().replace(',','.'));
         }
         catch(Exception ex) { err("A",ex); }
         try
         {
            B=new Matrix(MatrixB.getText().replace(',','.'));
         }
         catch(Exception ex) { err("B",ex); }
         Matrix C=Matrix.multiply(A,B);
         MatrixR.setText(C.toString().replace('.',','));
      }
      catch(Exception ex) { err("Multiply",ex); }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      DivVertical = new javax.swing.JSplitPane();
      DivHorizontal = new javax.swing.JSplitPane();
      MatrixAscroll = new javax.swing.JScrollPane();
      MatrixA = new javax.swing.JTextArea();
      MatrixBscroll = new javax.swing.JScrollPane();
      MatrixB = new javax.swing.JTextArea();
      MatrixRscroll = new javax.swing.JScrollPane();
      MatrixR = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      DivVertical.setDividerLocation(250);
      DivVertical.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);

      DivHorizontal.setDividerLocation(280);

      MatrixA.setColumns(20);
      MatrixA.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      MatrixA.setRows(5);
      MatrixA.setText("2,9\t5,1\t0,5\t1,6\n4,6\t4,9\t0,7\t1,7\n6,2\t9,8\t5,0\t8,1\n8,7\t7,9\t7,8\t1,9\n");
      MatrixAscroll.setViewportView(MatrixA);

      DivHorizontal.setLeftComponent(MatrixAscroll);

      MatrixB.setColumns(20);
      MatrixB.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      MatrixB.setRows(5);
      MatrixB.setText("9,6\t0,6\t1,7\t7,7\t7,6\n7,1\t9,5\t8,5\t9,2\t3,8\n6,4\t0,2\t0,5\t2,9\t9,6\n5,6\t6,9\t2,1\t0,4\t10,0\n");
      MatrixBscroll.setViewportView(MatrixB);

      DivHorizontal.setRightComponent(MatrixBscroll);

      DivVertical.setTopComponent(DivHorizontal);

      MatrixR.setColumns(20);
      MatrixR.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      MatrixR.setRows(5);
      MatrixRscroll.setViewportView(MatrixR);

      DivVertical.setRightComponent(MatrixRscroll);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(DivVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 645, Short.MAX_VALUE)
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(DivVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 461, Short.MAX_VALUE)
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new MatrixMultiplyForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JSplitPane DivHorizontal;
   private javax.swing.JSplitPane DivVertical;
   private javax.swing.JTextArea MatrixA;
   private javax.swing.JScrollPane MatrixAscroll;
   private javax.swing.JTextArea MatrixB;
   private javax.swing.JScrollPane MatrixBscroll;
   private javax.swing.JTextArea MatrixR;
   private javax.swing.JScrollPane MatrixRscroll;
   // End of variables declaration//GEN-END:variables
}
