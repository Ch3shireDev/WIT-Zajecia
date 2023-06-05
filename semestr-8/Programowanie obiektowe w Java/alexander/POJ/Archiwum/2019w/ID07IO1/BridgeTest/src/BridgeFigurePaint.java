
import java.awt.Graphics;
import java.awt.SystemColor;
import javax.swing.JPanel;

public class BridgeFigurePaint extends BridgeFiguresBase
{
    private final JPanel jpaint;
    private final Graphics gr;
    public BridgeFigurePaint(JPanel jpaint)
    {
        this.jpaint=(JPaintBox)jpaint;
        gr=((JPaintBox)jpaint).getGraphics();
    }
    @Override protected void init()
    {
        gr.setColor(SystemColor.control);
        gr.fillRect(0, 0, jpaint.getWidth(), jpaint.getHeight());
    }
    @Override protected void proceed(FigureCollection list)
    {
        for(Figure fig:list) fig.draw(gr);
    }
    @Override protected void finish()
    {
        jpaint.invalidate();
        jpaint.repaint(1, 0, 0, jpaint.getWidth(), jpaint.getHeight());
    }
}
