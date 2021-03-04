//1    
static void Main(string[] args)
        {
        //exception will not be caught
             try
            {
                CallMethods().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async Task CallMethods()
        {
            await Method1();
            Method2();
            await Method3();
        }

        private static async Task<string> Method1()
        {
            await Task.Delay(5000);
            return "method1";
        }
        private static async Task<string> Method2()
        {
            await Task.Delay(7000);
            throw new Exception("method2 exc");
            return "method2";
        }
        private static async Task<string> Method3()
        {
            await Task.Delay(9000);
            return "method3";
        }

//2 method1 printed first and then success
static void Main(string[] args)
        {
            CallMethods().GetAwaiter().GetResult();
        }
        private static async Task CallMethods()
        {
            Console.WriteLine(await Method1());
            Console.WriteLine("success");
        }
        private static async Task<string> Method1()
        {
            await Task.Delay(5000);
            return "method1";
        }

//3 output of line 62 System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`
  static void Main(string[] args)
        {
            CallMethods().GetAwaiter().GetResult();
        }
        private static async Task CallMethods()
        {
            Console.WriteLine(Method1());//this is the change
            Console.WriteLine("success");
        }
        private static async Task<string> Method1()
        {
            await Task.Delay(500);
            return "method1";
        }
