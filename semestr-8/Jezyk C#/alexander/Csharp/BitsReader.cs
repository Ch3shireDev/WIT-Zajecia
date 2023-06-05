
class BitsReader
{
	private byte[] tb;
	private long index;
	public BiteReader(byte[] tb) { this.tb=tb; }
	private static int idx(long i) { return (int)(i>>3); }
	private static int msk(long i) { return (int)(i&7); }
	public bool empty() { return idx(index)>=tb.Length; }
	public byte next()
	{
		int bpos=msk(index),ipos=idx(index++);
		return (byte)(empty()?0:((tb[ipos]>>bpos)&1));
	}
}