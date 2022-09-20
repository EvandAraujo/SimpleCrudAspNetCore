namespace SimpleCrudBackEndNetCore.Crosscutting.models
{
    public class GridDTO<T>
    {
        public IEnumerable<T> Itens { get; set; }
        public int Count { get; set; }
    }
}
