package pl.wit.lab6;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class CollectionsTutorial {
    private Collection<String> collection = null;

    public CollectionsTutorial() {
        this.collection = new ArrayList<String>();

        for (int i = 0; i < 100000; i++) {
            collection.add("item_" + ((i + 1) % 10000));
        }
    }

    public Set<String> getSetWithOrderWithNoLessThan100() {
        return collection.stream().filter(x -> isLowerOrEqualThan(x, 100)).collect(Collectors.toCollection(HashSet<String>::new));
    }

    boolean isLowerOrEqualThan(String element, int number) {
        try {
            int value = getNumber(element);
            return value <= number;
        }
        catch (Exception e) {
            return false;
        }
    }

    public Set<String> getSet() {
        Set<String> set = new HashSet<String>(10000);
        set.addAll(collection);
        return set;
    }

    public List<String> getOnlyEvenItems() {
        return collection.stream().filter(x -> isEven(x)).collect(Collectors.toCollection(ArrayList<String>::new));
    }

    Boolean isEven(String element) {
        try {
            return getNumber(element) % 2 == 0;
        }
        catch (Exception e) {
            return false;
        }
    }

    int getNumber(String element) throws Exception {


        Pattern p = Pattern.compile("item_(\\d+)");
        Matcher m = p.matcher(element);
        if (!m.matches()) throw new Exception(String.format("Wyrażenie %s nie ma postaci 'item_(cyfry)'", element));
        String numberStr = m.group(1);
        int number = Integer.parseInt(numberStr);
        return number;
    }

    public LinkedHashSet<String> getSetWithOrder() {
        return new LinkedHashSet<String>(collection);
    }

    public TreeSet<String> getEvery3ElementAsSortedSet() {
        String[] array = collection.toArray(new String[0]);
        Collection<String> c2 = IntStream
                .range(0, collection.size())
                .filter(n -> n % 3 == 0)
                .mapToObj(i -> array[i])
                .collect(Collectors.toCollection(ArrayList<String>::new));
        return new TreeSet<>(c2);

    }
}
