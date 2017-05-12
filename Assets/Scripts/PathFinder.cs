using System.Collections.Generic;
using UnityEngine;


public static class PathFinder
{

    public static List<Grid.Position> FindPath(Tile[,] tiles, Grid.Position fromPosition, Grid.Position toPosition)
    {
        var path = new List<Grid.Position>();
        Queue<Grid.Position> q = new Queue<Grid.Position>();
        q.Enqueue(fromPosition);
        
        while (q.Count > 0)
        {
            var p = q.Dequeue();
            path.Add(p);
            if (p.x == toPosition.x)
            {
                Debug.Log("Achei");
                break;
            }

            else
            {
                if (p.y >= 0 && p.y < 9) { q.Enqueue(new Grid.Position { x = p.x, y = p.y + 1 }); }
                if (p.y > 0 && p.y =< 9) { q.Enqueue(new Grid.Position { x = p.x, y = p.y - 1 }); }
                if (p.x >= 0 && p.x < 9) { q.Enqueue(new Grid.Position { x = p.x + 1, y = p.y }); }
                if (p.x > 0 && p.x =< 9) { q.Enqueue(new Grid.Position { x = p.x - 1, y = p.y }); }
            }
         }

        return path;
    }
}
