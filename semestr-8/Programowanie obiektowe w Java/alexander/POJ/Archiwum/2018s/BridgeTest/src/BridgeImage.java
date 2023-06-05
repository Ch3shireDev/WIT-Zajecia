import java.awt.Color;
import java.awt.Graphics2D;
import java.awt.image.BufferedImage;
import java.util.HashMap;

public class BridgeImage extends Bridge
{
   private ImagePaintBox ib;
   public BridgeImage(ImagePaintBox ib)
   {
      this.ib=ib;
   }      
   @Override protected void init() 
   {
      final BufferedImage img=ib.getImage();
      final Graphics2D gr=img.createGraphics();
      gr.setBackground(Color.white);
      gr.clearRect(0, 0, img.getWidth(), img.getHeight());
   }
   static final HashMap<Class,Painter> drawer = new HashMap<Class,Painter>()
   {
      private final Painter drawRectangle=new Painter()
      {
         @Override public void paint(Figure fig,Graphics2D gr)
         {
            FigRectangle f=(FigRectangle)fig;
            gr.setColor(Color.red);
            gr.drawRect(f.getX(), f.getY(), f.getWidth(), f.getHeight());
         }
      };
      private final Painter drawTriangle=new Painter()
      {
         @Override public void paint(Figure fig,Graphics2D gr)
         {
            FigTriangle f=(FigTriangle)fig;
            gr.setColor(Color.green);
            gr.drawPolyline(new int[] { f.getX1(),f.getX2(),f.getX3(),f.getX1() }, new int[] { f.getY1(),f.getY2(),f.getY3(),f.getY1() }, 4);
         }
      };
      private final Painter drawCircle=new Painter()
      {
         @Override public void paint(Figure fig,Graphics2D gr)
         {
            FigCircle f=(FigCircle)fig;
            gr.setColor(Color.blue);
            gr.drawOval(f.getX(), f.getY(), f.getWidth(), f.getHeight());
         }
      };
      {
         put(FigRectangle.class,drawRectangle);
         put(FigTriangle.class,drawTriangle);
         put(FigCircle.class,drawCircle);
      }
   };
   @Override protected void draw(Figure fig) 
   {
      final BufferedImage img=ib.getImage();
      final Graphics2D gr=img.createGraphics();
      drawer.get(fig.getClass()).paint(fig,gr);
   }
   @Override protected void done() 
   {
      ib.invalidate();
      ib.repaint();
   }   
}

interface Painter
{
   void paint(Figure fig,Graphics2D gr);
}