using System.Collections.Generic;

namespace A.V.A_0._2
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
        public static IList<string> stopava = new List<string>()
        {
            "Durma",
            "Va Dormi",
            "Feche Se",
            "Pode Descansar Agora"
        };

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
        public static IList<string> RecStop = new List<string>()
        {
            "Para de me ouvir",
            "Silencio",
            "Fica Calada",
            "Fica Calado",
            "Fique Mudo",
            "Fique Muda",
            "Fique Surda",
            "Fique Surdo"
        };
        public static IList<string> RecReturn = new List<string>()
        {
            "AVA",
            "Ava Volte a me Ouvir",
            "Volte a me Ouvir",
            "Me Escute",
            "Ava Voce Estar ai",
            "Volte a Ouvir",
            "Volte a Falar",
            "Ola AVA"
        };

        public static IList<string> MudarVoz= new List<string>()
        {
            "Alterar Voz",
            "Mudar Voz",
            "Trocar Voz"
        };

        #endregion

        #region interface

        public static IList<string> Minimizar = new List<string>()
        {
            "Minimizar Janela",
            "Minimizar",
            "Minimize",
            "Minimizar Interface",
            "Diminuir janela",
            "Diminuir Interface",
            "Por Favor Minimize a Janela",
            "Por Favor Minimize a Interface"
        };

        public static IList<string> TamanhoNormal = new List<string>()
        {
            "Deixar a Janela em Tamanho Normal",
            "Deixar a Janela em Tamanho Normal",
            "Tamanho Normal",
            "Normalizar Janela",
            "Por Favor Deixe a Janela em Tamanho Normal",
            "Por Favor  Deixe a Interface em Tamanho Normal"
        };
        public static IList<string> Maximizar = new List<string>()
        {
            "Maximizar Janela",
            "Maximizar",
            "Maximize",
            "Maximizar Interface",
            "Aumentar janela",
            "Aumentar Interface",
            "Por Favor Maximizar a Janela",
            "Por Favor Maximizar a Interface"
        };
        public static IList<string> SegundoPlano = new List<string>()
        {
            "Janela em Segundo Plano",
            "Interface em Segundo Plano",
            "Ocultar Janela",
            "Ocultar Interface",
            "Esconder Janela",
            "Esconder Interface",
            "Por Favor Ocultar a Janela",
            "Por Favor Ocultar a Interface",
            "Por Favor Esconder a Interface",
            "Por Favor Esconder a Janela",
            "Por Favor Deixar a Interface em Segundo Plano",
            "Por Favor Deixar a Janela em Segundo Plano"
        };
        public static IList<string> PrimeiroPlano = new List<string>()
        {
            "Janela em Primeiro Plano",
            "Interface em Primeiro Plano",
            "Mostrar Janela",
            "Mostrar Interface",
            "Por Favor Mostre a Janela",
            "Por Favor Mostre a Interface",
            "Por Favor Deixar a Interface em Primeiro Plano",
            "Por Favor Deixar a Janela em Primeiro Plano"
        };

        #endregion

        #region abrir programas
        public static IList<string> Chrome = new List<string>()
        {
            "Abrir Google",
            "Abrir Navegador",
            "Abrir Chrome",
            "Abra o Google",
            "Abra o Navegador"
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
            "Documentos",
            "Pasta Documentos"
        };
        public static IList<string> OpenVideos = new List<string>()
        {
            "Abrir Videos",
            "Abrir Meus Videos",
            "Abra o Videos",
            "Abra o Meus Videos",
            "Videos",
            "Pasta Videos"
        };
        public static IList<string> OpenImagens = new List<string>()
        {
            "Abrir Imagens",
            "Abrir Minhas Imagens",
            "Abra o Imagens",
            "Abra o Minhas Imagens",
            "Imagens",
            "Pasta Imagens"
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
            "Downloads",
            "Pasta Downloads"
        };
        public static IList<string> OpenDesktop= new List<string>()
        {
            "Abrir Desktop",
            "Abrir o Desktop",
            "Abra o Desktop",
            "Abra  Desktop",
            "Desktop",
            "Pasta Desktop"
        };
        public static IList<string> OpenAppData = new List<string>()
        {
            "Abrir AppData",
            "Abrir o AppData",
            "Abra o AppData",
            "Abra  AppData",
            "Pasta AppData"
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

        #region Sites
        public static IList<string> Youtube = new List<string>()
        {
            "Abrir Youtube",
            "Por Favor Abra o Youtube",
            "Abra o Youtube",
            "Youtube"
        };
        public static IList<string> Twitch = new List<string>()
        {
            "Abrir Tuiti",
            "Por Favor Abra o Tuiti",
            "Abra o Tuiti",
            "Tuiti"
        };
        public static IList<string> Facebook = new List<string>()
        {
            "Abrir Facebook",
            "Por Favor Abra o Facebook",
            "Abra o Facebook",
            "Facebook"
        };
        public static IList<string> Wikipedia = new List<string>()
        {
            "Abrir Wikipédia",
            "Por Favor Abra o Wikipédia",
            "Abra o Wikipédia",
            "Wikipédia"
        };
        public static IList<string> Instagram = new List<string>()
        {
            "Abrir Instagram",
            "Por Favor Abra o Instagram",
            "Abra o Instagram",
            "Instagram"
        };
        public static IList<string> whatsapp = new List<string>()
        {
            "Abrir Uatizape",
            "Por Favor Abra o Uatizape",
            "Abra o Uatizape",
            "Uatizape"
        };
        public static IList<string> twitter = new List<string>()
        {
            "Abrir Tuiter",
            "Por Favor Abra o Tuiter",
            "Abra o Tuiter",
            "Tuiter"
        };
        public static IList<string> Netflix = new List<string>()
        {
            "Abrir Netflix",
            "Por Favor Abra o Netflix",
            "Abra o Netflix",
            "Netflix"
        };
        public static IList<string> Amazon = new List<string>()
        {
            "Abrir Amazon",
            "Por Favor Abra o Amazon",
            "Abra o Amazon",
            "Amazon"
        };
        #endregion

    }
}


