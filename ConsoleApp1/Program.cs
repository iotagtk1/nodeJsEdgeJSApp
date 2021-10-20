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
            
            // RestAPIから情報取得のためにアクセスする、e-StatのURLです(XML用)
            client.BaseUrl = new Uri("http://api.e-stat.go.jp/rest/3.0/app/getStatsData");

            // RestAPIから情報取得のためにアクセスする、e-StatのURLです(json用) 
            //client.BaseUrl = new Uri("http://api.e-stat.go.jp/rest/3.0/app/json/getStatsData");

            // HTTPのコマンドを指定します、情報の取得なので GET を指定します
            request.Method = Method.GET;

            // e-Statで取得した appID をパラメータとして追加します
            request.AddParameter("appId", "*** 取得したappidを記載する ***", ParameterType.GetOrPost);

            // e-Statの統計表表示 ID (取得した統計表の番号) をパラメータとして追加します
            request.AddParameter("statsDataId", "0003412317", ParameterType.GetOrPost);

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