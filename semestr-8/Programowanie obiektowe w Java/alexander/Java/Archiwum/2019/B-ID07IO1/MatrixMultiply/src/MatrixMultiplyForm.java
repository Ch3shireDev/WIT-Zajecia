
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

   private void recalc()
   {
      try
      {
         Matrix A=new Matrix(MatrixA.getText().replace(',','.'));
         try
         {
            Matrix B=new Matrix(MatrixB.getText().replace(',','.'));
            try
            {
               Matrix C=Matrix.multiply(A,B);
               MatrixR.setText(C.toString().replace('.',','));
            }
            catch(Exception ex) { MatrixR.setText(ex.getMessage()); }
         }
         catch(Exception ex) { MatrixR.setText("B: "+ex.getMessage()); }
      }
      catch(Exception ex) { MatrixR.setText("A: "+ex.getMessage()); }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      Vertical = new javax.swing.JSplitPane();
      Horizontal = new javax.swing.JSplitPane();
      MatrixAScroll = new javax.swing.JScrollPane();
      MatrixA = new javax.swing.JTextArea();
      MatrixBScroll = new javax.swing.JScrollPane();
      MatrixB = new javax.swing.JTextArea();
      MatrixRScroll = new javax.swing.JScrollPane();
      MatrixR = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Mnożenie macierzy ...");

      Vertical.setDividerLocation(200);
      Vertical.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);

      Horizontal.setDividerLocation(270);

      MatrixA.setColumns(20);
      MatrixA.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixA.setRows(5);
      MatrixA.setText("1,9\t7,2\t5,8\t4,6\n2,2\t2,3\t1,6\t4,4\n2,8\t9,1\t1,0\t7,5\n9,7\t7,3\t4,5\t2,2\n");
      MatrixA.setToolTipText("");
      MatrixAScroll.setViewportView(MatrixA);

      Horizontal.setLeftComponent(MatrixAScroll);

      MatrixB.setColumns(20);
      MatrixB.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixB.setRows(5);
      MatrixB.setText("5,5\t9,9\t8,8\t8,4\t6,5\n7,6\t2,0\t6,5\t8,7\t7,6\n0,6\t0,9\t2,3\t3,6\t2,2\n4,7\t8,3\t6,0\t0,5\t2,0\n");
      MatrixB.setToolTipText("");
      MatrixBScroll.setViewportView(MatrixB);

      Horizontal.setRightComponent(MatrixBScroll);

      Vertical.setTopComponent(Horizontal);

      MatrixR.setEditable(false);
      MatrixR.setBackground(new java.awt.Color(245, 245, 245));
      MatrixR.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixR.setRows(5);
      MatrixR.setAutoscrolls(false);
      MatrixRScroll.setViewportView(MatrixR);

      Vertical.setRightComponent(MatrixRScroll);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(Vertical, javax.swing.GroupLayout.DEFAULT_SIZE, 609, Short.MAX_VALUE)
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(Vertical, javax.swing.GroupLayout.DEFAULT_SIZE, 427, Short.MAX_VALUE)
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new MatrixMultiplyForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JSplitPane Horizontal;
   private javax.swing.JTextArea MatrixA;
   private javax.swing.JScrollPane MatrixAScroll;
   private javax.swing.JTextArea MatrixB;
   private javax.swing.JScrollPane MatrixBScroll;
   private javax.swing.JTextArea MatrixR;
   private javax.swing.JScrollPane MatrixRScroll;
   private javax.swing.JSplitPane Vertical;
   // End of variables declaration//GEN-END:variables
}
