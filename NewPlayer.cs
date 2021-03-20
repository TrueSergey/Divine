using Divine;

namespace NewPlayer
{
    class Newplayer : Bootstrapper
    {
        protected override void OnPreActivate()
        {
            GameManager.ExecuteCommand("dota_new_player 0");
        }
    }
}