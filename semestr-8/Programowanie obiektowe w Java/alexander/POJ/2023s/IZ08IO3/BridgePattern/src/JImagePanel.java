
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;

public class JImagePanel extends JPanel
{
    private Image image;

    @Override protected void paintComponent(Graphics g)
    {
        super.paintComponent(g);
        if(image!=null) g.drawImage(image,0,0,Color.LIGHT_GRAY,this);
    }
    
    public Graphics g()
    {
        image=new BufferedImage(getWidth(),getHeight(),BufferedImage.TYPE_INT_ARGB);        
        return image.getGraphics(); 
    }
}
