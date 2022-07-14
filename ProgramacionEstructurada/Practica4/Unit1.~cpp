//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
int N1 = StrToInt (Edit1->Text);
int N2 = StrToInt (Edit2->Text);
int Suma= N1+N2;

Label1->Caption=IntToStr(Suma);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
int N1 = StrToInt (Edit1->Text);
int N2 = StrToInt (Edit2->Text);
int Resta= N1-N2;

Label1->Caption=IntToStr(Resta);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
int N1 = StrToInt (Edit1->Text);
int N2 = StrToInt (Edit2->Text);
int Multi= N1*N2;

Label1->Caption=IntToStr(Multi);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button4Click(TObject *Sender)
{
int N1 = StrToInt (Edit1->Text);
int N2 = StrToInt (Edit2->Text);
int Divi= N1/N2;

Label1->Caption=IntToStr(Divi);
}
//---------------------------------------------------------------------------
