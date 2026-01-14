using Facade.Facades.Interfaces;
using Facade.Subsystems;

namespace Facade.Facades
{
    // Facade Pattern: Provides a simplified interface to a complex subsystem
    // The facade knows which subsystem classes are responsible for a request
    // and delegates client requests to appropriate subsystem objects
    public class HomeTheaterFacade : IHomeTheaterFacade
    {
        private readonly DVDPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly SoundSystem _soundSystem;
        private readonly Lights _lights;

        public HomeTheaterFacade(
            DVDPlayer dvdPlayer,
            Projector projector,
            SoundSystem soundSystem,
            Lights lights)
        {
            _dvdPlayer = dvdPlayer ?? throw new ArgumentNullException(nameof(dvdPlayer));
            _projector = projector ?? throw new ArgumentNullException(nameof(projector));
            _soundSystem = soundSystem ?? throw new ArgumentNullException(nameof(soundSystem));
            _lights = lights ?? throw new ArgumentNullException(nameof(lights));
        }

        // Simplified method that hides the complexity of setting up the home theater
        public void WatchMovie(string movie)
        {
            Console.WriteLine("\n=== Get ready to watch a movie... ===\n");
            
            _lights.Dim(10);
            _projector.On();
            _projector.WideScreenMode();
            _soundSystem.On();
            _soundSystem.SetSurroundSound();
            _soundSystem.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
            
            Console.WriteLine("\n=== Enjoy the movie! ===\n");
        }

        // Simplified method that handles cleanup
        public void EndMovie()
        {
            Console.WriteLine("\n=== Shutting down movie theater... ===\n");
            
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
            _soundSystem.Off();
            _projector.Off();
            _lights.On();
            
            Console.WriteLine("\n=== Movie theater is shut down ===\n");
        }
    }
}
