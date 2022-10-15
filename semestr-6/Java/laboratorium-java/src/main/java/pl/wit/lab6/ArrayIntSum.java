package pl.wit.lab6;

import java.util.Arrays;
import java.util.concurrent.Callable;

public class ArrayIntSum implements Callable<Integer>{
	private int arr[];
	public ArrayIntSum(int arr[]) {
		this.arr = arr;
		System.out.println(Arrays.toString(arr));
	}
	
	@Override
	public Integer call() throws Exception {
		int sum = Arrays.stream(arr).reduce(0, (a, b) -> a + b);
		return Integer.valueOf(sum);
	}

}
