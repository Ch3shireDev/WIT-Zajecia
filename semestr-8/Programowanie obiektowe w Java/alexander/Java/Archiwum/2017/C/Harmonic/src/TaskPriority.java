public enum TaskPriority 
{
   High(0,"Wysoki"),
   Medium(1,"Średni"),
   Low(2,"Niski");

   public int getValue() { return value; }
   int value;
   String ForHuman;
   TaskPriority(int value,String ForHuman) 
   {
      this.value=value; 
      this.ForHuman=ForHuman;
   }
   @Override public String toString() { return ForHuman; }   
}
