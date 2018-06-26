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
