library ieee;

use ieee.std_logic_1164.all;
use ieee.numeric_std.all;
use ieee.std_logic_unsigned.all;

entity MemoriaRamTB is
end MemoriaRamTB;

architecture arq_MemoriaRamTB of MemoriaRamTB is
	component MemoriaRam
	port (	clk, WR: in std_logic;
			Address: in std_logic_vector (3 downto 0);
			Data_in: in std_logic_vector (7 downto 0);
			Data_out:	out std_logic_vector (7 downto 0));
end component;

-- Inputs
signal clk : std_logic := '0';
signal WR : std_logic := '0';
signal Address : std_logic_vector(3 downto 0) := (others => '0');
signal Data_in : std_logic_vector(7 downto 0) := (others => '0');

-- Outputs
signal Data_out : std_logic_vector(7 downto 0);

-- Clock period definitions
constant clk_period : time := 10 ns;

begin

-- Instantiate the Unit Under Test (UUT)
	uut : 	MemoriaRam port map (
			clk => clk,
			WR => WR,
			Address => Address,
			Data_in => Data_in,
			Data_out => Data_out
			);
			
-- Clock process definitions
	clk_process : process
	begin
		clk <= '0';
		wait for clk_period/2;
		clk <= '1';
		wait for clk_period/2;
	end process;
	
-- Stimulus process
	stim_proc : process
	begin
		-- hold reset state for 100 ns
		wait for 100 ns;
				
		-- insert stimulus here
		
		WR <= '1';
		Address <= "1001";
		Data_in <= "11110000";
		
		wait for clk_period;
		
		WR <= '1';
		Address <= "0110";
		Data_in <= "00001111";
		
		WR <= '0';
		Address <= "1001";
		
		wait for clk_period*3;
		
		WR <= '0';
		Address <= "0110";
		
		wait for clk_period*3;
		
		WR <= '0';
		Address <= "1111";
		
		wait for clk_period*3;
		
		wait;
	end process;
end;