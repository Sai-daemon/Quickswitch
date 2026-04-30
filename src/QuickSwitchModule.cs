// This file was generated with the assistance of DeepSeek AI (DeepSeek-V4).
// The code is published under the MIT License. All licensing responsibilities
// and copyright for this specific file are held by SAI-DAEMON, 2026.

using System.Linq;

namespace QuickSwitch
{
    /// <summary>
    /// Adds a "Switch To" button to the right-click menu of any command-capable part,
    /// allowing quick switching to that vessel in flight.
    /// Runtime deduplication: if MM adds duplicate QuickSwitchModule instances,
    /// only the first one shows the "Switch To" button.
    /// </summary>
    public class QuickSwitchModule : PartModule
    {
        public override void OnStart(StartState state)
        {
            // Deduplication: only the first QuickSwitchModule on this part gets a button
            var first = part.Modules.OfType<QuickSwitchModule>().FirstOrDefault();
            if (first != null && first != this)
            {
                Events["SwitchToVessel"].active = false;
            }
        }

        [KSPEvent(
            guiActive = false,
            guiActiveEditor = false,
            guiActiveUnfocused = true,
            unfocusedRange = 5000f,
            guiName = "Switch To",
            externalToEVAOnly = false
        )]
        public void SwitchToVessel()
        {
            if (part == null || part.vessel == null)
                return;

            Vessel targetVessel = part.vessel;

            if (targetVessel != FlightGlobals.ActiveVessel)
            {
                FlightGlobals.SetActiveVessel(targetVessel);
            }
        }
    }
}