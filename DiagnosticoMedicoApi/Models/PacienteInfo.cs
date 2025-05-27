using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnosticoMedicoApi.Models
{
    public class PacienteInfo
    {
        public string? Sintoma { get; set; }
        public bool ExameFeito { get; set; }
        public bool HistoricoRespiratorio { get; set; }
    }
}