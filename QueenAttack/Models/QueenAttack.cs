using System;
namespace QueenAttack
{
public class Queen
{
  public bool isQueenKill(int queenX, int queenY, int pieceX, int pieceY)
  {

  if (queenX == pieceX || queenY == pieceY)
  {
    return true;
  }
  else if (Math.Abs(queenX - pieceX) == Math.Abs(queenY - pieceY))
  {
    return true;
  }
  else
  {
    return false;
  }






  }
}
}
class Leet
{
  static void Main()
  {
    Queen queenKill = new Queen();
    Console.WriteLine (" Please enter queen x position");
    string queenX = Console.ReadLine();
    int intX = int.Parse(queenX)
    Console.WriteLine (" Please enter queen y position");
    string queenY = Console.ReadLine();
    int intY = int.Parse(queenY)
    Console.WriteLine (" Please enter piece x position");
    string pieceX = Console.ReadLine();
    int intPieceX = int.Parse(pieceX)
    Console.WriteLine (" Please enter piece y position");
    string pieceY = Console.ReadLine();
    int intPieceY = int.Parse(pieceY)
    Console.WriteLine(queenKill.isQueenKill(intX,intY,intPieceX,intPieceY
     ));
  }
}

}
