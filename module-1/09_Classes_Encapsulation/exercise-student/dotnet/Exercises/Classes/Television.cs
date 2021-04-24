namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get { return IsOn; } private set { } }

        public int CurrentChannel { get; private set; }

        public int CurrentVolume { get; private set; }  

        private void TurnOff() 
        { 
            IsOn = false; 
        }

        private void TurnOn() 
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        private void ChangeChannel(int newChannel) //ChangeChannel is a function because no get/set 
        {
           
            if (IsOn && newChannel >= 3 && newChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
        }

        private void ChannelUp() 
        {
            if (IsOn)
            {
                if (CurrentChannel >= 18)
                {
                    CurrentChannel = 3;
                }
                else
                {
                    CurrentChannel = CurrentChannel + 1;
                }
      
            }

        }
        private void ChannelDown() 
        {
            if (IsOn)
            {
                if (CurrentChannel <= 3)
                {
                    CurrentChannel = 18;
                }
                else
                {
                    CurrentChannel = CurrentChannel - 1;
                }

            }
        }
        private void RaiseVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume < 10)
                {
                    CurrentVolume += 1;
                }
            }
        }
        private void LowerVolume() 
        {
            if (IsOn)
            {
                
                if (CurrentVolume > 0)
                {
                    CurrentVolume -= 1;
                }
            }
        }
        public Television() 
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2; 
        }
    }
}
