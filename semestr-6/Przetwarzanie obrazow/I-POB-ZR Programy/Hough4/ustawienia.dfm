object ustaw_form: Tustaw_form
  Left = 331
  Top = 575
  BorderIcons = []
  BorderStyle = bsDialog
  Caption = 'Ustawnienia'
  ClientHeight = 131
  ClientWidth = 321
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poDefault
  Visible = True
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object pasek_ro: TScrollBar
    Left = 104
    Top = 8
    Width = 121
    Height = 16
    LargeChange = 10
    Max = 1000
    Min = 1
    PageSize = 0
    Position = 10
    TabOrder = 0
    OnChange = pasek_roChange
  end
  object StaticText1: TStaticText
    Left = 0
    Top = 8
    Width = 85
    Height = 17
    Caption = 'Gêstoœæ wg. "ro"'
    TabOrder = 1
  end
  object StaticText2: TStaticText
    Left = 0
    Top = 32
    Width = 86
    Height = 17
    Caption = 'Gêstoœæ wg. "mi"'
    TabOrder = 2
  end
  object pasek_mi: TScrollBar
    Left = 104
    Top = 32
    Width = 121
    Height = 16
    LargeChange = 10
    Max = 1000
    Min = 1
    PageSize = 0
    Position = 10
    TabOrder = 3
    OnChange = pasek_miChange
  end
  object Zatwierdz_bt: TButton
    Left = 16
    Top = 96
    Width = 89
    Height = 25
    Caption = 'ZatwiedŸ'
    TabOrder = 4
    OnClick = Zatwierdz_btClick
  end
  object Anuluj_bt: TButton
    Left = 128
    Top = 98
    Width = 89
    Height = 25
    Caption = 'Anuluj'
    TabOrder = 5
    OnClick = Anuluj_btClick
  end
  object Edit_ro: TEdit
    Left = 232
    Top = 8
    Width = 65
    Height = 21
    ReadOnly = True
    TabOrder = 6
    Text = '10'
  end
  object Edit_mi: TEdit
    Left = 232
    Top = 32
    Width = 65
    Height = 21
    ReadOnly = True
    TabOrder = 7
    Text = '10'
  end
  object pasek_prog: TScrollBar
    Left = 104
    Top = 56
    Width = 121
    Height = 16
    LargeChange = 10
    PageSize = 0
    Position = 95
    TabOrder = 8
    OnChange = pasek_progChange
  end
  object Edit_prog: TEdit
    Left = 232
    Top = 56
    Width = 65
    Height = 21
    ReadOnly = True
    TabOrder = 9
    Text = '95%'
  end
  object StaticText3: TStaticText
    Left = 0
    Top = 56
    Width = 26
    Height = 17
    Caption = 'Próg'
    TabOrder = 10
  end
  object aut_check: TCheckBox
    Left = 224
    Top = 80
    Width = 97
    Height = 17
    Caption = 'automatyczny'
    Checked = True
    State = cbChecked
    TabOrder = 11
    OnClick = aut_checkClick
  end
end
