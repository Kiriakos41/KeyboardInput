**Keyboard Input Popup Sample for .NET MAUI**

This sample project shows how to create a clean and simple popup with an input field that automatically opens the keyboard just above the popup — without navigating away from the current page. The user can start typing right away without any extra steps.

**Key Features:**
- Popup slides up from the bottom with a transparent background.
- The input box (**Entry**) immediately gets focus when the popup appears, triggering the keyboard automatically.
- Users can type text directly into the popup.
- Pressing "**Done**" on the keyboard closes the popup and hides the keyboard.
- No page navigation is required; the popup overlays on top of the current screen.

**How It Works:**
- The popup is built using **CommunityToolkit.Maui.Views.Popup** and defined in XAML.
- When the popup opens, a short delay (**100 milliseconds**) is added to ensure the keyboard shows up reliably before focusing the **Entry**.
- When the user finishes typing and presses "**Done**," the popup closes and the input loses focus.

**Usage Instructions:**
- To show the popup, simply call `this.ShowPopup(new Pop())` from a button click or any event handler.

This approach provides a smooth and intuitive way for users to input text quickly without leaving their current context.
