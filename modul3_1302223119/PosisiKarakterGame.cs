using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static modul4_1302223119.PosisiKarakterGame;

namespace modul4_1302223119
{
    internal class PosisiKarakterGame
    {
        public enum State { Jongkok, Berdiri, Tengkurap, Terbang };

        public enum Trigger { TombolW, TombolS, TombolX }

        public State prevState, nextState;

        public State currentState;

        public Trigger trigger;

        public PosisiKarakterGame(State currentState)
        {
            this.currentState = currentState;
        }

        public PosisiKarakterGame(State prevState, State nextState, Trigger trigger)
        {
            this.prevState = prevState;
            this.nextState = nextState;
            this.trigger = trigger;
        }

    }
    class Transition
    {
        PosisiKarakterGame[] transition = { 
            new PosisiKarakterGame(State.Tengkurap, State.Jongkok, Trigger.TombolW),
            new PosisiKarakterGame(State.Jongkok, State.Tengkurap, Trigger.TombolS),
            new PosisiKarakterGame(State.Jongkok, State.Berdiri, Trigger.TombolW),
            new PosisiKarakterGame(State.Berdiri, State.Jongkok, Trigger.TombolS),
            new PosisiKarakterGame(State.Berdiri, State.Terbang, Trigger.TombolW),
            new PosisiKarakterGame(State.Terbang, State.Berdiri, Trigger.TombolS),
            new PosisiKarakterGame(State.Terbang, State.Jongkok, Trigger.TombolX)

        };

        public PosisiKarakterGame NextState(PosisiKarakterGame posisi, Trigger trigger)
        {
            for (int i = 0; i < transition.Length; i++)
            {
                if (transition[i].prevState == posisi.currentState && transition[i].trigger == trigger)
                {
                   // Console.WriteLine(transition[i].prevState.ToString()+ transition[i].trigger.ToString() + transition[i].nextState.ToString());

                    switch (trigger)
                    {
                        case Trigger.TombolS:
                            Console.WriteLine("tombol arah bawah ditekan");
                            break;
                        case Trigger.TombolW:
                            Console.WriteLine("tombola rah atas ditekan");
                            break;
                    }

                    posisi.prevState = posisi.currentState;
                    posisi.currentState = transition[i].nextState;
                    return posisi;
                }
            }
            return posisi;

        }

    }

}
