// Course: PROG 1103 – Spring 2026
// Project: HW3
// Team Name: Eddie the Eagle
// Names: Brandon Shook, Tyler

namespace HW3Calculator
{
    /// <summary>
    /// This record tracks the calculator's current state. 
    /// It handles the numbers typed, the math operation, and the memory bank.
    /// </summary>
    public record CalculatorState
    {
        public string CurrentInput { get; init; } = "";
        public double Result { get; init; } = 0;
        public string Operation { get; init; } = "";
        public bool OperationPending { get; init; } = false;
        public double Memory { get; init; } = 0;
    }
}