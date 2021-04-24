namespace Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; }  
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        Elevator(int numberOfLevels) { }

        public void OpenDoor()
        {

        }
        public void CloseDoor() { }
        public void GoUp(int desiredFloor) { }
        public void GoDown(int desiredFloor) { }

    }
}
