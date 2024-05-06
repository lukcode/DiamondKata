## Description
### DiamondKata
Implementation of coding test.

### Done:
- [x] Implementation in .Net 8
- [x] TDD approach showed in git commits
- [x] Solution implemented based on following requirement: Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.
- [x] Soulution implemented for single uppercase character from A to Z

### Usage
#### Build
```sh
\DiamondKata>
dotnet build
```
#### Run e.g
```sh
\DiamondKata\bin\Debug\net8.0>
DiamondKata.exe H
```
#### Results
```sh
DiamondKata\bin\Debug\net8.0>DiamondKata.exe H
       A
      B B
     C   C
    D     D
   E       E
  F         F
 G           G
H             H
 G           G
  F         F
   E       E
    D     D
     C   C
      B B
       A
```

```sh
DiamondKata\bin\Debug\net8.0>DiamondKata.exe A2123
Invalid input. Please provide one uppercase character from A to Z.
```