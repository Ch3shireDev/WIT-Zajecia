package shapecalc;

import javax.swing.event.DocumentListener;

public abstract class FieldListener implements DocumentListener
{
    private int index;
    FieldListener(int index) { this.index=index; }
    public int getIndex() { return index; }    
}
