package pl.wit.lab5;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeEach;

public class LambdaTutorialTest {

    LambdaTutorial lambdaTutorial;

    @BeforeEach
    public void SetUp(){
        lambdaTutorial = new LambdaTutorial();
        lambdaTutorial.addNumber(5);
        lambdaTutorial.addNumber(3);
        lambdaTutorial.addNumber(8);
        lambdaTutorial.addNumber(1);
    }

	@Test
	public void isMoreThan10Test() {
        Assertions.assertFalse(lambdaTutorial.isMoreThan10());
	}
	
	@Test
	public void isNotEmptyTest() {
		Assertions.assertTrue(lambdaTutorial.isNotEmpty());
	}

	@Test
	public void firstElementTest() {
	Assertions.assertEquals(5, lambdaTutorial.getFirstElement());
	}
	
	@Test
	public void maxElementTest() {
		Assertions.assertEquals(8,lambdaTutorial.getMaxElement());
	}
}
