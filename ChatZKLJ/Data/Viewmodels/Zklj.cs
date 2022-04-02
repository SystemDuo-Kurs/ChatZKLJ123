namespace ChatZKLJ.Data.Viewmodels
{
    public class Zklj : IMessageVM
    {
        public List<Data.Message> Messages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Data.Message MessageEditor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Data.Message m)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public Task SaveMessageAsync()
        {
            throw new NotImplementedException();
        }
    }
}