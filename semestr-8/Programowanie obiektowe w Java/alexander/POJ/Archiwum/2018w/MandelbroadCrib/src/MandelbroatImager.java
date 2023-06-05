import java.awt.image.BufferedImage;

public interface MandelbroatImager
{
   public void execute(double tp,double lf,double zoom,BufferedImage img,MandelbroatDone done);
}
