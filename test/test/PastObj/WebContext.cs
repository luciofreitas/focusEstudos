using System;
using System.IO;
using System.Net;


namespace test.PastObj
{
    public class WebContext
    {
        public static string GET(string url)
        {
            try
            {
                var requisicaoWeb = WebRequest.CreateHttp(url);
                requisicaoWeb.Method = "GET";
                requisicaoWeb.Accept = "application/json";

                var respostaRequisicaoWeb = (HttpWebResponse)requisicaoWeb.GetResponse();
                using (var sr = new StreamReader(respostaRequisicaoWeb.GetResponseStream()))
                {
                    var resultado = sr.ReadToEnd();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}