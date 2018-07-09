namespace Claro.Map
{
    public class ItemManager : Singleton<ItemManager>
    {

        public Item current;

        public Item Current
        {
            get { return current; }
            set 
            { 
                this.Display(false);
                this.current = value;
                this.Display(true);
            }
        }

        private void Display(bool display)
        {
            if (this.current != null)
                this.current.Display(display);
        }
    }
}
