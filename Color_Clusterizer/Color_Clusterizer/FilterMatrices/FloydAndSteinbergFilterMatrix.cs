namespace Color_Reducer.FilterMatrices
{
    class FloydAndSteinbergFilterMatrix : FilterMatrix
    {
        public FloydAndSteinbergFilterMatrix() : base(1, 1)
        {
            Weights[0, 0] = 0f;
            Weights[0, 1] = 0f;
            Weights[0, 2] = 0f;
            Weights[1, 0] = 0f;
            Weights[1, 1] = 0f;
            Weights[1, 2] = 7f / 16;
            Weights[2, 0] = 3f / 16;
            Weights[2, 1] = 5f / 16;
            Weights[2, 2] = 1f / 16;
        }
    }
}
