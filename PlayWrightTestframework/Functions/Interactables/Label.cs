
using SeleniumTestframework.Functions.Interactables;

namespace SeleniumWebtestFramework.Func.Interactables
{
    public class Label : IInteractables
    {
        public string Xpath { get; set; }

       public Label()
        {
            Xpath = "//ion-label";
        }
    }
}
