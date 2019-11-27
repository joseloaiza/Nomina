namespace Payroll.Models.Common
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string ReturnMessage { get; set; }
        public T Data { get; set; }
    }
}

