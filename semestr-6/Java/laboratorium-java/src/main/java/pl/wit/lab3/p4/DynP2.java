package pl.wit.lab3.p4;

public class DynP2 extends DynP1 {
    public DynP2(String message) {
        super(message);
    }

    @Override
    public void show() {
        System.out.println("DP2:" + getMessage());
    }
}
