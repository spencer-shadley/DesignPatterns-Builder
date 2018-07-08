namespace Builder
{
    abstract class MazeBuilder
    {
        public Maze Maze { get; set; }

        public abstract void BuildMaze();
        public abstract void BuildRoom(int room);
        public abstract void BuildDoor(int roomFrom, int roomTo);

        protected MazeBuilder() { }
    }
}
