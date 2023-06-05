package test005;
import java.util.Scanner;

public class Test005
{
    static Scanner sc=new Scanner(System.in);
    public static void main(String[] args)
    {
        String line;
        long[] tb=new long[26];
        while(!(line=sc.nextLine().toUpperCase()).equals("..."))
        {
            for(int i=0;i<line.length();++i)
            {
                int pos=line.charAt(i)-'A';
                if((0<=pos)&&(pos<26)) ++tb[pos];
            }
        }
        for(int i=0;i<tb.length;++i) if(tb[i]!=0) System.out.println(((char)('A'+i))+" - "+tb[i]);
    }
}
