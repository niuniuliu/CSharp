using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         // Output text to the screen.
    //         Console.WriteLine("The first app in Beginning C# Programming!");
    //         Console.ReadKey();
    //     }
    // }



// CommandLine 　　　 获取该进程的命令行。
// CurrentDirectory    　　获取或设置当前工作目录的完全限定路径。
// ExitCode    　　　　　　获取或设置进程的退出代码。
// HasShutdownStarted  　　获取一个值，该值指示公共语言运行时 (CLR) 是否正在关闭。
// Is64BitOperatingSystem  确定当前操作系统是否为 64 位操作系统。
// Is64BitProcess  　　　确定当前进程是否为 64 位进程。
// MachineName 　　　  获取此本地计算机的 NetBIOS 名称。
// NewLine 　　　　　　 获取为此环境定义的换行字符串。
// OSVersion   　　　　   获取包含当前平台标识符和版本号的 OperatingSystem 对象。
// ProcessorCount  　　 获取当前计算机上的处理器数。
// StackTrace  　　　　  获取当前的堆栈跟踪信息。
// SystemDirectory 　　获取系统目录的完全限定路径。
// SystemPageSize  　　获取操作系统的页面文件的内存量。
// TickCount   　　　　　 获取系统启动后经过的毫秒数。
// UserDomainName  　　获取与当前用户关联的网络域名。
// UserInteractive 　　　 获取一个值，用以指示当前进程是否在用户交互模式中运行。
// UserName    　　　　　　获取当前已登录到 Windows 操作系统的人员的用户名。
// Version 　　　　　　    获取一个 Version 对象，该对象描述公共语言运行时的主版本、次版本、内部版本和修订号。
// WorkingSet  　　　　　获取映射到进程上下文的物理内存量。

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.WorkingSet);  //输出 15806464

            Version version = Environment.Version;
            Console.WriteLine(version.Build);   //输出 30319
            Console.WriteLine(Environment.UserName);    //输出 Administrator  获取当前Windows系统的用户名
            Console.WriteLine(Environment.UserInteractive);     //输出 True 获取一个值，用以指示当前进程是否在用户交互模式中运行。
            Console.WriteLine(Environment.UserDomainName);  //输出 KISSDODOG-PC 获取与当前用户关联的网络域名。
            Console.WriteLine(Environment.TickCount);   //输出 33445319 系统启动后经过的毫秒数
            Console.WriteLine(Environment.TickCount / 1000 / 60);   //我靠，启动了558分钟了
            Console.WriteLine(Environment.SystemPageSize);   //输出 4096 获取操作系统的页面文件的内存量(单位字节)。
            Console.WriteLine(Environment.SystemDirectory);  //输出 C:\Windows\system32 获取系统目录的完全限定路径。
            Console.WriteLine(Environment.StackTrace);    //输出 跟错误信息差不多，都是在xxx位置，等等这些信息，目前还看不懂 获取当前的堆栈跟踪信息。
            Console.WriteLine(Environment.ProcessorCount);  //输出 2 输出当前计算机的CPU内核数 双核，没错
            

            OperatingSystem os = Environment.OSVersion;
            Console.WriteLine(os);   //输出    获取包含当前操作系统平台标识符和版本号的 OperatingSystem 对象。

            Console.WriteLine(Environment.NewLine);     //输出 换行符 获取为此环境定义的换行字符串。
            Console.WriteLine(Environment.MachineName); //输出 KISSDODOG-PC 获取此本地计算机的 NetBIOS 名称。

            Console.WriteLine(Environment.Is64BitOperatingSystem);  //输出 False 确定当前操作系统是否为 64 位操作系统。
            Console.WriteLine(Environment.Is64BitProcess);   //输出 False 确定当前进程是否为 64 位进程。

            Console.WriteLine(Environment.HasShutdownStarted);  //输出 False 指示公共语言运行时CLR是否正在关闭

            Console.WriteLine(Environment.ExitCode);    //输出 0 获取或设置进程的退出代码。

            Console.WriteLine(Environment.CurrentDirectory);     //输出 C:\Users\Administrator\Desktop\ConsoleApplication1\ConsoleApplication1\bin\Debug 获取或设置当前工作目录的完全限定路径。

            Console.WriteLine(Environment.CommandLine);     //输出 "C:\Users\Administrator\Desktop\ConsoleApplication1\ConsoleApplication1\bin\Debug\ConsoleApplication1.vshost.exe" 获取该进程的命令行

            // File.WriteAllText(@"D:\123.txt", Environment.CommandLine);  //输出 Microsoft Windows NT 6.1.7600.0


            Console.ReadKey();
        }
    }
}
