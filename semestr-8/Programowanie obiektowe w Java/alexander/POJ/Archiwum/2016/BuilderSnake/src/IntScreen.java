public interface IntScreen extends Runnable
{
   public void setSize(int Widht,int Height);
   public void setScore(int Score);
   public void displayBody(int x,int y);
   public void displayFruit(int x,int y);
   public void displayEmpty(int x,int y);
}
