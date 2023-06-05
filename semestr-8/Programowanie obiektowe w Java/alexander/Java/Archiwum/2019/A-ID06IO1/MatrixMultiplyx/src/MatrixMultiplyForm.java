
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
      Matrix A=null,B=null;
      try
      {
         A=new Matrix(MatrixA.getText().replace(",","."));
      }
      catch(Exception ex)
      {
         MatrixR.setText("Error: A: "+ex.getMessage());
         return;
      }
      try
      {
         B=new Matrix(MatrixB.getText().replace(",","."));
      }
      catch(Exception ex)
      {
         MatrixR.setText("Error: B: "+ex.getMessage());
         return;
      }
      try
      {
         MatrixR.setText(Matrix.multiply(A,B).toString().replace(".",","));
      }
      catch(Exception ex) { MatrixR.setText("Error: "+ex.getMessage()); }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      SplitVertical = new javax.swing.JSplitPane();
      SplitHorizontal = new javax.swing.JSplitPane();
      MatrixAScroll = new javax.swing.JScrollPane();
      MatrixA = new javax.swing.JTextArea();
      MatrixBScroll = new javax.swing.JScrollPane();
      MatrixB = new javax.swing.JTextArea();
      MatrixRScroll = new javax.swing.JScrollPane();
      MatrixR = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      SplitVertical.setDividerLocation(150);
      SplitVertical.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);

      SplitHorizontal.setDividerLocation(300);

      MatrixA.setColumns(20);
      MatrixA.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixA.setRows(5);
      MatrixA.setText("2,7\t4,3\t0,3\t0,9\n9,0\t0,1\t2,7\t8,6\n1,3\t8,8\t0,4\t6,6\n1,6\t5,3\t2,6\t4,0\n");
      MatrixAScroll.setViewportView(MatrixA);

      SplitHorizontal.setLeftComponent(MatrixAScroll);

      MatrixB.setColumns(20);
      MatrixB.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixB.setRows(5);
      MatrixB.setText("9,5\t7,1\t2,6\t6,6\t5,6\n7,6\t9,6\t2,4\t4,9\t4,1\n2,9\t1,8\t10,0\t9,2\t3,9\n1,2\t6,0\t2,3\t3,7\t5,9\n");
      MatrixB.setToolTipText("");
      MatrixBScroll.setViewportView(MatrixB);

      SplitHorizontal.setRightComponent(MatrixBScroll);

      SplitVertical.setLeftComponent(SplitHorizontal);

      MatrixR.setEditable(false);
      MatrixR.setBackground(new java.awt.Color(222, 222, 222));
      MatrixR.setColumns(20);
      MatrixR.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixR.setRows(5);
      MatrixRScroll.setViewportView(MatrixR);

      SplitVertical.setRightComponent(MatrixRScroll);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(SplitVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 649, Short.MAX_VALUE)
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(SplitVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 424, Short.MAX_VALUE)
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() ->new MatrixMultiplyForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JTextArea MatrixA;
   private javax.swing.JScrollPane MatrixAScroll;
   private javax.swing.JTextArea MatrixB;
   private javax.swing.JScrollPane MatrixBScroll;
   private javax.swing.JTextArea MatrixR;
   private javax.swing.JScrollPane MatrixRScroll;
   private javax.swing.JSplitPane SplitHorizontal;
   private javax.swing.JSplitPane SplitVertical;
   // End of variables declaration//GEN-END:variables
}
