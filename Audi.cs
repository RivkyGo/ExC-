

namespace exHadasim
{
    class Audi : Car
    {
        public override void Accelerate(int amount)
        {
            //int currentSpeed = GetCurrentSpeed();
            base.Accelerate(amount * 2);
        }

        public override string ToString()
        {
            return "Audi, Speed: " + GetCurrentSpeed() + " km/h";
        }
    }
}
