namespace Model.ReturnMessageModel
{
    public class ReturnMessageModel
    {
        public ReturnMessageCode Code { get; set; }

        public string Message { get; set; } = "";
    }

    public enum ReturnMessageCode
    {
        Success = 1,
        Fail = 2,
        SystemError = 3
    }
}