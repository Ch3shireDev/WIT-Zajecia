#ifndef an_disp_H
#define an_disp_H

#include <stdlib.h>
#include <stdio.h>
#include <math.h>
//PIN SET

#include "main.h"


#define LCD_RS_PIN DISP_RS_Pin
#define LCD_RS_PORT DISP_RS_GPIO_Port

#define LCD_E_PIN DISP_E_Pin
#define LCD_E_PORT DISP_E_GPIO_Port

#define LCD_D4_PIN DISP_D4_Pin
#define LCD_D4_PORT DISP_D4_GPIO_Port

#define LCD_D5_PIN DISP_D5_Pin
#define LCD_D5_PORT DISP_D5_GPIO_Port

#define LCD_D6_PIN DISP_D6_Pin
#define LCD_D6_PORT DISP_D6_GPIO_Port

#define LCD_D7_PIN DISP_D7_Pin
#define LCD_D7_PORT DISP_D7_GPIO_Port

//STATE SET
#define LCD_E_HIGH HAL_GPIO_WritePin(LCD_E_PORT, LCD_E_PIN, GPIO_PIN_SET)
#define LCD_E_LOW HAL_GPIO_WritePin(LCD_E_PORT, LCD_E_PIN, GPIO_PIN_RESET)

#define LCD_RS_HIGH HAL_GPIO_WritePin(LCD_RS_PORT, LCD_RS_PIN, GPIO_PIN_SET)
#define LCD_RS_LOW HAL_GPIO_WritePin(LCD_RS_PORT, LCD_RS_PIN, GPIO_PIN_RESET)

//CONF
#define LCD_CLEAR 0x01
#define LCD_HOME 0x02
#define LCDC_ENTRY_MODE 0x04
#define LCD_EM_SHIFT_CURSOR 0x00
#define LCD_EM_SHIFT_DISPLAY 0x01
#define LCD_EM_LEFT 0x00
#define LCD_EM_RIGHT 0x02
#define LCD_ONOFF 0x08
#define LCD_DISP_ON 0x04
#define LCD_CURSOR_ON 0x02
#define LCDC_CURSOR_OFF 0x00
#define LCDC_BLINK_ON 0x01
#define LCDC_BLINK_OFF 0x00
#define LCD_SHIFT 0x10
#define LCDC_SHIFT_DISP 0x08
#define LCDC_SHIFT_CURSOR 0x00
#define LCDC_SHIFT_RIGHT 0x04
#define LCDC_SHIFT_LEFT 0x00
#define LCD_FUNC 0x20
#define LCD_8_BIT 0x10
#define LCD_4_BIT 0x00
#define LCDC_TWO_LINE 0x08
#define LCDC_FONT_5x10 0x04
#define LCDC_FONT_5x7 0x00
#define LCDC_SET_CGRAM 0x40
#define LCDC_SET_DDRAM 0x80

#define LCD_LINE1 0x00
#define LCD_LINE2 0x40
#define LCD_LINE3 0x20
#define LCD_LINE4 0x60

void lcdSendHalf(uint8_t data);

void lcdWriteByte(uint8_t data);

void lcdWiteCmd(uint8_t cmd);

void lcdChar(char data);

void lcdInit(void);

void lcdLocate(uint8_t x, uint8_t y);

void lcdStr(char *text);

void lcdInt(int data);

void lcdClear(void);

void lcdFloat(float data, uint32_t denominator);

void floatToInts(float data, uint32_t denominator, int32_t *ones, uint32_t *decimals, uint8_t *zeros);

#endif
