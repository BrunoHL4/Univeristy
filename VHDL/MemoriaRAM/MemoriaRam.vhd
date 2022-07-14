library ieee;
use ieee.std_logic_unsigned.all;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity MemoriaRam is
port (	clk, WR: in std_logic;
			Address: in std_logic_vector (3 downto 0);
			Data_in: in std_logic_vector (7 downto 0);
			Data_out:	out std_logic_vector (7 downto 0));
end MemoriaRam;

architecture arq_MemoriaRam of MemoriaRam is

type ram_type is array (15 downto 0) of std_logic_vector (7 downto 0);
signal myRam: ram_type;

begin

process (clk)
begin
	if (clk'event and clk = '1') then
		if (WR = '1') then
			myRam(conv_integer(Address)) <= Data_in;
		else
			Data_out <= myRam(conv_integer(Address));
		end if;
	end if;
end process;

end arq_MemoriaRam;