// Klasa zasobów.
class Resource {

    public assignedProcesses: Process[] = [];
    public awaitingProcesses: Process[] = [];

    public constructor(
        // Nazwa zasobu.
        public name: string,
        // Liczba egzemplarzy zasobów.
        public count: number
    ) {

    }
}

// Klasa procesu.
class Process {

    // Potrzebne zasoby.
    public awaitingResources: Resource[] = [];
    public assignedResources: Resource[] = [];

    public constructor(
        // Nazwa procesu.
        public name: string
    ) {

    }

    // public init(resources: Resource[]) {
    //     this.requiredResources.forEach(rr => {
    //         let resource: Resource = resources.find(r => r.name == rr.resourceName) as Resource;
    //         for (let i = 0; i < rr.resourceCount; i++) {
    //             this.awaitingResources.push(resource);
    //         }
    //     });
    // }

    public showResources() {
        console.log(`Assigned resources: ${this.assignedResources.map(r => r.name).join(', ')}`);
        console.log(`Awaiting resources: ${this.awaitingResources.map(r => r.name).join(', ')}`);
    }

    get lockedProcesses(): Process[] {
        let p = this.assignedResources.map(r => r.awaitingProcesses).flat().filter(p => p != this);
        let p1 = new Set(p);
        let p2 = new Array(...p1);
        return p2;
    }

    public showName() {
        console.log(`Process: ${this.name}`);
    }

    public showLockedProcesses() {
        console.log(`Locked processes: ${this.lockedProcesses.map(p => p.name).join(", ")}`);
    }


}

// Klasa systemu operacyjnego, zawiera w sobie listy zasobów i procesów.
class OperatingSystem {
    public processes: Process[] = [];
    public resources: Resource[] = [];

    // Zwraca zasób o podanej nazwie lub undefined.
    public getResource(resourceName: string): Resource {
        return this.resources.find(r => r.name == resourceName) as Resource;
    }

    // Zwraca proces o podanej nazwie. Jeśli proces nie istnieje, tworzy nowy.
    public getProcess(processName: string): Process {
        let process = this.processes.find(p => p.name == processName) as Process;
        if (process === undefined) {
            process = new Process(processName);
            this.processes.push(process);
        }
        return process;
    }


    public allocate(resourceName: string, resourceCount: number): void {
        this.resources.push(new Resource(resourceName, resourceCount));
    }

    // Dodaje informację o oczekiwaniu przez proces na zasób w danej liczbie.
    public await(processName: string, resourceName: string, numberOfCopies = 1) {
        if (numberOfCopies < 1) return;
        let process = this.getProcess(processName);
        let resource = this.getResource(resourceName);
        for (let i = 0; i < numberOfCopies; i++) {
            process.awaitingResources.push(resource);
            resource.awaitingProcesses.push(process);
        }
    }

    // Przypisuje zasób do danego procesu w danej liczbie.
    public assign(resourceName: string, processName: string, numberOfCopies = 1) {
        if (numberOfCopies < 1) return;
        let resource = this.getResource(resourceName);
        let process = this.getProcess(processName);
        for (let i = 0; i < numberOfCopies; i++) {

            // Przypisuje zasób do procesu oraz usuwa zasób z listy oczekujących zasobów.
            process.assignedResources.push(resource);
            let rIndex = this.resources.indexOf(resource);
            if (rIndex != -1) {
                process.awaitingResources.splice(rIndex, 1);
            }

            // Przypisuje proces do zasobu i usuwa proces z listy oczekujących na zasób.
            resource.assignedProcesses.push(process);
            let pIndex = this.processes.indexOf(process);
            if (pIndex != -1) {
                resource.awaitingProcesses.splice(pIndex, 1);
            }

        }
    }

    // Funkcja zwracająca zasoby na które oczekuje proces p1, a które przetrzymuje proces p2.
    public findLockedResources(p1: string, p2: string) {
        let z1 = this.getProcess(p1).awaitingResources.map(z => z.name);
        let z2 = this.getProcess(p2).assignedResources.map(z => z.name);
        return z1.filter(z => z2.includes(z));
    }

    // Funkcja znajdująca blokady w systemie.
    public detectDeadlock(): string {

        let graph: Map<string, string[]> = new Map<string, string[]>();

        this.processes.forEach(p1 => {
            p1.lockedProcesses.forEach(p2 => {
                if (graph.has(p1.name)) {
                    let tab = graph.get(p1.name);
                    if (tab !== undefined) {
                        tab.push(p2.name);
                        graph.set(p1.name, tab);
                    }
                }
                else {
                    graph.set(p1.name, [p2.name]);
                }
            }
            );
        });

        let result: string[] = [];
        this.processes.forEach(p1 => {
            result = this.dfs(p1.name, p1.name, graph, []);
            if (result.length > 0) return;
        });

        let result2: string[] = [];

        for (let i = 0; i < result.length; i++) {
            let p1 = result[i];
            let p2 = result[(i + 1) % result.length];
            let r = this.findLockedResources(p1, p2)[0];
            result2.push(...[p1, r]);
        }

        return result2.join(" -> ");
    }

    // Pokazuje stan blokady.
    public showDeadlock(): void {
        let deadlock = os.detectDeadlock();
        if (deadlock === "") {
            console.log("No deadlock found!");
        }
        else {
            console.log(deadlock);
        }
    }

    // Depth first search - z węzła v1 poszukiwana jest droga do węzła v2 na grafie graph, z listą odwiedzonych węzłów visited.
    dfs(v1: string, v2: string, graph: Map<string, string[]>, visited: string[]): string[] {

        let vertices = graph.get(v1);

        if (vertices === undefined) return [];

        if (vertices.includes(v2)) {
            return [v1, v2];
        }

        let result: string[] = [];
        vertices.forEach(v => {
            if (result.length > 0) return;
            if (!graph.has(v) || visited.includes(v)) return;
            result = this.dfs(v, v2, graph, visited.concat([v]));
            if (result.length > 0) {
                result = [v1].concat(result);
            }
        });

        return result;
    }


}

// Tworzę nowy system operacyjny, tj. środowisko w którym działają procesy i są przechowywane zasoby.
let os = new OperatingSystem();

// Stworzenie zasobów w liczbie kopii.
os.allocate("Z1", 3);
os.allocate("Z2", 3);

// Tworzenie procesów razem z żądaniem zasobów.
os.await("P1", "Z1");
os.await("P2", "Z1");
os.await("P3", "Z1");
os.await("P1", "Z2", 2);
os.await("P2", "Z2");
os.await("P3", "Z2", 2);
os.await("P4", "Z2", 2);


// Tutaj pokazuję P1 wraz z żądanymi i przypisanymi zasobami.
os.getProcess("P1").showName();
os.getProcess("P1").showResources();

// Tutaj pokazuję potencjalny stan blokady.
os.showDeadlock();

// Przydzielanie zasobów do procesów.
os.assign("Z1", "P1");
os.assign("Z1", "P2");
os.assign("Z1", "P3");
os.assign("Z2", "P1");
os.assign("Z2", "P3");
os.assign("Z2", "P4");

// Pokazuję P1 wraz z żądanymi i przypisanymi zasobami.
os.getProcess("P1").showName();
os.getProcess("P1").showResources();

// Pokazuję P1 wraz z zablokowanymi przezeń procesami (przez trzymanie zasobów).
os.getProcess("P1").showName();
os.getProcess("P1").showLockedProcesses();

// Pokazuję stan blokady.
os.showDeadlock();