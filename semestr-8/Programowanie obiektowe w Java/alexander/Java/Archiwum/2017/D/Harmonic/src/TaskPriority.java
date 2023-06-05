public enum TaskPriority 
{
   High(0,"Wysoki"),
   Midium(1,"Średni"),
   Low(2,"Niski");
   final int value;
   final String HumanName;
   TaskPriority(int value,String HumanName)
   {
      this.value=value;
      this.HumanName=HumanName;
   }
   public int getValue() { return value; }
   @Override public String toString() { return HumanName; }
}
