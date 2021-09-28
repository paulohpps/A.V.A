using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using SHDocVw;
using System.IO;

namespace A.V.A_0._2
{
    class resp
    {

        #region comandos de tempo
        public static void horas()
        {
            speaker.speak("Agora São Exatamente: " + DateTime.Now.ToShortTimeString());
        }
        public static void data()
        {
            speaker.speak("A Data de Hoje é: " + DateTime.Now.ToShortDateString());
        }
        #endregion

        #region abrir programas
        public static void chrome()
        {
            try
            {
                Process.Start(@"https://www.google.com/");
                speaker.speak("O Google foi aberto");
            }
            catch
            {
                speaker.speak("Não foi Possivel Abrir Esse Programa, Verifique se Ele Está Realmente Instalado em seu Computador");
            }
        }
        public static void notepad()
        {
            try
            {
                Process.Start("notepad.exe");
                speaker.speak("O Bloco de Notas foi Aberto");
            }
            catch
            {
                speaker.speak("Não foi Possivel Abrir Esse Programa, Verifique se Ele Está Realmente Instalado em seu Computador");
            }
        }

        public static void steam()
        {
            try
            {
                Process.Start("steam.exe");
                speaker.speak("O laucher da Steam foi Aberto");
            }
            catch
            {
                speaker.speak("Não foi Possivel Abrir Esse Programa, Verifique se Ele Está Realmente Instalado em seu Computador");
            }
        }
        public static void explorer()
        {
            try
            {
                Process.Start("explorer.exe");
                speaker.speak("O Windows Explorer foi Aberto");
            }
            catch
            {
                speaker.speak("Não foi Possivel Abrir Esse Programa, Verifique se Ele Está Realmente Instalado em seu Computador");
            }
        }
        public static void cmd()
        {
            try
            {
                Process.Start("cmd.exe");
                speaker.speak("O Prompt de Comando foi Aberto");
            }
            catch
            {
                speaker.speak("Não foi Possivel Abrir Esse Programa, Verifique se Ele Está Realmente Instalado em seu Computador");
            }
        }
        public static void Discord()
        {
            speaker.speak("Função Indiponivel");
        }
        public static void OpenDocuments()
        {
            try
            {
                String diretorio = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Process.Start("explorer.exe", diretorio);
                speaker.speak("A Pasta Documentos foi aberta");
            }
            catch
            {
                speaker.speak("Não foi Possivel essa pasta");
            }
        }
        public static void OpenImages()
        {
            try
            {
                String diretorio = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                Process.Start("explorer.exe", diretorio);
                speaker.speak("A Pasta Imagens Foi Aberta");
            }
            catch
            {
                speaker.speak("Não foi Possivel essa pasta");
            }
        }
        public static void OpenVideos()
        {
            try
            {
                String diretorio = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                Process.Start("explorer.exe", diretorio);
                speaker.speak("A Pasta Videos foi Aberta");
            }
            catch
            {
                speaker.speak("Não foi Possivel essa pasta");
            }
        }
        public static void OpenDesktop()
        {
            try
            { 
                String diretorio = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Process.Start("explorer.exe", diretorio);
                speaker.speak("A Pasta da Desktop foi Aberta");
            }
            catch
            {
                speaker.speak("Não foi Possivel essa pasta");
            }
        }
        public static void OpenAppData()
        {
            try
            {
                String diretorio = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                Process.Start("explorer.exe", diretorio);
                speaker.speak("A Pasta App Data foi Aberta");
            }
            catch
            {
                speaker.speak("Não foi Possivel essa pasta");
            }
        }

        public static void OpenDownload()
        {
            try
            {
                Process.Start("shell:Downloads");
                speaker.speak("A Pasta Downloads foi Aberta");
            }
            catch
            {
                speaker.speak("Não foi Possivel essa pasta");
            }
        }

        #endregion

        #region sites
        public static void Youtube()
        {
            Process.Start(@"https://www.youtube.com/");
            speaker.speak("O Youtube foi Aberto");
        }
        public static void Twitch()
        {
            Process.Start(@"https://www.twitch.tv/");
            speaker.speak("A Twitch foi Aberta");
        }
        public static void Facebook()
        {
            Process.Start(@"https://www.facebook.com/");
            speaker.speak("O Facebook foi Aberto");
        }
        public static void Wikipedia()
        {
            Process.Start(@"https://pt.wikipedia.org/");
            speaker.speak("A Wikipedia foi Aberta");
        }
        public static void Instagram()
        {
            Process.Start(@"https://www.instagram.com/");
            speaker.speak("O Instagram foi Aberto");
        }
        public static void whatsapp()
        {
            Process.Start(@"https://web.whatsapp.com/");
            speaker.speak("O Whatsapp foi Aberto");
        }
        public static void twitter()
        {
            Process.Start(@"https://twitter.com/");
            speaker.speak("O Twitter foi Aberto");
        }
        public static void Netflix()
        {
            Process.Start(@"https://www.netflix.com/");
            speaker.speak("O Netflix foi Aberto");
        }
        public static void Amazon()
        {
            Process.Start(@"https://www.amazon.com.br/");
            speaker.speak("A Amazon foi Aberta");
        }


        #endregion

        #region fechar programas
        public static void chromestop()
        {
            var processes = Process.GetProcessesByName("chrome");
            foreach (var p in processes)
                p.CloseMainWindow();
            speaker.speak("O Google Chrome foi Fechado");
        }
        public static void notestop()
        {

            var processes = Process.GetProcessesByName("notepad");
            foreach (var p in processes)
                p.CloseMainWindow();
            speaker.speak("O Bloco de Notas foi Fechado");

        }
        public static void ExploreStop()
        {
            ShellWindows _shellWindows = new SHDocVw.ShellWindows();
            string processType;

            foreach (InternetExplorer ie in _shellWindows)
            {
                //this parses the name of the process
                processType = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();

                //this could also be used for IE windows with processType of "iexplore"             caminho especifico a ser fechado
                if (processType.Equals("explorer"))                                          //&& ie.LocationURL.Contains(@"C:/Users/Bob"))
                {
                    ie.Quit();
                }
            }
            speaker.speak("O Windows Explire foi Fechado");
        }
        public static void discordstop()
        {
            var processes = Process.GetProcessesByName("discord");
            foreach (var p in processes)
                p.CloseMainWindow();
            speaker.speak("O Discord foi Fechado");
        }
        #endregion
    }
}
