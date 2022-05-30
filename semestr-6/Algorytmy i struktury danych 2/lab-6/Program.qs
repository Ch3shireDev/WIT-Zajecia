namespace Quantum.QSharpApplication {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    
    @EntryPoint()
    operation Main() : Unit {
        //Zad1();
        //Zad2();
        //Zad3();
        let results = Zad4(5);
    }

    operation Zad1(): Unit{
        
        Message("Zad1. (15 pkt) Stworzenie dwóch kubitów, zmierzenie ich oraz zwrócenie dwóch pomiarów.");

        Message("- Tworzenie kubitów.");
        use q1 = Qubit();
        use q2 = Qubit();

        Message("- Przeprowadzanie pomiarów.");
        let result1 = M(q1);
        let result2 = M(q2);

        Message("- Wyniki:");
        Message($"  q1: {q1}, pomiar: {result1}");
        Message($"  q2: {q2}, pomiar: {result2}");
    }

    operation Zad2(): Unit{
        Message("Zad2. (15 pkt) Stworzenie dwóch kubitów, wprowadzenie w superpozycję, zmierzenie, oraz zwrócenie ich pomiarów");

        Message("- Tworzenie kubitów.");
        use q1 = Qubit();
        use q2 = Qubit();

        Message("- Ustawienie początkowego stanu operacją Hadamara. Mamy 50% szans na wynik 0 lub 1.");
        H(q1);
        H(q2);

        Message("- Przeprowadzanie pomiarów.");
        let result1 = M(q1);
        let result2 = M(q2);

        Message("- Wyniki:");
        Message($"  q1: {q1}, pomiar: {result1}");
        Message($"  q2: {q2}, pomiar: {result2}");

		
    }
    operation Zad3(): Unit{
        Message("Zad3. (20 pkt) Stworzenie dwóch kubitów, wprowadzenie jednego w superpozycję, splątanie, zmierzenie oraz zwrócenie pomiarów");
    
        Message("- Tworzenie kubitów.");
        use q1 = Qubit();
        use q2 = Qubit();
        
        Message("- Ustawienie początkowego stanu operacją Hadamara - superpozycja dwóch stanów dla M. Mamy 50% szans na wynik 0 lub 1.");
        H(q1);
        H(q2);

        Message("- Wprowadzanie w splątanie.");
        CNOT(q1, q2);

        Message("- Przeprowadzanie pomiarów.");
        let result1 = M(q1);
        let result2 = M(q2);

        Message("- Wyniki:");
        Message($"  q1: {q1}, pomiar: {result1}");
        Message($"  q2: {q2}, pomiar: {result2}");

    }

    operation Zad4(n:Int): Result[]{
        Message("Zad4. (20 pkt) Stworzenie dowolnej liczby kubitów poprzez podanie wartości, wprowadzenie ich w superpozycję, splątanie ich, zmierzenie oraz zwrócenie pomiarów");

        Message("- Tworzenie kubitów.");
        use qubits = Qubit[n];

        Message("- Ustawienie początkowego stanu operacją Hadamara - superpozycja dwóch stanów dla M. Mamy 50% szans na wynik 0 lub 1.");
        ApplyToEach(H, qubits);
        
        Message("- Wprowadzanie w splątanie.");
        ApplyCNOTChain(qubits);

        Message("- Przeprowadzanie pomiarów."); 
        mutable results = [];
        for qubit in qubits{
            set results += [M(qubit)];
        }

        Message("- Wyniki:");
        for i in 0 .. n-1 {
            Message($"q{i}: {qubits[i]}, pomiar: {results[i]}");
        }

        return results;

    }
}
