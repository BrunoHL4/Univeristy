library ieee;
use ieee.std_logic_1164.all;
entity decodificador3e8s is
port 
( S: out std_logic_vector(7 DOWNTO 0);
  E: in std_logic_vector(2 DOWNTO 0));
  
end decodificador3e8s;
architecture rtl of decodificador3e8s is
begin
with E select
 S<="00000001" when "000",
       "00000010" when "001",
	    "00000100" when "010",
	    "00001000" when "011",
	    "00010000" when "100",
	    "00100000" when "101",
	    "01000000" when "110",
	    "10000000" when others;
end rtl;
