
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class DrawPanel extends JPanel
{
    private Image image=new BufferedImage(1, 1, BufferedImage.TYPE_INT_ARGB);

    @Override public void paint(Graphics g)
    {
        super.paint(g);
        g.drawImage(image, 0, 0, Color.LIGHT_GRAY, this);
    }
    
    @Override public void setSize(Dimension d)
    {
        image=new BufferedImage(d.width, d.height, BufferedImage.TYPE_INT_ARGB);
        super.setSize(d);
    }
    
    public Graphics getGraphics() { return image.getGraphics(); }
}
