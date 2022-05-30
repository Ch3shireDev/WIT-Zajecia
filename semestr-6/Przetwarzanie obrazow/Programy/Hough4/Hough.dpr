program Hough;

uses
  Forms,
  transformH in 'transformH.pas' {Form1},
  ustawienia in 'ustawienia.pas' {ustaw_form},
  tab_akum in 'tab_akum.pas' {Form_tab_akum},
  abo_form in 'abo_form.pas' {about_form};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(Tustaw_form, ustaw_form);
  Application.CreateForm(TForm_tab_akum, Form_tab_akum);
  Application.CreateForm(Tabout_form, about_form);
  Application.Run;
end.
