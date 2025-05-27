using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiagnosticoMedicoApi.Models;

namespace DiagnosticoMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiagnosticoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Diagnosticar([FromBody] PacienteInfo info)
        {
            var sintomas = (info.Sintoma ?? string.Empty)
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim().ToLower())
                .ToList();

            bool temFebre = sintomas.Contains("febre");
            bool temTosse = sintomas.Contains("tosse");
            bool sintomasGraves = temFebre || temTosse;

            string resultado = "Sintomas informados: " + string.Join(", ", sintomas) + ".\n";

            if (sintomasGraves)
            {
                if (info.ExameFeito && info.HistoricoRespiratorio)
                {
                    resultado += "Diagnóstico provável: Infecção respiratória.";
                }
                else if (!info.ExameFeito)
                {
                    resultado += "Sintomas graves detectados. Solicitar exames complementares.";
                }
                else if (!info.HistoricoRespiratorio)
                {
                    resultado += "Sintomas graves detectados. Verificar histórico respiratório do paciente.";
                }
            }
            else if (sintomas.Count > 0)
            {
                resultado += "Sintomas leves detectados. Acompanhamento recomendado.";
            }
            else
            {
                resultado += "Nenhum sintoma informado.";
            }

            // Adiciona informações das checkboxes
            resultado += $"\nExame feito: {(info.ExameFeito ? "Sim" : "Não")}. ";
            resultado += $"\nHistórico respiratório: {(info.HistoricoRespiratorio ? "Sim" : "Não")}. ";

            return Ok(resultado);
        }
    }
}