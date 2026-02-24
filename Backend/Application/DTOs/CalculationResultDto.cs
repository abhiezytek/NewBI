using System;

namespace Backend.Application.DTOs
{
    public class CalculationResultDto
    {
        public string Result { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }

        public CalculationResultDto(string result, string status)
        {
            Result = result;
            Status = status;
            Timestamp = DateTime.UtcNow;
        }
    }
}