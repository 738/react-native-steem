using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Steem.RNSteem
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSteemModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSteemModule"/>.
        /// </summary>
        internal RNSteemModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSteem";
            }
        }
    }
}
