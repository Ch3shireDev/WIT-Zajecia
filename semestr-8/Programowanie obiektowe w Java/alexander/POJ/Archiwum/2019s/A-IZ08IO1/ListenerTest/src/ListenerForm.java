
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import javax.swing.GroupLayout;

public class ListenerForm extends javax.swing.JFrame
{
   private static int TickCount=5;
   private final TickPanel[] tb;
   public ListenerForm()
   {
      initComponents();
      tb=new TickPanel[TickCount];
      for(int i=0;i<TickCount;++i)
      {
         tb[i]=new TickPanel();
         GroupLayout gl=new javax.swing.GroupLayout(tb[i]);
         tb[i].setLayout(gl);
      }
      new TickTimer().AddTickListener(tb[0]);
      for(int i=1;i<TickCount;++i) tb[i-1].AddTickListener(tb[i]);
      final ComponentAdapter ca=new ComponentAdapter()
      {
         public void componentResized(ComponentEvent componentEvent)
         {
            int w=getWidth();
            int h=getHeight();
            int x=0;
            for(int i=TickCount-1;i>=0;--i)
            {
               int d=(w-x)/(i+1);
               tb[i].setSize(d,h);
               tb[i].setLocation(x,0);
               x+=d;
            }
         }
      };
      addComponentListener(ca);
   }
   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      jButton1 = new javax.swing.JButton();

      jButton1.setText("jButton1");

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 517, Short.MAX_VALUE)
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 224, Short.MAX_VALUE)
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new ListenerForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton jButton1;
   // End of variables declaration//GEN-END:variables
}
