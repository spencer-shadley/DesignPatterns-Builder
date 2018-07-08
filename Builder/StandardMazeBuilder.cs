using System;

namespace Builder
{
    class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;
        private Direction CommonWall(Room room1, Room room2)
        {
            return new Direction(); // in a real solution it would math out the direction
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            throw new NotImplementedException();
        }

        public override void BuildMaze()
        {
            throw new NotImplementedException();
        }

        public override void BuildRoom(int room)
        {
            throw new NotImplementedException();
        }
    }
}
