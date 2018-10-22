namespace Task0
{
    public abstract class Effect
    {
        protected string Name { get; }

        public abstract void ApplyEffect();
    }
}