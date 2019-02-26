namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;
        protected float durability; 

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return 0F; }
            protected set { speedBonus = value; }
        }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
            //Mantener Durability como rango de 0 a 1.
            if (durability >= 1F)
                durability = 1F;
            if (durability <= 0F)
                durability = 0F;

            if (speedBonus < 1.5F)
                speedBonus = speedBonus * durability;
            else
                speedBonus = 1.5F * durability;
        }

        public void Upgrade()
        {
            if (Level <= 3)
            {
                Level++;
                speedBonus += speedBonus * 0.3F * Level;
            }
        }
    }
}