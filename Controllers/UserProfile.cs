
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.UserProfile;

namespace best_dates_backend.Controllers{
    
    [ApiController]
    [Route("api_main/[controller]")]
    public class UserProfileController : ControllerBase {
        private readonly best_datesContext _best_datesContext;
        
        public UserProfileController(best_datesContext context){
            _best_datesContext = context;
        }

        [Authorize]
        [Route("aboutme")]
        [HttpPost]
        public IActionResult CompleteProfile([FromBody] UserProfile userProfile) { 
            if (!ModelState.IsValid) return BadRequest(new {message =  "The user profile is not valid."});

            _best_datesContext.userProfiles.Add(userProfile);
            _best_datesContext.SaveChanges();

            return Ok(new {message = "The user profile has been update"});
        }
    }
}
