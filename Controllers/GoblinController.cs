using Microsoft.AspNetCore.Mvc;
using goblinAPI.models;

namespace goblinAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoblinController : ControllerBase 
    {
        private static List<Goblin> goblinList = new List<Goblin>() {
            new Goblin(), 
            new Goblin() {id = 1 ,Name = "Gnongolas"},
            new Goblin() {id = 2, Name="Malglonga", Job = GoblinJob.CoinPolisher, Wealth = 3},
            new Goblin() {id = 3, Name="Golgnonga", Job = GoblinJob.Banker, Wealth = 999999999 }
        };

        [HttpGet("GetAll")]
        
        public ActionResult<List<Goblin>> Get()
        {
            return Ok(goblinList);
        }

        [HttpGet("{id}")]
        public ActionResult<Goblin> Getsingle(int id)
        {
            return Ok(goblinList.FirstOrDefault(c => c.id == id));
        }

        [HttpPost]
        public ActionResult<List<Goblin>> AddGoblin(Goblin newGoblin) 
        {
            goblinList.Add(newGoblin);
            return Ok(goblinList);
        }
        
        public ActionResult<List<Goblin>> DeleteGoblin(int id)
        {
            var foundGoblin = goblinList.FirstOrDefault(Goblin => Goblin.id == id);
            goblinList.Remove(foundGoblin);
            return goblinList;

        }
    }
}