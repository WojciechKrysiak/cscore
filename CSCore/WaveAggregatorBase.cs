﻿using System;

namespace CSCore
{
    public abstract class WaveAggregatorBase : IWaveAggregator
    {
        protected IWaveSource _baseStream;

        public WaveAggregatorBase()
        {
        }

        public WaveAggregatorBase(IWaveSource baseStream)
            : this()
        {
            BaseStream = baseStream;
        }

        public virtual IWaveSource BaseStream
        {
            get { return _baseStream; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("BaseStream must not be null");
                _baseStream = value;
            }
        }

        public virtual WaveFormat WaveFormat
        {
            get { return BaseStream.WaveFormat; }
        }

        public virtual int Read(byte[] buffer, int offset, int count)
        {
            return BaseStream.Read(buffer, offset, count);
        }

        public virtual long Position
        {
            get
            {
                return BaseStream.Position;
            }
            set
            {
                BaseStream.Position = value;
            }
        }

        public virtual long Length
        {
            get { return BaseStream.Length; }
        }

        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
			if(disposing)
			{
				//dispose managed
			}
            if(BaseStream != null)
                BaseStream.Dispose();
            _baseStream = null;
        }

        ~WaveAggregatorBase()
        {
            Dispose(false);
        }
    }
}