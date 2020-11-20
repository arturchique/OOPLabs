using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public abstract class AbstractHero
    {
        public abstract string GetPowers();
    }

    public class BumHero : AbstractHero
    {
        public override string GetPowers()
        {
            return @"Сила: 10
Ловкость: 5
Интеллект: 15";
        }
    }

    public class BoozerHero: AbstractHero
    {
        public override string GetPowers()
        {
            return @"Сила: 7
Ловкость: 15
Интеллект: 6";
        }
    }
}
