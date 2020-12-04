namespace Color_Reducer.FilterMatrices
{
    public abstract class FilterMatrix
    {
        public int Rows { get; }
        public int Cols { get; }
        protected float[,] Weights { get; set; }
        public float this[int i, int j]
        {
            get => Weights[i, j];
        }

        public FilterMatrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            Weights = new float[2 * Rows + 1, 2 * Cols + 1];
        }
    }
}
