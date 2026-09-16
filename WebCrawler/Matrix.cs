using System;
namespace Mat
{
	public class Matrix
	{
		int m_iRows;
		int m_iCols;
		int[,] m_iElement;
//.................................................................................................................
        public Matrix(int iRows, int iCols)
		{
			m_iRows=iRows;
			m_iCols=iCols;
			m_iElement=new int[iRows,iCols];
		}
//.................................................................................................................
		public int Rows
		{
			get	{ return m_iRows; }
		}
//.................................................................................................................
	    public int Cols
		{
			get	{ return m_iCols; }
		}
//.................................................................................................................
		public int this[int iRow, int iCol]		
		{
			get	{ return GetElement(iRow,iCol);	}
			set	{ SetElement(iRow,iCol,value);	}
		}
//.................................................................................................................
        private int GetElement(int iRow, int iCol)
		{
				if ( iRow<0 || iRow>Rows-1 || iCol<0 || iCol>Cols-1 )
					throw new MatrixException("Invalid index specified");
				return m_iElement[iRow,iCol];
		}
//.................................................................................................................
        private void SetElement(int iRow, int iCol, int value)
		{
				if ( iRow<0 || iRow>Rows-1 || iCol<0 || iCol>Cols-1 )
					throw new MatrixException("Invalid index specified");
				m_iElement[iRow,iCol]=value;
		}
//.................................................................................................................
	    public static Matrix NullMatrix(int iRows, int iCols)
        {
            int temp = new int();
            Matrix matrix = new Matrix(iRows, iCols);
            for (int i = 0; i < iRows; i++)
                for (int j = 0; j < iCols; j++)
                    matrix[i, j] = temp;
            return matrix;
        }
//.................................................................................................................
	    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
		{	return Matrix.Multiply(matrix1, matrix2);	}
//.................................................................................................................
       	public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
		{
			if ( matrix1.Cols!=matrix2.Rows )
				throw new MatrixException("Operation not possible");
			Matrix result=Matrix.NullMatrix(matrix1.Rows,matrix2.Cols);
			for (int i=0;i<matrix1.Rows;i++)
				for (int j=0;j<matrix2.Cols;j++)
					for (int k=0;k<matrix1.Cols;k++)
					result[i,j]+=matrix1[i,k]*matrix2[k,j];
			return result;						
		}
//.................................................................................................................
    }//end class Matrix
//.................................................................................................................
    public class MatrixException : Exception
	{
		public MatrixException() : base()
		{}
		public MatrixException(string Message) : base(Message)
		{}
		public MatrixException(string Message, Exception InnerException) : base(Message, InnerException)
		{}
	}	// end class MatrixException
//.................................................................................................................
}	//end namespace Mehroz
