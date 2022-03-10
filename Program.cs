using HW_Array;



int AC=HomeworkArray.CheckArray();
Console.WriteLine(AC);

int AS = HomeworkArray.FindTheMaximumElementOfAnArray();
Console.WriteLine(AS);

int AO = HomeworkArray.findMinTheIndex();
Console.WriteLine(AO);

int AT = HomeworkArray.findMaxTheIndex();
Console.WriteLine(AT);

int AQ = HomeworkArray.CalculateTheSumOfArrayElements();
Console.WriteLine(AQ);


int[] AW = HomeworkArray.GenerateRandom(5);
HomeworkArray.Write(AW);
int[] AP = HomeworkArray.ReverseAnArray(AW);
HomeworkArray.Write(AP);


int APP = HomeworkArray.CountTheNumberOfOddElementsInAnArray();
Console.WriteLine(APP);

int[] AUU = HomeworkArray.GenerateRandom(5);
HomeworkArray.Write(AW);
int[] AU = HomeworkArray.SwapTheFirstAndSecondHalfOfAnArray(AW);
HomeworkArray.Write(AP);

int[] AOI = HomeworkArray.SortArrayByAge();
HomeworkArray.Write(AOI);

int[] AOPP = HomeworkArray.SortArrayInDescendingOrder();
HomeworkArray.Write(AOI);
