library ieee;
use ieee.std_logic_1164.all;
entity sumadorc is
port 
(a, b, c: in std_logic;
sum, carry: out std_logic);
end sumadorc;

architecture rtl of sumadorc is
begin
sum <= (a xor b) xor c;
carry <= (a and b) or (c and (a xor b));
end rtl;
