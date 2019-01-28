﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;


namespace TranslatorWPF.ClassLibrary
{
    class Translator
    {
        private String API_LINK = "https://translate.yandex.net/api/v1.5/tr.json/translate?key="; 

        public Translator()
        {
            API_LINK += Settings.API_KEY;
        }

        public String Translate( String textToTranslate, String choosenLanguage)
        {
            String encodedText = HttpUtility.UrlEncode(textToTranslate);
            String link = API_LINK + "&text=" + encodedText + "&lang=" + choosenLanguage;

            Console.WriteLine(TranslateRequest(link));
            return "sdsa";
        }

        private String TranslateRequest(String url)
        {
            String translatedText = null;

            try
            {
                WebClient client = new WebClient();
                Byte[] pageData = client.DownloadData(url);
                String xmlResponse = Encoding.ASCII.GetString(pageData);

                translatedText = xmlResponse;
            }
            catch (WebException webEx)
            {
                Console.WriteLine(webEx.ToString());
                if (webEx.Status == WebExceptionStatus.ConnectFailure)
                {
                    Console.WriteLine("Najprawdopodobniej zapora systemowa zakłóciła działanie programu");
                }
            }

            return translatedText;
        }
    }
}