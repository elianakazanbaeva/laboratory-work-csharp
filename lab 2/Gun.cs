using System;

internal class Gun
{
    private int bullets;

    public Gun()
    {
        this.bullets = 5;
    }

    public Gun(int bullets)
    {
        this.bullets = bullets;
    }

    public int Bullets
    {
        get { return bullets; }
        private set { bullets = value; }
    }

    public void Shoot()
    {
        if (bullets > 0)
        {
            Console.WriteLine("Бах!");
            bullets--;
        }
        else
        {
            Console.WriteLine("Клац!");
        }
    }

    public override string ToString()
    {
        return "Пистолет с " + bullets + " патронами";
    }
}