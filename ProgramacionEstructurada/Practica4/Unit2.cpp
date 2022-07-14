//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit2.h"
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
int N1,N2,R;
N1=Edit1->Text.ToInt();
N2=Edit2->Text.ToInt();
R=N1+N2;

Label1->Caption=IntToStr(R);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
int N1,N2,R;
N1=Edit1->Text.ToInt();
N2=Edit2->Text.ToInt();
R=N1-N2;

Label1->Caption=IntToStr(R);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
int N1,N2,R;
N1=Edit1->Text.ToInt();
N2=Edit2->Text.ToInt();
R=N1*N2;

Label1->Caption=IntToStr(R);;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button4Click(TObject *Sender)
{
int N1,N2,R;

N1=Edit1->Text.ToInt();
N2=Edit2->Text.ToInt();

if(N2!=0)
  {
   R=N1/N2;
   Label1->Caption=IntToStr(R);
  }
else
   ShowMessage("Error de Division entre 0");

}
//---------------------------------------------------------------------------
