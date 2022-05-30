package pl.wit.lab4.p1;

public enum EnPersonType {
    student("student"),
    teacher("nauczyciel");

    private String type;

    private EnPersonType(String type) {
        this.type = type;
    }

    public String getType() {
        return type;
    }
}

