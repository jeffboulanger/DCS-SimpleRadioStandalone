﻿namespace Ciribob.DCS.SimpleRadio.Standalone.Client.UI.ClientWindow.PresetChannels
{
    public class PresetChannel
    {

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}