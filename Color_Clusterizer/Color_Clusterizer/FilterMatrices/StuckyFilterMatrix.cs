namespace Color_Clusterizer.FilterMatrices
{
    class StuckyFilterMatrix : FilterMatrix
    {
        public StuckyFilterMatrix() : base(2, 2)
        {
            Weights[0, 0] = 0f;
            Weights[0, 1] = 0f;
            Weights[0, 2] = 0f;
            Weights[0, 3] = 0f;
            Weights[0, 4] = 0f;
            Weights[1, 0] = 0f;
            Weights[1, 1] = 0f;
            Weights[1, 2] = 0f;
            Weights[1, 3] = 0f;
            Weights[1, 4] = 0f;
            Weights[2, 0] = 0f;
            Weights[2, 1] = 0f;
            Weights[2, 2] = 0f;
            Weights[2, 3] = 8f / 42;
            Weights[2, 4] = 4f / 42;
            Weights[3, 0] = 2f / 42;
            Weights[3, 1] = 4f / 42;
            Weights[3, 2] = 8f / 42;
            Weights[3, 3] = 4f / 42;
            Weights[3, 4] = 2f / 42;
            Weights[4, 0] = 1f / 42;
            Weights[4, 1] = 2f / 42;
            Weights[4, 2] = 4f / 42;
            Weights[4, 3] = 2f / 42;
            Weights[4, 4] = 1f / 42;
        }
    }
}
