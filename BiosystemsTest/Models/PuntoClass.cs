namespace BiosystemsTest.Models
{
    class PuntoClass: IPunto
    {
        private static readonly int[] Valores = new int[] { 0, 15, 30, 40 };
        private int count { get; set; }

        public int Puntos { get; private set; }
        public int Ventaja { get; private set; }

        public override bool EsFin => Ventaja > 0;
        public override bool EsGanador { get; set; }

        public int Valor => Puntos + Ventaja;

        public override bool Gana()
        {
            Add();
            count++;
            return EsFin;
        }
        public override void Pierde()
        {
            if (Ventaja > 0)
                Ventaja--;
            count++;
        }

        public void Add()
        {
            if (Puntos < Valores.Length - 1)
                Puntos++;
            else
                Ventaja++;
        }

        public override int CountPuntos() => count;

        public override string GetInfo() => $"{Valores[Puntos]}{(Ventaja > 0 ? " V" : "")}";

    }
}
