library ieee;
use ieee.std_logic_1164.all;
entity norex2e1s is
port
	(a,b:in std_logic;
		F: out std_logic);
end norex2e1s;

architecture rtl of norex2e1s is
begin
F <= a xnor b;
end rtl;