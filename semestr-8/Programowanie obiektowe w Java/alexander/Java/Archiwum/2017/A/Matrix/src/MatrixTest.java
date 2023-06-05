
import javax.swing.JLabel;
import javax.swing.JTextArea;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class MatrixTest extends javax.swing.JFrame {

   private Matrix mtxA,mtxB;
   public MatrixTest() {
      initComponents();
      MatrixA.getDocument().addDocumentListener(new DocumentListener() {
         @Override public void changedUpdate(DocumentEvent arg0) { change(); }
         @Override public void insertUpdate(DocumentEvent e) { change(); }
         @Override public void removeUpdate(DocumentEvent e) { change(); }
         private void change()
         {
            mtxA=calcSize(MatrixA,LabelSizeA);
            calculate();
         }
      });
      MatrixB.getDocument().addDocumentListener(new DocumentListener() {
         @Override public void changedUpdate(DocumentEvent arg0) { change(); }
         @Override public void insertUpdate(DocumentEvent e) { change(); }
         @Override public void removeUpdate(DocumentEvent e) { change(); }
         private void change()
         {
            mtxB=calcSize(MatrixB,LabelSizeB);
            calculate();
         }
      });
   }

   private Matrix calcSize(JTextArea box,JLabel info)
   {
      try
      {
         Matrix tmp=new Matrix(box.getText());
         info.setText(""+tmp.getRowCount()+"x"+tmp.getColCount());
         return tmp;
      }
      catch(Exception e)
      {
         info.setText(e.getMessage());
         return null;
      }
   }
   
   private void calculate()
   {
      Matrix c=Matrix.add(mtxA, mtxB);
      if(c!=null)
      {
         MatrixC.setText(c.toString());
      }
      else MatrixC.setText("");
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

      MatrixC.setColumns(20);
      MatrixC.setRows(5);
      MatrixScrollC.setViewportView(MatrixC);

      MatrixA.setColumns(20);
      MatrixA.setRows(5);
      MatrixA.setName(""); // NOI18N
      MatrixScrollA.setViewportView(MatrixA);

      LabelOperation.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
      LabelOperation.setText("+");

      LabelCalculate.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
      LabelCalculate.setText("=");

      MatrixB.setColumns(20);
      MatrixB.setRows(5);
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
                  .addComponent(MatrixScrollA, javax.swing.GroupLayout.PREFERRED_SIZE, 192, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(LabelOperation))
               .addComponent(LabelSizeA))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(MatrixScrollB, javax.swing.GroupLayout.PREFERRED_SIZE, 192, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(LabelCalculate)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(MatrixScrollC, javax.swing.GroupLayout.PREFERRED_SIZE, 192, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addComponent(LabelSizeB))
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addGap(123, 123, 123)
                  .addComponent(LabelOperation))
               .addGroup(layout.createSequentialGroup()
                  .addContainerGap()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(MatrixScrollB, javax.swing.GroupLayout.PREFERRED_SIZE, 251, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(MatrixScrollA, javax.swing.GroupLayout.PREFERRED_SIZE, 251, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(MatrixScrollC, javax.swing.GroupLayout.PREFERRED_SIZE, 251, javax.swing.GroupLayout.PREFERRED_SIZE)))
               .addGroup(layout.createSequentialGroup()
                  .addGap(128, 128, 128)
                  .addComponent(LabelCalculate)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 7, Short.MAX_VALUE)
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
   private static String[] noEmptySplit(String Text,String expr)
   {
      String[] tb=Text.split(expr);
      int sz=0;
      for(String str:tb) if(str.length()>0) ++sz;
      String[] ret=new String[sz];
      sz=0;
      for(String str:tb) if(str.length()>0) ret[sz++]=str;      
      return ret;
   }
   public Matrix(int RowCount,int ColCount)
   {
      tb=new double[RowCount][ColCount];
   }
   public Matrix(String Text) throws Exception
   {
      String[] Lines=noEmptySplit(Text,"\n");
      int RowCount=Lines.length;
      int ColCount=0;
      tb=null;
      for(int r=0;r<RowCount;++r)
      {
         String[] Cells=noEmptySplit(Lines[r],"[ \t]");
         if(r==0)
         {
            ColCount=Cells.length;
            tb=new double[RowCount][ColCount];
         }
         else if(ColCount!=Cells.length) throw new Exception("Różne rozmiary wierszy");
         for(int c=0;c<ColCount;++c)
         {
            try
            {
               tb[r][c]=Double.parseDouble(Cells[c]);
            }
            catch(Exception e)
            {
               throw new Exception(""+r+"x"+c+" "+e.getMessage());
            }
         }
      }
   }
   public static Matrix add(Matrix a,Matrix b)
   {
      if(a==null) return null;
      if(b==null) return null;
      int RowCount=a.getRowCount(),ColCount=a.getColCount();
      if(RowCount!=b.getRowCount()) return null;
      if(ColCount!=b.getColCount()) return null;
      Matrix ret=new Matrix(RowCount,ColCount);
      for(int r=0;r<RowCount;++r)
      {
         for(int c=0;c<ColCount;++c)
         {
            ret.tb[r][c]=a.tb[r][c]+b.tb[r][c];
         }
      }
      return ret;
   }
   @Override public String toString()
   {
      String ret="";
      for(int r=0;r<tb.length;++r)
      {
         for(int c=0;c<tb[r].length;++c)
         {
            if(c!=0) ret=ret+"\t";
            ret=ret+tb[r][c];
         }
         ret=ret+"\n";
      }
      return ret;
   }
   public int getRowCount() { return tb==null?0:tb.length; }
   public int getColCount() { return tb==null?0:tb[0].length; }
}