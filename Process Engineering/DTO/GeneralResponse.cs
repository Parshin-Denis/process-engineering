namespace Process_Engineering.DTO
{
    internal class GeneralResponse<T>
    {
        public bool isResultOK { get; set; } = false;

        public string message { get; set; }

        public T data { get; set; }

        public GeneralResponse() { }

        public GeneralResponse(bool isResultOK, string message, T data)
        {
            this.isResultOK = isResultOK;
            this.message = message;
            this.data = data;
        }

        public GeneralResponse(bool isResultOK, string message)
        {
            this.isResultOK = isResultOK;
            this.message = message;
        }
    }

}
