namespace BiosystemsTest.Clases
{
    public class PuntoClass
    {
        private static readonly int[] Valores = new int[] { 0, 15, 30, 40 };

        public int Puntos { get; private set; }
        public int Ventaja { get; private set; }
        public int Count { get; private set; }

        public bool EsFin => Ventaja > 0;
        public int Valor => Puntos + Ventaja;

        public void Gana()
        {
            Add();
            Count++;
        }
        public void Pierde()
        {
            if (Ventaja > 0)
                Ventaja--;
            Count++;
        }

        public void Add()
        {
            if (Puntos < Valores.Length - 1)
                Puntos++;
            else
                Ventaja++;
        }

        public string Info => $"{Valores[Puntos]}{(Ventaja > 0 ? " V" : "")}";
    }
}
