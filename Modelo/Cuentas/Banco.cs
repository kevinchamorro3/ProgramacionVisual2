namespace Modelo.Cuentas
{
    public class Banco: IDBEntity
    {
        public int BancoId { get; set; }
        public string Nombre { get; set; }
        public double Debe { get; set; }
        public double Haber { get; set; }
        public double Acreedor { get; set; }
        public double Deudor { get; set; }
        public int CorrienteID { get; set; }
        public Corriente Corriente { get; set; }
    }
}
