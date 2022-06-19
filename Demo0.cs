//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    public class Demo0
//    {
//        static async Task Main(string[] args)
//        {
//            //Console.WriteLine(await GetTaskTString());
//            //await PrintTaskString();
//            //PrintVoidString();//cant be awaited
//            //Console.Read();

//            ////output:
//            //Enter GetTaskTString
//            //GetTaskTString
//            //Enter PrintTaskString
//            //PrintTaskString
//            //Enter PrintVoidString
//            //PrintVoidString

//            Console.WriteLine(GetTaskTString());
//            PrintTaskString();//Because this call is not awaited, execution of the current method continues before the call is completed
//            PrintVoidString();//cant be awaited
//            Console.Read();
//        }

//        static async Task<string> GetTaskTString()
//        {
//            Console.WriteLine("Enter GetTaskTString");
//            Thread.Sleep(10000);
//            return await Task.Run(() => "GetTaskTString");
//        }
//        static async Task PrintTaskString()
//        {
//            Console.WriteLine("Enter PrintTaskString");
//            Thread.Sleep(10000);
//            await Task.Run(() => Console.WriteLine("PrintTaskString"));
//        }
//        static async void PrintVoidString()
//        {
//            Console.WriteLine("Enter PrintVoidString");
//            Thread.Sleep(10000);
//            await Task.Run(() => Console.WriteLine("PrintVoidString"));
//        }
//    }
//}
