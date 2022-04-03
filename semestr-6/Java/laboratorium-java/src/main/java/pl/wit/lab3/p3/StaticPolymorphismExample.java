package pl.wit.lab3.p3;
/**
 * Klasa przykładowa dla polimorfizmu statycznego
 * @author Łukasz
 *
 */
public class StaticPolymorphismExample {
	public void print(String msg) {
		System.out.println(msg);
	}
	
	public void print(int i) {
		System.out.println("i="+i);
	}
	
	public void print(Integer i) {
		System.out.println("i="+i.toString());
	}
	
	public void print(double d) {
		System.out.println("d="+d);
	}
	
	public void print(Double d) {
		System.out.println("d="+d.toString());
	}
}
