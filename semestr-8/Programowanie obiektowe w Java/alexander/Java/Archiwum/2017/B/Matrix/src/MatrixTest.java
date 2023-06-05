
import java.awt.Dimension;
import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;
import javax.swing.JLabel;
import javax.swing.JTextArea;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class MatrixTest extends javax.swing.JFrame {

   private Matrix mtxA,mtxB;
   public MatrixTest() {
      initComponents();
      MatrixA.getDocument().addDocumentListener(new DocumentListener() {
         @Override public void insertUpdate(DocumentEvent e) { change(); }
         @Override public void removeUpdate(DocumentEvent e) { change(); }
         @Override public void changedUpdate(DocumentEvent e) { change(); }
         private void change()
         {
            mtxA=readMatrix(MatrixA.getText(),LabelSizeA);
            calculate();
         }
      });
      MatrixB.getDocument().addDocumentListener(new DocumentListener() {
         @Override public void insertUpdate(DocumentEvent e) { change(); }
         @Override public void removeUpdate(DocumentEvent e) { change(); }
         @Override public void changedUpdate(DocumentEvent e) { change(); }
         private void change()
         {
            mtxB=readMatrix(MatrixB.getText(),LabelSizeB);
            calculate();
         }
      });
   }
   
   private Matrix readMatrix(String text,JLabel info)
   {
      try
      {
         Matrix ret=new Matrix(text);
         info.setText(""+ret.getRowCount()+"x"+ret.getColCount());
         return ret;
      }
      catch(Exception e)
      {
         info.setText(e.getMessage());
         return null;
      }
   }

   private void calculate()
   {
      Matrix c=Matrix.sum(mtxA,mtxB);
      if(c==null) MatrixC.setText("");
      else MatrixC.setText(c.toString());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      MatrixScrollC = new javax.swing.JScrollPane();
      MatrixC = new javax.swing.JTextArea();
      MatrixScrollA = new javax.swing.JScrollPane();
      MatrixA = new javax.swing.JTextArea();
      LabelOperation = new javax.swing.JLabel();
      LabelCalculate = new javax.swing.JLabel();
      MatrixScrollB = new javax.swing.JScrollPane();
      MatrixB = new javax.swing.JTextArea();
      LabelSizeA = new javax.swing.JLabel();
      LabelSizeB = new javax.swing.JLabel();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Dodawanie maqcierzy ...");
      setMinimumSize(new java.awt.Dimension(800, 300));

      MatrixScrollC.setPreferredSize(null);

      MatrixC.setColumns(20);
      MatrixC.setRows(5);
      MatrixC.setMinimumSize(new java.awt.Dimension(20, 50));
      MatrixC.setPreferredSize(null);
      MatrixScrollC.setViewportView(MatrixC);

      MatrixScrollA.setPreferredSize(null);
      MatrixScrollA.setRequestFocusEnabled(false);

      MatrixA.setColumns(20);
      MatrixA.setRows(5);
      MatrixA.setMinimumSize(new java.awt.Dimension(20, 50));
      MatrixA.setName(""); // NOI18N
      MatrixA.setPreferredSize(null);
      MatrixScrollA.setViewportView(MatrixA);

      LabelOperation.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
      LabelOperation.setText("+");

      LabelCalculate.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
      LabelCalculate.setText("=");

      MatrixScrollB.setPreferredSize(null);

      MatrixB.setColumns(20);
      MatrixB.setRows(5);
      MatrixB.setMinimumSize(new java.awt.Dimension(20, 50));
      MatrixB.setPreferredSize(null);
      MatrixScrollB.setViewportView(MatrixB);

      LabelSizeA.setText("0x0");

      LabelSizeB.setText("0x0");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(MatrixScrollA, javax.swing.GroupLayout.DEFAULT_SIZE, 200, Short.MAX_VALUE)
                  .addGap(6, 6, 6)
                  .addComponent(LabelOperation))
               .addComponent(LabelSizeA))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(MatrixScrollB, javax.swing.GroupLayout.DEFAULT_SIZE, 200, Short.MAX_VALUE)
                  .addGap(6, 6, 6)
                  .addComponent(LabelCalculate))
               .addComponent(LabelSizeB))
            .addGap(6, 6, 6)
            .addComponent(MatrixScrollC, javax.swing.GroupLayout.DEFAULT_SIZE, 200, Short.MAX_VALUE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addGap(123, 123, 123)
                        .addComponent(LabelOperation))
                     .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addComponent(MatrixScrollA, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                           .addComponent(MatrixScrollB, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                           .addComponent(MatrixScrollC, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED))
               .addGroup(layout.createSequentialGroup()
                  .addGap(125, 125, 125)
                  .addComponent(LabelCalculate)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 122, Short.MAX_VALUE)))
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(LabelSizeA, javax.swing.GroupLayout.Alignment.TRAILING)
               .addComponent(LabelSizeB, javax.swing.GroupLayout.Alignment.TRAILING))
            .addContainerGap())
      );

      LabelSizeA.getAccessibleContext().setAccessibleName("");
      LabelSizeB.getAccessibleContext().setAccessibleName("");

      pack();
   }// </editor-fold>//GEN-END:initComponents

   /**
    * @param args the command line arguments
    */
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
         java.util.logging.Logger.getLogger(MatrixTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(MatrixTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(MatrixTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(MatrixTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
        //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new MatrixTest().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JLabel LabelCalculate;
   private javax.swing.JLabel LabelOperation;
   private javax.swing.JLabel LabelSizeA;
   private javax.swing.JLabel LabelSizeB;
   private javax.swing.JTextArea MatrixA;
   private javax.swing.JTextArea MatrixB;
   private javax.swing.JTextArea MatrixC;
   private javax.swing.JScrollPane MatrixScrollA;
   private javax.swing.JScrollPane MatrixScrollB;
   private javax.swing.JScrollPane MatrixScrollC;
   // End of variables declaration//GEN-END:variables
}

class Matrix
{
   private double [][] tb;
   public Matrix(int RowCount,int ColCount)
   {
      tb=new double[RowCount][ColCount];
   }
   private String[] splitNoEmpty(String text,String expr)
   {
      String[] tmp=text.split(expr);
      int sz=0;
      for(String str:tmp) if(str.trim().length()>0) ++sz;
      String[] ret=new String[sz];
      sz=0;
      for(String str:tmp) if(str.trim().length()>0) ret[sz++]=str.trim();
      return ret;
   }
   public Matrix(String text) throws Exception
   {
      String[] Lines=splitNoEmpty(text.trim(),"\n");
      int RowCount=Lines.length;
      int ColCount=0;
      for(int y=0;y<RowCount;++y)
      {
         String[] Cells=splitNoEmpty(Lines[y],"[ \t]");
         if(y==0) tb=new double[RowCount][ColCount=Cells.length];
         else if(ColCount!=Cells.length) throw new Exception("Różne rozmiary wierszy");
         for(int x=0;x<ColCount;++x)
         {
            try
            {
               tb[y][x]=Double.parseDouble(Cells[x]);
            }
            catch(Exception e)
            {
               throw new Exception("Nie liczba "+(y+1)+"x"+(x+1)+": "+Cells[x]);
            }
         }
      }      
   }
   public static Matrix sum(Matrix a,Matrix b)
   {
      if(a==null) return null;
      if(b==null) return null;
      int RowCount=a.getRowCount(),ColCount=a.getColCount();
      if(RowCount!=b.getRowCount()) return null;
      if(ColCount!=b.getColCount()) return null;
      Matrix ret=new Matrix(RowCount,ColCount);
      for(int y=0;y<RowCount;++y)
      {
         for(int x=0;x<ColCount;++x)
         {
            ret.tb[y][x]=a.tb[y][x]+b.tb[y][x];
         }
      }
      return ret;
   }
   @Override public String toString()
   {
      String ret="";
      for(double[] row:tb)
      {
         String add="";
         for(double val:row) add=add+val+"\t";
         ret=ret+add.trim()+"\n";
      }
      return ret;
   }
   public int getRowCount() { return tb.length; }
   public int getColCount() { return tb.length>0?tb[0].length:0; }
}