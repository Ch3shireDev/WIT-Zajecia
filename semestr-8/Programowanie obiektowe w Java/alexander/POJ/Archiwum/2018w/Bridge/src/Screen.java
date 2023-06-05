public abstract class Screen
{
   public void Draw(FigureList list)
   {
      Clear();
      Figure last=null;
      for(Figure fig:list.getData())
      {
         last=fig;
         Draw(fig);
      }
      if(last!=null) Select(last);
   }
   public abstract void Clear();
   public abstract void Draw(Figure fig);
   public abstract void Select(Figure fig);
}
