public class Solution
{
    /*
     You are playing the following Nim Game with your friend:
     Initially, there is a heap of stones on the table.
     You and your friend will alternate taking turns, and you go first.
     On each turn, the person whose turn it is will remove 1 to 3 stones from the heap.
     The one who removes the last stone is the winner.
     Given n, the number of stones in the heap, return true if you can win the game assuming both you and your friend play optimally, otherwise return false.
     */
    public static bool CanWinNim(int n)
    {
        //If n = 1, 2, or 3, there are fewer than 4 stones, and since I go first, I can remove all the stones and win right away
        if (n == 1 || n == 2 || n==3) return true;

        /* 
           If n is divisible by 4 (i.e., n % 4 == 0), I can't win. 
           For example, if n = 4:
           - If I start by removing 1 stone, my friend will remove 3 and win.
           - If I start by removing 2 stones, my friend will remove 2 and win.
           - If I start by removing 3 stones, my friend will remove 1 and win.

           In all these cases, my friend wins because they can always take the last stone.

           However, if n is not divisible by 4, I can win. For example, if n = 5:
           - If I start by removing 1 stone (leaving 4 stones), my friend is forced into a losing position since the remaining stones form a multiple of 4. 
           - No matter how many stones they take (1, 2, or 3), I can win by taking the last stone on my next turn.

           Therefore, the strategy is:
           - If n % 4 != 0, I can win by forcing my opponent into a losing position.
        */
        return (n % 4 != 0);
    }

    public static void Main()
    {
        Console.WriteLine(CanWinNim(1));
        Console.WriteLine(CanWinNim(16));
        Console.WriteLine(CanWinNim(5));

    }
}
