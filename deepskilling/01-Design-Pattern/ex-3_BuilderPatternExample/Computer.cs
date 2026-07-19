public class Computer
{
    public string CPU { get; }
    public int RAM { get; }
    public int Storage { get; }

    private Computer(Builder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
    }

    public void Display()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM} GB");
        Console.WriteLine($"Storage: {Storage} GB");
        Console.WriteLine();
    }

    public class Builder
    {
        public string CPU { get; private set; }
        public int RAM { get; private set; }
        public int Storage { get; private set; }

        public Builder SetCPU(string cpu)
        {
            CPU = cpu;
            return this;
        }

        public Builder SetRAM(int ram)
        {
            RAM = ram;
            return this;
        }

        public Builder SetStorage(int storage)
        {
            Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}