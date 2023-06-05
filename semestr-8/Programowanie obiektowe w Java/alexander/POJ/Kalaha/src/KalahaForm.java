
import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.util.HashMap;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class KalahaForm extends javax.swing.JFrame
{
   private static final int sidecount=7;
   private static final int allcount=sidecount<<1;
   private static final int baselocation=sidecount-1;
   private static final int lastlocation=baselocation-1;
   private JButton[] Box=new JButton[allcount];
   private HashMap<Object,Integer> map=new HashMap<>();

   public KalahaForm()
   {
      InitAll();
   }

   private void InitAll()
   {
      final Container pane=getContentPane();
      final JPanel client=new JPanel();
      int W=pane.getWidth(),w=W>>3;
      int H=pane.getHeight(),h=H>>1;
      for(int i=0;i<allcount;++i)
      {
         Box[i]=new JButton();
         map.put(Box[i],i);
      }
      for(int y=0;y<2;++y)
      {
         final JButton base=Box[y*sidecount+baselocation];
         base.setPreferredSize(new Dimension(w,H));
         base.setEnabled(false);
         for(int x=0;x<baselocation;++x)
         {
            JButton box=Box[y*sidecount+x];
            box.setPreferredSize(new Dimension(w,h));
            box.addActionListener(this::BoxActionPerformed);
            box.setText("6");
            //box.setEnabled(y>0);
         }
      }
      client.setPreferredSize(new Dimension(W,H));
      GridLayout cLayout=new GridLayout(1,8);
      cLayout.setHgap(2);
      client.setLayout(cLayout);
      client.add(Box[baselocation]);
      for(int i=0;i<baselocation;++i)
      {
         JPanel panel=new JPanel();
         panel.setPreferredSize(new Dimension(w,H));
         client.add(panel);
         GridLayout pLayout=new GridLayout(2,1);
         pLayout.setVgap(2);
         panel.setLayout(pLayout);
         panel.add(Box[lastlocation-i]);
         panel.add(Box[sidecount+i]);
      }
      client.add(Box[sidecount+baselocation]);
      setMinimumSize(new Dimension(600,200));
      pane.add(client,BorderLayout.CENTER);
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      pack();
      setVisible(true);
   }

   private void BoxActionPerformed(ActionEvent evt)
   {
      int index=map.get(evt.getSource());
      setTitle(""+index);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 542, Short.MAX_VALUE)
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 171, Short.MAX_VALUE)
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new KalahaForm());
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   // End of variables declaration//GEN-END:variables
}
