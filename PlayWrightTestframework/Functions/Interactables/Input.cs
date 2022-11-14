
using SeleniumTestframework.Functions.Interactables;


namespace SeleniumWebtestFramework.Func.Interactables
{
    public class Input : IInteractables
    {
        public string Xpath { get; set; }

        public Input()
        {
            Xpath = "//Ion-input";
        }
    }
}
