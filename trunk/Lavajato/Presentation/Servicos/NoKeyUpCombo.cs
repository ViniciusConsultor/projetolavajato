using System;

namespace HenryCorporation.Lavajato.BusinessLogic
{
	public class NoKeyUpCombo: System.Windows.Forms.ComboBox
	{
		private const int WM_KEYUP = 0x101;

		protected override void WndProc(ref System.Windows.Forms.Message theMessage)
		{
			//
			// Ignore KeyUp event to avoid problem with tabbing the dropdown.
			//
			if (theMessage.Msg == WM_KEYUP)
				return;
			else
				base.WndProc(ref theMessage);
		}
	} // class

} //namespace
