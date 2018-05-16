using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoEv3Clases.Core
{
    /// <summary>
    /// Buttons on the face of the LEGO EV3 brick
    /// </summary>
    public sealed class BrickButtons
    {
        /// <summary>
        /// Up button
        /// </summary>
        public bool Up { get; set; }
        /// <summary>
        ///  Down button
        /// </summary>
        public bool Down { get; set; }
        /// <summary>
        /// Left button
        /// </summary>
        public bool Left { get; set; }
        /// <summary>
        /// Right button
        /// </summary>
        public bool Right { get; set; }
        /// <summary>
        ///  Back button
        /// </summary>
        public bool Back { get; set; }
        /// <summary>
        /// Enter button
        /// </summary>
        public bool Enter { get; set; }
    }
}
