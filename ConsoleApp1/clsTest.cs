using System;
using System.Threading.Tasks;

public class Startup
{
    public async Task<object> Invoke(object input)
    {
        
        System.Diagnostics.Process p = new System.Diagnostics.Process();

        // 子プロセスの実行ファイル名
        p.StartInfo.FileName = "ConsoleApp1/bin/Debug/net5.0/ConsoleApp1";

        // 子プロセスのオプション（もしあれば）
        p.StartInfo.Arguments = "-n";

        // コンソール・ウィンドウを開かない
        p.StartInfo.CreateNoWindow = true;

        // シェル機能を使用しない
        p.StartInfo.UseShellExecute = false;

        // 標準出力をリダイレクト
        p.StartInfo.RedirectStandardOutput = true;

        // 標準入力をリダイレクト
        p.StartInfo.RedirectStandardInput = true;

        p.Start(); // 子プロセスの実行開始

        // 子プロセスの出力の読み込み
        string output2 = await p.StandardOutput.ReadToEndAsync();
            
        p.WaitForExit();

        // p.WaitForExitAsync(); // 子プロセスが終了するのを待つ　こっちだとエラーが出た
        p.Dispose(); // 子プロセスの破棄
       
        return output2;
    }		
}