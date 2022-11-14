
using SeleniumTestframework.Functions.Interactables;


namespace SeleniumWebtestFramework.Func.Interactables
{
    public class Button : IInteractables
    {
        public string Xpath { get; set; }

       public Button()
        {
            Xpath = "//ion-button";
        }
    }
}
