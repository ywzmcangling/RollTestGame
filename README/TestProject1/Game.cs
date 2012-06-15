using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1
{
    class Game
    {   private int s=0;
        private int[] rolls=new int[21];
        private int currentRoll = 0;
       public  void roll(int pins)
        {
            this.s += pins;
            this.rolls[currentRoll++] = pins;
        }

       public  int  score()
       {
           int frameIndex=0;
           int result = 0;
           for (int frame = 0; frame < 10; frame++)
           {
               if (isStrike(frameIndex))
               {
                   result += 10 +SrikeBonus(frameIndex);
                   frameIndex++;
               }
               else if (isSpare(frameIndex))
               {
                   result += 10 +SpareBonus(frameIndex);
                   frameIndex += 2;
               }
               else
               {
                   result += SumOfBallInFrame(frameIndex);
                   frameIndex += 2;
               }
               
           }//for
               return result;
        }

       private bool isStrike(int frameIndex)
       {
           return rolls[frameIndex] == 10;
       }



       private int SrikeBonus(int frameIndex)
       {
           return rolls[frameIndex + 1] + rolls[frameIndex + 2];
       }



       private int SpareBonus(int frameIndex)
       {
           return rolls[frameIndex + 2];
       }

       private int SumOfBallInFrame(int frameIndex)
       {
           return rolls[frameIndex] + rolls[frameIndex + 1];
       }

       private bool isSpare(int frameIndex)
       {
           return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
       }



      
    }
}
