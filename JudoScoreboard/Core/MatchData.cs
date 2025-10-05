namespace JudoScoreboard.Core
{
    public class MatchData
    {
        public string NomeAzul { get; set; } = "";
        public string NomeBranco { get; set; } = "";
        public string Categoria { get; set; } = "";
        public int TempoRestante { get; set; }
        public int IpponAzul { get; set; }
        public int WazaAzul { get; set; }
        public int YukoAzul { get; set; }
        public int ShidoAzul { get; set; }
        public int IpponBranco { get; set; }
        public int WazaBranco { get; set; }
        public int YukoBranco { get; set; }
        public int ShidoBranco { get; set; }
        public bool IsRunning { get; set; }
        public bool IsGoldenScore { get; set; }
        public string Estado { get; set; } = "";
    }
}