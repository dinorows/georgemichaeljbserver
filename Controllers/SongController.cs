using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET api/values/Faith
        [HttpGet("{title}")]
        public ActionResult<string> Get(string title)
        {
            if (title == "Wakemeup")
            {
                return "Jitterbug<br>	Jitterbug<br>	Jitterbug<br>	Jitterbug<br>	<br>	You put the boom-boom into my heart (do do)<br>	You send my soul sky high when your lovin' starts<br>	Jitterbug into my brain (yeah yeah)<br>	Goes a bang-bang-bang 'til my feet do the same<br>	But something's bugging you<br>	Something ain't right<br>	My best friend told me what you did last night<br>	Left me sleepin' in my bed<br>	I was dreaming, but I should have been with you instead<br>	<br>	Wake me up before you go-go<br>	Don't leave me hanging on like a yo-yo<br>	Wake me up before you go-go<br>	I don't want to miss it when you hit that high<br>	Wake me up before you go-go<br>	'Cause I'm not planning on going solo<br>	Wake me up before you go-go (ah)<br>	Take me dancing tonight<br>	I wanna hit that high (yeah, yeah)<br>	<br>	You take the grey skies out of my way (do do)<br>	You make the sun shine brighter than Doris Day<br>	Turned a bright spark into a flame (yeah yeah)<br>	My beats per minute never been the same<br>	<br>	'Cause you're my lady, I'm your fool<br>	It makes me crazy when you act so cruel<br>	Come on, baby, let's not fight<br>	We'll go dancing, everything will be all right<br>	<br>	Wake me up before you go-go<br>	Don't leave me hanging on like a yo-yo<br>	Wake me up before you go-go<br>	I don't want to miss it when you hit that high<br>	Wake me up before you go-go<br>	'Cause I'm not planning on going solo<br>	Wake me up before you go-go (ah)<br>	Take me dancing tonight<br>	I wanna hit that high (yeah, yeah, yeah, baby)<br>	<br>	(Jitterbug)<br>	(Jitterbug)<br>	<br>	Cuddle up, baby, move in tight<br>	We'll go dancing tomorrow night<br>	It's cold out there, but it's warm in bed<br>	They can dance, we'll stay home instead (yeah, yeah)<br>	<br>	(Jitterbug)<br>	<br>	Wake me up before you go-go<br>	Don't leave me hanging on like a yo-yo<br>	Wake me up before you go-go<br>	I don't want to miss it when you hit that high<br>	Wake me up before you go-go<br>	'Cause I'm not plannin' on going solo<br>	Wake me up before you go-go (ah)<br>	Take me dancing tonight<br>	Wake me up before you go-go, don't you dare to leave me hanging on like a<br>	Yo-yo<br>	Take me dancing<br>	<br>	(Boom-boom-boom-boom)<br>	<br>	(Boom-boom-boom-boom)";
            }

            if (title == "Faith")
            {
                return "Well I guess it would be nice<br>    If I could touch your body<br>    I know not everybody<br>    Has got a body like you<br>    <br>    But I've got to think twice<br>    Before I give my heart away<br>    And I know all the games you play<br>    Because I play them too<br>    <br>    Oh but I<br>    Need some time off from that emotion<br>    Time to pick my heart up off the floor<br>    Oh when that love comes down<br>    Without devotion<br>    Well it takes a strong man baby<br>    But I'm showing you the door<br>    <br>    ‘Cause I gotta have faith<br>    I gotta have faith<br>    ‘Cause I gotta have faith, faith<br>    ‘Cause I gotta have faith, faith, faith<br>    <br>    Baby,<br>    I know you're asking me to stay<br>    Say please, please, please don't go away<br>    You say I'm giving you the blues<br>    Maybe<br>    You mean every word you say<br>    Can't help but think of yesterday<br>    And another who tied me down to loverboy rules<br>    <br>    Before this river<br>    Becomes an ocean<br>    Before you throw my heart back on the floor<br>    Oh oh baby I reconsider<br>    My foolish notion<br>    Well I need someone to hold me<br>    But I'll wait for something more<br>    <br>    Yes I've gotta have faith…<br>    Mmm, I gotta have faith<br>    ‘Cause I gotta have faith, faith, faith<br>    I gotta have faith-a-faith-a-faith<br>    <br>    Before this river<br>    Becomes an ocean<br>    Before you throw my heart back on the floor<br>    Oh oh baby I reconsider<br>    My foolish notion<br>    Well I need someone to hold me<br>    But I'll wait for something more<br>    <br>    Cause I gotta have faith<br>    Mmm I gotta have faith<br>    Because I got to have faith-a-faith-a-faith<br>    I gotta have faith-a-faith-a-faith";
            }

            if (title == "Whisper")
            {
                return "I feel so unsure<br>	As I take your hand<br>	And lead you to the dance floor<br>	As the music dies<br>	Something in your eyes<br>	Calls to mind a silver screen<br>	And all its sad goodbyes<br>	<br>	I'm never gonna dance again<br>	Guilty feet have got no rhythm<br>	Though it's easy to pretend<br>	I know you're not a fool<br>	I should've known better than to cheat a friend<br>	And waste the chance that I've been given<br>	So I'm never gonna dance again<br>	The way I danced with you<br>	<br>	Time can never mend<br>	The careless whispers of a good friend<br>	To the heart and mind<br>	Ignorance is kind<br>	There's no comfort in the truth<br>	Pain is all you'll find<br>	<br>	I'm never gonna dance again<br>	Guilty feet have got no rhythm<br>	Though it's easy to pretend<br>	I know you're not a fool<br>	I should've known better than to cheat a friend<br>	And waste the chance that I've been given<br>	So I'm never gonna dance again<br>	The way I danced with you<br>	<br>	Tonight the music seems so loud<br>	I wish that we could lose this crowd<br>	Maybe it's better this way<br>	We'd hurt each other with the things we want to say<br>	We could have been so good together<br>	We could have lived this dance forever<br>	But now who's gonna dance with me<br>	Please stay<br>	<br>	I'm never gonna dance again<br>	Guilty feet have got no rhythm<br>	Though it's easy to pretend<br>	I know you're not a fool<br>	I should've known better than to cheat a friend<br>	And waste the chance that I've been given<br>	So I'm never gonna dance again<br>	The way I danced with you<br>	<br>	Now that you're gone<br>	Now that you're gone<br>	Now that you're gone<br>	Was what I did so wrong<br>	So wrong that you had to leave me alone?";
            }

            return "unknown";
        }
    }
}