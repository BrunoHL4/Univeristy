library ieee;
use ieee.std_logic_1164.all;
use ieee.std_logic_unsigned.all;
 
entity rom512_28b is
    port (
        clk  : in  std_logic;
        en   : in  std_logic;
        addr : in  std_logic_vector(8 downto 0);
        data : out std_logic_vector(27 downto 0)
    );
end rom512_28b;
 
architecture behavioral of rom512_28b is
    type memoria_rom is array (0 to 299) of std_logic_vector (27 downto 0);
    signal ROM : memoria_rom := (
        x"b2d05df", x"59682ef", x"3b9ac9f", x"2cb4177", x"23c345f", x"1dcd64f", x"198b7b1", x"165a0bb", -- Fila con datos 0 a 7
        x"13de434", x"11e1a2f", x"10417ce", x"0ee6b27", x"0dc1424", x"0cc5bd8", x"0bebc1f", x"0b2d05d", -- Fila con datos 8 a 15
        x"0a84ba3", x"09ef21a", x"0969484", x"08f0d17", x"0883d3a", x"0820be6", x"07c646d", x"0773593", -- Fila con datos 16 a 23
        x"07270df", x"06e0a11", x"069f6bb", x"0662dec", x"062a7ec", x"05f5e0f", x"05c4a82", x"059682e", -- Fila con datos 24 a 31
        x"056b299", x"05425d1", x"051be56", x"04f790c", x"04d532f", x"04b4a42", x"0495c0b", x"047868b", -- Fila con datos 32 a 39
        x"045c7f2", x"0441e9d", x"0428910", x"04105f3", x"03f940a", x"03e3236", x"03cdf71", x"03b9ac9", -- Fila con datos 40 a 47
        x"03a6362", x"039386f", x"0381936", x"0370508", x"035fb47", x"034fb5d", x"03404c2", x"03316f5", -- Fila con datos 48 a 55
        x"0323181", x"03153f6", x"0307ded", x"02faf07", x"02ee6e9", x"02e2541", x"02d69bd", x"02cb416", -- Fila con datos 56 a 63
        x"02c0406", x"02b594c", x"02ab3aa", x"02a12e8", x"02976ce", x"028df2a", x"0284bcc", x"027bc86", -- Fila con datos 64 a 71
        x"027312c", x"026a997", x"026259f", x"025a520", x"02527f8", x"024ae05", x"0243729", x"023c345", -- Fila con datos 72 a 79
        x"023523e", x"022e3f8", x"022785b", x"0220f4e", x"021a8b9", x"0214488", x"020e2a3", x"02082f9", -- Fila con datos 80 a 87
        x"0202575", x"01fca04", x"01f7097", x"01f191a", x"01ec380", x"01e6fb8", x"01e1db3", x"01dcd64", -- Fila con datos 88 a 95
        x"01d7ebd", x"01d31b0", x"01ce632", x"01c9c37", x"01c53b3", x"01c0c9a", x"01bc6e3", x"01b8284", -- Fila con datos 96 a 103
        x"01b3f71", x"01afda3", x"01abd0f", x"01a7dae", x"01a3f76", x"01a0260", x"019c664", x"0198b7a", -- Fila con datos 104 a 111
        x"019519b", x"01918c0", x"018e0e2", x"018a9fa", x"0187403", x"0183ef6", x"0180acd", x"017d783", -- Fila con datos 112 a 119
        x"017a512", x"0177374", x"01742a5", x"01712a0", x"016e35f", x"016b4de", x"0168719", x"0165a0b", -- Fila con datos 120 a 127
        x"0162daf", x"0160203", x"015d701", x"015aca6", x"01582ed", x"01559d5", x"0153158", x"0150973", -- Fila con datos 128 a 135
        x"014e224", x"014bb67", x"0149538", x"0146f95", x"0144a7a", x"01425e6", x"01401d4", x"013de42", -- Fila con datos 136 a 143
        x"013bb2e", x"0139896", x"0137675", x"01354cb", x"0133394", x"01312cf", x"012f279", x"012d290", -- Fila con datos 144 a 151
        x"012b311", x"01293fb", x"012754c", x"0125702", x"012391b", x"0121b94", x"011fe6c", x"011e1a2", -- Fila con datos 152 a 159
        x"011c533", x"011a91e", x"0118d62", x"01171fc", x"01156eb", x"0113c2d", x"01121c1", x"01107a6", -- Fila con datos 160 a 167
        x"010edda", x"010d45c", x"010bb2a", x"010a243", x"01089a6", x"0107151", x"0105944", x"010417c", -- Fila con datos 168 a 175
        x"01029f9", x"01012ba", x"00ffbbd", x"00fe502", x"00fce87", x"00fb84b", x"00fa24d", x"00f8c8d", -- Fila con datos 176 a 183
        x"00f7709", x"00f61c0", x"00f4cb1", x"00f37db", x"00f233e", x"00f0ed9", x"00efaaa", x"00ee6b1", -- Fila con datos 184 a 191
        x"00ed2ee", x"00ebf5e", x"00eac01", x"00e98d8", x"00e85e0", x"00e7319", x"00e6082", x"00e4e1b", -- Fila con datos 192 a 199
        x"00e3be3", x"00e29d9", x"00e17fc", x"00e064d", x"00df4c9", x"00de371", x"00dd244", x"00dc141", -- Fila con datos 200 a 207
        x"00db068", x"00d9fb8", x"00d8f31", x"00d7ed1", x"00d6e99", x"00d5e87", x"00d4e9c", x"00d3ed7", -- Fila con datos 208 a 215
        x"00d2f36", x"00d1fbb", x"00d1063", x"00d0130", x"00cf21f", x"00ce332", x"00cd466", x"00cc5bd", -- Fila con datos 216 a 223
        x"00cb734", x"00ca8cd", x"00c9a86", x"00c8c5f", x"00c7e58", x"00c7070", x"00c62a7", x"00c54fd", -- Fila con datos 224 a 231
        x"00c4770", x"00c3a01", x"00c2caf", x"00c1f7b", x"00c1262", x"00c0566", x"00bf886", x"00bebc1", -- Fila con datos 232 a 239
        x"00bdf17", x"00bd288", x"00bc614", x"00bb9ba", x"00bad79", x"00ba152", x"00b9544", x"00b894f", -- Fila con datos 240 a 247
        x"00b7d73", x"00b71af", x"00b6603", x"00b5a6f", x"00b4ef2", x"00b438c", x"00b383d", x"00b2d05", -- Fila con datos 248 a 255
        x"00b21e3", x"00b16d7", x"00b0be1", x"00b0101", x"00af636", x"00aeb80", x"00ae0df", x"00ad652", -- Fila con datos 256 a 263
        x"00acbda", x"00ac176", x"00ab726", x"00aacea", x"00aa2c1", x"00a98ab", x"00a8ea9", x"00a84b9", -- Fila con datos 264 a 271
        x"00a7adc", x"00a7112", x"00a6759", x"00a5db3", x"00a541e", x"00a4a9b", x"00a412a", x"00a37ca", -- Fila con datos 272 a 279
        x"00a2e7b", x"00a253d", x"00a1c0f", x"00a12f2", x"00a09e6", x"00a00e9", x"009f7fd", x"009ef21", -- Fila con datos 280 a 287
        x"009e654", x"009dd97", x"009d4e9", x"009cc4a", x"009c3bb", x"009bb3a", x"009b2c8", x"009aa65", -- Fila con datos 288 a 295
        x"009a210", x"00999ca", x"0099191", x"0098967"                                                  -- Fila con datos 296 a 299
    );
begin
    process (clk) begin
        if rising_edge(clk) then
            if (en = '1') then
                data <= ROM(conv_integer(addr));
            end if;
        end if;
    end process;
end behavioral;