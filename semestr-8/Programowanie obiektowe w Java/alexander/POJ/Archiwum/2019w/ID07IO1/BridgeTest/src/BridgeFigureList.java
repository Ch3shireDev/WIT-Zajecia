
import javax.swing.DefaultListModel;
import javax.swing.JList;

public class BridgeFigureList extends BridgeFiguresBase
{
    private final JList<Figure> jlist;
    private final DefaultListModel<Figure> model;
    public BridgeFigureList(JList<Figure> jlist)
    {
        this.jlist=jlist;
        this.model=(DefaultListModel<Figure>)jlist.getModel();
    }
    @Override protected void init()
    {
        model.clear();
    }
    @Override protected void proceed(FigureCollection list)
    {
        for(Figure fig:list) model.addElement(fig);
    }
    @Override protected void finish()
    {
        jlist.setSelectedIndex(model.size()-1);
    }
}
