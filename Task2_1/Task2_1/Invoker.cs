namespace Task2_1
{
    class Invoker
    {
        static Invoker invoker;
        public ICommand Command { private get; set; }
        
        private Invoker()
        {

        }
        public static Invoker Log()
        {
            if(invoker == null)
            {
                return new Invoker();
            }
            return invoker;
        }
        public void StartCommand()
        {
            Command.Execute();
        }
    }
}
