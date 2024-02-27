namespace Dotnet.Onion.Template.API.DTO.Contrato
{
    public class CertificadosDTO
    {
        public long handle { get; set; }
        public string nom_doc { get; set; }

        public int? qtd_original { get; set; }

        public int? qtd_copias { get; set; }
    }
}
