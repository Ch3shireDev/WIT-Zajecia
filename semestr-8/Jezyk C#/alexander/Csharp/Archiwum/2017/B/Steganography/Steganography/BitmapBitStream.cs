using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapBitStream
{
    public unsafe class BitmapBitStream : Stream
    {
        private Bitmap bmp;
        private BitmapData data;
        private int YSize, XSize, RSize, SSize, rowpos, colpos;
        private byte* ptr;
        public BitmapBitStream(Bitmap bmp)
        {
            this.bmp = bmp;
            YSize = bmp.Height;
            XSize = bmp.Width;
            RSize = 3 * XSize;
            SSize = YSize * RSize;
            rowpos = colpos = 0;
            data = bmp.LockBits(new Rectangle(0, 0, XSize, YSize), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            ptr = (byte*)data.Scan0;
        }
        ~BitmapBitStream()
        {
            bmp.UnlockBits(data);
        }
        public override bool CanRead { get { return true; } }
        public override bool CanSeek { get { return false; } }
        public override bool CanWrite { get { return true; } }
        public override long Length { get { return SSize; } }
        public override long Position
        {
            get { return rowpos * RSize + colpos; }
            set
            {
                rowpos = (int)(value / RSize);
                colpos = (int)(value % RSize);
            }
        }
        public override void Flush() { }
        private void NextPos()
        {
            if(++colpos>XSize)
            {
                colpos = 0;
                ++rowpos;
            }
        }
        public int ReadBit()
        {
            int pos = rowpos * data.Stride + colpos;
            NextPos();
            return ptr[pos] & 1;
        }
        public void WriteBit(int bit)
        {
            int pos = rowpos * data.Stride + colpos;
            NextPos();
            ptr[pos] &= 0xFE;
            ptr[pos] |= (byte)(bit & 1);
        }
        public override int ReadByte()
        {
            int ret = 0;
            for (int i = 0; i < 8; ++i) ret |= ReadBit() << i;
            return ret;
        }
        public override void WriteByte(byte value)
        {
            for (int i = 0; i < 8; ++i) WriteBit(value >> i);
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                buffer[offset + i] = (byte)ReadByte();
                if (rowpos >= YSize) return i;
            }
            return count;
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                WriteByte(buffer[offset + i]);
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            switch(origin)
            {
                case SeekOrigin.Begin: Position = offset; break;
                case SeekOrigin.End: Position = Length - offset; break;
                case SeekOrigin.Current: Position += offset; break;
            }
            return Position;
        }
        public override void SetLength(long value) { throw new NotImplementedException(); }
    }
}
