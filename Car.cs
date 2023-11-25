

namespace exHadasim
{
    abstract class Car
    {
        private int speed;

        public int GetCurrentSpeed()
        {
            return speed;
        }

        public virtual void Accelerate(int amount)
        {
            speed += amount;
        }

        public void Decelerate(int amount)
        {
            speed -= amount;
            if (speed < 0)
            {
                speed = 0;
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        public abstract override string ToString();
    }
}
