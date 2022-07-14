library ieee;

use ieee.std_logic_1164.all;
use ieee.std_logic_unsigned.all;
use ieee.numeric_std.all;

entity Alu2 is
	
	port (
			a, b: in std_logic_vector (7 downto 0);
			selector: in std_logic_vector (2 downto 0);
			resp: out std_logic_vector (7 downto 0);
			c: out std_logic
			);
end Alu2;

architecture arq_Alu2 of Alu2 is
signal tres: std_logic_vector (7 downto 0);
signal tmp: std_logic_vector (8 downto 0);
	
begin
	process (a,b,selector)
	begin 
		case(selector) is
			when "000" => tres <= a + b;
			when "001" => tres <= a - b;
			when "011" => tres <= std_logic_vector(to_unsigned(to_integer(unsigned(a)) * to_integer(unsigned(b)), 8));
			when "010" => tres <= std_logic_vector(to_unsigned(to_integer(unsigned(a)) / to_integer(unsigned(b)), 8));
			when others => tres <= a + b;
		end case;
	end process;
resp <= tres;
tmp <= ('0' & a) + ('0' & b);
c <= tmp(8);

end arq_Alu2;