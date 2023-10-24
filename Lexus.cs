

namespace exHadasim
{
    class Lexus : Car
    {
        private bool isPlayingMusic;

        public void PlayMusic()
        {
            isPlayingMusic = true;
        }

        public void StopMusic()
        {
            isPlayingMusic = false;
        }

        public override string ToString()
        {
            return "Lexus, Speed: " + GetCurrentSpeed() + " km/h, Music: " + (isPlayingMusic ? "On" : "Off");
        }
    }
}
