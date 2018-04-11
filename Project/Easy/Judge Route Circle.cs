using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    /// 657. Judge Route Circle
    /// Initially, there is a Robot at position (0, 0). Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.
    /// The move sequence is represented by a string. And each move is represent by a character.The valid robot moves are R (Right), L(Left), U(Up) and D(down). The output should be true or false representing whether the robot makes a circle.
    /// </summary>
    public class Judge_Route_Circle
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            var movesList = moves.Select(c => c.ToString()).ToList();

            foreach (var move in movesList)
            {
                switch (move)
                {
                    case "R":
                        {
                            x++;
                            break;
                        }
                    case "L":
                        {
                            x--;
                            break;
                        }
                    case "U":
                        {
                            y++;
                            break;
                        }
                    case "D":
                        {
                            y--;
                            break;
                        }
                }
            }

            if (x == 0 && y == 0)
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
