namespace TrafficLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trafficlight tl = new Trafficlight();
            tl.GreenLight();
            tl.YellowLight();
            tl.RedLight();
            tl.RedLight();
        }
    }
    interface iTrafficlight 
    {
        void Green(Trafficlight tl);
        void Yellow(Trafficlight tl);
        void Red(Trafficlight tl);
    }

    class Trafficlight
    {
        iTrafficlight tl {  get; set; }

        public Trafficlight()
        {
            tl = new GreenLight();
        }
        public void Changestate(iTrafficlight ChangeState)
        {
            tl = ChangeState;
        }
        public void GreenLight()
        {
            tl.Green(this);
        }
        public void YellowLight()
        {
            tl.Yellow(this);
        }
        public void RedLight()
        {
            tl.Red(this);
        }
    }

    internal class GreenLight : iTrafficlight
    {
        public void Red(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Now Red");
            tl.Changestate(new RedLight());
        }

        public void Yellow(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Now Yellow");
            tl.Changestate(new YellowLight());
        }

        public void Green(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Already Green");
        }
    }
    internal class YellowLight : iTrafficlight
    {
        public void Red(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Now Red");
            tl.Changestate(new RedLight());
        }

        public void Yellow(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Aleady Yellow");
        }

        public void Green(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Now Green");
            tl.Changestate(new GreenLight());
        }
    }
    internal class RedLight : iTrafficlight
    {
        public void Red(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Already Red");
        }

        public void Yellow(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Now Yellow");
            tl.Changestate(new YellowLight());
        }

        public void Green(Trafficlight tl)
        {
            Console.WriteLine("TrafficLight is Now Green");
            tl.Changestate(new GreenLight());
        }
    }
}