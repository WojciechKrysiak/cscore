using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CSCore.DMO.Effects
{
    /// <summary>
    /// Parameters structure for XAudio2 Reverb APO
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ReverbParameters
    {
        /// <summary>
        /// Percentage of the output that will be reverb. Allowable values are from 0 to 100.
        /// </summary>
        public float WetDryMix;

        /// <summary>
        /// The delay time of the first reflection relative to the direct path. Permitted range is from 0 to 300 milliseconds.
        /// </summary>
        public UInt32 ReflectionsDelay;

        /// <summary>
        /// Delay of reverb relative to the first reflection. Permitted range is from 0 to 85 milliseconds.
        /// </summary>
        public byte ReverbDelay;

        /// <summary>
        /// Delay for the left rear output and right rear output. Permitted range is from 0 to 5 milliseconds.
        /// </summary>
        public byte RearDelay;

        /// <summary>
        /// Position of the left input within the simulated space relative to the listener.Permitted range is from 0 to 30 (no units).
        /// </summary>
        public byte PositionLeft;

        /// <summary>
        /// Position of the right input within the simulated space relative to the listener.Permitted range is from 0 to 30 (no units).
        /// </summary>
        public byte PositionRight;

        /// <summary>
        /// Gives a greater or lesser impression of distance from the source to the listener. Permitted range is from 0 to 30 (no units).
        /// </summary>
        public byte PositionMatrixLeft;

        /// <summary>
        /// Gives a greater or lesser impression of distance from the source to the listener. Permitted range is from 0 to 30 (no units).
        /// </summary>
        public byte PositionMatrixRight;

        /// <summary>
        /// Controls the character of the individual wall reflections. Set to minimum value to simulate a hard flat surface and to maximum value to simulate a diffuse surface. 
        /// Permitted range is from 0 to 15 (no units).
        /// </summary>
        public byte EarlyDiffusion;

        /// <summary>
        /// Controls the character of the individual wall reverberations. Set to minimum value to simulate a hard flat surface and to maximum value to simulate a diffuse surface. 
        /// Permitted range is from 0 to 15 (no units).
        /// </summary>
        public byte LateDiffusion;

        /// <summary>
        /// Adjusts the decay time of low frequencies relative to the decay time at 1 kHz. The values correspond to dB of gain as follows:
        /// Value	   | 0	|1	|2	|3	|4	|5	|6	|7	|8	|9	|10	|11	|12
        /// Gain(dB)   |-8	|-7	|-6	|-5	|-4	|-3	|-2	|-1	|0	|+1	|+2	|+3	|+4
        /// </summary>
        public byte LowEQGain;

        /// <summary>
        /// Sets the corner frequency of the low pass filter that is controlled by the LowEQGain parameter. The values correspond to frequency in Hz as follows:
        /// Value	       | 0	|1	    |2	    |3	    |4	    |5	    |6	    |7	    |8	    |9
        /// Frequency(Hz)  |50	|100	|150	|200	|250	|300	|350	|400	|450	|500
        /// </summary>
        public byte LowEQCutoff;

        /// <summary>
        /// Adjusts the decay time of high frequencies relative to the decay time at 1 kHz. When set to zero, high frequencies decay at the same rate as 1 kHz. 
        /// When set to maximum value, high frequencies decay at a much faster rate than 1 kHz.
        /// Value	   | 0	|1	|2	|3	|4	|5	|6	|7	|8
        /// Gain(dB)   |-8	|-7	|-6	|-5	|-4	|-3	|-2	|-1	|0
        /// </summary>
        public byte HighEQGain;

        /// <summary>
        /// Sets the corner frequency of the high pass filter that is controlled by the HighEQGain parameter. 
        /// The values correspond to frequency in kHz as follows:
        /// Value	        |0	|1	    |2	|3	    |4	|5	    |6	|7	    |8	|9	    |10	|11	    |12	|13	    |14
        /// Frequency(kHz)  |1	|1.5	|2	|2.5	|3	|3.5	|4	|4.5	|5	|5.5	|6	|6.5	|7	|7.5	|8
        /// </summary>
        public byte HighEQCutoff;

        /// <summary>
        /// Sets the corner frequency of the low pass filter for the room effect. Permitted range is from 20 to 20,000 Hz.
        /// </summary>
        public float RoomFilterFreq;

        /// <summary>
        /// Sets the pass band intensity level of the low-pass filter for both the early reflections and the late field reverberation. 
        /// Permitted range is from -100 to 0 dB.
        /// </summary>
        public float RoomFilterMain;

        /// <summary>
        /// Sets the intensity of the low-pass filter for both the early reflections and the late field reverberation at the corner frequency (RoomFilterFreq). 
        /// Permitted range is from -100 to 0 dB.
        /// </summary>
        public float RoomFilterHF;

        /// <summary>
        /// Adjusts the intensity of the early reflections. Permitted range is from -100 to 20 dB.
        /// </summary>
        public float ReflectionsGain;

        /// <summary>
        /// Adjusts the intensity of the reverberations. Permitted range is from -100 to 20 dB.
        /// </summary>
        public float ReverbGain;

        /// <summary>
        /// Reverberation decay time at 1 kHz. This is the time that a full scale input signal decays by 60 dB. Permitted range is from 0.1 to infinity seconds.
        /// </summary>
        public float DecayTime;

        /// <summary>
        /// Controls the modal density in the late field reverberation. For colorless spaces, Density should be set to the maximum value (100).
        /// As Density is decreased, the sound becomes hollow (comb filtered).
        /// This is an effect that can be useful if you are trying to model a silo. Permitted range as a percentage is from 0 to 100.
        /// </summary>
        public float Density;

        /// <summary>
        /// The apparent size of the acoustic space. Permitted range is from 1 to 100 feet.
        /// </summary>
        public float RoomSize;

    }
}
