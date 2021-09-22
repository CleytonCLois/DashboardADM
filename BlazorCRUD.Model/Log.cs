namespace BlazorCRUD.Model
{
    #region " Usings "

    using System;

    #endregion

    public class Log
    {
        #region " Atributos & Propriedades "

        public int Id { get; set; }

        public DateTime DataHoraInicial { get; set; }

        public DateTime DataHoraFinal { get; set; }

        public string TipoLog { get; set; }

        public string Notificacao { get; set; }

        public string UsuarioIp { get; set; }

        public string UsuarioUrl { get; set; }

        public string EmailEnviado { get; set; }

        public string Prefeitura { get; set; }

        public string Usuario { get; set; }

        public string UsuarioCPF { get; set; }

        public int PrefeituraId { get; set; }

        public int UsuarioId { get; set; }

        #endregion

    }
}