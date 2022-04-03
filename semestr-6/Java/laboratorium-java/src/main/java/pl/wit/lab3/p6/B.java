package pl.wit.lab3.p6;

/**
 * Przykładowa klasa pochodna
 * @author Łukasz
 *
 */
public class B extends A {
	public int y;
	public B(int x, int y) {
		super(x);
		this.y=y;
	}
	
	public void show() {
		System.out.println("SHOW B");
	}
}
