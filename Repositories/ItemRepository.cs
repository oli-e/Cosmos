using Cosmos.Commands;
using Cosmos.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
	public class ItemRepository
	{
		private readonly GalaxyDao galaxyDao;

		public ItemRepository(GalaxyDao galaxyDao)
		{
			this.galaxyDao = galaxyDao;
		}

		// TODO to be removed
		public void Description()
		{
			// Zakładając, że mamy załadowane dane (patrz folder SampleData), to przez GalaxyDao
			// możemy dostać się do każdego modelu.
			// Ta klasa (ItemRepository) służy ViewModelowi jako proxy do GalaxyDao, więc to z tej klasy
			// będziemy operować na modelu (powinno to być łatwiejsze w użyciu).

			// Według mnie przykładowe flow obsługi modelu przez ViewModel (VM) wygląda tak, że:

			// VM pobiera sobie jakiś item
			IdentifableObject io = getItem(1);

			// Po castowaniu (wspominałeś, że gdzieś na etapie nawigacji będzie castowanie)
			// powinniśmy mieć zrzutowany item na jego konkretny model.

			// Na przykładzie obiektu Planet:
			Planet planet = (Planet)io;

			// Teraz możesz robić cokolwiek chcesz na tym modelu i zostanie to zapisane w aplikacji.

			// Edycja tego obiektu
			planet.Name = "Abc";

			// Usuwanie obiektu
			RemoveItem(planet.Id);

			// Dodawanie obiektów jest tylko trochę bardziej skomplikowane, bo tutaj musisz pobrać obiekt rodzica, do którego
			// dodajesz dziecko. Kilka przykładów:

			// Dodawnanie planety do układu planetarnego (czyli musimy mieć referencję do układu planetarnego,
			// żeby dodać nową planetę)
			PlanetarySystem planetarySystem = null; /* new PlanetarySystem(...) */
			planetarySystem.AddPlanet(null /* new Planet(...) */);

			// Dodawanie księżyca (dziecka) do planety
			planet.AddMoon(null /* new Moon(...) */);

			// Jedynym wyjątkiem jest galaktyka, bo ona nie ma rodzica (jest obiektem najwyższym w drzewie) - stąd żeby
			// dodać nową galaktykę, musimy zrobić to przez tę klasę (ItemRepository), która doda galaktykę przez DAO.
			AddGalaxy(null /* new Galaxy (...) */);

			// Wydaje mi się, że to wszystko, czego będziesz potrzebował do zarządzania obiektami, podsumowując:

			// Wyszukujesz wyłącznie przez id.
			// Usuwasz wyłącznie przez id.
			// Edytujesz przez normalne zmienianie wartości pól na obiekcie.
			// Dodajesz nowe obiekty poprzez wywoływanie metod Add...() na rodzicu obiektu, który chcesz dodać
			// (w przypadku galaktyki robisz to przez AddGalaxy() w ItemRepository).
		}

		//To be changed
		public IdentifableObject getItem(int id)
		{
			//IdentifableObject identifableObject = (IdentifableObject)galaxyDao.FindById(id);
            //System.Diagnostics.Debug.WriteLine("Item repo determining type");
            //System.Diagnostics.Debug.WriteLine(identifableObject.GetType());
            return (IdentifableObject) galaxyDao.FindById(id);
        }

		public void RemoveItem(long id)
		{
			galaxyDao.RemoveById(id);
		}

		public void AddGalaxy(Galaxy galaxy)
		{
			galaxyDao.AddGalaxy(galaxy);
		}
	}
}
