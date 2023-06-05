public class Matrix
{
	private final int rowCount,colCount;
	private final double[][] data;

	public int getRowCount() { return rowCount; }
	public int getColCount() { return colCount; }
	public double getValue(int r,int c) { return data[r][c]; }
	public void setValue(int r,int c,double v) { data[r][c]=v; }

	public Matrix(int rowCount,int colCount)
	{
		this.rowCount=rowCount;
		this.colCount=colCount;
		this.data=new double[rowCount][colCount];
	}

	public Matrix(double[][] data)
	{
		if(data==null) data=new double[0][0];
		this.data=data;
		this.rowCount=data.length;
		this.colCount=rowCount>0?data[0].length:0;
	}
	
	public static Matrix parseMatrix(String src)
	{
		
	}

	public static Matrix parseMatrixOrNull(String src)
	{
		try { return parseMatrix(src); }
		catch(Exception e) { return null; }
	}
	
	public static Matrix add(Matrix a,Matrix b)
	{
		int rowCount=a.getRowCount();
		int colCount=a.getColCount();
		if((rowCount!=b.getRowCount())||(colCount!=b.getColCount()))
		{
			throw InvalidParameterException("Uncompatible matrix size");
		}
		Matrix ret=new Matrix(rowCount,colCount);
		for(int r=0;r<rowCount;++r)
		{
			for(int c=0;c<colCount;++c)
			{
				ret.setValue(r,c,a.getValue(r,c)+b.getValue(r,c));
			}
		}		
	}
	
	public static Matrix addOrNull(Matrix a,Matrix b)
	{
		try { return add(a,b); }
		catch(Exception e) { return null; }
	}

	@Override public String toString()
	{
		StringBuilder sb=new StringBuilder();
		for(int r=0;r<rowCount;++r)
		{
			for(int c=0;c<colCount;++c)
			{
				if(c>0) sb.append("\t");
				sb.append(String.format("%.2f",getValue(r,c))); // data[r][c]
			}
			sb.append(System.lineSeparator());
		}
		return sb.toString();
	}
}
