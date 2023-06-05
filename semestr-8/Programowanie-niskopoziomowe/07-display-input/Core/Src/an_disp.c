/*
 * an_disp.c
 *
 *  Created on: 21.08.2019
 *      Author: Bartosz Pracz
 */

#include "../Display/an_disp.h"

void lcdSendHalf(uint8_t data) {
	LCD_E_HIGH;
	HAL_GPIO_WritePin(LCD_D4_PORT, LCD_D4_PIN, (data & 0x01));
	HAL_GPIO_WritePin(LCD_D5_PORT, LCD_D5_PIN, (data & 0x02));
	HAL_GPIO_WritePin(LCD_D6_PORT, LCD_D6_PIN, (data & 0x04));
	HAL_GPIO_WritePin(LCD_D7_PORT, LCD_D7_PIN, (data & 0x08));
	LCD_E_LOW;
}

void lcdWriteByte(uint8_t data) {
	lcdSendHalf(data >> 4);
	lcdSendHalf(data);
	HAL_Delay(1);
}

void lcdWriteCmd(uint8_t cmd) {
	LCD_RS_LOW;
	lcdWriteByte(cmd);
}

void lcdChar(char data) {
	LCD_RS_HIGH;
	lcdWriteByte(data);
}

void lcdInit(void) {
	HAL_Delay(15);

	LCD_E_LOW;
	LCD_RS_LOW;

	lcdSendHalf(0x03);
	HAL_Delay(5);
	lcdSendHalf(0x03);
	HAL_Delay(5);
	lcdSendHalf(0x03);
	HAL_Delay(5);
	lcdSendHalf(0x02);
	HAL_Delay(5);

	lcdWriteCmd( LCD_FUNC | LCD_4_BIT | LCDC_TWO_LINE | LCDC_FONT_5x7);
	HAL_Delay(5);
	lcdWriteCmd( LCD_ONOFF | LCD_DISP_ON);
	HAL_Delay(5);
	lcdWriteCmd( LCD_CLEAR);
	HAL_Delay(5);
	lcdWriteCmd( LCDC_ENTRY_MODE | LCD_EM_SHIFT_CURSOR | LCD_EM_RIGHT);
	HAL_Delay(5);
}

void lcdClear(void){
	lcdWriteCmd(LCD_CLEAR);
}

void lcdLocate(uint8_t x, uint8_t y) {

	switch (y) {
	case 0:
		lcdWriteCmd( LCDC_SET_DDRAM | (LCD_LINE1 + x));
		break;

	case 1:
		lcdWriteCmd( LCDC_SET_DDRAM | (LCD_LINE2 + x));
		break;
	case 2:
		lcdWriteCmd( LCDC_SET_DDRAM | (LCD_LINE3 + (x - 12)));
		break;
	case 3:
		lcdWriteCmd( LCDC_SET_DDRAM | (LCD_LINE4 + (x - 12)));
		break;
	}

}

void lcdStr(char *text) {
	while (*text)
		lcdChar(*text++);
}

void lcdInt(int data){

	char buffer[20];
	sprintf(buffer, "%d", data);
	lcdStr(buffer);

}

void floatToInts(float data, uint32_t denominator, int32_t *ones, uint32_t *decimals, uint8_t *zeros){
	//ex 21.04
	int32_t integer = (uint32_t)data;//21
	int32_t all = data*(float)denominator;//21040
	float afterComma = all - (integer*denominator);

	*ones = integer;
	*decimals = abs((int32_t)afterComma);
	*zeros = log10(denominator)-1;



}

void lcdFloat(float data, uint32_t denominator){

	int32_t beforeComma;
	uint32_t afterComma;
	uint8_t zeros;

	floatToInts(data, denominator, &beforeComma, &afterComma, &zeros);

	lcdInt(beforeComma);
	lcdChar('.');

	if(denominator == 100 && afterComma < 10){
		lcdStr("0");
	}
	if(denominator == 1000){
		if(afterComma<10) lcdStr("00");
		else if(afterComma<100) lcdStr("0");
	}



	lcdInt(afterComma);

}
