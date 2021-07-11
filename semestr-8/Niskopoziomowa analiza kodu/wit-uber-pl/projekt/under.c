sfr at 0x90 P1;
#define E 0x08
#define RS 0x04
#define TIMER0_INIT 0
 
#define KLAW_1 0xFE
#define KLAW_2 0xFD
#define KLAW_3 0xFB
#define KLAW_4 0xF7

const int klaw[4] = {KLAW_1, KLAW_2, KLAW_3, KLAW_4};

xdata at 0x8000 unsigned char U15;
xdata at 0x8000 unsigned char U12;
xdata at 0xFFFF unsigned char U10;

int _godzina;
int _minuta;
int _czas = 0;

void send_Command_8_bit(unsigned char polecenie)
{
  P1=polecenie;
  P1=polecenie | E;
  P1=polecenie & !E;
}

void send_Command_4_bit(unsigned char polecenie)
{
  P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
  P1=(polecenie & 0xf0) | E; //sygna³ „strob”
  P1=(polecenie & 0xf0) & !E;
  P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
  P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
  P1=((polecenie << 4) & 0xf0) & !E;
}

void send_Date(unsigned char dana)
{
  P1=(dana & 0xf0) | RS;
  P1=((dana & 0xf0) | E) | RS;
  P1=((dana & 0xf0) & !E) | RS;
  P1=((dana << 4) & 0xf0) | RS;
  P1=(((dana << 4) & 0xf0) | E) | RS;
  P1=(((dana << 4) & 0xf0) & !E) | RS;
}

void czekaj(int d){
  int i, j;
  for(i = 0; i<d; i++) {
    for(j = 0; j < 256; j++) {
       ;
    } 
  }
}

void lcd_init()
{
  send_Command_8_bit(0x30);
  czekaj(50);
  send_Command_8_bit(0x30);
  czekaj(50);
  send_Command_8_bit(0x30);
  czekaj(50);
  send_Command_8_bit(0x20);
  czekaj(50);
  send_Command_4_bit(0x28);
  czekaj(50);
  send_Command_4_bit(0x08);

  czekaj(50);
  send_Command_4_bit(0x0E);
  czekaj(50);
  send_Command_4_bit(0x0E);
}


void lcd_write(char *text) {
  while(*text) {
     send_Date(*text);
     czekaj(100);
     *text++;
  }
}

void lcd_czas(char *text) {
  send_Date(*text);
  *text++;
  send_Date(*text);
}

void lcd_clear(void) {
  send_Command_4_bit(0x01);
  czekaj(20);
  send_Command_4_bit(0x02);
  czekaj(20);
  send_Command_4_bit(0x0D);
  czekaj(20);

  send_Command_4_bit(0x80);   
  czekaj(50);
}

void lcd_xy(unsigned char w, unsigned char k)
{
  send_Command_4_bit((w*0x40+k) | 0x80);
  czekaj(20);
} 

char znak(int x) {
	switch(x) {
		case 0:
			return '0';
		case 1:
			return '1';
		case 2:
			return '2';
		case 3:
			return '3';
		case 4:
			return '4';
		case 5:
			return '5';
		case 6:
			return '6';
		case 7:
			return '7';
		case 8:
			return '8';
		case 9:
			return '9';
	}
}

void zmien_czas(int czas)
{
	int t2;
	int t1;
	int t = _godzina + czas;

	if(t >= 24)
	   t = t - 24;
	
	t2 = t / 10;

	t1 = t - t2*10;
	
	lcd_xy(1, 0);
	//godziny
	send_Date(znak(t2));
	send_Date(znak(t1));
	lcd_write(" : ");
	//minuty
	t = _minuta;
	t2 = t / 10;
	t1 = t - t2*10;
	
	send_Date(znak(t2));
	send_Date(znak(t1));
}

void strefa(int s) {
  lcd_clear();
  lcd_xy(0, 0);
  
  if(s == 0) {
     lcd_write("Warszawa");
     zmien_czas(0);
  }
  if(s == 1) {
     lcd_write("Moskwa");
     zmien_czas(2);     
  }
  if(s == 2) {
     lcd_write("Tokio");
     zmien_czas(7);
  }
  if(s == 3) {
     lcd_write("Londyn");
     zmien_czas(-1);
  }
  if(s == 4) {
     lcd_write("Chicago");
     zmien_czas(-5);
  }
  if(s == 5) {
     lcd_write("Kijow");
     zmien_czas(1);
  }
  if(s == 6) {
     lcd_write("Pekin");
     zmien_czas(5);
  }
  if(s == 7) {
     lcd_write("Bagdad");
     zmien_czas(4);
  }
  czekaj(100);
}

void czas(void) {
	if(_czas == 500) {
		_minuta++;
		_czas = 0;
		
		if (_minuta>59){
			_minuta = 0;
			_godzina++;
		}
		
		if (_godzina>23){
			_godzina++;
		}
	}
	_czas++;
}

void main(void) {
  int c;
  lcd_init();
  czekaj(100);
  lcd_clear();

  czekaj(100);
  lcd_clear();
  czekaj(500);
  _godzina = 14;
  _minuta = 50;

  while(1) {
     for(c = 0; c < 4; c++) {
        U15 = klaw[c];
     
        if((U12 & 0x10) == 0)
           strefa(c);
        if((U12 & 0x20) == 0)
           strefa(c+4);
     }
     czekaj(10);
     czas();
  }
}