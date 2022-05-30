object Form_tab_akum: TForm_tab_akum
  Left = 5
  Top = 280
  Width = 571
  Height = 353
  BorderIcons = [biSystemMenu, biMaximize]
  Caption = 'Tablica akumulatorów'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnResize = FormResize
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object StringGrid1: TStringGrid
    Left = 0
    Top = 0
    Width = 561
    Height = 321
    ColCount = 10
    DefaultColWidth = 15
    DefaultRowHeight = 15
    FixedCols = 0
    RowCount = 10
    FixedRows = 0
    TabOrder = 0
    OnDrawCell = StringGrid1DrawCell
  end
end
