library ieee;
use ieee.std_logic_1164.all;
entity xor2e1s is
port(a,b: in std_logic;
       x: out std_logic);
end xor2e1s;

architecture rtl of xor2e1s is 
begin 
x<=a xor b;
end rtl;

