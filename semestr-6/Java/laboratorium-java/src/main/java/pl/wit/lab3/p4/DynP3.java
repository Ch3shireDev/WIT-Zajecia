package pl.wit.lab3.p4;

public class DynP3 extends DynP2 {
    public DynP3(String message) {
        super(message);
    }

    @Override
    public void show() {
        System.out.println("DP3:" + getMessage());
    }

    public String getDynP3Name() {
        return "DynP3";
    }
}
