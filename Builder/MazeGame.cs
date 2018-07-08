using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MazeGame
    {
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.Maze;
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            // ...
            builder.BuildRoom(1001);

            return builder.Maze;
        }
    }
}
