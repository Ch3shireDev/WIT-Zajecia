
import java.awt.image.BufferedImage;


public class MandelbrottFragment
{
	public static BufferedImage makeImage(MandelbrottTheme theme,int width,int height,double Si,double Sr,double scale)
	{
		int[][][] colors=new int[height][width][];
		for(int h=0;h<height;++h)
		{
			double Pi=Si-h*scale;
			for(int w=0;w<width;++w)
			{
				double Pr=Sr+w*scale;
				colors[h][w]=MandelbrottCalc.Calc(theme,Pi,Pr);
			}
		}
		return ImageHelper.toImage(colors);
	}	
}
