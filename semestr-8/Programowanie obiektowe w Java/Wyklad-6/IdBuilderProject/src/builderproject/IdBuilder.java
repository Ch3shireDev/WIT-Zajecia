package builderproject;

import java.util.HashSet;

public class IdBuilder {
    private HashSet<Long> ids = new HashSet<Long>();
    private String delimeter = ", ";
    private String emptyString = "";

    public IdBuilder append(long id) {
        ids.add(id);
        return this;
    }

    public IdBuilder remove(long id) {
        ids.remove(id);
        return this;
    }

    public IdBuilder clear() {
        ids.clear();
        return this;
    }

    public IdBuilder setDelimeter(String delimeter) {
        this.delimeter = delimeter;
        return this;
    }

    public IdBuilder setEmptyString(String emptyString) {
        this.emptyString = emptyString;
        return this;
    }

    public String build() {

        if (ids.isEmpty()) {
            return emptyString;
        }

        // String.join(delimeter, ids.stream().map(Object::toString).toArray(String[]::new));


        StringBuilder sb = new StringBuilder();
        for (long id : ids) {
            sb.append(id).append(delimeter);
        }
        sb.delete(sb.length() - delimeter.length(), sb.length());
        return sb.toString();
    }

}
