namespace NamuDarbasAutomobiliai
{
    class Motociklai
    {
        private string _marke;
        private string _valstybinisNumeris;
        private int _kubatura;
        private int _kaina;
        private int _maksimalusGreitis;
        private int _metai;

        public Motociklai() { }
        public Motociklai(string marke, string valstybinisNumeris, int kubatura, int kaina, int maksimalusGreitis, int metai)
        {
            this._marke = marke;
            this._valstybinisNumeris = valstybinisNumeris;
            this._kubatura = kubatura;
            this._kaina = kaina;
            this._maksimalusGreitis = maksimalusGreitis;
            this._metai = metai;
        }

        public string Marke { get => _marke; set => _marke = value; }
        public string ValstybinisNumeris { get => _valstybinisNumeris; set => _valstybinisNumeris = value; }
        public int Kubatura { get => _kubatura; set => _kubatura = value; }
        public int Kaina { get => _kaina; set => _kaina = value; }
        public int MaksimalusGreitis { get => _maksimalusGreitis; set => _maksimalusGreitis = value; }
        public int Metai { get => _metai; set => _metai = value; }

        public string ToPrint()
        {
            return "Marke: " + Marke + ", " + "Valstybinis nr: " + ValstybinisNumeris + ", " + "Kubatura: " + Kubatura + ", " 
                + "Kaina: " + Kaina + ", " + "Maksimalus greitis: " + MaksimalusGreitis + ", " + "Pagaminimo metai: " + Metai;
        }
    }
}
