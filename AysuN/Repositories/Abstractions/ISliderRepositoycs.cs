using AysuN.Models;

namespace AysuN.Repositories.Abstractions
{
    public class ISliderRepositoycs : IRepository<Slider>
    {
        private string _connection=""
        public void Create(Slider entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Slider> GetAll()
        {
            throw new NotImplementedException();
        }

        public Slider GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Slider entity)
        {
            throw new NotImplementedException();
        }
    }
}
