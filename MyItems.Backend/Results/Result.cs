﻿namespace MyItems.Backend.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; }
        public string Message { get; } = null!;
    }
}
