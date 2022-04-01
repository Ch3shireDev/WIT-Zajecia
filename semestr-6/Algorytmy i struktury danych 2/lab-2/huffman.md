
- `A = 0.15`
- `D = 0.12`
- `E = 0.12`
- `B = 0.11`
- `C = 0.11`
- `F = 0.10`
- `G = 0.10`
- `H = 0.07`
- `I = 0.06`
- `K = 0.06`


```dot
graph base_flow {
  node [shape=circle];
  A [label="A - 0.15"];
  D [label="D - 0.12"];
  E [label="E - 0.12"];
  B [label="B - 0.11"];
  C [label="C - 0.11"];
  F [label="F - 0.10"];
  G [label="G - 0.10"];
  H [label="H - 0.07"];
  I [label="I - 0.06"];
  K [label="K - 0.06"];

IK [label="0.12"];
HG [label="0.17"];
FC [label="0.21"];
BE [label="0.23"];

DIK [label="0.24"];
HGA [label="0.32"];

FCBE [label="0.44"];

DIKHGA [label="0.56"];

FCBEDIKHGA [label="1.00"];

IK -- I [label="0"];
IK -- K [label="1"];

HG -- H [label="0"];
HG -- G [label="1"];

FC -- F [label="0"];
FC -- C [label="1"];

BE -- B [label="0"];
BE -- E [label="1"];

DIK -- D [label="0"];
DIK -- IK [label="1"];

HGA -- A [label="0"];
HGA -- HG [label="1"];

FCBE -- FC [label="0"];
FCBE -- BE [label="1"];

DIKHGA -- DIK [label="0"];
DIKHGA -- HGA [label="1"];

FCBEDIKHGA -- FCBE [label="0"];
FCBEDIKHGA -- DIKHGA [label="1"];


}
```

- `A = 110`
- `B = 010`
- `C = 001`
- `D = 100`
- `E = 011`
- `F = 000`
- `G = 1111`
- `H = 1110`
- `I = 1010`
- `K = 1011`
