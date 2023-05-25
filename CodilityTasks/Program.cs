using CodilityTasks.Easy.Arrays;
using CodilityTasks.Easy.BinaryGap;
using CodilityTasks.Easy.CaterpillarMethod.AbsDistinct;
using CodilityTasks.Easy.CaterpillarMethod.CountDistinctSlices;
using CodilityTasks.Easy.CaterpillarMethod.CounTriangles;
using CodilityTasks.Easy.GreedyAlgorithms;
using CodilityTasks.Easy.GreedyAlgorithms.Ropes;
using CodilityTasks.Easy.Leader.Dominator;
using CodilityTasks.Easy.Leader.EquiLeader;
using CodilityTasks.Easy.MaxProfit;
using CodilityTasks.Easy.PrefixSum;
using CodilityTasks.Easy.PrimeNumbers;
using CodilityTasks.Easy.Sorting.Distinict;
using CodilityTasks.Easy.Sorting.MaxProductOfThree;
using CodilityTasks.Easy.Sorting.Triangle;
using CodilityTasks.Easy.StacksAndQueues;
using CodilityTasks.Easy.StacksAndQueues.Fish;
using CodilityTasks.Easy.TimeComplexity;
using CodilityTasks.Easy.TimeComplexity.PermMissingElement;
using CodilityTasks.Medium.CountingElements.MaxCounter;
using CodilityTasks.Medium.CountingElements.MissingInteger;
using CodilityTasks.Medium.Fibonacci;
using CodilityTasks.Medium.PrefixSums.CountDiv;
using CodilityTasks.RandomTaskInternet;
using CodilityTasks.Search;
using CodilityTasks.Sorting;
using CodilityTasks.Strings;

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

      // var fish = new Fish();
      // var A = new int[] { 4,3,2,1,5 };
      // var B = new int[] { 0,1,0,0,0 };
      //var result = fish.solution(A,B);

      // var dominator = new Dominator();
      //var A = new int[] { 3,3,3,3,5,6,7,1 };
      //  var result = dominator.solution(A);

      //var equiLeader = new EquiLeader();
      //var A = new int[] { 4,4,3,4,4,2 };

      // var result = equiLeader.solution(A);

      //var A = new int[] { 23171 , 21011 ,21123 ,21366 ,21013 ,21367 };

      // var maxProfit = new MaxProfit();
      //var result = maxProfit.solution(A);

      //var countFactor = new MinPerimeterRectangle();
      //var result = countFactor.solution(30);

      // var A = new int[] { 3,4,5,5,2};

      // var caterPilar = new CountDistinctSlices();
      // var result = caterPilar.solution(6,A);

      // var A = new int[] { 10, 2, 5, 1, 8, 12 };
      // var triangle = new CountTriangles();
      // var result = triangle.solution(A);

      // var A = new int[] { 1,3,7,9,9 };
      //  var B = new int[] { 5,6,8,9,10 };

      //var maxNooverlap = new MaxNonoverlappingSegments();
      ///var result = maxNooverlap.solution(A,B);

      //var C = new int[] { 1,2,3,4,1,1,3 };
      // var rope = new Ropes();
      // var result  = rope.solution(4, C);

      // var A = new int[] { 0, 0 ,0 ,1, 1 ,0,1,0,0,0,0 };
      // var fib = new Frog();
      // fib.solution(A);

      //var removeNum = new DeletingNumber();
      //var result = removeNum.solution(15958);

      //var balancedString = new BalancedString();
      //var result = balancedString.GetBalancedString("bbaaaaabb");

      // var weekDays = new WeekDay();
      //var result = weekDays.GetWeekDay("Sunday", 10);

      //var svaps = new Palindrome();
      //var result = svaps.GetNumberOfSwaps("roort");

      //var lex = new LexicographicallySmallestString();
      //var result =lex.RemoveCharacter("bba");

      //var sub = new LongestSubstring();
      //var result = sub.GetSubString("aabbbbaa");

      // var max = new MaxInsertToObtainString();
      // var result = max.Solution("aabab");

      var equal = new EqualHeight();
      var piles = new int[] {5, 2, 1 };

     // var result = equal.MakeEqual(piles);

      //var A = new int[] { 4, -1, 0, 3 };
     // var B = new int[] { -2, 5, 0, 3 };
      //var index = new FairIndex();
     // var result = index.GetFairIndex(A, B);

      var A = new int[] { 4,2,3,0,3,1,2 };

      //var jump = new Jump();
      //var solution = jump.CanReachZero(A, 5);

      // int[] X = { 1,8,7,3,4,1,8 };
      // int[] Y = {6,4,1,8,5,1,7};
      // var trees = new Trees();
       //int maxWidth = trees.solution(X, Y);

     //  var arithmeticSLices = new ArithmeticSlices();
      // var slices = new int[] { 1, 2, 3, 4 };
      // var slice = arithmeticSLices.GetNumberOfSubArrays(slices);
      //var velocity = new ParticleVelocity();
     // var slices = new int[] {-1, 1, 3, 3, 3, 2, 3, 2, 1, 0};

      //var vel = velocity.CountStablePeriods(slices);

      //var arr = new UniqueSumUpToZero();
     //var result = arr.ReturnAnArray(3);

    // var arr = new string[] { "un", "iq", "ue" };
    //  var uni = new UniqueCharacters();
     // var result = uni.MaxConcatenatedLength(arr);

     // var ball = new RedWhiteBall();
      //var result = ball.MinSwaps("WRRWWR");
      
       var nums = new int[] {3, 2, -2, 5, -3};

      var positive = new LargestK();
     //var result =  positive.ReturnLargest(nums);

       var bubble = new BubbleSort();
       var bub = new int[] {5,1,7,2,6,4};

      // bubble.Bubble(bub);
       var insert = new InsertionSort();
      //var t= insert.Insertion(bub);

      var selection = new CountingSort();
    //  selection.sort(bub,7);
     // var st = StringUtils.CountVowels("heeeloo");
     // var r = StringUtils.reverse("fifi");
     // var re = StringUtils.reverseSentence("helllo fifi");
    //  var duplicates = StringUtils.duplicates("Trees are beautiful");
     // var toUpper = StringUtils.ToUpper("trees are beautiful");
     // var anagram = StringUtils.Anagram2("trees","trees");
     // var pal = StringUtils.IsPalindrome("Madam");
     var linearSearch = new LinearSearch();
     var resu = linearSearch.linearSearch(bub, 7);
     var binary =  BinarySearch.SearchIteration(bub,7);
     var ternary =  TernarySearch.ternarySearch(bub,7);

         Console.WriteLine();
     }
    }
}