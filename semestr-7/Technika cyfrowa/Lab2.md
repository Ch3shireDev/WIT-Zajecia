# 1. Zaprojektować 27-bitowy licznik binarny z kasowaniem asynchronicznym.
( zastosować sygnał zegarowy z płytki testowej, osiem najbardziej znaczących
bitów licznika wyprowadzić na diody LED )

TeC_IZ_wyk3_cz2_VHDL_[41F]_BW.pdf - strona 33

*CNT_modb27.vhd*
```
library ieee;
use ieee.std_logic_1164.all;
use ieee.std_logic_unsigned.all;

entity CNT_modb27 is
  port ( R, C : in std_logic;
			Q : inout std_logic_vector(26 downto 0)
			);
  end CNT_modb27 ;

architecture Bech of CNT_modb27 is
begin

  process( C, R, Q )
  begin
    if R = '0' then Q <= (others => '0'); -- KASOWANIE ASYNCHRONICZNE
    elsif rising_edge(C) then Q <= Q + 1;
    end if;
  end process;
  
end Bech;
```

*porty.ucf* dla płytki **Nexys 3**
```
NET "R" LOC="T5";
NET "C" LOC="V10";

NET "Q[26]" LOC="T11";
NET "Q[25]" LOC="R11";
NET "Q[24]" LOC="N11";
NET "Q[23]" LOC="M11";
NET "Q[22]" LOC="V15";
NET "Q[21]" LOC="U15";
NET "Q[20]" LOC="V16";
NET "Q[19]" LOC="U16";
```
# 2. Zaprojektować 8-bitowy licznik Johnsona.
( jako dzielnik częstotliwości sygnału zegarowego zastosować N-bitowy licznik
binarny, dobrać N )


TeC_IZ_wyk3_cz2_VHDL_[41F]_BW.pdf - strona 8 (signal - sygnały wewnątrz architektury)
TeC_IZ_wyk4_cz1_Projekty_[21F]_BW.pdf - strona 7 (licznik Johnsona)

*CNT_modb27J.vhd*
```
library ieee;
use ieee.std_logic_1164.all;
use ieee.std_logic_unsigned.all;

entity CNT_modb27J is
  port ( R, C : in std_logic;
			J : inout std_logic_vector(7 downto 0)
			);
  end CNT_modb27J ;

architecture Bech of CNT_modb27J is
  signal Q : std_logic_vector( 26 downto 0 );
begin

  process( C, R )
  begin
    if R = '0' then Q <= (others => '0'); -- KASOWANIE ASYNCHRONICZNE
    elsif rising_edge(C) then Q <= Q + 1;
    end if;
  end process;
  
  process(Q, J)
  begin
	 if rising_edge(Q(22)) then
	   J <= J(6 downto 0) & ( not J(7));
	 end if;
  end process;

end Bech;
```

*porty.ucf* dla płytki **Nexys 3**
```
NET "R" LOC="T5";
NET "C" LOC="V10";

NET "J[7]" LOC="T11";
NET "J[6]" LOC="R11";
NET "J[5]" LOC="N11";
NET "J[4]" LOC="M11";
NET "J[3]" LOC="V15";
NET "J[2]" LOC="U15";
NET "J[1]" LOC="V16";
NET "J[0]" LOC="U16";
```

# 3. Zaprojektować 8-bitowy licznik pierścieniowy typu „krążąca jedynka” .
( zastosować dzielnik częstotliwości... )

Trzeba odpoowiednio zmodyfikować linię 
```J <= J(6 downto 0) & ( not J(7));```
z poprzedniego projektu.
```not J(7)``` zastąpić NAND lub XOR całego J.
Na początku pliku dodać:
use ieee.std_logic_misc.all;
a wyżej wspomniana linijkę:
J <= J(6 downto 0) & ( not or_reduce(J));


# 4. Zmodyfikować punkt 3) tak, aby za pomocą suwaka wybierać pomiędzy
„krążącą jedynką” a „krążącym zerem”
