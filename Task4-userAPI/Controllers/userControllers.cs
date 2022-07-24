using Microsoft.AspNetCore.Mvc;
using Task4_userAPI.Models;
using Task4_userAPI.Repo;

namespace Task4_userAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class userControllers : ControllerBase

    {
        private IuserRepo _userRepo;
        public userControllers(IuserRepo userRepo)
        {
            _userRepo = userRepo;

        }
        [HttpGet]
        public ActionResult<List<user>> getAll()
        {
            return _userRepo.getAll();
        }

        [HttpGet("{id}")]
        public ActionResult<user> get(int id)
        {
            var _user = _userRepo.get(id);
            if (_user == null)
                return NotFound();
            return _user;
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var _user = _userRepo.get(id);
            if (_user == null)
                return NotFound();
            _userRepo.delete(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult update(user _user)
        {
            var user = _userRepo.get(_user.Id);
            if (user == null) return NotFound();
            _userRepo.update(_user);
            return Ok();
        }

        [HttpPost]
        public ActionResult create(user _user)
        {
            _userRepo.add(_user);
            return Ok();

        }
    }
}
