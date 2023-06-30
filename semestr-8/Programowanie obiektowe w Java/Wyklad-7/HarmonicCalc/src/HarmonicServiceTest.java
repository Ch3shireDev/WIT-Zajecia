import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class HarmonicServiceTest {

    HarmonicService service;

    @org.junit.jupiter.api.BeforeEach
    void setUp() {
        service = new HarmonicService();
    }

    @org.junit.jupiter.api.Test
    void simpleCalc() {
        var number = 1;

        var result = service.SimpleCalc(number);

        assertEquals(1.0, result);
    }

    @org.junit.jupiter.api.Test
    void otherSimpleCalc() {
        var number = 2;

        var result = service.SimpleCalc(number);

        assertEquals(1.5, result);
    }

    @org.junit.jupiter.api.Test
    void twoThreadsTest() {
        var threads = 2;

        var part1 = service.ThreadCalc(4, threads, 0);
        var part2 = service.ThreadCalc(4, threads, 1);
        var result = part1 + part2;

        assertEquals(1.333, part1, 0.001);
        assertEquals(0.75, part2);

        assertEquals(2.083, result, 0.001);
    }

    @Test
    void oneThreadTest() {
        var count = 4;

        var result = service.SimpleCalc(count);

        assertEquals(2.083, result, 0.001);
    }

    @Test
    void getResultMultithreadedTest(){

        var result1 = service.SimpleCalc(1000);
        var result2 = service.getSumMultithreaded(1000);

        assertEquals(result1, result2);
    }
}