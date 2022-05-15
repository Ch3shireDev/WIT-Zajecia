package pl.wit.lab4.p1;

public enum EnPersonType {
    student,
    teacher {
        @Override
        public String toString() {
            return "nauczyciel";
        }
    }


}
