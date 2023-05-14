using CodilityTasks.Easy.Arrays;
using CodilityTasks.Easy.BinaryGap;
using CodilityTasks.Easy.PrefixSum;
using CodilityTasks.Easy.Sorting.Distinict;
using CodilityTasks.Easy.Sorting.MaxProductOfThree;
using CodilityTasks.Easy.Sorting.Triangle;
using CodilityTasks.Easy.StacksAndQueues;
using CodilityTasks.Easy.StacksAndQueues.Fish;
using CodilityTasks.Easy.TimeComplexity;
using CodilityTasks.Easy.TimeComplexity.PermMissingElement;
using CodilityTasks.Medium.CountingElements.MaxCounter;
using CodilityTasks.Medium.CountingElements.MissingInteger;
using CodilityTasks.Medium.PrefixSums.CountDiv;

namespace CodilityTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var binaryGap = new BinaryGap();
           //var result = binaryGap.Solution(1041);

           //var cyclicRotation = new CyclicRotation();
           // var A = new int[]{3, 8, 9, 7, 6};
           //var K = 3;
           //var result = cyclicRotation.solution(A, K);

           //var A = new int[] { 9, 3, 9, 3, 9, 9, 7 };
           //var oddOccurences = new OddOccurencesInArray();
           //var result = oddOccurences.solution(A);

          // var fromJump = new FrogJump();
           //var result = fromJump.solution(10, 85, 30);

          // var perm = new PermMissingElement();
           //var A = new int[] { 1,2,3,5 };
           //var result = perm.solution(A);

           //var A = new int[] { 3,4,4,6,1,4,4 };

           //var maxCounter = new MaxCounter();
           //var result = maxCounter.solution(5, A);

           //var A = new int[] { -1,102,103 };
           //var missingInt = new MissinInteger();
          //var result = missingInt.solution(A);
          
          //var A = new int[] { 0,1,0,1,1 };
          //var passingCars = new PassingCars();
          //var result = passingCars.solution(A);

         // var countDiv = new CountDiv();
         // var result = countDiv.solution(6, 124, 2);

         //var A = new int[] { 2,2,1,3,1,1 };
         //var distinct = new Distinct();
        // var result = distinct.solution(A);

        // var A = new int[] { -3,1,2,-2,5,6 };
        // var lastThree = new MaxProductOfThree();
        // var result = lastThree.solution(A);
        
        
         //var A = new int[] { 10,2,5,1 };
        // var triangle = new Triangle();
        // var result = triangle.solution(A);
         
         //var brackets = new Brackets();
        // var result = brackets.solution("{[()()]}");

         var fish = new Fish();
         var A = new int[] { 4,3,2,1,5 };
         var B = new int[] { 0,1,0,0,0 };

         var result = fish.solution(A,B);
         Console.WriteLine(result);
        }
    }
}