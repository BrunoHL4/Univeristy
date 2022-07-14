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
    Left = 272
    Top = 104
    Width = 83
    Height = 13
    Caption = 'Grados Fareinheit'
  end
  object Edit1: TEdit
    Left = 272
    Top = 56
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Introducir Centigrados'
  end
  object Button1: TButton
    Left = 296
    Top = 152
    Width = 75
    Height = 25
    Caption = 'CONVERTIR'
    TabOrder = 1
    OnClick = Button1Click
  end
end
