library ieee;
use ieee.std_logic_1164.all;
entity FuncionBooleana is
port 
(A, B, C: in std_logic; F: out std_logic);
end FuncionBooleana;
architecture rtl of FuncionBooleana is
begin
F <= (not A AND not B) OR (not B AND C) OR (A AND not C);
end rtl;
