
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class JDrawPanel extends JPanel
{
    private Image image=new BufferedImage(1,1,BufferedImage.TYPE_INT_ARGB);
    public JDrawPanel()
    {
        ComponentAdapter adapter=new ComponentAdapter()
        {
            @Override public void componentResized(ComponentEvent e)
            {
                image=new BufferedImage(getWidth(),getHeight(),BufferedImage.TYPE_INT_RGB);
            }
        };
        addComponentListener(adapter);
    }
    
    @Override protected void paintComponent(Graphics g)
    {
        super.paintComponent(g);
        g.drawImage(image,0,0,this);
    }
    
    public Graphics g() { return image.getGraphics(); }
}
