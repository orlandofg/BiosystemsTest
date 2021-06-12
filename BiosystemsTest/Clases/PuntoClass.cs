namespace BiosystemsTest.Clases
{
    /// <summary>
    /// Clase para el tratamiento de un punto
    /// </summary>
    public class PuntoClass : JuegoBase
    {
        private static readonly int[] Valores = new int[] { 0, 15, 30, 40 };

        //
        // se controlan puntos y ventaja para poder hacer seguimiento de los mismos
        //
        public int Puntos { get; private set; }
        public int Ventaja { get; private set; }
        public int Count { get; private set; }

        public bool EsFin => Ventaja > 0;
        public int Valor => Puntos + Ventaja;

        public override bool Gana()
        {
            Add();
            Count++;
            return EsFin;
        }
        public override void Pierde()
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

        public override string GetInfo() => $"{Valores[Puntos]}{(Ventaja > 0 ? " V" : "")}";
    }
}
