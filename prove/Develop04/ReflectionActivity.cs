class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
}