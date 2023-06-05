import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.URI;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFileChooser;
import javax.swing.filechooser.FileNameExtensionFilter;

public class MergeSortForm extends javax.swing.JFrame
{
   public MergeSortForm()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      LbSrcFile = new javax.swing.JLabel();
      BtnSrcFile = new javax.swing.JButton();
      LbDstFile = new javax.swing.JLabel();
      BtnDstFile = new javax.swing.JButton();
      BtnSort = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      LbSrcFile.setText("P:\\Barski\\POJ\\2018_z\\MergeSortThreadTest\\Test1.txt");

      BtnSrcFile.setText("Zmień");
      BtnSrcFile.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnSrcFileActionPerformed(evt);
         }
      });

      LbDstFile.setText("c:\\Temp\\Test0.txt");

      BtnDstFile.setText("Zmień");
      BtnDstFile.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnDstFileActionPerformed(evt);
         }
      });

      BtnSort.setText("Sort");
      BtnSort.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnSortActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addComponent(LbDstFile, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnDstFile))
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addGap(0, 0, Short.MAX_VALUE)
                  .addComponent(BtnSort))
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addComponent(LbSrcFile, javax.swing.GroupLayout.DEFAULT_SIZE, 412, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnSrcFile)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(BtnSrcFile)
               .addComponent(LbSrcFile))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(BtnDstFile)
               .addComponent(LbDstFile))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(BtnSort)
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnSrcFileActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnSrcFileActionPerformed
   {//GEN-HEADEREND:event_BtnSrcFileActionPerformed
      JFileChooser chooser=new JFileChooser();
      final File curr=new File(LbSrcFile.getText());
      final File path=new File(curr.getParent());
      chooser.setCurrentDirectory(path);
      chooser.setSelectedFile(curr);
      chooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
      chooser.removeChoosableFileFilter(chooser.getFileFilter());
      chooser.addChoosableFileFilter(new FileNameExtensionFilter("Pliki txt","txt"));
      chooser.addChoosableFileFilter(new FileNameExtensionFilter("Wszystkie pliki","*"));
      if(chooser.showOpenDialog(this)==JFileChooser.APPROVE_OPTION)
      {
         LbSrcFile.setText(chooser.getSelectedFile().getPath());
      }
   }//GEN-LAST:event_BtnSrcFileActionPerformed

   private void BtnDstFileActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnDstFileActionPerformed
   {//GEN-HEADEREND:event_BtnDstFileActionPerformed
      JFileChooser chooser=new JFileChooser();
      final File curr=new File(LbDstFile.getText());
      final File path=new File(curr.getParent());
      chooser.setCurrentDirectory(path);
      chooser.setSelectedFile(curr);
      chooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
      chooser.removeChoosableFileFilter(chooser.getFileFilter());
      chooser.addChoosableFileFilter(new FileNameExtensionFilter("Pliki txt","txt"));
      chooser.addChoosableFileFilter(new FileNameExtensionFilter("Wszystkie pliki","*"));
      if(chooser.showOpenDialog(this)==JFileChooser.APPROVE_OPTION)
      {
         LbDstFile.setText(chooser.getSelectedFile().getPath());
      }
   }//GEN-LAST:event_BtnDstFileActionPerformed

   private void BtnSortActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnSortActionPerformed
   {//GEN-HEADEREND:event_BtnSortActionPerformed
      final Path src=Paths.get(LbSrcFile.getText());
      final File dest=new File(LbDstFile.getText());
      try
      {
         List<String> lines=Files.readAllLines(src,Charset.defaultCharset());
         int[] tb=new int[lines.size()];
         for(int i=0;i<tb.length;++i) tb[i]=Integer.parseInt(lines.get(i));
         MergeTaskThread.sort(tb);
         StringBuilder sb=new StringBuilder();
         for(int i=0;i<tb.length;++i)
         {
            sb.append(tb[i]).append(System.lineSeparator());
         }
         final String content=sb.toString();
         try(BufferedWriter bf=new BufferedWriter(new FileWriter(dest)))
         {
            bf.write(content);
            bf.close();
         }
      }
      catch(InterruptedException|IOException ex) {}
   }//GEN-LAST:event_BtnSortActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(()->new MergeSortForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnDstFile;
   private javax.swing.JButton BtnSort;
   private javax.swing.JButton BtnSrcFile;
   private javax.swing.JLabel LbDstFile;
   private javax.swing.JLabel LbSrcFile;
   // End of variables declaration//GEN-END:variables
}
