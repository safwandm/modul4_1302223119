// See https://aka.ms/new-console-template for more information
using modul4_1302223119;
using static modul4_1302223119.PosisiKarakterGame;
using static modul4_1302223119.Transition;

//Soal C
Console.WriteLine("Soal C\n");

KodeBuah kodeBuah = new KodeBuah();

Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.Buah.Melon));


//Soal E

Console.WriteLine("\n\nSoal E\n");


Transition transition = new Transition();
PosisiKarakterGame posisi = new PosisiKarakterGame(State.Terbang);


transition.NextState(posisi, Trigger.TombolX);
Console.WriteLine(posisi.currentState.ToString());

transition.NextState(posisi, Trigger.TombolS);
Console.WriteLine(posisi.currentState.ToString());

transition.NextState(posisi, Trigger.TombolW);
Console.WriteLine(posisi.currentState.ToString());

transition.NextState(posisi, Trigger.TombolW);
Console.WriteLine(posisi.currentState.ToString());

transition.NextState(posisi, Trigger.TombolW);
Console.WriteLine(posisi.currentState.ToString());