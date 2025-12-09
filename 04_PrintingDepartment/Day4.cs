using System.Collections.Generic;
using System.Diagnostics;

namespace _04_PrintingDepartment
{
    public class Day4
    {
       
        private char[][] _grid;
        const char paperChar = '@';
        public Day4(string input)
        {
            var splitInput = input.Split("\n");
            _grid = splitInput.Select(r => r.ToCharArray()).ToArray();

        }

        bool CanReach(char[][] grid, int startX, int startY)
        {
            int paperCount = 0;
      
            for (int dy = -1; dy < 2; dy++)
            {
                var y = startY + dy;
                if (y < 0 || y >= grid.Length) continue;

                for (int dx = -1; dx < 2; dx++)
                {
                    var x = startX + dx;
                    if (x < 0 || x >= grid[y].Length) continue;

                    if(dx == 0 && dy==0) continue;

                    if (grid[y][x] == '@')
                    {
                        paperCount++;
                    }
                        
                }
               
            }

      
            return paperCount<4; 


        }

     
        public int Calculate()
        {
            int countPaper = 0;


            for (int y = 0; y < _grid.Length; y++)
            {
                for (int x = 0; x < _grid[y].Length; x++)
                {

                    if (_grid[y][x] == '.' || _grid[y][x] == 'x') continue;

                    if (CanReach(_grid, x, y))
                    {
                        //_grid[y][x] = 'x';
                        countPaper += 1;
                    }


                }
            }

            //for (int y = 0; y < _grid.Length; y++)
            //{
            //    for (int x = 0; x < _grid[y].Length; x++)
            //    {
            //        Debug.Write(_grid[y][x]);
            //    }
            //    Debug.WriteLine("");
            //}

                    return countPaper;

        }
    }
}
