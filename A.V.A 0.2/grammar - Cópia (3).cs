using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;

namespace Assistente_Virtual
{
    public static class grammar
    {
        #region comandos de tempo
        public static IList<string> Horas = new List<string>()
        {
            "Que Horas são",
            "Me Diga as Horas",
            "Me Informe as Horas",
            "Poderia me Falar as Horas",
            "Por Favor me Diga as Horas",
            "Por Favor me Fale as Horas"
        };
        public static IList<string> Data = new List<string>()
        {
            "Qual a Data de Hoje",
            "Me Diga a Data",
            "Me Informe a Data",
            "Poderia me Falar a Data",
            "Por Favor me Diga a Data",
            "Por Favor me Fale a Data"
        };
        #endregion

        #region OutroComandos

        public static IList<string> CpuUso = new List<string>()
        {
            "Uso de CPU",
            "Me Diga o Uso de CPU",
            "Me Informe o Uso De CPU",
            "Por Favor me Diga o Uso de CPU",
            "Por Favor me Fale o Uso de CPU",
            "Uso do Processador",
            "Me Diga o Uso do Processador",
            "Me Informe o Uso do Processador",
            "Por Favor me Diga o Uso do Processador",
            "Por Favor me Fale o Uso do Processador"
        };

        public static IList<string> RAMUso = new List<string>()
        {
            "Uso de RAM",
            "Me Diga o Uso de RAM",
            "Me Informe o Uso De RAM",
            "Por Favor me Diga o Uso de RAM",
            "Por Favor me Fale o Uso de RAM",
            "Uso de Memoria RAM",
            "Me Diga o Uso de Memoria RAM",
            "Me Informe o Uso de Memoria RAM",
            "Por Favor me Diga o Uso de Memoria RAM",
            "Por Favor me Fale o Uso de Memoria RAM",
            "Uso de Memoria",
            "Me Diga o Uso de Memoria",
            "Me Informe o Uso de Memoria",
            "Por Favor me Diga o Uso de Memoria",
            "Por Favor me Fale o Uso de Memoria"
        };
        public static IList<string> StatusGerais = new List<string>()
        {
            "Status Gerais de Uso",
            "Status de Uso",
            "Me Diga o Status de Uso",
            "Me Informe o Status Uso",
            "Por Favor me Diga o Status de Uso",
            "Por Favor me Fale o Status de Uso",
            "Informações de Uso",
            "Me Diga as Informações de Uso",
            "Me Informe as Informações de Uso",
            "Por Favor me Diga as Informações de Uso",
            "Por Favor me Fale as Informações de Uso"
        };

        #endregion

        #region abrir programas
        public static IList<string> Chrome = new List<string>()
        {
            "Abrir Google",
            "Abrir Google Chrome",
            "Abrir Chrome",
            "Abra o Google",
            "Abra o Chrome",
            "Abra o Google Chrome",
        };
        public static IList<string> Notepad = new List<string>()
        {
            "Abrir Bloco de Nota",
            "Abrir Notepad",
            "Abra o Bloco de Notas",
            "Abra o Notepad"
        };
        public static IList<string> Steam = new List<string>()
        {
            "Abrir Steam",
            "Abra a Steam"
        };
        public static IList<string> Explorer = new List<string>()
        {
            "Abrir Windows Explorer",
            "Abrir Explorer",
            "Abrir Gerenciador de Arquivos",
            "Abra o Windows Explorer",
            "Abra o Explorer",
            "Abra o Gerenciador de Arquivos"
        };

        public static IList<string> Cmd = new List<string>()
        {
            "Abrir Cmd",
            "Abrir Prompt",
            "Abrir Prompt de Comando",
            "Abra o Cmd",
            "Abra o Prompt",
            "Abra o Prompt de Comando"
        };
        public static IList<string> OpenDocuments = new List<string>()
        {
            "Abrir Documentos",
            "Abrir Meus Documentos",
            "Abra o Documentos",
            "Abra o Meus Documentos",
            "Documentos"
        };
        public static IList<string> OpenVideos = new List<string>()
        {
            "Abrir Videos",
            "Abrir Meus Videos",
            "Abra o Videos",
            "Abra o Meus Videos",
            "Videos"
        };
        public static IList<string> OpenImagens = new List<string>()
        {
            "Abrir Imagens",
            "Abrir Minhas Imagens",
            "Abra o Imagens",
            "Abra o Minhas Imagens",
            "Imagens"
        };
        public static IList<string> Discord = new List<string>()
        {
            "Abrir Discord",
            "Abrir o Discord",
            "Abra o Discord",
            "Abra Discord"
        };
        public static IList<string> OpenDownloads = new List<string>()
        {
            "Abrir Downloads",
            "Abrir o Downloads",
            "Abra o Downloads",
            "Abra  Downloads",
            "Downloads"
        };
 

        #endregion

        #region fechar programas
        public static IList<string> ChromeStop = new List<string>()
        {
            "Fechar Google",
            "Fechar Google Chrome",
            "Fechar Chrome",
            "Fechar Navegador",
            "Feche o Google",
            "Feche o Chrome",
            "Feche o Google Chrome",
            "Feche o Navegador"
        };
        public static IList<string> NotaPadStop = new List<string>()
        {
            "Fechar Bloco de Notas",
            "Fechar Notepad",
            "Feche o Bloco de Notas",
            "Feche o Notepad"
        };
        public static IList<string> CmdStop = new List<string>()
        {
            "Fechar Cmd",
            "Fechar Prompt",
            "Feche o Prompt de Comando",
            "Feche o Cmd"
        };
        public static IList<string> DiscordStop = new List<string>()
        {
            "Fechar Discord",
            "Feche o Discord",
            "Feche o Discordo",
            "Feche a discordia"
        };
        public static IList<string> ExploreStop = new List<string>()
        {
            "Fechar Windows Explorer",
            "Fechar Explorer",
            "Fechar Gerenciador de Arquivos",
            "Fecha o Windows Explorer",
            "Fecha o Explorer",
            "Fecha o Gerenciador de Arquivos"
        };


        #endregion
    }
}
