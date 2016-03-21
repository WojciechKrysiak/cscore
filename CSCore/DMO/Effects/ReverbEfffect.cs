using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;

using CSCore.Win32;
using CSCore.XAudio2;

namespace CSCore.DMO.Effects
{
    /// <summary>
    /// Referb effect applicable to a XAudio2Voice.
    /// </summary>
    public class ReverbEfffect : ComObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverbEfffect"/> class.
        /// </summary>
        /// <param name="ptr">
        /// The native pointer. 
        /// </param>
        internal ReverbEfffect(IntPtr ptr)
            :base(ptr)
        {
            Parameters = new ReverbParameters { DecayTime = 0.1f, LowEQGain = 8, HighEQGain = 8, RoomSize = 1 };
        }

        /// <summary>
        /// Gets the effect parameters. 
        /// </summary>
        public ReverbParameters Parameters
        {
            get; private set;
        }
    }
}
