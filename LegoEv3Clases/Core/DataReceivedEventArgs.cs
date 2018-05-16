using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoEv3Clases.Core
{
    /// <summary>
    /// Event arguments for the ReportReceived event.
    /// </summary>
    public sealed class ReportReceivedEventArgs
    #if !WINRT
    : EventArgs
    #endif
    {
        /// <summary>
        /// Byte array of the data received from the EV3 brick.
        /// </summary>
        public byte[] Report { get; set; }
    }
}
