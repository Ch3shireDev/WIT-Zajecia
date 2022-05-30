package pl.wit.lab5;

import java.util.LinkedHashSet;
import java.util.Set;
import java.util.function.Function;
import java.util.function.Predicate;
import java.util.function.Supplier;

public class LambdaTutorial {
private Set<Integer> setNumbers = new LinkedHashSet<Integer>();
	
	public void addNumber(int no) {
		setNumbers.add(no);
	}
	
	public boolean isMoreThan10() {
		Predicate<Set<Integer>> x = a -> a.size() > 10;
		return x.test(setNumbers);
	}
	
	public boolean isNotEmpty() {
		Predicate<Set<Integer>> x = a -> a!=null && a.size() > 0;
		return x.test(setNumbers);
	}
	
	public void printSet() {
		String str =  String.join(",", setNumbers.stream().map(x->x.toString()).toArray(String[]::new));
		System.out.println(str);
	}
	
	public Integer getFirstElement() {
		Supplier<Integer> x = () -> {if(setNumbers==null || setNumbers.size()==0)return null; return setNumbers.stream().toArray(Integer[]::new)[0];};
		return x.get();
	}
	
	public Integer getMaxElement() {
		Function<Set<Integer>, Integer> x = a->a.stream().max(Integer::compare).get();
		return x.apply(setNumbers);
	}
}
