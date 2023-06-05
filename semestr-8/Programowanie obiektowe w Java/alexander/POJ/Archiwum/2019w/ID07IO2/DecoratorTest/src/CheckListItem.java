class CheckListItem 
{
    private String label;
    private boolean isSelected=false;
    public CheckListItem(String label) { this.label=label; }
    public boolean isSelected() { return isSelected; }
    public void setSelected(boolean isSelected) { this.isSelected = isSelected; }
    @Override public String toString() { return label; }
}