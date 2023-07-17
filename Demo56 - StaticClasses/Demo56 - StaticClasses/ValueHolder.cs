namespace Demo56___StaticClasses;

public static class ValueHolder
{
    static ValueHolder()
    {
        Value = 20;
    }

    public static int Value { get; set; }

    // public string Firstname { get; set; } // Cannot create not static members inside static classes
}