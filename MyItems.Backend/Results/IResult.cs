﻿namespace MyItems.Backend.Results
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}
