library ieee;
use ieee.std_logic_1164.all;
 
entity mul4e1s is
 port(A,B,C,D : in std_logic;
     S0,S1: in std_logic;
     Z: out std_logic);
end mul4e1s;
 
architecture rtl of mul4e1s is
begin
process (A,B,C,D,S0,S1) is
begin
  if (S0 ='0' and S1 = '0') then
      Z <= A;
  elsif (S0 ='1' and S1 = '0') then
      Z <= B;
  elsif (S0 ='0' and S1 = '1') then
      Z <= C;
  else
      Z <= D;
  end if;
 
end process;
end rtl;