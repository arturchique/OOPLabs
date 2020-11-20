using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractHero CreateHero();
        public abstract Form CreateCard(AbstractHero abtractProperties);
    }

    public class BumFactory : AbstractFactory
    {
        public override AbstractHero CreateHero()
        {
            return new BumHero();
        }
        public override Form CreateCard(AbstractHero hero)
        {
            return new BumForm(hero);
        }
    }

    public class BoozerFactory : AbstractFactory
    {
        public override AbstractHero CreateHero()
        {
            return new BoozerHero();
        }
        public override Form CreateCard(AbstractHero hero)
        {
            return new BoozerForm(hero);
        }
    }
}
