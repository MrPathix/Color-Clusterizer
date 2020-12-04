namespace Color_Clusterizer.FilterMatrices
{
    class BurkesFilterMatrix : FilterMatrix
    {
        public BurkesFilterMatrix() : base(1, 2)
        {
            Weights[0, 0] = 0f;
            Weights[0, 1] = 0f;
            Weights[0, 2] = 0f;
            Weights[0, 3] = 0f;
            Weights[0, 4] = 0f;
            Weights[1, 0] = 0f;
            Weights[1, 1] = 0f;
            Weights[1, 2] = 0f;
            Weights[1, 3] = 8f / 32;
            Weights[1, 4] = 4f / 32;
            Weights[2, 0] = 2f / 32;
            Weights[2, 1] = 4f / 32;
            Weights[2, 2] = 8f / 32;
            Weights[2, 3] = 4f / 32;
            Weights[2, 4] = 2f / 32;
        }
    }
}
