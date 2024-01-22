namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Method Overriding = Te da uma nova versão de um método herdado da classe pai;
            //  O método herdado precisa ser: Abstract, Virtual ou ja overriden; 
            //  Usado com ToString(), polimorfismo;
            //  overrride == sobrescrito/reescrito;

            Cachorro mel = new Cachorro();
            Gato laranja = new Gato();

            mel.Som();
            laranja.Som();

            Console.ReadKey();
            Console.Beep();
        }
    }
    class Animal
    {
        public virtual void Som()
        {
            Console.WriteLine("O animal faz *brrr*");
        }
    }
    class Cachorro : Animal
    {
        public override void Som()
        {
            Console.WriteLine("O cachorro faz *auau*");
        }
    }
    class Gato : Animal
    {
        public override void Som()
        {
            Console.WriteLine("O gato faz *miau*");
        }
    }

}
