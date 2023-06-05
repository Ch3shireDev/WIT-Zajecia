
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class JPaintBox extends JPanel 
{
    private final BufferedImage image;
    public JPaintBox(BufferedImage image) { this.image=image; }    
    public Graphics getGraphics() { return image.getGraphics(); }
    @Override public void paintComponent(Graphics g) 
    {
        super.paintComponent(g);
        g.drawImage(image,0,0,this);
    }
}
