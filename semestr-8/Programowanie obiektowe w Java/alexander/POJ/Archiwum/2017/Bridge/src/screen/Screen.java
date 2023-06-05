package screen;

import core.Circle;
import core.Figure;
import core.Rectangle;
import core.Triangle;
import java.util.HashMap;

public abstract class Screen 
{
   //*///
   private final HashMap<Class, IFigureDraw> map = new HashMap<Class, IFigureDraw>()   
   {
      {
         put(Triangle.class, (Figure fig) -> DrawTriangle((Triangle)fig) );
         put(Rectangle.class, (Figure fig) -> DrawRectangle((Rectangle)fig) );
         put(Circle.class, (Figure fig) -> DrawCircle((Circle)fig) );
      }
   };
   /*/
   private final HashMap<String, IFigureDraw> map = map();
   private HashMap<String,IFigureDraw> map()
   {
      final HashMap<String,IFigureDraw> map=new HashMap<>();
      map.put(Triangle.class.getName(), (Figure fig) -> DrawTriangle((Triangle)fig) );
      map.put(Rectangle.class.getName(), (Figure fig) -> DrawRectangle((Rectangle)fig) );
      map.put(Circle.class.getName(), (Figure fig) -> DrawCircle((Circle)fig) );
      return map;
   }
   //*///
   protected abstract void DrawTriangle(Triangle fig);
   protected abstract void DrawRectangle(Rectangle fig);
   protected abstract void DrawCircle(Circle fig);
   public void Draw(Figure fig) 
   {
      //*///
      map.get(fig.getClass()).Draw(fig);
      /*/
      map.get(fig.getClass().getName()).Draw(fig);
      //*///
   }   
}
