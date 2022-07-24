using Task4_userAPI.Models;
namespace Task4_userAPI.Repo
{
    public interface IuserRepo
    {
        public List<user> getAll();
        public user get(int id);
        public void delete(int id);
        public  void update(user _user);
        public void add(user _user);


        }
}
