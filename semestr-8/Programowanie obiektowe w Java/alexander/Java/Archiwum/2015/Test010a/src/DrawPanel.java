import java.awt.*;
import java.awt.geom.*;
import java.awt.font.FontRenderContext;
import javax.swing.JPanel;

class DrawPanel extends JPanel {

    private final int Margin=4;
    FontRenderContext frc;  

    public DrawPanel() {
         setFont(getFont().deriveFont(30.0f));
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        frc = new FontRenderContext(new AffineTransform(),true,true);  
        int Size = Math.min(
                (getWidth() - 5 * Margin) / 4,
                (getHeight() - 5 * Margin) / 4);
        int LfMargin = (getWidth() - 4 * Size - 3 * Margin) / 2;
        int UpMargin = (getHeight() - 4 * Size - 3 * Margin) / 2;
        for(int y=0;y<4;++y) {
            int Up = UpMargin + y * (Size + Margin);
            for(int x=0;x<4;++x) {
                int Lf = LfMargin + x * (Size + Margin);                
                g.setColor(Color.gray);
                g.fillRect(Lf, Up, Size, Size);                
                g.setColor(Color.red);
                g.drawRect(Lf, Up, Size, Size);
                g.setColor(Color.blue);
                String text = ""+(y+1)+"x"+(x+1);
                Rectangle2D sz = g.getFont().getStringBounds(text, frc);
                g.drawString(
                        text, 
                        Lf+(int)((Size-sz.getWidth())/2), 
                        Up+(int)((Size-sz.getHeight())/2-sz.getY()));
            }
        }
    }
}