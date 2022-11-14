
using PlayWrightTestframework.Base;
using SeleniumTestframework.Functions.Interactables;
using SeleniumWebtestFramework.Base;
using SeleniumWebtestFramework.Func.Interactables;


namespace SeleniumWebtestFramework.Func.perform
{
    public class BaseFunctions : Configurator
    {
        public Button Button;

        public Label Label;

        public Input Input;
        public BaseFunctions() : base() { Button = new(); Label = new(); Input = new(); } 

      
        public async void Click(IInteractables interactables, string title, IArea area)
        {
            try
            {
                await Page.Locator("xpath=//" + area.Xpath + interactables.Xpath + $"[@title = '{title}']").ClickAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Oops, an error occured. " + ex);
            }
        }

        /// <summary>
        /// sending keys to an element e.g input
        /// </summary>
        /// <param name="title">title of the element</param>
        /// <param name="interactable">The Element to interact e.g Button</param>
        /// <param name="text">title of the element</param>
        /// <param name="area">area of the element e.g a card</param>
        /// <exception cref="Exception"></exception>
        public async void SendKeys( string title, string text, IArea area)
        {
            try
            {
                await Page.Locator("xpath=//" + area.Xpath + Input.Xpath + $"[@title = '{title}']").TypeAsync(text);
                await Page.Keyboard.PressAsync("Enter");

            }
            catch (Exception ex)
            {
                throw new Exception("Oops, an error occured. " + ex);
            }
        }
       
        /// <summary>
        /// Prüft ob der Wert des Elements dem Soll-Wert entspricht
        /// </summary>
        /// <param name="interactables"></param>
        /// <param name="title"></param>
        /// <param name="sollWert"></param>
        /// <param name="area"></param>
        /// <exception cref="Exception"></exception>
        public async void ProofValue(IInteractables interactables, string title, string sollWert, IArea area)
        {
           
            try
            {

                var locator =  Page.Locator("xpath=//" + area.Xpath + interactables.Xpath + $"[@title = '{title}']");
                await Expect(locator).ToHaveTextAsync(sollWert);

            }
            catch (Exception ex)
            {
                throw new Exception("Oops, an error occured. The Text of the element c " + ex);

            }
           

        }
      
    }
}
