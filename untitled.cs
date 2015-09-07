首先我们来写一个C#调用powershell的公共方法
 
需要引用：System.Management.Automation.dll
 
此dll一般装上powershell 的sdk就可以找到
 
我这里直接放到源码里了。。
 
折叠展开C# 代码

 using System.Management;   
 using System.Management.Automation;   
 using System.Management.Automation.Runspaces;  

执行脚本代码如下：
 
折叠展开C# 代码
// <summary>   
      /// PowerShell脚本基础   
      /// </summary>   
      public static class PowerShell   
      {   
          /// <summary>   
          /// 运行脚本信息,返回脚本输出   
          /// </summary>   
          /// <param name="scriptText"& gt;需要运行的脚本</param>   
          /// <returns>output of the script</returns>   
          public static string RunScript(List<string> scripts,List<PSParam> pars)   
          {   
              Runspace runspace = RunspaceFactory.CreateRunspace();   
    
              runspace.Open();   
    
              Pipeline pipeline = runspace.CreatePipeline();   
              foreach (var scr in scripts)   
              {   
                  pipeline.Commands.AddScript(scr);   
              }   
    
              //注入参数   
              if (pars != null)   
              {   
                  foreach (var par in pars)   
                  {   
                      runspace.SessionStateProxy.SetVariable(par.Key,par.Value);   
                  }   
              }   
    
              //返回结果   
              var results = pipeline.Invoke();   
              runspace.Close();   
              StringBuilder stringBuilder = new StringBuilder();   
              foreach (PSObject obj in results)   
              {   
                  stringBuilder.AppendLine(obj.ToString());   
              }   
              return stringBuilder.ToString();   
          }   
      }   
    
      /// <summary>   
      /// 脚本参数   
      /// </summary>   
      public class PSParam   
      {   
          public string Key   
          {   
              get;   
              set;   
          }   
    
          public object Value   
          {   
              get;   
              set;   
          }   
      }  

 
这句为注入脚本一个.net对象：runspace.SessionStateProxy.SetVariable(par.Key,par.Value);   
 
这样在powershell脚本中就可以直接通过$key访问和操作这个对象
 
下面来看调用实例:
 
定义一个.net对象，以便powershell中调用：
折叠展开C# 代码

 class info   
     {   
         public int x { get; set; }   
         public int y { get; set; }   
         public int z { get; set; }   
     }  

实例化一个对象psobj。。就是上面定义的info
 
给x,y赋值
然后把此对象传给powershell脚本，，参数标识写做arg
 
折叠展开C# 代码
 static void Main(string[] args)   
         {   
             List<string> ps = new List<string>();   
             ps.Add("Set-ExecutionPolicy RemoteSigned");//先执行启动安全策略，，使系统可以执行powershell脚本文件   
   
             string pspath = System.IO.Path.Combine(Environment.CurrentDirectory,"ps.ps1");   
   
             ps.Add(pspath);// 执行脚本文件   
   
             info psobj = new info();   
             psobj.x = 20;   
             psobj.y = 10;   
   
             BaseCommon.PSParam par=new BaseCommon.PSParam();   
             par.Key="arg";   
             par.Value=psobj;   
   
             BaseCommon.PowerShell.RunScript(ps, new List<BaseCommon.PSParam>() { par });   
   
             Console.WriteLine(psobj.x + " + " + psobj.y + " = " + psobj.z);   
   
             Console.ReadLine();   
         }  

 
接下来就看写一个简单的powershell脚本来操作.net实例了
 

   $a=$arg.x   
   $b=$arg.y   
   $arg.z=$a+$b  

 
其中$arg就表示上面注入的psobj对象。。标识为arg
 
把此脚本存在此程序的bin\debug目录下。文件名为：ps.ps1，，就可以执行程　序看结果：
 
10+20=30
 
此结果由powershell脚本返回

源码下载：http://www.jiamaocode.com/Cts/1193.shtml
更多 0