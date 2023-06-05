
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class DrawPanel extends JPanel 
{
    private final BufferedImage image;
    public DrawPanel(BufferedImage image) { this.image=image; }    
    public BufferedImage getImage() { return image; }
    @Override public void paintComponent(Graphics g) 
    {
        super.paintComponent(g);
        g.drawImage(image,0,0,this);
    }
}
