using System;
namespace homework4{
    class Program {
        static void Main(string[]args){
            Console.WriteLine("Input length of road and distance that customers can come(N K): ");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);

            Console.WriteLine("Input population of " + N + "street blocks(Ex:4 5 2...):");
            string inputPopulation = Console.ReadLine();
            string[] populationInput = inputPopulation.Split(' ');

            int[] population = new int[N];

            for (int i = 0; i < N; i++) {
                population[i] = int.Parse(populationInput[i]);
            }

            int maxSum = GetMaxSum(population, K);
            Console.WriteLine("The maximum total number of people: " + maxSum);
            Console.WriteLine("The maximum sum of " + K + " consecutive numbers is: " + maxSum);
        }
        static int GetMaxSum(int[] population, int K) {
            int maxSum = int.MinValue;

            for (int i = 0; i <= population.Length - (2 * K + 1); i++) {
                int currentSum = 0;

                for (int j = i; j <= i + (2 * K); j++) {
                    currentSum += population[j];
                }

                if (currentSum > maxSum){
                    maxSum = currentSum;
                }
            }
            return maxSum;
        }
    }
}
