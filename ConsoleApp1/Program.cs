using System;
using System.Diagnostics;
using System.Threading;
using RestSharp;

namespace ConsoleApp1
{
    class Program
    {
        
        private static Timer MyTimer;
        static void Main(string[] args)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest();
            
            // RestAPIから情報取得のためにアクセスする、e-StatのURLです(json用) 
            client.BaseUrl = new Uri("http://api.e-stat.go.jp/rest/3.0/app/json/getStatsData");

            // HTTPのコマンドを指定します、情報の取得なので GET を指定します
            request.Method = Method.GET;

            // リクエストを送信します
            var response = client.Execute(request);

            //Thread.Sleep(1000);  
            Console.WriteLine("--------111-----------------" + response.Content );
            // Thread.Sleep(1000);
            Console.WriteLine("--------222-----------------" + request.ToString());
            // Thread.Sleep(2000);
            
            Console.WriteLine("--------333-----------------");
        }
    }
}