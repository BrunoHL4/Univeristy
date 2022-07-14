object Form1: TForm1
  Left = 192
  Top = 125
  Width = 928
  Height = 480
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 392
    Top = 248
    Width = 66
    Height = 13
    Caption = 'RESULTADO'
  end
  object Button1: TButton
    Left = 408
    Top = 88
    Width = 25
    Height = 25
    Caption = '+'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 408
    Top = 128
    Width = 25
    Height = 25
    Caption = '-'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 408
    Top = 168
    Width = 25
    Height = 25
    Caption = '*'
    TabOrder = 2
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 408
    Top = 208
    Width = 25
    Height = 25
    Caption = '/'
    TabOrder = 3
    OnClick = Button4Click
  end
  object Edit1: TEdit
    Left = 264
    Top = 152
    Width = 121
    Height = 21
    TabOrder = 4
    Text = 'N1'
  end
  object Edit2: TEdit
    Left = 456
    Top = 152
    Width = 121
    Height = 21
    TabOrder = 5
    Text = 'N2'
  end
end
